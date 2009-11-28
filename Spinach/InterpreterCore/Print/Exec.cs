﻿////////////////////////////////////////////////////////////////////////
// Exec.cs: demonstrates the interpreter for the Spinach language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Srinivasan Sundararajan (ssunda04@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

#define TEST_EXEC

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spinach
{
    public class executor
    {
        public Core coreObject;
        public exec frontEnd;
        public delegate void err(int code, string message);
        public event err errEvent;
        public delegate void result(string message);
        public event result resEvent;
        public void Onerror(int code, string message)
        {
            if (errEvent != null)
                errEvent(code, message);
        }
        public executor(PlotReceiver plot)
        {
            coreObject = new Core(plot);
            frontEnd = new exec();
            frontEnd.error_ +=new exec.errorreport(Onerror);
            frontEnd.astEvent += new Spinach.exec.ast(AST);
            coreObject.errorcore_ +=new Core.errorcoremsg(Onerror);
            coreObject.rescore_ += new Core.resultcore(coreObject_rescore_);
        }

        
        void coreObject_rescore_(string coremsg)
        {
            if (resEvent != null)
                resEvent(coremsg);
        }

        public void VisitLine(string args)
        {
            List<string> keywords = new List<string>();
            keywords = frontEnd.getKeywords();
            //frontEnd.error_ += new Spinach.exec.errorreport(Onerror);
            
            
            frontEnd.Visitline(args);
        }
        public void AST(List<Element> elements)
        {
            coreObject.clearVarMap();
            coreObject.setAST(elements);
        }
    }
}



#if TEST_EXEC



namespace Spinach
{
    public class UI
    {
        public static void Main(string[] args)
        {
            PlotReceiver plot = new PlotReceiver();
            Core obj = new Core(plot);
            executor obj1 = new executor(plot);
            obj1.errEvent += new executor.err(error);
            obj1.VisitLine("ubPlot(1,a,\"abc\",1D);vec[i]=i + 2;mat[i][j] = i + 2;");
        }
        public static void error(int code, string message)
        {
            Console.Write(code + " " + message);
        }
    }
}
#endif