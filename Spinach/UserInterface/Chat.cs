//////////////////////////////////////////////////////////////////////////////////
//  Chat.cs - Chat handling class                                               //
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
using Spinach;

namespace Spinach
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void ChatNotification(string Uname, string Msg);
    public class ChatModule
    {
        public event ChatNotification Chat;
        private SwarmConnection SC;

        public ChatModule(SwarmConnection SConn)
        {
            SC = SConn;
            SC.ChatChanged += new SwarmConnection.ChatEventHandler(ChatMsg);
        }

        //----< Sends Error Message to ProgConf >----
        public void ChatMsg(string Uname, string Msg)
        {
            if (Chat != null)
                Chat(Uname, Msg);
        }

    }
}
