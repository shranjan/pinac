//////////////////////////////////////////////////////////////////////////////////
//  Error.cs - Error Module                                                     //
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
using Spinach;

namespace Spinach
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void ErrorNotification(string Msg);
    public class ErrorModule
    {
        public event ErrorNotification ConnError;
        public event ErrorNotification ProgConfError;
        public event ErrorNotification ProgWinError;
        
        private executor Ex;
        private PlotReceiver plot;
        private SwarmConnection SC;
        private SwarmMemory SM = null;

        private Dictionary<int, string> ErrorDict = new Dictionary<int, string>();

        //----< Create the Dictionary of Errors >----
        public ErrorModule()
        {
            // Swarm Error Messages
            ErrorDict.Add(10, "Connection Error: ");
            // FrontEnd Error Messages
            ErrorDict.Add(101, "Syntax Error: ");
            ErrorDict.Add(102, "Exception: ");
            // CoreTeam Error Messages
            ErrorDict.Add(112, "Semantic Error: ");
            ErrorDict.Add(113, "Exception: ");
            // PlotTeam Error Messages
            ErrorDict.Add(121, "Plotting Error: ");
            ErrorDict.Add(122, "Plotting Error: ");
            ErrorDict.Add(123, "Plotting Error: ");

        }

        //----< Sends Error Message to appropriate window >----
        public void ErrorMsg(int Code, string Msg)
        {
            string ErrMsg = ErrorDict[Code] + Msg;
            if (Code < 50 && ConnError != null)
                ConnError(ErrMsg);
            else if (Code < 100 && ProgConfError != null)
                ProgConfError(ErrMsg);
            else if (Code < 150 && ProgWinError != null)
            {
                SM.BroadcastError(ErrMsg);
                //if (Code == 101 || Code == 102 || Code == 201 || Code == 202 || Code==203)
                    SM.clearMasterBackup(true);
                //ProgWinError(ErrMsg);
            }
        }

        public void SetExecutorObject(executor E)
        {
            Ex = E;
            Ex.errEvent +=new executor.err(ErrorMsg);
        }

        public void SetPlotObject(PlotReceiver p)
        {
            plot = p;
            plot.error +=new PlotReceiver.PlotError(ErrorMsg);
        }

        public void SetSwarmConnectionObject(SwarmConnection s)
        {
            SC = s;
            SC.ErrorChanged +=new SwarmConnection.ErrorEventHandler(ErrorMsg);
        }

        public void SetSwarmMemoryObject(SwarmMemory s)
        {
            SM = s;
            SM.ErrorResult+=new SwarmMemory.BrdErrorResult(ShowMsg);
        }

        public void ShowMsg(string ErrMsg)
        {
            ProgWinError(ErrMsg);
        }
    }
}
