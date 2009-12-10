//////////////////////////////////////////////////////////////////////////////////
//  SwarmMemory.cs - Memory class                                               //
//                                                                              //
//  Language:      C#                                                           //
//  Author:        Mehmet KAYA (mkaya@syr.edu)                                  //
//                 (315) 480-9763                                               //
//                 Shaonan Wang (swang25@syr.edu)                               //
//                 Mohammad Irfan Khan Tareen (mtareen@syr.edu)                 //
//////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace Spinach
{
    public class SwarmMemory
    {
        public delegate void PermissionListChanged(List<string> PerListChanged);
        public event PermissionListChanged PermissionListCh;
        public delegate void SourceCodeChanged(string[] SourceChanged);
        public event SourceCodeChanged srcChanged;
        public delegate void RunButtonClick(bool Clicked);
        public event RunButtonClick rnBtnClicked;
        public delegate void executeParallel(string data, string body, int index1,int index2,string range);
        public event executeParallel parallelcore_;
        public delegate void getResults(List<string> results);
        public event getResults parallelresult_;
        public delegate void GetFinalResult(string FinRes);
        public event GetFinalResult FinalResult;
        public delegate void BrdErrorResult(string error);
        public event BrdErrorResult ErrorResult;
        public delegate void GetPlot(string PlotRes);
        public event GetPlot PlotResult;

        public delegate void CloseProgram(bool CloseProg);
        public event CloseProgram CloseP;
        public delegate void RerunProgram(bool Rerun);
        public event RerunProgram RerunP;

        Hashtable ParallelPortions;
        Hashtable ParallelResults;
        Hashtable permissions;
        //Hashtable Reply;
        //Hashtable MatrixPortions;
        //Hashtable MatrixResults;
        bool RunFlag;
        string StartFlag;
        String Pid;
        String Master;
        String BackUp;
        String owner;
        String ParallelForBody;
        String ParallelForData;
        String rng; //for core team
        //String MatrixBody;
        //String MatrixData;
        int numberOfIterations;
        List<int> TaskIndexList = new List<int>();  // when to clear this List?
        Hashtable ResultCollection;
        Hashtable SubResultCollection;
        private SwarmConnection conn;

        public SwarmMemory(SwarmConnection c)
        {
            Master = "";
            BackUp = "";
            conn = c;
            TaskIndexList = new List<int>();
            ResultCollection = new Hashtable();
            SubResultCollection = new Hashtable();
        }
        public void AddTaskIndex(int index)
        {
            TaskIndexList.Add(index);
        }
        public void ClearTask()
        {
            TaskIndexList.Clear();
            ResultCollection.Clear();
            SubResultCollection.Clear();
        }
        public int GetTaskIndexCount()
        {
            return TaskIndexList.Count;
        }

        public void createTheObjects(string _Pid, string myIP, string myPort)
        {

            //Reply = new Hashtable();            
            permissions = new Hashtable();            
            Pid = _Pid;
            owner = myIP + ":" + myPort;
            string[] temp = { "true", "true" };
            permissions[owner]= temp;
            BuildList();
            RunFlag = false;
            StartFlag = "";
        }
        public string getMaster()
        {
            return Master;
        }
        public string getBackUp()
        {
            return BackUp;
        }
        private void computationDone()
        {
            if (permissions.Count > 1)
            {
                string xml = "<ComputationDone>" + "<Pid>" + Pid + "</Pid></ComputationDone>";
                AsynchronousSocketListener msocket = conn.getSocket();
                string myIP = msocket.GetIP();
                string myPort = msocket.GetPort();
                List<string> endPoints = Peers();
                Hashtable temp = conn.GetIPtoPeer();
                Hashtable tempToSend = new Hashtable();

                foreach (DictionaryEntry item in temp)
                {
                    if (endPoints.Contains(item.Key.ToString()))
                    {
                        tempToSend.Add(item.Key, item.Value);
                    }
                }        

                AsynchronousClient client = new AsynchronousClient();
                client.SetMultiMsg(tempToSend, xml, myIP + ":" + myPort);
                Thread t = new Thread(new ThreadStart(client.SendMultiClient));
                t.IsBackground = true;
                t.Start();
            }
            setRunFlag(false);
            setStartFlag("");
        }
        public void BroadcastResult(string result)
        {
         
            if (permissions.Count > 1)
            {
                string xml = "<FinalResult>" + "<Pid>" + Pid + "</Pid>" + "<Result>" + result + "</Result>" + "</FinalResult>";
                AsynchronousSocketListener msocket = conn.getSocket();
                string myIP = msocket.GetIP();
                string myPort = msocket.GetPort();
                List<string> endPoints = Peers();
                Hashtable temp = conn.GetIPtoPeer();
                Hashtable tempToSend = new Hashtable();

                foreach (DictionaryEntry item in temp)
                {
                    if (endPoints.Contains(item.Key.ToString()))
                    {
                        tempToSend.Add(item.Key, item.Value);
                    }
                }

                AsynchronousClient client = new AsynchronousClient();
                client.SetMultiMsg(tempToSend, xml, myIP + ":" + myPort);
                Thread t = new Thread(new ThreadStart(client.SendMultiClient));
                t.IsBackground = true;
                t.Start();
            }
        }
        public void BroadcastPlot(string plot)
        {

            if (permissions.Count > 0)
            {
                string xml = "<Plotmsg>" + "<Pid>" + Pid + "</Pid>" + "<Plot>" + plot + "</Plot>" + "</Plotmsg>";
                AsynchronousSocketListener msocket = conn.getSocket();
                string myIP = msocket.GetIP();
                string myPort = msocket.GetPort();
                List<string> endPoints = Peers();
                Hashtable temp = conn.GetIPtoPeer();
                Hashtable tempToSend = new Hashtable();

                foreach (DictionaryEntry item in temp)
                {
                    if (endPoints.Contains(item.Key.ToString()))
                    {
                        tempToSend.Add(item.Key, item.Value);
                    }
                }

                AsynchronousClient client = new AsynchronousClient();
                client.SetMultiMsg(tempToSend, xml, myIP + ":" + myPort);
                Thread t = new Thread(new ThreadStart(client.SendMultiClientChat));
                t.IsBackground = true;
                t.Start();
            }
        }

        public void getPlot(string plot)
        {
            if (PlotResult != null)
                PlotResult(plot);
        }
        public void getFinalResult(string result)
        {
            if (FinalResult != null)
                FinalResult(result);
        }
        public void BroadcastError(string error_)
        {
            if (permissions.Count > 0)
            {
                string error = error_.Replace('<', '@');
                error = error.Replace('>', '$');
                string xml = "<ComError>" + "<Pid>" + Pid + "</Pid>" + "<ErrorDetail>" + error + "</ErrorDetail>" + "</ComError>";
                AsynchronousSocketListener msocket = conn.getSocket();
                string myIP = msocket.GetIP();
                string myPort = msocket.GetPort();
                List<string> endPoints = Peers();
                Hashtable temp = conn.GetIPtoPeer();
                Hashtable tempToSend = new Hashtable();

                foreach (DictionaryEntry item in temp)
                {
                    if (endPoints.Contains(item.Key.ToString()))
                    {
                        tempToSend.Add(item.Key, item.Value);
                    }
                }

                AsynchronousClient client = new AsynchronousClient();
                client.SetMultiMsg(tempToSend, xml, myIP + ":" + myPort);
                Thread t = new Thread(new ThreadStart(client.SendMultiClientChat));
                t.IsBackground = true;
                t.Start();
            }
        }
        public void GetError(string error)
        {
            if (ErrorResult != null)
                ErrorResult(error);
            
        }
        public void programClosed()
        {
            if (permissions.Count > 1)
            {

                AsynchronousSocketListener msocket = conn.getSocket();
                string myIP = msocket.GetIP();
                string myPort = msocket.GetPort();
                string xml = "<ProgramClosed>" + "<Pid>" + Pid + "</Pid><IPPort>" + myIP + ":" + myPort + "</IPPort></ProgramClosed>";
                List<string> endPoints = Peers();
                Hashtable temp = conn.GetIPtoPeer();
                Hashtable tempToSend = new Hashtable();

                foreach (DictionaryEntry item in temp)
                {
                    if (endPoints.Contains(item.Key.ToString()))
                    {
                        tempToSend.Add(item.Key, item.Value);
                    }
                }        

                AsynchronousClient client = new AsynchronousClient();
                client.SetMultiMsg(tempToSend, xml, myIP + ":" + myPort);
                Thread t = new Thread(new ThreadStart(client.SendMultiClient));
                t.IsBackground = true;
                t.Start();
            }
        }
        public void clearMasterBackup(bool x)
        {
            if (x == true)
            {
                AsynchronousSocketListener msocket = conn.getSocket();
                if ((msocket.GetIP() + ":" + msocket.GetPort()) == Master)
                {
                    setBackUp("");
                    setMaster("");
                    computationDone();

                    if (rnBtnClicked != null)
                        rnBtnClicked(false);
                }
                
            }
            else
            {
                setBackUp("");
                setMaster("");
                //
                if (rnBtnClicked != null)
                    rnBtnClicked(false);
            }

        }
        public void setRunFlag(bool x)
        { RunFlag = x; }
        public bool getRunFlag()
        { return RunFlag; }
        public void setStartFlag(String x)
        { StartFlag = x; }
        public String getStartFlag()
        { return StartFlag; }
        public void setMaster(string _Master)
        {
            Master = _Master;
        }
        public void setBackUp(string _BackUp)
        {
            BackUp = _BackUp;
        }
        private string selectBackUp()
        {
            string backup = "";
            string master = getMaster();
            if (permissions.Count == 1)
            {
                return backup;
            }
            else
            {
                foreach (string IP in permissions.Keys)
                {
                    if (IP != master)
                    {
                        backup = IP;
                    }
                }
                foreach (string IPs in permissions.Keys)
                {
                    if (IPs != master)
                    {
                        int comp = IPs.CompareTo(backup);
                        if (comp < 0)
                            backup = IPs;
                    }
                }
                return backup;
            }
        }
        private string getMasterBackUpXML()
        {
            string xml = "<MasterBackUp>";
            xml += "<Pid>" + Pid + "</Pid>";
            xml += "<Master>" + getMaster() + "</Master>";
            xml += "<BackUp>" + getBackUp() + "</BackUp>";
            xml += "</MasterBackUp>";
            return xml;
        }
        public void Lock()
        {
            if (rnBtnClicked != null)
                rnBtnClicked(true);
        }
        public bool RunClicked(string myIP, string myPort)
        {
            string[] target = owner.Split(':');
            string ip = target[0];
            string port = target[1];
            MessageGenerator mg = new MessageGenerator();
            string request = mg.msgRunRequest(Pid, myIP + ":" + myPort);
            AsynchronousClient client = new AsynchronousClient();
            client.SetSingleMsg(ip, port, request);
            Thread t = new Thread(new ThreadStart(client.SendSingleClient));
            t.IsBackground = true;
            t.Start();
            while (StartFlag == "")
                Thread.Sleep(500);

            if (StartFlag == "Fail")
                return false;
            else
            {
                setMaster(myIP + ":" + myPort);
                setBackUp(selectBackUp());

                if (rnBtnClicked != null)
                    rnBtnClicked(true);
                if (permissions.Count > 1)
                {
                    List<string> endPoints = Peers();
                    Hashtable temp = conn.GetIPtoPeer();
                    Hashtable tempToSend = new Hashtable();

                    foreach (DictionaryEntry item in temp)
                    {
                        if (endPoints.Contains(item.Key.ToString()))
                        {
                            tempToSend.Add(item.Key, item.Value);
                        }
                    }        

                    AsynchronousClient client1 = new AsynchronousClient();
                    client1.SetMultiMsg(tempToSend, getMasterBackUpXML(), myIP + ":" + myPort);
                    Thread t1 = new Thread(new ThreadStart(client1.SendMultiClient));
                    t1.IsBackground = true;
                    t1.Start();
                }
                return true;
            }
            
        }
        public bool ReRunClicked(string myIP, string myPort)
        {
            
                setMaster(myIP + ":" + myPort);
                setBackUp(selectBackUp());
                ClearTask();

                //if (rnBtnClicked != null)
                //    rnBtnClicked(true);
                if (permissions.Count > 1)
                {
                    List<string> endPoints = Peers();
                    Hashtable temp = conn.GetIPtoPeer();
                    Hashtable tempToSend = new Hashtable();

                    foreach (DictionaryEntry item in temp)
                    {
                        if (endPoints.Contains(item.Key.ToString()))
                        {
                            tempToSend.Add(item.Key, item.Value);
                        }
                    }        

                    AsynchronousClient client1 = new AsynchronousClient();
                    client1.SetMultiMsg(tempToSend, getMasterBackUpXML(), myIP + ":" + myPort);
                    Thread t1 = new Thread(new ThreadStart(client1.SendMultiClient));
                    t1.IsBackground = true;
                    t1.Start();
                }
            return true;

        }
        public Hashtable getPermissions()
        {
            return permissions;
        }
       
        //public void setReply(Hashtable newReply)
        //{
        //    Reply = newReply;
        //}

        public void setPermissions(Hashtable newPermissons)
        {
            permissions = newPermissons;
        }
        
        public void setOwner(string _owner)
        {
            owner = _owner;
        }
        public string getPid()
        {
            return Pid;
        }
        public string getOwner()
        {
            return owner;
        }
        //public int sizeOfReply()
        //{
        //    return Reply.Count;
        //}
        //public void addReply(string IPP, string _reply)
        //{
        //    Reply.Add(IPP, _reply);
        //}
        public void removePermissionRec(string IPPort)
        {
            lock (this)
            {
                try
                {
                    if (permissions.Contains(IPPort))
                    {
                        if (IPPort == owner)
                        {
                            if (CloseP != null)
                                CloseP(true);
                        }
                        else if (IPPort == Master)
                        {
                            AsynchronousSocketListener msocket = conn.getSocket();
                            if ((msocket.GetIP() + ":" + msocket.GetPort()) == BackUp)
                            {
                                permissions.Remove(IPPort);
                                BuildList();
                                if (RerunP != null)
                                    RerunP(true);//ask UI call ReRunClicked()

                            }
                        }
                        else if (IPPort == BackUp)
                        {
                            permissions.Remove(IPPort);
                            BuildList();
                            BackUp = selectBackUp();
                            AsynchronousSocketListener msocket = conn.getSocket();
                            if ((msocket.GetIP() + ":" + msocket.GetPort()) == Master)
                            {
                                PeerGone(IPPort);
                            }

                        }
                        else
                        {
                            permissions.Remove(IPPort);
                            BuildList();
                            AsynchronousSocketListener msocket = conn.getSocket();
                            if ((msocket.GetIP() + ":" + msocket.GetPort()) == Master)
                            {
                                PeerGone(IPPort);
                            }
                        }
                    }
                }
                catch (Exception e)
                { Console.WriteLine(e.ToString()); }
            }
        }
        //public void deleteReply(string IPP)
        //{
        //    Reply.Remove(IPP);
        //}
        //public Hashtable getReplies()
        //{
        //    return Reply;
        //}
        public string[] getOnePermission(string IPPort)
        {
            //string IPPort = theIP + ":" + thePort;
            string[] permit = new string[2];
            if (permissions.Contains(IPPort))
            {
                permit = (string[])(permissions[IPPort]);
            }
            else { permit[0] = "false"; permit[1] = "false"; }
            return permit;
        }
        public void adder(string IPPort, string read, string write)
        {
            //string IPPort = theIP + ":" + thePort;
            string[] privileges = { read, write };
            permissions[IPPort] = privileges;
            BuildList();


        }
       
        private void BuildList()
        {
            List<string> DisplayList = new List<string>();
            foreach (string iport in permissions.Keys)
            {
                Hashtable temp = conn.getSocket().GetIPtoPeer();
                if (temp.Contains(iport))
                {
                    Peer st = (Peer)temp[iport];
                    string Username = st.mName;
                    string conMsg = Username + " | " + iport;

                    DisplayList.Add(conMsg);
                }
            }
            
            if (PermissionListCh != null)
                PermissionListCh(DisplayList);
        }
        public void changeTheOwner(string IPPort, string myIP, string myPort)
        {
            try
            {
                string myIPPort = myIP + ":" + myPort;
                setOwner(IPPort);
                string changeOwner = "<ChangeOwner><Pid>" + Pid + "</Pid><IPPort>" + IPPort + "</IPPort></ChangeOwner>";
                List<string> endPoints = Peers();
                Hashtable temp = conn.GetIPtoPeer();
                Hashtable tempToSend = new Hashtable();

                foreach (DictionaryEntry item in temp)
                {
                    if (endPoints.Contains(item.Key.ToString()))
                    {
                        tempToSend.Add(item.Key, item.Value);
                    }
                }
                AsynchronousClient client = new AsynchronousClient();
                client.SetMultiMsg(tempToSend, changeOwner, myIPPort);
                Thread t = new Thread(new ThreadStart(client.SendMultiClientChat));
                t.IsBackground = true;
                t.Start();
            }
            catch (Exception e)
            { Console.WriteLine(e.ToString()); }
            
        }

        public void InitializeThePeer(string changes)
        {
            try
            {
                XDocument doc = XDocument.Parse(changes);
                /////////////////////////////
                var q = from x in doc.Elements().Descendants("Permissions").Descendants("Permit").Descendants("IPPort") select x;
                List<string> IPorts = new List<string>();
                foreach (var item in q)
                {
                    IPorts.Add(item.Value.ToString());
                }
                q = from x in doc.Elements().Descendants("Permissions").Descendants("Permit").Descendants("Read") select x;
                List<string> reads = new List<string>();
                foreach (var item in q)
                {
                    reads.Add(item.Value.ToString());
                }
                q = from x in doc.Elements().Descendants("Permissions").Descendants("Permit").Descendants("Write") select x;
                List<string> writes = new List<string>();
                foreach (var item in q)
                {
                    writes.Add(item.Value.ToString());
                }

                Hashtable newPermissions = new Hashtable();
                for (int i = 0; i < IPorts.Count; i++)
                {
                    string[] temp = { reads[i].ToString(), writes[i].ToString() };
                    newPermissions.Add(IPorts[i].ToString(), temp);
                }
                setPermissions(newPermissions);
                //////////////////////////////

                ///////////////////////////////////////////
                //q = from x in doc.Elements().Descendants("Replies").Descendants("Reply").Descendants("IPPort") select x;
                //List<string> ports = new List<string>();
                //foreach (var item in q)
                //{
                //    ports.Add(item.Value.ToString());
                //}
                //q = from x in doc.Elements().Descendants("Replies").Descendants("Reply").Descendants("ReplyValue") select x;
                //List<string> repVal = new List<string>();
                //foreach (var item in q)
                //{
                //    repVal.Add(item.Value.ToString());
                //}
                //Hashtable newReplies = new Hashtable();
                //for (int i = 0; i < ports.Count; i++)
                //{
                //    newReplies.Add(ports[i].ToString(), repVal[i].ToString());
                //}
                //setReply(newReplies);
            }
            catch (Exception e)
            { Console.WriteLine(e.ToString()); }
           
        }
        private string changePermissionMessage(string IPPort, string read, string write)
        {
            string _xml = "<PermissionChange>" + "<Pid>" + Pid.ToString() + "</Pid>"
                + "<IPPort>" + IPPort + "</IPPort>" + "<Read>" + read + "</Read>" + "<Write>" + write + "</Write>"
                + "</PermissionChange>";
            return _xml;
        }
        public void changePermissionRequest(string myIP, string myPort, string IPPort, string read, string write)
        {
            try
            {
                string myIPPort = myIP + ":" + myPort;
                string[] tempPermissions = (string[])permissions[IPPort];
                if ((read == "false" && write == "true") || (tempPermissions[1].ToString() == "true" && write == "false") || (tempPermissions[0].ToString() == "true" && read == "false"))
                {
                }
                else
                {
                    string[] privileges = { read, write };
                    permissions[IPPort] = privileges;
                    List<string> endPoints = Peers();
                    Hashtable temp = conn.GetIPtoPeer();
                    Hashtable tempToSend = new Hashtable();

                    foreach (DictionaryEntry item in temp)
                    {
                        if (endPoints.Contains(item.Key.ToString()))
                        {
                            tempToSend.Add(item.Key, item.Value);
                        }
                    }
                    string permissionMessage = changePermissionMessage(IPPort, read, write);
                    //Console.WriteLine(permissionMessage);
                    AsynchronousClient client = new AsynchronousClient();
                    client.SetMultiMsg(tempToSend, permissionMessage, myIPPort);
                    Thread t = new Thread(new ThreadStart(client.SendMultiClientChat));
                    t.IsBackground = true;
                    t.Start();

                }
            }
            catch (Exception e)
            { Console.WriteLine(e.ToString()); }
        }
        //public void finalCodeChange(string changes)
        //{
        //    XDocument doc = XDocument.Parse(changes);
        //    var q = from x in doc.Elements().Descendants("Pid") select x;
        //    string Pid = q.ElementAt(0).Value.ToString();
        //    q = from x in doc.Elements().Descendants("delete") select x;
        //    string delno = q.ElementAt(0).Value.ToString();
        //    q = from x in doc.Elements().Descendants("add") select x;
        //    string addno = q.ElementAt(0).Value.ToString();
        //    q = from x in doc.Elements().Descendants("addstring") select x;
        //    string addString = q.ElementAt(0).Value.ToString();
        //    //UIteams function 
        //    //function(Pid,delno,addno,addString);
        //}
        //public void masterCodeChanger(string changes)
        //{
        //    List<string> endPoints = Peers();
        //    XDocument doc = XDocument.Parse(changes);
        //    var q = from x in doc.Elements().Descendants("Pid") select x;
        //    string Pid = q.ElementAt(0).Value.ToString();
        //    q = from x in doc.Elements().Descendants("delete") select x;
        //    string delno = q.ElementAt(0).Value.ToString();
        //    q = from x in doc.Elements().Descendants("add") select x;
        //    string addno = q.ElementAt(0).Value.ToString();
        //    q = from x in doc.Elements().Descendants("addstring") select x;
        //    string addString = q.ElementAt(0).Value.ToString();
        //    //UIteams function 
        //    //function(Pid,delno,addno,addString);
        //    changes = changes.Substring(changes.IndexOf('>') + 1, changes.LastIndexOf('<') - changes.IndexOf('>') - 1);
        //    changes = "<sourcechange>" + changes + "</sourcechange>";
        //    //senderFunction(endPoints,changes);
        //}
        public void getSourceChanges(string[] chng)
        {
            string[] temp = { chng[1],chng[2],chng[3],chng[4]};
            if (srcChanged != null)
                srcChanged(temp);
        }
        public void sourceCodeChanged(string lno, string inputs, string mod, string uname)
        {
            Thread.Sleep(50);
            lock (this)
            {
                if (permissions.Count > 1)
                {
                    string s = inputs.Replace('<', '%');
                    s = s.Replace('>', '@');
                    string codechange = "<SourceChange>" + "<Pid>" + Pid.ToString() + "</Pid>" + "<lno>" + lno.ToString() + "</lno>" + "<s>" + s.ToString() + "</s>" + "<mod>" + mod + "</mod>" + "<uname>" + uname + "</uname>" + "</SourceChange>";
                    AsynchronousSocketListener msocket = conn.getSocket();
                    string myIP = msocket.GetIP();
                    string myPort = msocket.GetPort();

                    List<string> endPoints = Peers();
                    Hashtable temp = conn.GetIPtoPeer();
                    Hashtable tempToSend = new Hashtable();

                    foreach (DictionaryEntry item in temp)
                    {
                        if (endPoints.Contains(item.Key.ToString()))
                        {
                            tempToSend.Add(item.Key, item.Value);
                        }
                    }

                    AsynchronousClient client = new AsynchronousClient();
                    client.SetMultiMsg(tempToSend, codechange, myIP + ":" + myPort);
                    //Thread t = new Thread(new ThreadStart(client.SendMultiClient));
                    try
                    {
                        client.SendMultiClient();
                    }
                    catch (Exception e)
                    { Console.WriteLine(e.ToString()); }
                    
                }
            }
        }
        public bool writePrivilege(string uname)
        {
            string IPPort = "";
            //IPPort = returnIPportFunction(uname);
            string[] _privilege = (string[])permissions[IPPort];
            if (_privilege[1].ToString() == "true")
                return true;
            return false;
        }
        private List<string> Peers()
        {
            List<string> computers = new List<string>();
            foreach (DictionaryEntry comps in permissions)
            {
                //string[] rw = (string[])comps.Value;
                //if (rw[0].ToString() == "true" )
                computers.Add(comps.Key.ToString());
            }
            return computers;
        }
        private string InitialXMLString()
        {            
            string XMLstring = "<Permissions>";
            foreach (DictionaryEntry item in permissions)
            {
                string[] p = (string[])item.Value;
                XMLstring += "<Permit><IPPort>" + item.Key.ToString() + "</IPPort><Read>" + p[0].ToString() +
                    "</Read><Write>" + p[1].ToString() + "</Write></Permit>";
            }
            //XMLstring += "</Permissions><Replies>";
            XMLstring += "</Permissions>";
           
            //foreach (DictionaryEntry item in Reply)
            //{
            //    XMLstring += "<Reply><IPPort>" + item.Key.ToString() + "</IPPort><ReplyValue>" + item.Value.ToString() + "</ReplyValue></Reply>";
            //}
            //XMLstring += "</Replies>";
            return XMLstring.ToString();

        }
        
        public void addPermissionRequest(string myIP, string myPort, string inputcode, string IPPort, string read, string write)
        {
            try
            {
                string myIPPort = myIP + ":" + myPort;
                string code = inputcode.Replace('<', '%');
                code = code.Replace('>', '@');
                //string IPPort = theIP + ":" + thePort;
                if (read == "false")
                { }
                else
                {
                    string[] privileges = { read, write };
                    permissions[IPPort] = privileges;
                    if (permissions.Count > 1)
                    {
                        List<string> endPoints = Peers();
                        Hashtable temp = conn.GetIPtoPeer();
                        Hashtable tempToSend = new Hashtable();

                        foreach (DictionaryEntry item in temp)
                        {
                            if (endPoints.Contains(item.Key.ToString()))
                            {
                                tempToSend.Add(item.Key, item.Value);
                            }
                        }

                        code = "<NewProg>" + "<Code>" + code + "</Code>" + "<Pid>" + Pid + "</Pid>" + "<Owner>" + owner + "</Owner>" + "<IPPort>" + IPPort + "</IPPort>" + "<Read>" + read + "</Read>" + "<Write>" + write + "</Write>";
                        code = code + InitialXMLString().ToString() + "</NewProg>";
                        BuildList();
                        //Console.WriteLine(code); //this line is a part of test1
                        AsynchronousClient client = new AsynchronousClient();
                        client.SetMultiMsg(tempToSend, code, myIPPort);
                        Thread t = new Thread(new ThreadStart(client.SendMultiClient));
                        t.IsBackground = true;
                        t.Start();
                    }

                }
            }
            catch (Exception e)
            { Console.WriteLine(e.ToString()); }
        }
        public void outgoingResult(string index, string result)
        {
            if (!string.IsNullOrEmpty(Master))
            {
                try
                {
                    // if count < number of tasks for this machine, put the result into the table
                    // if count == number of tasks for this machine, build a big message and send it to master
                    int indexNum = Int32.Parse(index);
                    if (TaskIndexList.Contains(indexNum))
                    {
                        if (!ResultCollection.ContainsKey(index))
                        {
                            ResultCollection.Add(index, result);
                            SubResultCollection.Add(index, result);
                            if (SubResultCollection.Count == 1000 || ResultCollection.Count == TaskIndexList.Count)
                            {
                                string[] temp = Master.Split(':');
                                string theIP = temp[0];
                                string thePort = temp[1];
                                if (SubResultCollection.Count == 1000 && ResultCollection.Count != TaskIndexList.Count)
                                {
                                    AsynchronousClient client = new AsynchronousClient();
                                    client.SetSingleMsg(theIP, thePort, createParallelResultMessage(SubResultCollection));
                                    Thread t = new Thread(new ThreadStart(client.SendSingleClient));
                                    t.IsBackground = true;
                                    t.Start();
                                    SubResultCollection.Clear();
                                }
                                if (ResultCollection.Count == TaskIndexList.Count)
                                {
                                    AsynchronousClient client = new AsynchronousClient();
                                    client.SetSingleMsg(theIP, thePort, createParallelResultMessage(SubResultCollection));
                                    Thread t = new Thread(new ThreadStart(client.SendSingleClient));
                                    t.IsBackground = true;
                                    t.Start();
                                    Thread.Sleep(100);
                                    TaskIndexList.Clear();
                                    ResultCollection.Clear();
                                    SubResultCollection.Clear();
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                { Console.WriteLine(e.ToString()); }
            }
             
        }
        //public void PeerGone(string IPPort)
        //{
        //    try
        //    {
        //        List<string> temp = new List<string>();
        //        foreach (DictionaryEntry item in ParallelPortions)
        //        {
        //            if (item.Value.ToString() == IPPort)
        //            {
        //                temp.Add(item.Key.ToString());
        //            }
        //        }
        //        if (temp.Count > 0)
        //        {
        //            int nextStatement = 0;
        //            int numberofStatements = temp.Count;
        //            int numberofComputers = permissions.Count;
        //            int StatementPerComputer;
        //            if ((numberofStatements % numberofComputers) == 0)
        //                StatementPerComputer = (int)(numberofStatements / numberofComputers);
        //            else
        //                StatementPerComputer = (int)(numberofStatements / numberofComputers + 1);
        //            //split the codes
        //            foreach (DictionaryEntry Permitted in permissions)
        //            {
        //                for (int i = 0; i < StatementPerComputer; i++)
        //                {
        //                    ParallelPortions[temp[nextStatement]] = Permitted.Key.ToString();
        //                    if (nextStatement >= temp.Count)
        //                        break;
        //                    else
        //                        nextStatement++;
        //                }
        //                if (nextStatement >= temp.Count)
        //                    break;
        //            }
        //            foreach (DictionaryEntry item in ParallelPortions)
        //            {
        //                if (temp.Contains(item.Key.ToString()))
        //                {
        //                    string theIP = item.Value.ToString();
        //                    theIP = theIP.Substring(0, theIP.IndexOf(':'));
        //                    string thePort = item.Value.ToString();
        //                    thePort = thePort.Substring(thePort.IndexOf(':') + 1);
        //                    AsynchronousClient client = new AsynchronousClient();
        //                    client.SetSingleMsg(theIP, thePort, createParallelDistributionMessage(item.Key.ToString()));
        //                    Thread t = new Thread(new ThreadStart(client.SendSingleClient));
        //                    t.IsBackground = true;
        //                    t.Start();

        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    { Console.WriteLine(e.ToString()); }

        //}

        // new function for using large message
        public void PeerGone(string IPPort)
        {
            try
            {
                List<string> temp = new List<string>();
                foreach (DictionaryEntry item in ParallelPortions)
                {
                    if (item.Value.ToString() == IPPort)
                    {
                        temp.Add(item.Key.ToString());
                    }
                }
                if (temp.Count > 0)
                {
                    // first get the portion that is not finished
                    string IndexRange = temp[0];
                    string startIndex = IndexRange.Substring(0, IndexRange.IndexOf(':'));
                    string endIndex = IndexRange.Substring(IndexRange.IndexOf(':') + 1);
                    int startNumber = Int32.Parse(startIndex);
                    int endNumber = Int32.Parse(endIndex);

                    int numberofStatements = endNumber - startNumber + 1;
                    int numberofComputers = permissions.Count;

                    List<int> lhs = new List<int>();
                    List<int> rhs = new List<int>();
                    int numberOfTasks = splitIndex(startNumber, endNumber, numberofComputers, out lhs, out rhs);
                    Console.WriteLine("(PeerGone)Tasks are re-splitted as follows:");
                    for (int i = 0; i < lhs.Count; ++i)
                    {
                        Console.WriteLine(lhs[i].ToString() + " " + rhs[i].ToString());
                    }

                    Hashtable rescheduleParallelPortions = new Hashtable();
                    ParallelPortions.Remove(IndexRange);

                    try
                    {
                        int count = 0;
                        foreach (DictionaryEntry Permitted in permissions)
                        {
                            if (count < numberOfTasks)
                            {
                                string key = lhs[count].ToString() + ":" + rhs[count].ToString();
                                rescheduleParallelPortions.Add(key, Permitted.Key.ToString());
                                ParallelPortions.Add(key, Permitted.Key.ToString());
                                ++count;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show(e.Message, "first for.");
                    }

                    //int nextStatement = 0;
                    //int numberofStatements = temp.Count;
                    //int numberofComputers = permissions.Count;
                    //int StatementPerComputer;
                    //if ((numberofStatements % numberofComputers) == 0)
                    //    StatementPerComputer = (int)(numberofStatements / numberofComputers);
                    //else
                    //    StatementPerComputer = (int)(numberofStatements / numberofComputers + 1);
                    ////split the codes
                    //foreach (DictionaryEntry Permitted in permissions)
                    //{
                    //    for (int i = 0; i < StatementPerComputer; i++)
                    //    {
                    //        ParallelPortions[temp[nextStatement]] = Permitted.Key.ToString();
                    //        if (nextStatement >= temp.Count)
                    //            break;
                    //        else
                    //            nextStatement++;
                    //    }
                    //    if (nextStatement >= temp.Count)
                    //        break;
                    //}
                    foreach (DictionaryEntry item in rescheduleParallelPortions)
                    {
                        //if (temp.Contains(item.Key.ToString()))
                        {
                            string theIP = item.Value.ToString();
                            theIP = theIP.Substring(0, theIP.IndexOf(':'));
                            string thePort = item.Value.ToString();
                            thePort = thePort.Substring(thePort.IndexOf(':') + 1);

                            string tmpIndexRange = item.Key.ToString();
                            string tmpStartIndex = tmpIndexRange.Substring(0, tmpIndexRange.IndexOf(':'));
                            string tmpEndIndex = tmpIndexRange.Substring(tmpIndexRange.IndexOf(':') + 1);

                            AsynchronousClient client = new AsynchronousClient();
                            client.SetSingleMsg(theIP, thePort, createParallelDistributionMessage(tmpStartIndex, tmpEndIndex));
                            Thread t = new Thread(new ThreadStart(client.SendSingleClient));
                            t.IsBackground = true;
                            t.Start();

                        }
                    }
                }
            }
            catch (Exception e)
            { Console.WriteLine(e.ToString()); }

        }
        public void incomingResult(string result, string index)
        {
            lock (this)
            {
                if (!ParallelResults.ContainsKey(index))
                {
                    ParallelResults[index] = result;

                    if (ParallelResults.Count == numberOfIterations)
                    {
                        List<string> parresult = new List<string>();
                        foreach (DictionaryEntry res in ParallelResults)
                        {
                            parresult.Add(res.Value.ToString());
                        }
                        if (parallelresult_ != null)
                            parallelresult_(parresult);
                        ParallelResults.Clear();
                        ParallelPortions.Clear();
                    }
                }
            }
        }
        //==================distribute
     
        private string createParallelResultMessage(string index, string result)
        {
            string xml = "<PrallelResult>";
            xml += "<Pid>" + Pid + "</Pid>";
            xml += "<Index>" + index + "</Index>";            
            xml += "<Result>" + result + "</Result>";
            xml += "</PrallelResult>";
            return xml;
        }
        private string createParallelResultMessage(Hashtable subresult)
        {
            StringBuilder sb = new StringBuilder("<ResultSet>");
            sb.Append("<Numbers>").Append(subresult.Count.ToString()).Append("</Numbers>");
            foreach (DictionaryEntry item in subresult)
            {
                sb.Append("<PrallelResult>");
                sb.Append("<Pid>").Append(Pid.ToString()).Append("</Pid>");
                sb.Append("<Index>").Append(item.Key.ToString()).Append("</Index>");
                sb.Append("<Result>").Append(item.Value.ToString()).Append("</Result>");
                sb.Append("</PrallelResult>");
            }
            sb.Append("</ResultSet>");
            //Console.WriteLine("The Big Result: " + sb.ToString());
            return sb.ToString(); ;
        }
        private string createParallelDistributionMessage(string index)
        {  
            
            string xml = "<Prallel>";
            xml += "<Pid>" + Pid + "</Pid>";
            xml += "<IPPort>" + conn.getSocket().GetIP() + ":" + conn.getSocket().GetPort() + "</IPPort>";
            xml += "<Index>" + index + "</Index>";            
            xml += "<Data>" + ParallelForData + "</Data>";
            xml += "<Body>" + ParallelForBody + "</Body>";
            xml += "<Range>" + rng + "</Range>";
            xml += "</Prallel>";
            return xml;
        }
        private string createParallelDistributionMessage(string start, string end)
        {
            StringBuilder sb = new StringBuilder("<PrallelSet>");
            sb.Append("<lower>");
            sb.Append(start);
            sb.Append("</lower>");
            sb.Append("<upper>");
            sb.Append(end);
            sb.Append("</upper>");
            sb.Append("<Prallel>");
            sb.Append("<Pid>" + Pid + "</Pid>");
            sb.Append("<IPPort>" + conn.getSocket().GetIP() + ":" + conn.getSocket().GetPort() + "</IPPort>");
            //xml += "<Index>" + index + "</Index>";
            sb.Append("<Data>" + ParallelForData + "</Data>");
            sb.Append("<Body>" + ParallelForBody + "</Body>");
            sb.Append("<Range>" + rng + "</Range>");
            sb.Append("</Prallel>");
            sb.Append("</PrallelSet>");
            Console.WriteLine("New Big Message is : " + sb.ToString());
            return sb.ToString();
        }
        public void acceptParallelfor(string data, string body, string index, string range)
        {
            if (parallelcore_ != null)
                parallelcore_(body, data, int.Parse(index), int.Parse(index),range);
 
        }
        //private string createMatrixDistributionMessage(string row)
        //{
        //    string xml = "<ParallelMatrix>";
        //    xml += "<Pid>" + Pid + "</Pid>";
        //    xml += "<Row>" + row + "</Row>";
        //    xml += "<Data>" + MatrixData + "</Data>";
        //    xml += "<Body>" + MatrixBody + "</Body>";
        //    xml += "</ParallelMatrix>";
        //    return xml;
        //}

        //public void distributeParallelCode(int start, int end, string data, string body, string range)
        //{
        //    try
        //    {
        //        rng = range;
        //        ParallelPortions = new Hashtable();
        //        ParallelResults = new Hashtable();
        //        ParallelForBody = body;
        //        ParallelForBody = ParallelForBody.Replace('<', '%');
        //        ParallelForBody = ParallelForBody.Replace('>', '@');
        //        ParallelForData = data;


        //        int numberofStatements = end - start + 1;
        //        int numberofComputers = permissions.Count;
        //        int StatementPerComputer;
        //        if ((numberofStatements % numberofComputers) == 0)
        //            StatementPerComputer = (int)(numberofStatements / numberofComputers);
        //        else
        //            StatementPerComputer = (int)(numberofStatements / numberofComputers + 1);
        //        //split the codes
        //        try
        //        {
        //            foreach (DictionaryEntry Permitted in permissions)
        //            {
        //                for (int i = 0; i < StatementPerComputer; i++)
        //                {
        //                    ParallelPortions[start.ToString()] = Permitted.Key.ToString();
        //                    if (start > end)
        //                        break;
        //                    else
        //                        start++;
        //                }
        //                if (start > end)
        //                    break;
        //            }
        //        }
        //        catch (Exception e)
        //        { System.Windows.Forms.MessageBox.Show(e.Message, "first for."); }
        //        //List<string> calculationComputers = new List<string>();           
        //        //int totalCPU = 0;
        //        //foreach (DictionaryEntry allPeers in IPtoCPU)
        //        //{
        //        //    foreach (DictionaryEntry permitted in permissions)
        //        //    {
        //        //        if (allPeers.Key.ToString() == permitted.Key.ToString())
        //        //        {                        
        //        //            //this should be a struct
        //        //            totalCPU = totalCPU + int.Parse(allPeers.Value.ToString());
        //        //            calculationComputers.Add(permitted.Key.ToString());
        //        //        }
        //        //    }
        //        //}
        //        ////=======================================================
        //        //int LinePerCPU = (int)(numberofStatements / totalCPU + 1);

        //        //for (int k = 0; k < calculationComputers.Count; k++)
        //        //{
        //        //    int numberofCPU = (int)IPtoCPU[calculationComputers[k].ToString()];
        //        //    for (int a = 0; a < numberofCPU * LinePerCPU; a++)
        //        //    {
        //        //        ParallelPortions[start] = calculationComputers[k].ToString();
        //        //        start++;
        //        //        if (start > end)
        //        //        {
        //        //            break;
        //        //        }
        //        //    }
        //        //    if (start > end)
        //        //    {
        //        //        break;
        //        //    }
        //        //}
        //        //=======================================================
        //        //send the codes
        //        try
        //        {
        //            List<string> allIP = new List<string>();
        //            List<string> allPort = new List<string>();
        //            List<string> allKey = new List<string>();
        //            foreach (DictionaryEntry item in ParallelPortions)
        //            {
        //                allIP.Add(item.Value.ToString().Substring(0, item.Value.ToString().IndexOf(':')));
        //                allPort.Add(item.Value.ToString().Substring(item.Value.ToString().IndexOf(':') + 1));
        //                allKey.Add(item.Key.ToString());
        //            }
        //            //foreach (DictionaryEntry item in ParallelPortions)
        //            //{
        //            //    string theIP = item.Value.ToString();
        //            //    theIP = theIP.Substring(0, theIP.IndexOf(':'));
        //            //    string thePort = item.Value.ToString();
        //            //    thePort = thePort.Substring(thePort.IndexOf(':') + 1);
        //            //    AsynchronousClient client = new AsynchronousClient();
        //            //    client.SetSingleMsg(theIP, thePort, createParallelDistributionMessage(item.Key.ToString()));
        //            //    Thread t = new Thread(new ThreadStart(client.SendSingleClient));
        //            //    t.IsBackground = true;
        //            //    t.Start();
        //            //    Thread.Sleep(5);
        //            //}
        //            for (int i = 0; i < allKey.Count; i++)
        //            {
        //                AsynchronousClient client = new AsynchronousClient();
        //                client.SetSingleMsg(allIP[i], allPort[i], createParallelDistributionMessage(allKey[i]));
        //                Thread t = new Thread(new ThreadStart(client.SendSingleClient));
        //                t.IsBackground = true;
        //                t.Start();
        //                Thread.Sleep(5);
        //            }
        //        }
        //        catch (Exception e)
        //        { System.Windows.Forms.MessageBox.Show(e.Message, "seconde for."); }

        //    }
        //    catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.Message, "distributeParallelCode."); }
        //} 

        public int splitIndex(int start, int end, int number, out List<int> lhs, out List<int> rhs)
        {
            if (start < end)
            {
                Console.WriteLine("Incorrect start and end.");
            }
            int range = end - start + 1;
            int quotient = range / number;
            int residue = range % number;
            lhs = new List<int>();
            rhs = new List<int>();
            if (number == 1)
            {
                lhs.Add(start);
                rhs.Add(end);
                return lhs.Count;
            }

            if (residue == 0)
            {
                for (int i = 0; i < number; ++i)
                {
                    lhs.Add(start + quotient * i);
                    rhs.Add(start + quotient * (i + 1) - 1);
                }
            }
            else
            {
                int local_start = 0;
                int local_end = 0;
                for (int i = 0; i < residue; ++i)
                {
                    lhs.Add(local_start);
                    local_end = local_start + quotient;
                    rhs.Add(local_end);
                    local_start = local_end + 1;
                }
                for (int i = residue; i < number; i++)
                {
                    lhs.Add(local_start);
                    local_end = local_start + quotient - 1;
                    rhs.Add(local_end);
                    local_start = local_end + 1;
                }
            }

            return lhs.Count;
        }

        public void distributeParallelCode(int start, int end, string data, string body, string range)
        {
            try
            {
                rng = range;
                ParallelPortions = new Hashtable();
                ParallelResults = new Hashtable();
                ParallelForBody = body;
                ParallelForBody = ParallelForBody.Replace('<', '%');
                ParallelForBody = ParallelForBody.Replace('>', '@');
                ParallelForData = data;


                int numberofStatements = end - start + 1;
                numberOfIterations = numberofStatements;
                int numberofComputers = permissions.Count;

                List<int> lhs = new List<int>();
                List<int> rhs = new List<int>();
                int numberOfTasks = splitIndex(start, end, numberofComputers, out lhs, out rhs);
                Console.WriteLine("Tasks are splitted as follows:");
                for (int i = 0; i < lhs.Count; ++i)
                {
                    Console.WriteLine(lhs[i].ToString() + " " + rhs[i].ToString());
                }
                try
                {
                    int count = 0;
                    foreach (DictionaryEntry Permitted in permissions)
                    {
                        if (count < numberOfTasks)
                        {
                            string key = lhs[count].ToString() + ":" + rhs[count].ToString();
                            ParallelPortions.Add(key, Permitted.Key.ToString());
                            ++count;
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message, "first for.");
                }
                //int StatementPerComputer;
                //if ((numberofStatements % numberofComputers) == 0)
                //    StatementPerComputer = (int)(numberofStatements / numberofComputers);
                //else
                //    StatementPerComputer = (int)(numberofStatements / numberofComputers + 1);
                ////split the codes
                //try
                //{
                //    foreach (DictionaryEntry Permitted in permissions)
                //    {
                //        for (int i = 0; i < StatementPerComputer; i++)
                //        {
                //            ParallelPortions[start.ToString()] = Permitted.Key.ToString();
                //            if (start > end)
                //                break;
                //            else
                //                start++;
                //        }
                //        if (start > end)
                //            break;
                //    }
                //}
                //catch (Exception e)
                //{ System.Windows.Forms.MessageBox.Show(e.Message, "first for."); }


                //List<string> calculationComputers = new List<string>();           
                //int totalCPU = 0;
                //foreach (DictionaryEntry allPeers in IPtoCPU)
                //{
                //    foreach (DictionaryEntry permitted in permissions)
                //    {
                //        if (allPeers.Key.ToString() == permitted.Key.ToString())
                //        {                        
                //            //this should be a struct
                //            totalCPU = totalCPU + int.Parse(allPeers.Value.ToString());
                //            calculationComputers.Add(permitted.Key.ToString());
                //        }
                //    }
                //}
                ////=======================================================
                //int LinePerCPU = (int)(numberofStatements / totalCPU + 1);

                //for (int k = 0; k < calculationComputers.Count; k++)
                //{
                //    int numberofCPU = (int)IPtoCPU[calculationComputers[k].ToString()];
                //    for (int a = 0; a < numberofCPU * LinePerCPU; a++)
                //    {
                //        ParallelPortions[start] = calculationComputers[k].ToString();
                //        start++;
                //        if (start > end)
                //        {
                //            break;
                //        }
                //    }
                //    if (start > end)
                //    {
                //        break;
                //    }
                //}
                //=======================================================
                //send the codes
                try
                {
                    List<string> allIP = new List<string>();
                    List<string> allPort = new List<string>();
                    List<string> allKey = new List<string>();
                    foreach (DictionaryEntry item in ParallelPortions)
                    {
                        allIP.Add(item.Value.ToString().Substring(0, item.Value.ToString().IndexOf(':')));
                        allPort.Add(item.Value.ToString().Substring(item.Value.ToString().IndexOf(':') + 1));
                        allKey.Add(item.Key.ToString());
                    }
                    //foreach (DictionaryEntry item in ParallelPortions)
                    //{
                    //    string theIP = item.Value.ToString();
                    //    theIP = theIP.Substring(0, theIP.IndexOf(':'));
                    //    string thePort = item.Value.ToString();
                    //    thePort = thePort.Substring(thePort.IndexOf(':') + 1);
                    //    AsynchronousClient client = new AsynchronousClient();
                    //    client.SetSingleMsg(theIP, thePort, createParallelDistributionMessage(item.Key.ToString()));
                    //    Thread t = new Thread(new ThreadStart(client.SendSingleClient));
                    //    t.IsBackground = true;
                    //    t.Start();
                    //    Thread.Sleep(5);
                    //}
                    for (int i = 0; i < lhs.Count; i++)
                    {
                        AsynchronousClient client = new AsynchronousClient();
                        client.SetSingleMsg(allIP[i], allPort[i], createParallelDistributionMessage(lhs[i].ToString(), rhs[i].ToString()));
                        Thread t = new Thread(new ThreadStart(client.SendSingleClient));
                        t.IsBackground = true;
                        t.Start();
                        Thread.Sleep(5);
                    }
                }
                catch (Exception e)
                { System.Windows.Forms.MessageBox.Show(e.Message, "seconde for."); }

            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.Message, "distributeParallelCode."); }
        }
  
        //public void distributeMatrix(string body, string data, int rows)
        //{
        //    MatrixBody = body;
        //    MatrixData = data;
        //    MatrixPortions = new Hashtable();
        //    MatrixResults = new Hashtable();
        //    MatrixBody = MatrixBody.Replace('<', '%');
        //    MatrixBody = MatrixBody.Replace('>', '@');
        //    int curr_row = 1;
        //    int numberofComputers = permissions.Count;
        //    int StatementPerComputer;
        //    if ((rows % numberofComputers) == 0)
        //        StatementPerComputer = (int)(rows / numberofComputers);
        //    else
        //        StatementPerComputer = (int)(rows / numberofComputers + 1);
        //    foreach (DictionaryEntry Permitted in permissions)
        //    {
        //        for (int i = 0; i < StatementPerComputer; i++)
        //        {
        //            MatrixPortions[curr_row.ToString()] = Permitted.Key.ToString();
        //            if (curr_row > rows)
        //                break;
        //            else
        //                curr_row++;
        //        }
        //        if (curr_row > rows)
        //            break;
        //    }
        //    foreach (DictionaryEntry item in MatrixPortions)
        //    {
        //        string theIP = item.Value.ToString();
        //        theIP = theIP.Substring(0, theIP.IndexOf(':'));
        //        string thePort = item.Value.ToString();
        //        thePort = thePort.Substring(thePort.IndexOf(':') + 1);
        //        AsynchronousClient client = new AsynchronousClient();
        //        client.SetSingleMsg(theIP, thePort,createMatrixDistributionMessage(item.Key.ToString()));
        //        Thread t = new Thread(new ThreadStart(client.SendSingleClient));
        //        t.IsBackground = true;
        //        t.Start();
        //        Thread.Sleep(5);
        //    }
        //}

    }
    
}
