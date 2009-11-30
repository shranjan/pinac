//////////////////////////////////////////////////////////////////////////////////
//  ProgWin.xaml.cs - Program Editor                                            //
//  ver 1.0                                                                     //
//                                                                              //
//  Language:      C#                                                           //
//  Platform:      Windows Vista                                                //
//  Application:   SPINACH                                                      //
//  Author:        Arunkumar K T (akyasara@syr.edu)                             //
//                 Abhay Ketkar  (asketkar@syr.edu)                             //
//                 Prateek Jain  (pjain02@syr.edu)                              //
//                 Rutu Pandya   (rkpandya@syr.edu)                             //
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
using System.IO;
using System.Threading;
using System.ComponentModel;
using Spinach;

namespace Spinach
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ProgWin : Window
    {
        //Local Declarations
        bool read, write;
        private string PID;                     //Program ID
        private string owner;
        private string username;
        private string progName="";
        string IP = "";
        string Port = "";
        private List<string> swarmUserList; 
        private List<string> progUserList;
        private List<string> collaboratedUsers = new List<string>();
        private List<Color> userColor = new List<Color>();
        private Dictionary<string, string> swarmUserTable = new Dictionary<string,string>();
        public enum editorType { owner, collaborator };
        public editorType et;
        private bool clickedCompute = false;
        private BackgroundWorker worker;
        public delegate void CloseProgramEventHandler(string pid);
        public event CloseProgramEventHandler CloseProgramEvent;

        //Collaborative Editing Related
        string prog = "";
        struct userhighlight
        {
            public int start;
            public int size;
            public string name;
        };
        List<userhighlight> m_user = new List<userhighlight>();
        Hashtable editedNum = new Hashtable();

        //Related to Text Highlighting
        struct tags
        {
            public int start;
            public int size;
        };
        List<tags> m_tags = new List<tags>();
        List<String> keywords = new List<String>();
        
        //Error Module
        private ErrorModule err = new ErrorModule();               
        
        //Plot related declarations
        private PlotReceiver plot = new PlotReceiver();             
        //PngBitmapEncoder PBE = new PngBitmapEncoder();
        private string plotpath = "";
        private int isplotReady = 0;
        private List<double> PlotVals;

        //Swarm Memory related Declarations
        private SwarmConnection SC;
        private SwarmMemory SM;

        //Exec Controller
        private executor Controller;
        
        Thread cur_th = null;
        public delegate void mydelegate();


        //***   All the public functions    ***//
        /// <summary>
        /// ProgWin Constructor
        /// </summary>
        /// <param name="e">editor type</param>
        /// <param name="sconn">Swarm Connection Object</param>
        /// <param name="ip">Self IP</param>
        /// <param name="port">Self Port</param>
        /// <param name="pid">PID of the program</param>
        /// <param name="uname">Self USername</param>
        public ProgWin(editorType e, SwarmConnection sconn, string ip, string port, string pid, string uname, string Prog)
        {
            InitializeComponent();
            et = e;
            err.ProgWinError += new ErrorNotification(ShowError);
            plot.image += new PlotReceiver.BmpImage(EnablePlot);
            Controller = new executor();
            Controller.resEvent += new executor.result(Display);
            keywords = Controller.frontEnd.getKeywords();
            err.SetExecutorObject(Controller);
            err.SetPlotObject(plot);
            username = uname;
            progName = Prog;

            //Swarm Operations
            SC = sconn;
            SM = new SwarmMemory(SC);
            IP = ip;
            Port = port;
            PID = pid;
            SM.PermissionListCh += new SwarmMemory.PermissionListChanged(progUserListChange);
            SM.rnBtnClicked += new SwarmMemory.RunButtonClick(RunClicked);
            SM.srcChanged += new SwarmMemory.SourceCodeChanged(CollabEditing);
            SM.CloseP += new SwarmMemory.CloseProgram(SM_CloseP);
            SM.RerunP += new SwarmMemory.RerunProgram(SM_RerunP);
            SC.DisconnectChanged += new SwarmConnection.DisconnectEventHandler(SM_CloseP);
            SM.FinalResult += new SwarmMemory.GetFinalResult(SM_FinalResult);
            SM.createTheObjects(PID, IP, Port);                 //Finally the swarm memory object
            SC.InsertProgtoSC(SM);
            err.SetSwarmMemoryObject(SM);

            //Exec Operations
            Controller.setPlotObject(plot);
            Controller.setSMObject(SM);
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            prog = new TextRange(rtbInput.Document.ContentStart, rtbInput.Document.ContentEnd).Text;
            userColor.Add(Colors.Brown);
            userColor.Add(Colors.Yellow);
            userColor.Add(Colors.Green);
        }

        void SM_FinalResult(string FinRes)
        {
            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            txtResult.Text = FinRes;
                        }));
                }));
            t.Start();
        }

        void SM_RerunP(bool Rerun)
        {
            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            if (SM.ReRunClicked(IP, Port))
                            {
                                txtResult.Text = "";
                                isplotReady = 0;
                                plotpath = Title;
                                plotpath += ".png";
                                TextPointer start = rtbInput.Document.ContentStart;
                                TextPointer end = rtbInput.Document.ContentEnd;
                                TextRange tr = new TextRange(start, end);
                                Controller.clearCoreValues();
                                worker.RunWorkerAsync(tr.Text);
                                mnuPlot.IsEnabled = true;
                            }
                        }));
                }));
            t.Start();
        }

        void SM_CloseP(bool CloseProg)
        {
            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            SM.programClosed();
                            //Thread.Sleep(2000);
                            this.Close();
                        }));
                }));
            t.Start();
            //BackgroundWorker bw = new BackgroundWorker();
            //bw.WorkerReportsProgress = true;
            //bw.WorkerSupportsCancellation = true;
            //bw.DoWork += new DoWorkEventHandler(closeAll);
            //bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(closebw);
            //bw.Dispose();
            //bw.RunWorkerAsync("Hello to worker");
        }

        //void closebw(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    Close();
            
        //}

        //void closeAll(object sender, DoWorkEventArgs e)
        //{
        //    Thread t = new Thread(new ThreadStart(
        //        delegate()
        //        {
        //            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
        //                delegate()
        //                {
        //                    SM.programClosed();
        //                    //Close();
        //                }));
        //        }));
        //    t.Start();
        //    //bw.ReportProgress(i);
        //    //Thread.Sleep(1000);
        //}

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Controller.VisitLine(e.Argument.ToString());
        }

        void CollabEditing(string[] SourceChanged)
        {
            update(SourceChanged[0], SourceChanged[1], SourceChanged[2], SourceChanged[3]);
        }

        void RunClicked(bool Clicked)
        {
            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            if (Clicked)
                            {
                                btnCompute.IsEnabled = false;
                                rtbInput.IsEnabled = false;
                            }
                            else
                            { 
                                btnCompute.IsEnabled = true;
                                if (write)
                                    rtbInput.IsEnabled = true;
                                if (clickedCompute)
                                {
                                    SM.BroadcastResult(txtResult.Text.ToString());
                                    clickedCompute = false;
                                }
                            }
                        }));
                }));
            t.Start();
        }

        void progUserListChange(List<string> PerListChanged)
        {
            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            lstUsers.Items.Clear();
                            foreach (string entry in PerListChanged)
                            {
                                lstUsers.Items.Add(entry);
                            }
                        }));
                }));
            t.Start();
        }

        /// <summary>
        /// Returns the swarm memory object for the calling object
        /// </summary>
        /// <returns>Swarm Memory Object of the object</returns>
        public SwarmMemory SMObj()
        {
            return SM;
        }

        /// <summary>
        /// Sets the owner of program, also updates the local variable 'owner'.
        /// </summary>
        /// <param name="uname"></param>
        public void setOwner(string uname)
        {
              Thread th = new Thread(new ThreadStart(
              delegate()
              {
                  this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                      delegate()
                      {
                          owner = uname;
                          lblOwner.Content = "Owner: " + owner;
                          //SM.setOwner(owner);

                          //Logic for checking Access menu
                          if (username == owner)
                              mnuAccess.IsEnabled = true;
                          else
                              mnuAccess.IsEnabled = false;
                      }));
              }));
              th.Start();
        }

        /// <summary>
        /// Sets the swarm user list
        /// </summary>
        /// <param name="list">Swarm User List</param>
        public void setUserList(List<string> list)
        {
            swarmUserList = list;
            foreach (string s in swarmUserList)
            {
                string[] userInfo = s.Split('|');
                string ipPort = userInfo[1].Trim();
                swarmUserTable[ipPort] = userInfo[0].Trim();
            }
        }

        /// <summary>
        /// Sets the Program Collaborators user list
        /// </summary>
        /// <param name="list">Program Collaboratos User List</param>
        public void setProgUserList(List<string> list)
        {
            progUserList = list;
        }
        
        /// <summary>
        /// Loads the program text into the editor.
        /// </summary>
        /// <param name="text">Program Text</param>
        public void loadProgram(string text)
        {
            rtbInput.AppendText(text);
            syntax();
            LineNumbers();
        }

        /// <summary>
        /// Sets the permissions for the user for this particular program
        /// </summary>
        /// <param name="perm">Permission String</param>
        public void setPermissions(string perm)
        {
            if (perm == "RW")
            {
                read = true;
                write = true;
            }
            else if (perm == "R")
            {
                read = true;
                write = false;
            }
            else if (perm == "W")
            {
                read = true;
                write = true;
            }

            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    rtbInput.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            if (write)
                                rtbInput.IsEnabled = true;
                            else
                                rtbInput.IsEnabled = false;
                        }));
                }));
            t.Start();
        }


        //***   All the Private Functions   ***//
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title += " - ";
            this.Title += progName;
            lblProgName.Content = "Program Name: " + progName;
            if (et == editorType.collaborator)
            {
                //This will disable the Access Control menu
                mnuAccess.IsEnabled = false;
                //txtResult.is
            }
        }

        private void format()
        {
            m_tags.Sort(compare);
            for (int i = 0; i < m_tags.Count; i++)
            {
                TextPointer str = rtbInput.Document.ContentStart.GetPositionAtOffset(m_tags[i].start, LogicalDirection.Forward);
                TextPointer stp = str.GetPositionAtOffset(m_tags[i].size, LogicalDirection.Backward);
                TextRange ts = new TextRange(str, stp);
                ts.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Blue));
            }
        }
        
        private void syntax()
        {
            TextPointer start = rtbInput.Document.ContentStart;
            TextPointer end = rtbInput.Document.ContentEnd;
            TextRange tr = new TextRange(start, end);
            tr.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Black)); 
            m_tags.Clear();
            for (int s = 0; s < keywords.Count && tr.Text.Length > 2; s++)
            {
                int index = -1;
                string text = tr.Text.ToString();
                string[] txt;
                index = text.LastIndexOf(keywords[s]);
                while (index != -1 && text.Length > 0)
                {
                    tags t = new tags();
                    text = text.Substring(0, index + keywords[s].Length);
                    txt = text.Split('\n');
                    int num = 0;
                    for (int i = 0; i < txt.Length; i++)
                        if (txt[i].Length > 1)
                            num = num + 1;
                        else if (txt[i].Length == 1 && keywords[s].Length == 1 && txt[i] == keywords[s])
                            num = num + 1;
                    if ((index==0 || (index >= 1 &&
                        !((tr.Text[index - 1] >= 'a' && tr.Text[index - 1] <= 'z') || (tr.Text[index - 1] >= 'A' && tr.Text[index - 1] <= 'Z')))) &&
                        !((tr.Text[index + keywords[s].Length] >= 'a' && tr.Text[index + keywords[s].Length] <= 'z') || (tr.Text[index + keywords[s].Length] >= 'A' && tr.Text[index + keywords[s].Length] <= 'Z')))
                    {
                        t.start = index+2*num;
                        t.size = keywords[s].Length;
                        m_tags.Add(t);
                    }
                        text = text.Substring(0, index);
                        index = text.LastIndexOf(keywords[s]);
                }
            }
            format();
        }
        
        private void LineNumbers()
        {
            TextPointer start = rtbInput.Document.ContentStart;
            TextPointer end = rtbInput.Document.ContentEnd;
            TextRange tr = new TextRange(start, end);
            string[] txt = tr.Text.Split('\n');
            if (tr.Text.Length > 2)
            {
                if (!mnuWrap.IsChecked)
                {
                    txtline.Text = "1";
                    if (txt.Length > 0)
                    {
                        int len = txtline.Text.Split('\n').Length;
                        if (len <= txt.Length - 2)
                        {
                            while (len <= txt.Length - 2)
                            {
                                txtline.AppendText("\n" + (len + 1).ToString());
                                len = len + 1;
                            }
                        }
                    }
                }
                else
                {

                    if (txt.Length > 0)
                    {
                        int lines = 0;
                        txtline.Text = "";
                        int i;
                        int width = 70;
                        for (i = 0; i <= txt.Length - 2; i++)
                        {
                            lines = 0;
                            lines += txt[i].Length / width;
                            if (txt[i].Length % width != 0)
                                lines += 1;
                            if (i == 0)
                                txtline.Text = (i + 1).ToString();
                            else
                                txtline.Text += "\n" + (i + 1).ToString();
                            for (int j = 1; j < lines; j++)
                            {
                                txtline.Text += "\n ";
                            }
                        }

                    }
                }
                txtline.ScrollToVerticalOffset(rtbInput.VerticalOffset);
            }
        }

        private void highlight()
        {
            syntax();
            LineNumbers();
        }
             
        private int compare(tags t1, tags t2)
        {
            if (t1.start < t2.start)
                return 1;
            if (t1.start == t2.start)
                return 0;
            return -1;
        }

        private void rtbInput_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key.ToString() == "Left" || e.Key.ToString() == "Right" || e.Key.ToString() == "Down" || e.Key.ToString() == "Up")
            {
            }
            else
            {
                try
                {
                    //Collaborative!!!!!!!!!!!!!!!!!!!!!!!
                    if (cur_th != null && cur_th.IsAlive == true)
                    {
                        cur_th.Abort();

                        cur_th = null;
                    }
                    TextPointer cur = rtbInput.CaretPosition;
                    TextPointer start = rtbInput.CaretPosition.GetLineStartPosition(0);
                    TextPointer end = rtbInput.Document.ContentEnd;
                    TextRange tr = new TextRange(start, end);
                    string s = tr.Text.ToString();
                    if (s.IndexOf('\r') != -1)
                        s = s.Substring(0, s.IndexOf('\r'));
                    int total = rtbInput.Document.ContentStart.GetOffsetToPosition(start);
                    TextRange ts = new TextRange(rtbInput.Document.ContentStart, start);
                    int linenum = ts.Text.Split('\n').Length;
                    linenum = linenum - 1;
                    int modifier = 0;
                    //if (prog != "")
                    if (e.Key.ToString() == "Return")
                    {
                        TextPointer tp = rtbInput.Document.ContentStart.GetLineStartPosition(0).GetLineStartPosition(linenum - 1);// start.GetLineStartPosition(0).GetLineStartPosition(-1).GetLineStartPosition(0);
                        if (tp != null)
                        {
                            TextRange tp1 = new TextRange(tp, end);
                            string st = tp1.Text.ToString();
                            if (st.IndexOf('\r') != -1)
                            {
                                st = st.Substring(0, st.IndexOf('\r'));
                            }
                            string[] param = prog.Split('\n');
                            if (linenum != 0 && linenum <= param.Length - 1)
                            {
                                string temp = param[linenum - 1];
                                if (temp.IndexOf('\r') != -1)
                                    temp = temp.Substring(0, temp.IndexOf('\r'));
                                if (temp != st)
                                {
                                    SM.sourceCodeChanged((linenum - 1).ToString(), st, "0", username);

                                }
                                modifier = 2;
                                SM.sourceCodeChanged(linenum.ToString(), s, modifier.ToString(), username);
                            }
                        }
                    }
                    else if ((e.Key.ToString() == "Back" || e.Key.ToString() == "Delete"))
                    {
                        int presentlen = new TextRange(rtbInput.Document.ContentStart, rtbInput.Document.ContentEnd).Text.Split('\n').Length;
                        int originallen = prog.Split('\n').Length;
                        string temp = prog.Split('\n')[linenum];
                        if (temp.IndexOf('\r') != -1)
                            temp = temp.Substring(0, temp.IndexOf('\r'));

                        if (presentlen < originallen)
                        {
                            modifier = 1;
                            //linenum = linenum + 1;
                            for (int j = (originallen - presentlen); j >= 1; j--)
                            {
                                SM.sourceCodeChanged((linenum + j).ToString(), s, modifier.ToString(), username);

                            }
                        }
                        if (temp != s)
                        {
                            start = rtbInput.Document.ContentStart.GetLineStartPosition(0).GetLineStartPosition(linenum);
                            tr = new TextRange(start, end);
                            s = tr.Text.ToString();
                            if (s.IndexOf('\r') != -1)
                                s = s.Substring(0, s.IndexOf('\r'));
                            SM.sourceCodeChanged(linenum.ToString(), s, "0", username);

                        }
                    }
                    else
                    {
                        start = rtbInput.Document.ContentStart.GetLineStartPosition(0).GetLineStartPosition(linenum);
                        tr = new TextRange(start, end);
                        s = tr.Text.ToString();
                        if (s.IndexOf('\r') != -1)
                            s = s.Substring(0, s.IndexOf('\r'));
                        SM.sourceCodeChanged(linenum.ToString(), s, "0", username);
                    }
                    tr = new TextRange(rtbInput.Document.ContentStart, rtbInput.Document.ContentEnd);
                    prog = tr.Text;
                    markLinepositions();
                }
                catch (SystemException except)
                {
                    //            System.Windows.MessageBox.Show("KEyin except:"+except.StackTrace);
                }
                if (e.Key.ToString() == "Space" || e.Key.ToString() == "Return")
                {
                    if (cur_th != null && cur_th.IsAlive == true)
                    {
                        cur_th.Abort();
                        cur_th = null;
                    }
                    cur_th = new Thread(new ThreadStart(
                                            delegate()
                                            {
                                                rtbInput.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                                                    delegate()
                                                    {
                                                        highlight();
                                                    }));
                                            }));
                    cur_th.IsBackground = true;
                    cur_th.Start();
                }

            }
        }

        private void markLinepositions()
        {
            try
            {
                string[] temp = prog.Split('\n');
                m_user.Clear();
                for (int i = 0; i < temp.Length && i < editedNum.Keys.Count; i++)
                {
                    userhighlight u = new userhighlight();
                    int length = 0;
                    int x = 0;
                    int[] keys = new int[editedNum.Count];
                    editedNum.Keys.CopyTo(keys, 0);
                    for (int j = 0; j < keys[i]; j++)
                    {
                        if (temp[j].IndexOf('\r') != -1)
                            length += temp[j].Substring(0, temp[j].IndexOf('\r')).Length;
                        else
                            length += temp[j].Length;
                    }
                    u.start = length + (i) * 4 + 2;
                    u.name = (string)editedNum[i];
                    if (temp[i].IndexOf('\r') != -1)
                    {
                        u.size = temp[i].Substring(0, temp[i].IndexOf('\r')).Length;
                        m_user.Add(u);
                    }
                }
                userformat();
                //syntax();
            }
            catch (Exception except)
            {
                //System.Windows.MessageBox.Show("Exception in Marking line position"+except.StackTrace);
            }
        }

        private void userformat()
        {
            try
            {
                if (mnuHighlight.IsChecked)
                {
                    TextRange tr = new TextRange(rtbInput.Document.ContentStart, rtbInput.Document.ContentEnd);
                    tr.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.White));
                    int[] keys = new int[editedNum.Count];
                    editedNum.Keys.CopyTo(keys, 0);
                    string[] param = prog.Split('\n');
                    for (int i = 0; i < editedNum.Count; i++)
                    {
                        TextPointer str = rtbInput.Document.ContentStart.GetPositionAtOffset(0).GetPositionAtOffset(keys[i] + 2, LogicalDirection.Forward);
                        TextPointer stp = str.GetPositionAtOffset(param[i].Length + 1, LogicalDirection.Backward);
                        TextRange ts = new TextRange(str, stp);
                        ts.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(userColor[(collaboratedUsers.IndexOf(m_user[i].name) % userColor.Count)]));
                    }
                }
            }
            catch (SystemException except)
            {
                //System.Windows.MessageBox.Show("Exception in user format"+except.InnerException.ToString());
            }
        }

        private void update(string lno1, string s, string mod1, string uname)
        {
            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            try
                            {
                                int lno = Int32.Parse(lno1);
                                int mod = Int32.Parse(mod1);
                                int flag = 0;
                                if (mod != 1)
                                {
                                    Hashtable temp = new Hashtable();
                                    for (int k = 0; k < editedNum.Keys.Count && mod == 2; k++)
                                    {
                                        if (k >= lno)
                                        {
                                            string nam = (string)editedNum[k];
                                            editedNum.Remove(k);
                                            temp.Add(k + 1, nam);
                                        }
                                    }
                                    for (int k = 0; k < temp.Keys.Count; k++)
                                    {
                                        if (editedNum.ContainsKey(k))
                                            editedNum.Remove(k);
                                        editedNum.Add(k, temp[k]);
                                    }
                                    temp.Clear();
                                    if (editedNum.ContainsKey(lno))
                                        editedNum.Remove(lno);
                                    editedNum.Add(lno, uname);
                                }
                                else
                                {
                                    Hashtable temp = new Hashtable();
                                    for (int k = 0; k < editedNum.Keys.Count; k++)
                                    {
                                        if (k > lno)
                                        {
                                            string nam = (string)editedNum[k];
                                            editedNum.Remove(k);
                                            temp.Add(k - 1, nam);
                                        }
                                    }
                                    for (int k = 0; k < temp.Keys.Count; k++)
                                    {
                                        if (editedNum.ContainsKey(k))
                                            editedNum.Remove(k);
                                        editedNum.Add(k, temp[k]);
                                        temp.Remove(k);
                                    }
                                }
                                string[] param = prog.Split('\n');
                                if (mod == 1)
                                {
                                    TextPointer t1 = rtbInput.Document.ContentStart.GetLineStartPosition(0).GetLineStartPosition(lno - 1);//GetPositionAtOffset(param[lno-1].Length);
                                    if (lno - 1 < param.Length)
                                    {
                                        string temp = param[lno - 1];
                                        if (temp.IndexOf('\r') != -1)
                                            temp = temp.Substring(0, temp.IndexOf('\r'));
                                        if (lno < param.Length)
                                        {
                                            string temp1 = param[lno];
                                            if (temp1.IndexOf('\r') != -1)
                                                temp1 = temp1.Substring(0, temp1.IndexOf('\r'));
                                            TextRange tr;
                                            if (temp1.Length > 0)
                                                tr = new TextRange(t1.GetPositionAtOffset(temp.Length + 2), t1.GetPositionAtOffset(temp.Length + 5 + temp1.Length));
                                            else
                                                tr = new TextRange(t1.GetPositionAtOffset(temp.Length + 2), t1.GetPositionAtOffset(temp.Length + 4));
                                            tr.Text = "";
                                        }
                                    }
                                }
                                else
                                    if (mod == 0)
                                    {
                                        TextPointer tp = rtbInput.Document.ContentStart.GetLineStartPosition(0).GetLineStartPosition(lno);
                                        if (tp != null)
                                        {
                                            string temp = param[lno];
                                            if (temp.IndexOf('\r') != -1)
                                                temp = temp.Substring(0, temp.IndexOf('\r'));
                                            TextRange tr = new TextRange(tp, tp.GetPositionAtOffset(temp.Length + 1));
                                            tr.Text = s;
                                        }
                                    }
                                    else
                                        if (mod == 2)
                                        {
                                            if (lno < param.Length - 1)
                                            {
                                                TextPointer tp = rtbInput.Document.ContentStart.GetLineStartPosition(0).GetLineStartPosition(lno);
                                                if (tp != null)
                                                {
                                                    tp.InsertTextInRun(s + "\n");
                                                }
                                            }
                                            else
                                                rtbInput.AppendText("\n" + s);
                                        }

                                prog = new TextRange(rtbInput.Document.ContentStart, rtbInput.Document.ContentEnd).Text.ToString();
                                markLinepositions();
                            }
                            catch (SystemException except)
                            {
                                //System.Windows.MessageBox.Show("Exception in update " + except.StackTrace);
                            }
                        }));
                }));
            t.Start();
        }

        private void ShowError(string Msg)
        {
            System.Windows.MessageBox.Show(Msg, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EnablePlot(PngBitmapEncoder encoder, List<double> listvalues)
        {
            try
            {
                if (encoder != null)
                {
                    PlotVals = listvalues;
                    PngBitmapEncoder PBE = new PngBitmapEncoder();
                    PBE.Frames.Add(BitmapFrame.Create(encoder.Frames[0].Clone()));
                    isplotReady = 1;
                    System.IO.FileStream outStream = new System.IO.FileStream(plotpath, System.IO.FileMode.Create);
                    PBE.Save(outStream);
                    outStream.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error in enable plot:" + e.Message);
            }
        }
            
        private void Display(string res)
        {
            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            txtResult.Text += res;
                        }));
                }));
            t.Start();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            plot.terminate();
        }

        
        //***   ALL THE EVENTS  ***//
        private void mnuFile_Click(object sender, RoutedEventArgs e)
        {
            mnuSave.Visibility = Visibility.Visible;
            mnuExit.Visibility = Visibility.Visible;
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            SM.programClosed();
            if (CloseProgramEvent != null)
                CloseProgramEvent(PID);
            Close();
        }

        private void mnuWrap_Click(object sender, RoutedEventArgs e)
        {
            if (rtbInput.HorizontalScrollBarVisibility == ScrollBarVisibility.Disabled)
            {
                rtbInput.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
                rtbInput.Document.PageWidth = 20000;
                LineNumbers();
                syntax();
            }
            else
            {
                rtbInput.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
                rtbInput.Document.PageWidth = rtbInput.Width;
                LineNumbers();
                syntax();
            }
        }

        private void mnuLine_Click(object sender, RoutedEventArgs e)
        {
            if (mnuLine.IsChecked)
                txtline.Visibility = Visibility.Visible;
            else
                txtline.Visibility = Visibility.Hidden;
        }

        private void mnuOption_Click(object sender, RoutedEventArgs e)
        {
            mnuLine.Visibility = Visibility.Visible;
            mnuWrap.Visibility = Visibility.Visible;
            mnuHighlight.Visibility = Visibility.Visible;
        }

        private void mnuAccess_Click(object sender, RoutedEventArgs e)
        {
            mnuEdit.Visibility = Visibility.Visible;
        }


        private void mnuEdit_Click(object sender, RoutedEventArgs e)
        {
            TextPointer start = rtbInput.Document.ContentStart;
            TextPointer end = rtbInput.Document.ContentEnd;
            TextRange tr = new TextRange(start, end);
            EditPermissions editPerm = new EditPermissions(SM, IP, Port, tr.Text, owner);
            editPerm.setUserList(swarmUserTable);
            editPerm.ShowDialog();
        }

        private void btnCompute_Click(object sender, RoutedEventArgs e)
        {
            if (SM.RunClicked(IP, Port))
            {
                clickedCompute = true;
                txtResult.Text = "";
                isplotReady = 0;
                plotpath = Title;
                plotpath += ".png";
                TextPointer start = rtbInput.Document.ContentStart;
                TextPointer end = rtbInput.Document.ContentEnd;
                TextRange tr = new TextRange(start, end);
                Controller.clearCoreValues();
                worker.RunWorkerAsync(tr.Text);
                mnuPlot.IsEnabled = true;
            }
        }

        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "ssf files (*.ssf)|*.ssf|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);
                    FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                    progName = fi.Name;
                    string[] title = this.Title.Split('-');
                    this.Title = title[0] + "-" + title[1] + "- " + progName;
                    lblProgName.Content = "Program Name: " + progName;
                    using (sw)
                    {
                        TextPointer start = rtbInput.Document.ContentStart;
                        TextPointer end = rtbInput.Document.ContentEnd;
                        TextRange tr = new TextRange(start, end);
                        sw.Write(tr.Text.ToString());
                        sw.Close();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error: Could not Write file to disk. Original error: " + ex.Message);
                }
            }
        }

        private void mnuShowPlot_Click(object sender, RoutedEventArgs e)
        {
            if (isplotReady == 1)
            {
                ProgPlot frmPlot = new ProgPlot(plotpath, PlotVals, plot);
                frmPlot.ShowDialog();
            }
            else
                System.Windows.MessageBox.Show("No Plot");
        }

        private void mnuSavePlot_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "png files (*.png)|*.png";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    String tempPath = saveFileDialog1.FileName;

                    // create a file stream for saving image
                    using (FileStream outStream = new FileStream(tempPath, FileMode.Create))
                    {
                        //SAVING**************************
                        //PBE.Save(outStream);
                    }

                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error: Could not Write file to disk. Original error: " + ex.Message);
                }
            }
        }

        public void send_close_msg()
        {
            SM.programClosed();
            //Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            SM.programClosed();
            if (CloseProgramEvent != null)
                CloseProgramEvent(PID);
            //Close();
        }

        private void rtbInput_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            txtline.ScrollToVerticalOffset(rtbInput.VerticalOffset);
        }

        private void rtbInput_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            txtline.ScrollToVerticalOffset(rtbInput.VerticalOffset);
        }
    }
}