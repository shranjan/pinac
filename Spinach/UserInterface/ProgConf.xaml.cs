//////////////////////////////////////////////////////////////////////////////////
//  ProgConf.xaml.cs - Program Configuration Window                             //
//  ver 1.0                                                                     //
//                                                                              //
//  Language:      C#                                                           //
//  Platform:      Windows Vista                                                //
//  Application:   SPINACH                                                      //
//  Author:        Prateek Jain (pjain02@syr.edu)                               //
//                 (315) 751 7324                                               //
//////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Spinach
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public delegate void ConnectionNotification();
    public partial class ProgConf : Window
    {
        public event ConnectionNotification Conn;
        private bool connected = false;                         //Specifies the state of the connection
        private string username = "";
        private string IP = "";
        private string Port = "";
        private Dictionary<string, ArrayList> AccessControlList = new Dictionary<string,ArrayList>();
        private List<string> userList;
        private Dictionary<string, string> swarmUserTable;
        private ErrorModule err = new ErrorModule();
        bool disconnectClick = false;                //Checks whether the diconnect button was pressed
        String programText = "";
        private SwarmConnection SC;
        private SwarmMemoryCaller SMCaller;
        
        
        /// <summary>
        /// Default constructor - Initializing the intial things
        /// </summary>
        // TODO check all the initializations
        public ProgConf(SwarmConnection SConn)
        {
            InitializeComponent();
            SC = SConn;
            ChatModule Chat = new ChatModule(SC);
            SMCaller = new SwarmMemoryCaller();
            mnuProg.Visibility = Visibility.Visible;
            txtMessage.Focus();
            err.ProgConfError += new ErrorNotification(ShowError);
            SC.ListChanged +=new SwarmConnection.ChangedEventHandler(setUserList);
            SC.TransOwner += new SwarmConnection.PrivelageEventHandler(OwnerChanged);
            SC.ChngPermission +=new SwarmConnection.PrivelageEventHandler(NewAccessPermission);
            SC.AddPrev +=new SwarmConnection.PrivelageEventHandler(NewAccessPermission);
            Chat.Chat +=new ChatNotification(DisplayChat);
        }

        void OwnerChanged(string[] strPrev)
        {
              Thread th = new Thread(new ThreadStart(
              delegate()
              {
                  this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                      delegate()
                      {
                            ProgWin temp = (ProgWin)AccessControlList[strPrev[0]][1];
                            string ipPort = strPrev[1] + ":" + strPrev[2];
                            foreach (string s in userList)
                            {
                                string[] userInfo = s.Split(':');
                                if ((userInfo[1].Trim() == strPrev[1]) && (userInfo[2].Trim() == strPrev[2]))
                                {
                                    temp.setOwner(userInfo[0].Trim());
                                    break;
                                }
                            }
                      }));
              }));
              th.Start();
        }

        //Runs on Exit Button being clicked
        private void submnuExit_Click(object sender, RoutedEventArgs e)
        {
            if (connected == true)
            {
                submnuDisconnect_Click(sender, e);
            }
            Environment.Exit(1);
        }

        private void submnuDisconnect_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = System.Windows.MessageBox.Show("Do you really want to disconnect from the swarm?", "Disconnect?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
              //Code for disconnecting from the swarm
              SC.Disconnect();
              //Connection conn = new Connection();
              //conn.Show();
              if (Conn != null)
                  Conn();
              connected = false;
              disconnectClick = true;
              frmProgConf.Close();
            }
        }

        private void frmProgConf_Loaded(object sender, RoutedEventArgs e)
        {
          //for (int i = 0; i < userList.Count; i++)
          //{
          //  lstUserList.Items.Add(userList[i]);
          //}
        }

        private void cmdSend_Click(object sender, RoutedEventArgs e)
        {
            if (txtMessage.Text != "")
            {
                int size = username.Length;

                //--TextPointer tp = rtbChat.CaretPosition.GetPositionAtOffset(0, LogicalDirection.Forward);
                //--rtbChat.CaretPosition.InsertTextInRun(username + ": " + txtMessage.Text + "\n");
                //rtbChat.CaretPosition.InsertParagraphBreak();
                //--rtbChat.CaretPosition = tp;

                //rtbChat.BeginChange();
                //rtbChat.FontWeight = FontWeights.Bold;
                //rtbChat.AppendText(username + ": ");
                //rtbChat.EndChange();

                //rtbChat.AppendText(txtMessage.Text + "\n");
                SC.Send_ChatMsg(txtMessage.Text, username);
                txtMessage.Text = "";
                rtbChat.ScrollToEnd();
            }
        }

      /// <summary>
      /// Sets the username to be displayed on the screen.
      /// This is sent by the connection module.
      /// </summary>
      /// <param name="user">username which was accepted by the swarm while connecting</param>
      public void setDetails(string SelfIP, string SelfPort, string user)
      {
        IP = SelfIP;
        Port = SelfPort;
        username = user;
      }

      /// <summary>
      /// Sets the userlist sent by the connection module.
      /// This list contains all the users currently in the swarm.
      /// </summary>
      /// <param name="list">List of all the users in the swarm</param>
      public void setUserList(List<string> list)
      {
        userList = list;
        Thread th = new Thread(new ThreadStart( 
            delegate() {
                lstUserList.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                    delegate()
                    {
                        lstUserList.Items.Clear();
                        for (int i = 0; i < userList.Count; i++)
                        {
                            lstUserList.Items.Add(userList[i]);
                        }
                        foreach (ArrayList ar in AccessControlList.Values)
                        {
                            ProgWin temp = (ProgWin)ar[1];
                            temp.setUserList(userList);
                        }
                        //foreach (string s in userList)
                        //{
                        //    string[] userInfo = s.Split(':');
                        //    string ipPort = userInfo[1].Trim() + ":" + userInfo[2].Trim();
                        //    swarmUserTable[ipPort] = userInfo[0].Trim();
                        //}
                    }));
            }));
          th.Start();
      }

      public void DisplayChat(string Uname, string Msg)
      {
          Thread th = new Thread(new ThreadStart(
            delegate()
            {
                rtbChat.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                    delegate()
                    {
                        TextPointer tp = rtbChat.CaretPosition.GetPositionAtOffset(0, LogicalDirection.Forward);
                        rtbChat.CaretPosition.InsertTextInRun(Uname + ": " + Msg + "\n");
                        rtbChat.CaretPosition = tp;
                    }));
            }));
          th.Start();
          //TextPointer tp = rtbChat.CaretPosition.GetPositionAtOffset(0, LogicalDirection.Forward);
          //rtbChat.CaretPosition.InsertTextInRun(Uname + ": " + Msg + "\n");
          //rtbChat.CaretPosition = tp;
      }

      private void submnuNew_Click(object sender, RoutedEventArgs e)
      {
        programText = "";
        Thread newWindowThread =
                        new Thread(
                             new ThreadStart(
                                  OwnerThreadStartingPoint));
        newWindowThread.SetApartmentState(ApartmentState.STA);
        newWindowThread.IsBackground = true;
        newWindowThread.Start();
      }

      private void OwnerThreadStartingPoint()
      {
          string pid;
          pid = Guid.NewGuid().ToString();
          ProgWin editor = new ProgWin(ProgWin.editorType.owner, SC, SMCaller, IP, Port, pid);
          //owner is the user itself. so pass the username here
          //list of the users in swarm
          //take the program name and send the program name
          editor.setUserList(userList);
          editor.setPermissions("RW");
          editor.loadProgram(programText);
          editor.setOwner(username);
          ArrayList list = new ArrayList();
          list.Add("RW");
          list.Add(editor);
          AccessControlList.Add(pid, list);
          editor.Show();

          System.Windows.Threading.Dispatcher.Run();
      }

      /// <summary>
      /// This will load the file and pass the text to the editor.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void submnuLoad_Click(object sender, RoutedEventArgs e)
      {
          Stream myStream = null;
          OpenFileDialog openFileDialog1 = new OpenFileDialog();

          openFileDialog1.InitialDirectory = "c:\\";
          openFileDialog1.Filter = "ssf files (*.ssf)|*.ssf|All files (*.*)|*.*";
          openFileDialog1.FilterIndex = 1;
          openFileDialog1.RestoreDirectory = true;

          if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
              try
              {
                  if ((myStream = openFileDialog1.OpenFile()) != null)
                  {
                      StreamReader sr = new StreamReader(openFileDialog1.FileName);
                      using(sr)
                      {
                          string line;
                          line = sr.ReadLine();
                          while ((line) != null)
                          {
                              programText = programText + line;
                              line = sr.ReadLine();
                              if (line != null)
                              {
                                  programText += "\n";
                              }
                          }
                      }
                  }

                  Thread newWindowThread =
                        new Thread(
                             new ThreadStart(
                                  OwnerThreadStartingPoint));
                  newWindowThread.SetApartmentState(ApartmentState.STA);
                  newWindowThread.IsBackground = true;
                  newWindowThread.Start();

                  //ProgWin editor = new ProgWin(ProgWin.editorType.owner);
                  
                  //editor.loadProgram(text);
                  //editor.Show();
                  //editor.setUserList(userList);
                  //editor.setPermissions("RW");
                  //string pid;
                  //pid = Guid.NewGuid().ToString();
                  //ArrayList list = new ArrayList();
                  //list.Add("RW");
                  //list.Add(editor);
                  //AccessControlList.Add(pid, list);
              }
              catch (Exception ex)
              {
                  System.Windows.MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
              }
          }

      }

      //[STAThread]
      private void NewAccessPermission(string[] strPrev)
      {
          Thread th = new Thread(new ThreadStart(
              delegate()
              {
                  this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                      delegate()
                      {
                          string[] s = strPrev;

                          if (s.Length == 8 && s[1] == IP && s[2] == Port)
                          {
                              string permission = "";
                              if (s[3].ToString() == "true")
                                  permission += "R";
                              if (s[4].ToString() == "true")
                                  permission += "W";
                              if (s[3].ToString() == "false" && s[4].ToString() == "false")
                              {
                                  ProgWin temp = (ProgWin)AccessControlList[s[0].ToString()][1];
                                  temp.Close();
                              }
                              AccessControlList[s[0].ToString()][0] = permission;
                              ProgWin t = (ProgWin)AccessControlList[s[0].ToString()][1];
                              t.SMObj().adder(s[1] + ":" + s[2], s[3], s[4]);
                          }
                          else if (s[3] == IP && s[4] == Port)
                          {
                              //string pid;
                              //pid = Guid.NewGuid().ToString();
                              ProgWin editor = new ProgWin(ProgWin.editorType.collaborator, SC, SMCaller, IP, Port, s[0]);
                              ArrayList list = new ArrayList();
                              string permission = "";
                              if (s[5].ToString() == "true")
                                  permission += "R";
                              if (s[6].ToString() == "true")
                                  permission += "W";
                              list.Add(permission);
                              list.Add(editor);
                              AccessControlList.Add(s[0], list);
                              editor.loadProgram(s[2]);
                              editor.setOwner(s[1]);
                              editor.Show();
                              editor.setPermissions(permission);
                              //editor.SMObj().createTheObjects(s[0], IP, Port);
                              editor.SMObj().InitializeThePeer(s[7]);
                              editor.SMObj().adder(s[3] + ":" + s[4], s[5], s[6]);
                          }
                          else
                          {
                              if (s.Length == 5)
                              {
                                  ProgWin t = (ProgWin)AccessControlList[s[0].ToString()][1];
                                  t.SMObj().adder(s[1] + ":" + s[2], s[3], s[4]);
                              }
                              else
                              {
                                  ProgWin t = (ProgWin)AccessControlList[s[0].ToString()][1];
                                  t.SMObj().adder(s[3] + ":" + s[4], s[5], s[6]);
                              }
                          }
                      }));
              }));
          th.Start();
      }

      private void ShowError(string errorMsg)
      {
          System.Windows.MessageBox.Show(errorMsg, "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Error);
      }

      /// <summary>
      /// Updates the list of users in the swarm.
      /// </summary>
      /// <param name="userList">List of users in the swarm</param>
      private void updateList(List<string> userList)
      {
      }

      private void frmProgConf_Closed(object sender, EventArgs e)
      {
          if (!disconnectClick)
          {
              if (connected == true)
              {
                  //submnuDisconnect_Click(sender, e);
                  //SC.Disconnect(IP, Port);
              }
              Environment.Exit(1);
          }
      }

    }
}
