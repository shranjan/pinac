﻿//////////////////////////////////////////////////////////////////////////////////
//  Connection.xaml.cs - Program Configuration Window                           //
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

/*
 * Maintenance History:
 * ====================
 * version 1.1 : 25 Oct 09
 * - introduced validation for the radio buttons and similarly passed the requisite
 *   user list
 * - made connection button the default button
 * - also validated the peer ip/port
 * version 1.0 : 24 Oct 09
 * - the initial version of the connection module
 */

using System;
using System.Collections.Generic;
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
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Spinach
{
  /// <summary>
  /// Interaction logic for Connection.xaml
  /// </summary>

  public partial class Connection : Window
  {
    private ErrorModule Err = new ErrorModule();
    private SwarmConnection SC = new SwarmConnection();
    private List<string> userList;

    //----< Connection Ctor >----
    public Connection()
    {
      InitializeComponent();
      Err.ConnError += new ErrorNotification(ShowError);
      SC.ListChanged += new SwarmConnection.ChangedEventHandler(SC_ListChanged);
      Err.SetSwarmConnectionObject(SC);
    }

    void SC_ListChanged(List<string> conInfo)
    {
        userList = conInfo;
    }

    //----< Connection Window Load Event >----
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        txtSelfIP.Text = GetIP();
        txtPort.Text = "11001";
        txtSelfIP.Focus();
        txtSelfIP.SelectAll();
        foreach (string sFile in Directory.GetFiles(Directory.GetCurrentDirectory()))
        {
            if (sFile.EndsWith(".png"))
                File.Delete(sFile);
        }
    }

    //----< Get the IP of the machine >----
    private string GetIP()
    {
      string strHostName = "";
      string ipAddr = "";
      strHostName = System.Net.Dns.GetHostName();
      IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
      foreach (IPAddress ip in ipEntry.AddressList)
      {
          if (ip.AddressFamily.ToString() == ProtocolFamily.InterNetwork.ToString())
              ipAddr = ip.ToString();
      }
      return ipAddr;
    }

    //----< Join Swarm Radio Button Checked Event >----
    private void rdbJoinSwarm_Checked(object sender, RoutedEventArgs e)
    {
      txtPeerIP.Visibility = Visibility.Visible;
      txtPeerPort.Visibility = Visibility.Visible;
      lblPeerIP.Visibility = Visibility.Visible;
      lblPeerPort.Visibility = Visibility.Visible;

    }

    //----< Join Swarm Radio Button Unchecked Event >----
    private void rdbJoinSwarm_Unchecked(object sender, RoutedEventArgs e)
    {
      txtPeerIP.Visibility = Visibility.Hidden;
      txtPeerPort.Visibility = Visibility.Hidden;
      lblPeerIP.Visibility = Visibility.Hidden;
      lblPeerPort.Visibility = Visibility.Hidden;
    }

    //----< Show error MessageBox to the user >----
    private void ShowError(string Msg)
    {
      MessageBox.Show(Msg, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }

    //----< Connect Button Click Event >----
    private void btnConnect_Click(object sender, RoutedEventArgs e)
    {
      bool conn = false;
      if (txtSelfIP.Text.Trim() == "")
      {
          MessageBox.Show("Please enter your IP Address", "IP Address", MessageBoxButton.OK, MessageBoxImage.Exclamation);
          txtSelfIP.Focus();
      }
      else if (txtPort.Text.Trim() == "")
      {
          MessageBox.Show("Please enter your Port", "Port", MessageBoxButton.OK, MessageBoxImage.Exclamation);
          txtPort.Focus();
      }
      else if (txtUsername.Text.Trim() == "")
      {
          MessageBox.Show("Please enter the Username", "Username", MessageBoxButton.OK, MessageBoxImage.Exclamation);
          txtUsername.Focus();
      }
      else if ((rdbCreateSwarm.IsChecked == false) && (rdbJoinSwarm.IsChecked == false))
      {
          MessageBox.Show("Please select the Swarm Type", "Swarm Type", MessageBoxButton.OK, MessageBoxImage.Exclamation);
          rdbCreateSwarm.Focus();
      }
      else
      {
          //Connect to the Swarm
          if (rdbJoinSwarm.IsChecked == true)
          {
             //make sure whether the user has entered the peer ip and port
              if (txtPeerIP.Text.Trim() == "" || txtPeerPort.Text.Trim() == "")
              {
                  MessageBox.Show("Please enter valid Peer IP/Port", "Peer IP/Port", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                  return;
              }
              else
              {
                  conn = SC.Join_Swarm(txtPeerIP.Text.Trim(), txtPeerPort.Text.Trim(), txtSelfIP.Text.Trim(), txtPort.Text.Trim(), txtUsername.Text.Trim());
                  //if (!conn)
                  //    MessageBox.Show("Connection Problem", "Error in Connection", MessageBoxButton.OK, MessageBoxImage.Exclamation);
              }
          }
          else if (rdbCreateSwarm.IsChecked == true)
          {
              conn = SC.Create_Swarm(txtSelfIP.Text.Trim(), txtPort.Text.Trim(), txtUsername.Text.Trim());
              if(!conn)
                  MessageBox.Show("Connection Problem", "Error in Connection", MessageBoxButton.OK, MessageBoxImage.Exclamation);
          }
          //SWARM MUST TELL ME IF THE CONNECTION WAS SUCCESSFUL OR NOT
          //Go to the next Window
          if (conn == true)
          {
              ProgConf winProgConf = new ProgConf(SC);
              winProgConf.Conn += new ConnectionNotification(UnHide);
              winProgConf.setUserList(userList);
              winProgConf.setDetails(txtSelfIP.Text.Trim(), txtPort.Text.Trim(), txtUsername.Text.Trim());
              winProgConf.Show();
              this.Hide();
          }
      }
    }

    void UnHide()
    {
        this.Show();
    }
  }
}
