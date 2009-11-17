////////////////////////////////////////////////////////////////////////
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
        private Core coreObject;
        public Program MyProg;
        public delegate void err(int code, string message);
        public event err errEvent;
        public void Onerror(int code, string message)
        {
            if (errEvent != null)
                errEvent(code, message);
        }
        public executor()
        {
            coreObject = new Core();
            Antlr.Runtime.CommonTokenStream str = new Antlr.Runtime.CommonTokenStream();
            MyProg = new Program(str);
        }
        public void VisitLine(string args)
        {
            List<string> keywords = new List<string>();
            keywords = MyProg.getKeywords();
            MyProg.error += new Spinach.Program.errorreport(Onerror);
            MyProg.AstEvent += new Spinach.Program.AstReport(AST);
            MyProg.VisitLine(args);
        }
        public void AST(List<Element> elements)
        {
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
            Core obj = new Core();
            executor obj1 = new executor();
            obj1.errEvent += new executor.err(error);
            obj1.VisitLine("for(i->0to10){int a; double b; b = 1.1*(2.1*3.2);}struct s{}; struct sasda{int a; double b;};parallelfor(i->0to10){for(i->0to10){int a; double b;Matrix<int>[2][3] bv= []; b = 1.1*(2.1*3.2);}if(s.a!=0){int a;Vector<double>[4] vec= [1,2,3,4];}}");
        }
        public static void error(int code, string message)
        {
            Console.Write(code + " " + message);
        }
    }
}
#endif