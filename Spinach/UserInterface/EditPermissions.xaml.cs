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
using System.Windows.Shapes;

namespace Spinach
{
    /// <summary>
    /// Interaction logic for EditPermissions.xaml
    /// </summary>
    public partial class EditPermissions : Window
    {
        private Dictionary<string, string> swarmUserTable = new Dictionary<string, string>();
        private string ipPort = "";
        private string myIP = "", myPort = "", programText = "";
        SwarmMemory SM;
        public EditPermissions(SwarmMemory sm, string ip, string port, string text)
        {
            InitializeComponent();
            SM = sm;
            myIP = ip;
            myPort = port;
            programText = text;
        }

        public void setUserList(Dictionary<string, string> suTable)
        {
            cbUser.Items.Clear();
            swarmUserTable = suTable;
            foreach (string s in swarmUserTable.Values)
            {
                cbUser.Items.Add(s);
            }
            //cbUser.SelectedIndex = 0;
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (chkRead.IsEnabled)
            {
                if (chkRead.IsChecked == true)
                {
                    string read = "true";
                    string write = "false";
                    if (chkWrite.IsChecked == true)
                        write = "true";
                    if (cbUser.Text != "")
                    {
                        SM.addPermissionRequest(myIP, myPort, programText, ipPort, read, write);
                    }
                    else
                        MessageBox.Show("Please select a user");
                    Close();
                }
            }
            else if (chkWrite.IsEnabled && chkWrite.IsChecked == true)
            {
                string read = "true";
                string write = "true";
                if (cbUser.Text != null)
                {
                    SM.changePermissionRequest(myIP, myPort, ipPort, read, write);
                }
                else
                    MessageBox.Show("Please select a user");
                Close();
            }
        }



        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cbUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string uname = (string)cbUser.SelectedItem;
            
            foreach (KeyValuePair<string, string> temp in swarmUserTable)
            {
                if (temp.Value == uname)
                {
                    ipPort = temp.Key;
                    break;
                }
            }
            string[] perm = SM.getOnePermission(ipPort);
            if (perm != null)
            {
                chkRead.IsEnabled = true;
                chkRead.IsChecked = false;
                chkWrite.IsEnabled = true;
                chkWrite.IsChecked = false;
                if (perm[0] == "true")
                {
                    chkRead.IsChecked = true;
                    chkRead.IsEnabled = false;
                }
                if (perm[1] == "true")
                {
                    chkWrite.IsChecked = true;
                    chkWrite.IsEnabled = false;
                }
            }
        }

        private void chkWrite_Checked(object sender, RoutedEventArgs e)
        {
            if (chkRead.IsEnabled)
                chkRead.IsChecked = true;
        }

        private void chkRead_Checked(object sender, RoutedEventArgs e)
        {
            if (chkWrite.IsChecked == true)
                chkRead.IsChecked = true;
        }

        private void btnCngOwner_Click(object sender, RoutedEventArgs e)
        {
            string user = cbUser.SelectedItem.ToString();
            SM.changeTheOwner(ipPort, myIP, myPort);
            string[] perm = SM.getOnePermission(ipPort);
            if (perm[0] == "false" && perm[1] == "false")
                SM.addPermissionRequest(myIP, myPort, programText, ipPort, "true", "true");
            else
            {
                SM.changePermissionRequest(myIP, myPort, ipPort, "true", "true");
            }
        }
    }
}
