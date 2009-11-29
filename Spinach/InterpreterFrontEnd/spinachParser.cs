// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 spinach.g 2009-11-26 05:23:59


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public class spinachParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"VARIABLE", 
		"INT_LITERAL", 
		"DOUBLE_LITERAL", 
		"VARTYPE", 
		"ASSIGNMENT", 
		"END_OF_STATEMENT", 
		"STRINGTYPE", 
		"LEFTBRACE", 
		"POINT", 
		"RIGHTBRACE", 
		"LEFTPARANTHESIS", 
		"RIGHTPARANTHESIS", 
		"SCALEMODE", 
		"PLUS", 
		"MULTIPLY", 
		"PERCENT", 
		"DOT", 
		"WHITESPACE", 
		"EQUALITYEXPRESSION", 
		"NONEQUALITYEXPRESSION", 
		"LESSTHANEXPRESSION", 
		"LESSTHANEQUALTOEXPRESSION", 
		"GREATERTHANEXPRESSION", 
		"GREATERTHANEQUALTOEXPRESSION", 
		"'matrix'", 
		"'['", 
		"']'", 
		"','", 
		"'vector'", 
		"'-'", 
		"'struct'", 
		"'delete'", 
		"'print'", 
		"'parallelfor'", 
		"'to'", 
		"'SYNC'", 
		"'if'", 
		"'else'", 
		"'for'", 
		"'void'", 
		"'DOT'", 
		"'T'", 
		"'return'", 
		"'subPlot'", 
		"'1D'", 
		"'2D'", 
		"'3D'", 
		"'plot'", 
		"'resetPlot'", 
		"'setPlotAxis'", 
		"'setAxisTitle'", 
		"'setScaleMode('", 
		"'//'", 
		"'setScaleMode'", 
		"'\"'", 
		"'&'", 
		"':'", 
		"'^'", 
		"'$'", 
		"'#'", 
		"'@'", 
		"'!'", 
		"'?'", 
		"'/'"
    };

    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__29 = 29;
    public const int T__64 = 64;
    public const int T__28 = 28;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int POINT = 12;
    public const int EQUALITYEXPRESSION = 22;
    public const int DOUBLE_LITERAL = 6;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int NONEQUALITYEXPRESSION = 23;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int LEFTBRACE = 11;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int LESSTHANEQUALTOEXPRESSION = 25;
    public const int T__54 = 54;
    public const int MULTIPLY = 18;
    public const int T__59 = 59;
    public const int PLUS = 17;
    public const int RIGHTBRACE = 13;
    public const int LESSTHANEXPRESSION = 24;
    public const int DOT = 20;
    public const int T__50 = 50;
    public const int END_OF_STATEMENT = 9;
    public const int RIGHTPARANTHESIS = 15;
    public const int GREATERTHANEQUALTOEXPRESSION = 27;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int SCALEMODE = 16;
    public const int T__40 = 40;
    public const int INT_LITERAL = 5;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int PERCENT = 19;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int WHITESPACE = 21;
    public const int GREATERTHANEXPRESSION = 26;
    public const int VARTYPE = 7;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int VARIABLE = 4;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRINGTYPE = 10;
    public const int LEFTPARANTHESIS = 14;
    public const int ASSIGNMENT = 8;

    // delegates
    // delegators



        public spinachParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public spinachParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return spinachParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "spinach.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        public List<Element> ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // spinach.g:24:1: program returns [List<Element> ret] : ( ( expr | comment )+ EOF ) ;
    public spinachParser.program_return program() // throws RecognitionException [1]
    {   
        spinachParser.program_return retval = new spinachParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF3 = null;
        spinachParser.expr_return expr1 = null;

        spinachParser.comment_return comment2 = null;


        object EOF3_tree=null;


          retval.ret = new List<Element>();

        try 
    	{
            // spinach.g:28:3: ( ( ( expr | comment )+ EOF ) )
            // spinach.g:28:5: ( ( expr | comment )+ EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:28:5: ( ( expr | comment )+ EOF )
            	// spinach.g:28:6: ( expr | comment )+ EOF
            	{
            		// spinach.g:28:6: ( expr | comment )+
            		int cnt1 = 0;
            		do 
            		{
            		    int alt1 = 3;
            		    int LA1_0 = input.LA(1);

            		    if ( (LA1_0 == VARIABLE || LA1_0 == VARTYPE || LA1_0 == STRINGTYPE || LA1_0 == 28 || LA1_0 == 32 || (LA1_0 >= 34 && LA1_0 <= 37) || LA1_0 == 40 || (LA1_0 >= 42 && LA1_0 <= 43) || LA1_0 == 47 || (LA1_0 >= 51 && LA1_0 <= 55)) )
            		    {
            		        alt1 = 1;
            		    }
            		    else if ( (LA1_0 == 56) )
            		    {
            		        alt1 = 2;
            		    }


            		    switch (alt1) 
            			{
            				case 1 :
            				    // spinach.g:28:7: expr
            				    {
            				    	PushFollow(FOLLOW_expr_in_program70);
            				    	expr1 = expr();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, expr1.Tree);
            				    	retval.ret.Add(((expr1 != null) ? expr1.ret : null)); 

            				    }
            				    break;
            				case 2 :
            				    // spinach.g:28:44: comment
            				    {
            				    	PushFollow(FOLLOW_comment_in_program76);
            				    	comment2 = comment();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, comment2.Tree);
            				    	retval.ret.Add(((comment2 != null) ? comment2.ret : null));

            				    }
            				    break;

            				default:
            				    if ( cnt1 >= 1 ) goto loop1;
            			            EarlyExitException eee1 =
            			                new EarlyExitException(1, input);
            			            throw eee1;
            		    }
            		    cnt1++;
            		} while (true);

            		loop1:
            			;	// Stops C# compiler whining that label 'loop1' has no statements

            		EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_program82); 
            			EOF3_tree = (object)adaptor.Create(EOF3);
            			adaptor.AddChild(root_0, EOF3_tree);


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class expr_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // spinach.g:32:1: expr returns [Element ret] : ( expr1 | parallelfor | structdec | functiondefination );
    public spinachParser.expr_return expr() // throws RecognitionException [1]
    {   
        spinachParser.expr_return retval = new spinachParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr14 = null;

        spinachParser.parallelfor_return parallelfor5 = null;

        spinachParser.structdec_return structdec6 = null;

        spinachParser.functiondefination_return functiondefination7 = null;



        try 
    	{
            // spinach.g:33:3: ( expr1 | parallelfor | structdec | functiondefination )
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            case STRINGTYPE:
            case 28:
            case 32:
            case 35:
            case 36:
            case 40:
            case 42:
            case 47:
            case 51:
            case 52:
            case 53:
            case 54:
            case 55:
            	{
                alt2 = 1;
                }
                break;
            case VARTYPE:
            	{
                int LA2_2 = input.LA(2);

                if ( (LA2_2 == VARIABLE) )
                {
                    int LA2_6 = input.LA(3);

                    if ( (LA2_6 == END_OF_STATEMENT) )
                    {
                        alt2 = 1;
                    }
                    else if ( (LA2_6 == LEFTBRACE) )
                    {
                        alt2 = 4;
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s6 =
                            new NoViableAltException("", 2, 6, input);

                        throw nvae_d2s6;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d2s2 =
                        new NoViableAltException("", 2, 2, input);

                    throw nvae_d2s2;
                }
                }
                break;
            case 37:
            	{
                alt2 = 2;
                }
                break;
            case 34:
            	{
                alt2 = 3;
                }
                break;
            case 43:
            	{
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // spinach.g:33:4: expr1
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr1_in_expr105);
                    	expr14 = expr1();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr14.Tree);
                    	retval.ret = ((expr14 != null) ? expr14.ret : null);

                    }
                    break;
                case 2 :
                    // spinach.g:33:37: parallelfor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallelfor_in_expr109);
                    	parallelfor5 = parallelfor();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, parallelfor5.Tree);
                    	retval.ret = ((parallelfor5 != null) ? parallelfor5.ret : null);

                    }
                    break;
                case 3 :
                    // spinach.g:33:82: structdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structdec_in_expr113);
                    	structdec6 = structdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structdec6.Tree);
                    	retval.ret = ((structdec6 != null) ? structdec6.ret : null);

                    }
                    break;
                case 4 :
                    // spinach.g:34:8: functiondefination
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functiondefination_in_expr124);
                    	functiondefination7 = functiondefination();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functiondefination7.Tree);
                    	retval.ret = ((functiondefination7 != null) ? functiondefination7.ret : null);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class expr1_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr1"
    // spinach.g:37:1: expr1 returns [Element ret] : ( forexpr | print );
    public spinachParser.expr1_return expr1() // throws RecognitionException [1]
    {   
        spinachParser.expr1_return retval = new spinachParser.expr1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.forexpr_return forexpr8 = null;

        spinachParser.print_return print9 = null;



        try 
    	{
            // spinach.g:38:4: ( forexpr | print )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == VARIABLE || LA3_0 == VARTYPE || LA3_0 == STRINGTYPE || LA3_0 == 28 || LA3_0 == 32 || LA3_0 == 35 || LA3_0 == 40 || LA3_0 == 42 || LA3_0 == 47 || (LA3_0 >= 51 && LA3_0 <= 55)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 36) )
            {
                alt3 = 2;
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // spinach.g:38:5: forexpr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forexpr_in_expr1140);
                    	forexpr8 = forexpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, forexpr8.Tree);
                    	retval.ret = ((forexpr8 != null) ? forexpr8.ret : null);

                    }
                    break;
                case 2 :
                    // spinach.g:39:10: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr1152);
                    	print9 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print9.Tree);
                    	 retval.ret = ((print9 != null) ? print9.ret : null); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr1"

    public class forexpr_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forexpr"
    // spinach.g:43:1: forexpr returns [Element ret] : ( expr2 | matrixvardec | plotfunctions | functioncall | vectorvardec );
    public spinachParser.forexpr_return forexpr() // throws RecognitionException [1]
    {   
        spinachParser.forexpr_return retval = new spinachParser.forexpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr2_return expr210 = null;

        spinachParser.matrixvardec_return matrixvardec11 = null;

        spinachParser.plotfunctions_return plotfunctions12 = null;

        spinachParser.functioncall_return functioncall13 = null;

        spinachParser.vectorvardec_return vectorvardec14 = null;



        try 
    	{
            // spinach.g:44:1: ( expr2 | matrixvardec | plotfunctions | functioncall | vectorvardec )
            int alt4 = 5;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                int LA4_1 = input.LA(2);

                if ( (LA4_1 == VARIABLE || LA4_1 == ASSIGNMENT || LA4_1 == DOT || LA4_1 == 29) )
                {
                    alt4 = 1;
                }
                else if ( (LA4_1 == LEFTBRACE) )
                {
                    alt4 = 4;
                }
                else 
                {
                    NoViableAltException nvae_d4s1 =
                        new NoViableAltException("", 4, 1, input);

                    throw nvae_d4s1;
                }
                }
                break;
            case VARTYPE:
            case STRINGTYPE:
            case 35:
            case 40:
            case 42:
            	{
                alt4 = 1;
                }
                break;
            case 28:
            	{
                alt4 = 2;
                }
                break;
            case 47:
            case 51:
            case 52:
            case 53:
            case 54:
            case 55:
            	{
                alt4 = 3;
                }
                break;
            case 32:
            	{
                alt4 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            }

            switch (alt4) 
            {
                case 1 :
                    // spinach.g:45:7: expr2
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr2_in_forexpr185);
                    	expr210 = expr2();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr210.Tree);
                    	retval.ret = ((expr210 != null) ? expr210.ret : null);

                    }
                    break;
                case 2 :
                    // spinach.g:46:7: matrixvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixvardec_in_forexpr194);
                    	matrixvardec11 = matrixvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matrixvardec11.Tree);
                    	 retval.ret = ((matrixvardec11 != null) ? matrixvardec11.ret : null);

                    }
                    break;
                case 3 :
                    // spinach.g:47:7: plotfunctions
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_plotfunctions_in_forexpr204);
                    	plotfunctions12 = plotfunctions();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, plotfunctions12.Tree);
                    	retval.ret = ((plotfunctions12 != null) ? plotfunctions12.ret : null);

                    }
                    break;
                case 4 :
                    // spinach.g:48:7: functioncall
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functioncall_in_forexpr213);
                    	functioncall13 = functioncall();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functioncall13.Tree);
                    	retval.ret=((functioncall13 != null) ? functioncall13.ret : null);

                    }
                    break;
                case 5 :
                    // spinach.g:49:7: vectorvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_vectorvardec_in_forexpr222);
                    	vectorvardec14 = vectorvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, vectorvardec14.Tree);
                    	 retval.ret = ((vectorvardec14 != null) ? vectorvardec14.ret : null);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forexpr"

    public class expr2_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr2"
    // spinach.g:52:1: expr2 returns [Element ret] : (el1= assignment | el4= ifelse | el5= forstatement | e12= scalarvardec | e13= deletionofvar | structobjdec ) ;
    public spinachParser.expr2_return expr2() // throws RecognitionException [1]
    {   
        spinachParser.expr2_return retval = new spinachParser.expr2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.assignment_return el1 = null;

        spinachParser.ifelse_return el4 = null;

        spinachParser.forstatement_return el5 = null;

        spinachParser.scalarvardec_return e12 = null;

        spinachParser.deletionofvar_return e13 = null;

        spinachParser.structobjdec_return structobjdec15 = null;



        try 
    	{
            // spinach.g:53:1: ( (el1= assignment | el4= ifelse | el5= forstatement | e12= scalarvardec | e13= deletionofvar | structobjdec ) )
            // spinach.g:53:4: (el1= assignment | el4= ifelse | el5= forstatement | e12= scalarvardec | e13= deletionofvar | structobjdec )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:53:4: (el1= assignment | el4= ifelse | el5= forstatement | e12= scalarvardec | e13= deletionofvar | structobjdec )
            	int alt5 = 6;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    int LA5_1 = input.LA(2);

            	    if ( (LA5_1 == ASSIGNMENT || LA5_1 == DOT || LA5_1 == 29) )
            	    {
            	        alt5 = 1;
            	    }
            	    else if ( (LA5_1 == VARIABLE) )
            	    {
            	        alt5 = 6;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d5s1 =
            	            new NoViableAltException("", 5, 1, input);

            	        throw nvae_d5s1;
            	    }
            	    }
            	    break;
            	case 40:
            		{
            	    alt5 = 2;
            	    }
            	    break;
            	case 42:
            		{
            	    alt5 = 3;
            	    }
            	    break;
            	case VARTYPE:
            	case STRINGTYPE:
            		{
            	    alt5 = 4;
            	    }
            	    break;
            	case 35:
            		{
            	    alt5 = 5;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d5s0 =
            		        new NoViableAltException("", 5, 0, input);

            		    throw nvae_d5s0;
            	}

            	switch (alt5) 
            	{
            	    case 1 :
            	        // spinach.g:53:5: el1= assignment
            	        {
            	        	PushFollow(FOLLOW_assignment_in_expr2242);
            	        	el1 = assignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret = ((el1 != null) ? el1.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:54:5: el4= ifelse
            	        {
            	        	PushFollow(FOLLOW_ifelse_in_expr2252);
            	        	el4 = ifelse();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	retval.ret = ((el4 != null) ? el4.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:55:5: el5= forstatement
            	        {
            	        	PushFollow(FOLLOW_forstatement_in_expr2262);
            	        	el5 = forstatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el5.Tree);
            	        	retval.ret = ((el5 != null) ? el5.ret : null);

            	        }
            	        break;
            	    case 4 :
            	        // spinach.g:57:5: e12= scalarvardec
            	        {
            	        	PushFollow(FOLLOW_scalarvardec_in_expr2274);
            	        	e12 = scalarvardec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e12.Tree);
            	        	 retval.ret = ((e12 != null) ? e12.ret : null);

            	        }
            	        break;
            	    case 5 :
            	        // spinach.g:58:5: e13= deletionofvar
            	        {
            	        	PushFollow(FOLLOW_deletionofvar_in_expr2286);
            	        	e13 = deletionofvar();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e13.Tree);
            	        	retval.ret = ((e13 != null) ? e13.ret : null);

            	        }
            	        break;
            	    case 6 :
            	        // spinach.g:59:5: structobjdec
            	        {
            	        	PushFollow(FOLLOW_structobjdec_in_expr2293);
            	        	structobjdec15 = structobjdec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structobjdec15.Tree);
            	        	 retval.ret = ((structobjdec15 != null) ? structobjdec15.ret : null);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr2"

    public class var_int_or_double_literal_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "var_int_or_double_literal"
    // spinach.g:63:1: var_int_or_double_literal returns [Element ret] : ( int_literal | double_literal | varorstruct ) ;
    public spinachParser.var_int_or_double_literal_return var_int_or_double_literal() // throws RecognitionException [1]
    {   
        spinachParser.var_int_or_double_literal_return retval = new spinachParser.var_int_or_double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.int_literal_return int_literal16 = null;

        spinachParser.double_literal_return double_literal17 = null;

        spinachParser.varorstruct_return varorstruct18 = null;



        try 
    	{
            // spinach.g:64:3: ( ( int_literal | double_literal | varorstruct ) )
            // spinach.g:64:7: ( int_literal | double_literal | varorstruct )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:64:7: ( int_literal | double_literal | varorstruct )
            	int alt6 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case INT_LITERAL:
            		{
            	    alt6 = 1;
            	    }
            	    break;
            	case DOUBLE_LITERAL:
            		{
            	    alt6 = 2;
            	    }
            	    break;
            	case VARIABLE:
            		{
            	    alt6 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d6s0 =
            		        new NoViableAltException("", 6, 0, input);

            		    throw nvae_d6s0;
            	}

            	switch (alt6) 
            	{
            	    case 1 :
            	        // spinach.g:64:8: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_int_or_double_literal318);
            	        	int_literal16 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal16.Tree);
            	        	retval.ret = ((int_literal16 != null) ? int_literal16.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:65:7: double_literal
            	        {
            	        	PushFollow(FOLLOW_double_literal_in_var_int_or_double_literal328);
            	        	double_literal17 = double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, double_literal17.Tree);
            	        	retval.ret = ((double_literal17 != null) ? double_literal17.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:66:5: varorstruct
            	        {
            	        	PushFollow(FOLLOW_varorstruct_in_var_int_or_double_literal336);
            	        	varorstruct18 = varorstruct();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, varorstruct18.Tree);
            	        	retval.ret = ((varorstruct18 != null) ? varorstruct18.ret : null);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "var_int_or_double_literal"

    public class varorstruct_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "varorstruct"
    // spinach.g:68:1: varorstruct returns [Element ret] : ( variable | matrixelem | vectorelem | structassign ) ;
    public spinachParser.varorstruct_return varorstruct() // throws RecognitionException [1]
    {   
        spinachParser.varorstruct_return retval = new spinachParser.varorstruct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.variable_return variable19 = null;

        spinachParser.matrixelem_return matrixelem20 = null;

        spinachParser.vectorelem_return vectorelem21 = null;

        spinachParser.structassign_return structassign22 = null;



        try 
    	{
            // spinach.g:69:1: ( ( variable | matrixelem | vectorelem | structassign ) )
            // spinach.g:69:3: ( variable | matrixelem | vectorelem | structassign )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:69:3: ( variable | matrixelem | vectorelem | structassign )
            	int alt7 = 4;
            	alt7 = dfa7.Predict(input);
            	switch (alt7) 
            	{
            	    case 1 :
            	        // spinach.g:69:4: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_varorstruct351);
            	        	variable19 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable19.Tree);
            	        	retval.ret = ((variable19 != null) ? variable19.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:70:2: matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_varorstruct355);
            	        	matrixelem20 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixelem20.Tree);
            	        	retval.ret=((matrixelem20 != null) ? matrixelem20.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:71:2: vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_varorstruct359);
            	        	vectorelem21 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorelem21.Tree);
            	        	retval.ret=((vectorelem21 != null) ? vectorelem21.ret : null);

            	        }
            	        break;
            	    case 4 :
            	        // spinach.g:72:2: structassign
            	        {
            	        	PushFollow(FOLLOW_structassign_in_varorstruct365);
            	        	structassign22 = structassign();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structassign22.Tree);
            	        	retval.ret = ((structassign22 != null) ? structassign22.ret : null);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "varorstruct"

    public class variable_return : ParserRuleReturnScope
    {
        public VariableElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variable"
    // spinach.g:75:1: variable returns [VariableElement ret] : VARIABLE ;
    public spinachParser.variable_return variable() // throws RecognitionException [1]
    {   
        spinachParser.variable_return retval = new spinachParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE23 = null;

        object VARIABLE23_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // spinach.g:79:3: ( VARIABLE )
            // spinach.g:79:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE23=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable387); 
            		VARIABLE23_tree = (object)adaptor.Create(VARIABLE23);
            		adaptor.AddChild(root_0, VARIABLE23_tree);

            	 retval.ret.setText(((VARIABLE23 != null) ? VARIABLE23.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class int_literal_return : ParserRuleReturnScope
    {
        public IntegerElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "int_literal"
    // spinach.g:81:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public spinachParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        spinachParser.int_literal_return retval = new spinachParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL24 = null;

        object INT_LITERAL24_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // spinach.g:85:3: ( INT_LITERAL )
            // spinach.g:85:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL24=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal408); 
            		INT_LITERAL24_tree = (object)adaptor.Create(INT_LITERAL24);
            		adaptor.AddChild(root_0, INT_LITERAL24_tree);

            	 retval.ret.setText(((INT_LITERAL24 != null) ? INT_LITERAL24.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_literal"

    public class double_literal_return : ParserRuleReturnScope
    {
        public DoubleElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "double_literal"
    // spinach.g:87:1: double_literal returns [DoubleElement ret] : el1= DOUBLE_LITERAL ;
    public spinachParser.double_literal_return double_literal() // throws RecognitionException [1]
    {   
        spinachParser.double_literal_return retval = new spinachParser.double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;

        object el1_tree=null;


        	retval.ret = new DoubleElement();
        	
        try 
    	{
            // spinach.g:91:2: (el1= DOUBLE_LITERAL )
            // spinach.g:91:4: el1= DOUBLE_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_double_literal430); 
            		el1_tree = (object)adaptor.Create(el1);
            		adaptor.AddChild(root_0, el1_tree);

            	retval.ret.setText(((el1 != null) ? el1.Text : null));

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "double_literal"

    public class matrixvardec_return : ParserRuleReturnScope
    {
        public MatrixVariableDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixvardec"
    // spinach.g:95:1: matrixvardec returns [MatrixVariableDeclaration ret] : ( 'matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) ) END_OF_STATEMENT ;
    public spinachParser.matrixvardec_return matrixvardec() // throws RecognitionException [1]
    {   
        spinachParser.matrixvardec_return retval = new spinachParser.matrixvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el0 = null;
        IToken string_literal25 = null;
        IToken char_literal26 = null;
        IToken char_literal27 = null;
        IToken char_literal28 = null;
        IToken char_literal29 = null;
        IToken char_literal30 = null;
        IToken char_literal31 = null;
        IToken ASSIGNMENT32 = null;
        IToken char_literal33 = null;
        IToken char_literal34 = null;
        IToken char_literal35 = null;
        IToken char_literal36 = null;
        IToken char_literal37 = null;
        IToken char_literal38 = null;
        IToken char_literal39 = null;
        IToken char_literal40 = null;
        IToken END_OF_STATEMENT41 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;

        spinachParser.int_literal_return el7 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object el0_tree=null;
        object string_literal25_tree=null;
        object char_literal26_tree=null;
        object char_literal27_tree=null;
        object char_literal28_tree=null;
        object char_literal29_tree=null;
        object char_literal30_tree=null;
        object char_literal31_tree=null;
        object ASSIGNMENT32_tree=null;
        object char_literal33_tree=null;
        object char_literal34_tree=null;
        object char_literal35_tree=null;
        object char_literal36_tree=null;
        object char_literal37_tree=null;
        object char_literal38_tree=null;
        object char_literal39_tree=null;
        object char_literal40_tree=null;
        object END_OF_STATEMENT41_tree=null;


        	retval.ret = new MatrixVariableDeclaration();
        	
        try 
    	{
            // spinach.g:99:2: ( ( 'matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) ) END_OF_STATEMENT )
            // spinach.g:99:3: ( 'matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:99:3: ( 'matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) )
            	// spinach.g:99:4: 'matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) )
            	{
            		string_literal25=(IToken)Match(input,28,FOLLOW_28_in_matrixvardec452); 
            			string_literal25_tree = (object)adaptor.Create(string_literal25);
            			adaptor.AddChild(root_0, string_literal25_tree);

            		char_literal26=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixvardec454); 
            			char_literal26_tree = (object)adaptor.Create(char_literal26);
            			adaptor.AddChild(root_0, char_literal26_tree);

            		// spinach.g:100:2: (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) )
            		// spinach.g:100:3: el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' )
            		{
            			el0=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixvardec461); 
            				el0_tree = (object)adaptor.Create(el0);
            				adaptor.AddChild(root_0, el0_tree);

            			 retval.ret.setType(((el0 != null) ? el0.Text : null));
            			char_literal27=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec463); 
            				char_literal27_tree = (object)adaptor.Create(char_literal27);
            				adaptor.AddChild(root_0, char_literal27_tree);

            			char_literal28=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec465); 
            				char_literal28_tree = (object)adaptor.Create(char_literal28);
            				adaptor.AddChild(root_0, char_literal28_tree);

            			PushFollow(FOLLOW_int_literal_in_matrixvardec468);
            			el1 = int_literal();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el1.Tree);
            			 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            			char_literal29=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec471); 
            				char_literal29_tree = (object)adaptor.Create(char_literal29);
            				adaptor.AddChild(root_0, char_literal29_tree);

            			char_literal30=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec474); 
            				char_literal30_tree = (object)adaptor.Create(char_literal30);
            				adaptor.AddChild(root_0, char_literal30_tree);

            			PushFollow(FOLLOW_int_literal_in_matrixvardec478);
            			el2 = int_literal();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el2.Tree);
            			 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            			char_literal31=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec481); 
            				char_literal31_tree = (object)adaptor.Create(char_literal31);
            				adaptor.AddChild(root_0, char_literal31_tree);

            			// spinach.g:102:3: (el3= variable )
            			// spinach.g:102:4: el3= variable
            			{
            				PushFollow(FOLLOW_variable_in_matrixvardec489);
            				el3 = variable();
            				state.followingStackPointer--;

            				adaptor.AddChild(root_0, el3.Tree);
            				 retval.ret.setVar(((el3 != null) ? el3.ret : null));

            			}

            			ASSIGNMENT32=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matrixvardec496); 
            				ASSIGNMENT32_tree = (object)adaptor.Create(ASSIGNMENT32);
            				adaptor.AddChild(root_0, ASSIGNMENT32_tree);

            			// spinach.g:104:3: ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' )
            			int alt10 = 3;
            			int LA10_0 = input.LA(1);

            			if ( (LA10_0 == 29) )
            			{
            			    switch ( input.LA(2) ) 
            			    {
            			    case 30:
            			    	{
            			        alt10 = 1;
            			        }
            			        break;
            			    case DOUBLE_LITERAL:
            			    	{
            			        alt10 = 3;
            			        }
            			        break;
            			    case INT_LITERAL:
            			    	{
            			        alt10 = 2;
            			        }
            			        break;
            			    	default:
            			    	    NoViableAltException nvae_d10s1 =
            			    	        new NoViableAltException("", 10, 1, input);

            			    	    throw nvae_d10s1;
            			    }

            			}
            			else 
            			{
            			    NoViableAltException nvae_d10s0 =
            			        new NoViableAltException("", 10, 0, input);

            			    throw nvae_d10s0;
            			}
            			switch (alt10) 
            			{
            			    case 1 :
            			        // spinach.g:104:4: ( '[' ']' )
            			        {
            			        	// spinach.g:104:4: ( '[' ']' )
            			        	// spinach.g:104:5: '[' ']'
            			        	{
            			        		char_literal33=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec502); 
            			        			char_literal33_tree = (object)adaptor.Create(char_literal33);
            			        			adaptor.AddChild(root_0, char_literal33_tree);

            			        		char_literal34=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec503); 
            			        			char_literal34_tree = (object)adaptor.Create(char_literal34);
            			        			adaptor.AddChild(root_0, char_literal34_tree);


            			        	}


            			        }
            			        break;
            			    case 2 :
            			        // spinach.g:105:3: ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' )
            			        {
            			        	// spinach.g:105:3: ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' )
            			        	// spinach.g:105:4: '[' (el7= int_literal ( ',' el5= int_literal )* ) ']'
            			        	{
            			        		char_literal35=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec510); 
            			        			char_literal35_tree = (object)adaptor.Create(char_literal35);
            			        			adaptor.AddChild(root_0, char_literal35_tree);

            			        		// spinach.g:105:7: (el7= int_literal ( ',' el5= int_literal )* )
            			        		// spinach.g:105:8: el7= int_literal ( ',' el5= int_literal )*
            			        		{
            			        			PushFollow(FOLLOW_int_literal_in_matrixvardec514);
            			        			el7 = int_literal();
            			        			state.followingStackPointer--;

            			        			adaptor.AddChild(root_0, el7.Tree);
            			        			retval.ret.addValue(((el7 != null) ? el7.ret : null));
            			        			// spinach.g:105:57: ( ',' el5= int_literal )*
            			        			do 
            			        			{
            			        			    int alt8 = 2;
            			        			    int LA8_0 = input.LA(1);

            			        			    if ( (LA8_0 == 31) )
            			        			    {
            			        			        alt8 = 1;
            			        			    }


            			        			    switch (alt8) 
            			        				{
            			        					case 1 :
            			        					    // spinach.g:105:58: ',' el5= int_literal
            			        					    {
            			        					    	char_literal36=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec519); 
            			        					    		char_literal36_tree = (object)adaptor.Create(char_literal36);
            			        					    		adaptor.AddChild(root_0, char_literal36_tree);

            			        					    	PushFollow(FOLLOW_int_literal_in_matrixvardec522);
            			        					    	el5 = int_literal();
            			        					    	state.followingStackPointer--;

            			        					    	adaptor.AddChild(root_0, el5.Tree);
            			        					    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            			        					    }
            			        					    break;

            			        					default:
            			        					    goto loop8;
            			        			    }
            			        			} while (true);

            			        			loop8:
            			        				;	// Stops C# compiler whining that label 'loop8' has no statements


            			        		}

            			        		char_literal37=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec528); 
            			        			char_literal37_tree = (object)adaptor.Create(char_literal37);
            			        			adaptor.AddChild(root_0, char_literal37_tree);


            			        	}


            			        }
            			        break;
            			    case 3 :
            			        // spinach.g:106:4: ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']'
            			        {
            			        	// spinach.g:106:4: ( '[' el4= double_literal ( ',' el6= double_literal )* )
            			        	// spinach.g:106:5: '[' el4= double_literal ( ',' el6= double_literal )*
            			        	{
            			        		char_literal38=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec535); 
            			        			char_literal38_tree = (object)adaptor.Create(char_literal38);
            			        			adaptor.AddChild(root_0, char_literal38_tree);

            			        		PushFollow(FOLLOW_double_literal_in_matrixvardec538);
            			        		el4 = double_literal();
            			        		state.followingStackPointer--;

            			        		adaptor.AddChild(root_0, el4.Tree);
            			        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            			        		// spinach.g:106:59: ( ',' el6= double_literal )*
            			        		do 
            			        		{
            			        		    int alt9 = 2;
            			        		    int LA9_0 = input.LA(1);

            			        		    if ( (LA9_0 == 31) )
            			        		    {
            			        		        alt9 = 1;
            			        		    }


            			        		    switch (alt9) 
            			        			{
            			        				case 1 :
            			        				    // spinach.g:106:60: ',' el6= double_literal
            			        				    {
            			        				    	char_literal39=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec542); 
            			        				    		char_literal39_tree = (object)adaptor.Create(char_literal39);
            			        				    		adaptor.AddChild(root_0, char_literal39_tree);

            			        				    	PushFollow(FOLLOW_double_literal_in_matrixvardec545);
            			        				    	el6 = double_literal();
            			        				    	state.followingStackPointer--;

            			        				    	adaptor.AddChild(root_0, el6.Tree);
            			        				    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

            			        				    }
            			        				    break;

            			        				default:
            			        				    goto loop9;
            			        		    }
            			        		} while (true);

            			        		loop9:
            			        			;	// Stops C# compiler whining that label 'loop9' has no statements


            			        	}

            			        	char_literal40=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec551); 
            			        		char_literal40_tree = (object)adaptor.Create(char_literal40);
            			        		adaptor.AddChild(root_0, char_literal40_tree);


            			        }
            			        break;

            			}


            		}

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT41=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matrixvardec562); 
            		END_OF_STATEMENT41_tree = (object)adaptor.Create(END_OF_STATEMENT41);
            		adaptor.AddChild(root_0, END_OF_STATEMENT41_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matrixvardec"

    public class vectorvardec_return : ParserRuleReturnScope
    {
        public VectorVariableDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "vectorvardec"
    // spinach.g:110:1: vectorvardec returns [VectorVariableDeclaration ret] : ( 'vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) END_OF_STATEMENT ;
    public spinachParser.vectorvardec_return vectorvardec() // throws RecognitionException [1]
    {   
        spinachParser.vectorvardec_return retval = new spinachParser.vectorvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal42 = null;
        IToken char_literal43 = null;
        IToken VARTYPE44 = null;
        IToken char_literal45 = null;
        IToken char_literal46 = null;
        IToken char_literal47 = null;
        IToken ASSIGNMENT48 = null;
        IToken char_literal49 = null;
        IToken char_literal50 = null;
        IToken char_literal51 = null;
        IToken char_literal52 = null;
        IToken char_literal53 = null;
        IToken char_literal54 = null;
        IToken char_literal55 = null;
        IToken char_literal56 = null;
        IToken END_OF_STATEMENT57 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.variable_return el2 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal42_tree=null;
        object char_literal43_tree=null;
        object VARTYPE44_tree=null;
        object char_literal45_tree=null;
        object char_literal46_tree=null;
        object char_literal47_tree=null;
        object ASSIGNMENT48_tree=null;
        object char_literal49_tree=null;
        object char_literal50_tree=null;
        object char_literal51_tree=null;
        object char_literal52_tree=null;
        object char_literal53_tree=null;
        object char_literal54_tree=null;
        object char_literal55_tree=null;
        object char_literal56_tree=null;
        object END_OF_STATEMENT57_tree=null;


        	retval.ret = new VectorVariableDeclaration();
        	
        try 
    	{
            // spinach.g:114:2: ( ( 'vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) END_OF_STATEMENT )
            // spinach.g:114:3: ( 'vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:114:3: ( 'vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) )
            	// spinach.g:114:4: 'vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' )
            	{
            		string_literal42=(IToken)Match(input,32,FOLLOW_32_in_vectorvardec580); 
            			string_literal42_tree = (object)adaptor.Create(string_literal42);
            			adaptor.AddChild(root_0, string_literal42_tree);

            		char_literal43=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorvardec582); 
            			char_literal43_tree = (object)adaptor.Create(char_literal43);
            			adaptor.AddChild(root_0, char_literal43_tree);

            		VARTYPE44=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorvardec584); 
            			VARTYPE44_tree = (object)adaptor.Create(VARTYPE44);
            			adaptor.AddChild(root_0, VARTYPE44_tree);

            		 retval.ret.setType(((VARTYPE44 != null) ? VARTYPE44.Text : null));
            		char_literal45=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec587); 
            			char_literal45_tree = (object)adaptor.Create(char_literal45);
            			adaptor.AddChild(root_0, char_literal45_tree);

            		char_literal46=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec589); 
            			char_literal46_tree = (object)adaptor.Create(char_literal46);
            			adaptor.AddChild(root_0, char_literal46_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorvardec592);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setRange(((el1 != null) ? el1.ret : null));
            		char_literal47=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec595); 
            			char_literal47_tree = (object)adaptor.Create(char_literal47);
            			adaptor.AddChild(root_0, char_literal47_tree);

            		PushFollow(FOLLOW_variable_in_vectorvardec601);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setText(((el2 != null) ? el2.ret : null));
            		ASSIGNMENT48=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_vectorvardec608); 
            			ASSIGNMENT48_tree = (object)adaptor.Create(ASSIGNMENT48);
            			adaptor.AddChild(root_0, ASSIGNMENT48_tree);

            		// spinach.g:117:3: ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' )
            		int alt13 = 3;
            		int LA13_0 = input.LA(1);

            		if ( (LA13_0 == 29) )
            		{
            		    switch ( input.LA(2) ) 
            		    {
            		    case 30:
            		    	{
            		        alt13 = 1;
            		        }
            		        break;
            		    case DOUBLE_LITERAL:
            		    	{
            		        alt13 = 3;
            		        }
            		        break;
            		    case INT_LITERAL:
            		    	{
            		        alt13 = 2;
            		        }
            		        break;
            		    	default:
            		    	    NoViableAltException nvae_d13s1 =
            		    	        new NoViableAltException("", 13, 1, input);

            		    	    throw nvae_d13s1;
            		    }

            		}
            		else 
            		{
            		    NoViableAltException nvae_d13s0 =
            		        new NoViableAltException("", 13, 0, input);

            		    throw nvae_d13s0;
            		}
            		switch (alt13) 
            		{
            		    case 1 :
            		        // spinach.g:117:4: ( '[' ']' )
            		        {
            		        	// spinach.g:117:4: ( '[' ']' )
            		        	// spinach.g:117:5: '[' ']'
            		        	{
            		        		char_literal49=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec615); 
            		        			char_literal49_tree = (object)adaptor.Create(char_literal49);
            		        			adaptor.AddChild(root_0, char_literal49_tree);

            		        		char_literal50=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec616); 
            		        			char_literal50_tree = (object)adaptor.Create(char_literal50);
            		        			adaptor.AddChild(root_0, char_literal50_tree);


            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:118:3: ( '[' el3= int_literal ( ',' el5= int_literal )* ']' )
            		        {
            		        	// spinach.g:118:3: ( '[' el3= int_literal ( ',' el5= int_literal )* ']' )
            		        	// spinach.g:118:4: '[' el3= int_literal ( ',' el5= int_literal )* ']'
            		        	{
            		        		char_literal51=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec623); 
            		        			char_literal51_tree = (object)adaptor.Create(char_literal51);
            		        			adaptor.AddChild(root_0, char_literal51_tree);

            		        		PushFollow(FOLLOW_int_literal_in_vectorvardec626);
            		        		el3 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el3.Tree);
            		        		retval.ret.addValue(((el3 != null) ? el3.ret : null));
            		        		// spinach.g:118:56: ( ',' el5= int_literal )*
            		        		do 
            		        		{
            		        		    int alt11 = 2;
            		        		    int LA11_0 = input.LA(1);

            		        		    if ( (LA11_0 == 31) )
            		        		    {
            		        		        alt11 = 1;
            		        		    }


            		        		    switch (alt11) 
            		        			{
            		        				case 1 :
            		        				    // spinach.g:118:57: ',' el5= int_literal
            		        				    {
            		        				    	char_literal52=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec631); 
            		        				    		char_literal52_tree = (object)adaptor.Create(char_literal52);
            		        				    		adaptor.AddChild(root_0, char_literal52_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_vectorvardec634);
            		        				    	el5 = int_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el5.Tree);
            		        				    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop11;
            		        		    }
            		        		} while (true);

            		        		loop11:
            		        			;	// Stops C# compiler whining that label 'loop11' has no statements

            		        		char_literal53=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec639); 
            		        			char_literal53_tree = (object)adaptor.Create(char_literal53);
            		        			adaptor.AddChild(root_0, char_literal53_tree);


            		        	}


            		        }
            		        break;
            		    case 3 :
            		        // spinach.g:119:3: ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']'
            		        {
            		        	// spinach.g:119:3: ( '[' el4= double_literal ( ',' el6= double_literal )* )
            		        	// spinach.g:119:4: '[' el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		char_literal54=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec646); 
            		        			char_literal54_tree = (object)adaptor.Create(char_literal54);
            		        			adaptor.AddChild(root_0, char_literal54_tree);

            		        		PushFollow(FOLLOW_double_literal_in_vectorvardec649);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// spinach.g:120:3: ( ',' el6= double_literal )*
            		        		do 
            		        		{
            		        		    int alt12 = 2;
            		        		    int LA12_0 = input.LA(1);

            		        		    if ( (LA12_0 == 31) )
            		        		    {
            		        		        alt12 = 1;
            		        		    }


            		        		    switch (alt12) 
            		        			{
            		        				case 1 :
            		        				    // spinach.g:120:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal55=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec656); 
            		        				    		char_literal55_tree = (object)adaptor.Create(char_literal55);
            		        				    		adaptor.AddChild(root_0, char_literal55_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_vectorvardec659);
            		        				    	el6 = double_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el6.Tree);
            		        				    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop12;
            		        		    }
            		        		} while (true);

            		        		loop12:
            		        			;	// Stops C# compiler whining that label 'loop12' has no statements


            		        	}

            		        	char_literal56=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec665); 
            		        		char_literal56_tree = (object)adaptor.Create(char_literal56);
            		        		adaptor.AddChild(root_0, char_literal56_tree);


            		        }
            		        break;

            		}

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT57=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_vectorvardec672); 
            		END_OF_STATEMENT57_tree = (object)adaptor.Create(END_OF_STATEMENT57);
            		adaptor.AddChild(root_0, END_OF_STATEMENT57_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "vectorvardec"

    public class matrixelem_return : ParserRuleReturnScope
    {
        public MatrixElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixelem"
    // spinach.g:123:1: matrixelem returns [MatrixElement ret] : (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' ) ;
    public spinachParser.matrixelem_return matrixelem() // throws RecognitionException [1]
    {   
        spinachParser.matrixelem_return retval = new spinachParser.matrixelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal58 = null;
        IToken char_literal59 = null;
        IToken char_literal60 = null;
        IToken char_literal61 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el4 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.variable_return el5 = null;


        object char_literal58_tree=null;
        object char_literal59_tree=null;
        object char_literal60_tree=null;
        object char_literal61_tree=null;


         retval.ret = new MatrixElement();
         
        try 
    	{
            // spinach.g:127:2: ( (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' ) )
            // spinach.g:127:3: (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:127:3: (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' )
            	// spinach.g:127:4: el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']'
            	{
            		PushFollow(FOLLOW_variable_in_matrixelem692);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal58=(IToken)Match(input,29,FOLLOW_29_in_matrixelem698); 
            			char_literal58_tree = (object)adaptor.Create(char_literal58);
            			adaptor.AddChild(root_0, char_literal58_tree);

            		// spinach.g:128:6: (el2= int_literal | el4= variable )
            		int alt14 = 2;
            		int LA14_0 = input.LA(1);

            		if ( (LA14_0 == INT_LITERAL) )
            		{
            		    alt14 = 1;
            		}
            		else if ( (LA14_0 == VARIABLE) )
            		{
            		    alt14 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d14s0 =
            		        new NoViableAltException("", 14, 0, input);

            		    throw nvae_d14s0;
            		}
            		switch (alt14) 
            		{
            		    case 1 :
            		        // spinach.g:128:7: el2= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_matrixelem702);
            		        	el2 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el2.Tree);
            		        	retval.ret.setRow(((el2 != null) ? el2.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:128:53: el4= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_matrixelem707);
            		        	el4 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el4.Tree);
            		        	retval.ret.setRow(((el4 != null) ? el4.ret : null));

            		        }
            		        break;

            		}

            		char_literal59=(IToken)Match(input,30,FOLLOW_30_in_matrixelem710); 
            			char_literal59_tree = (object)adaptor.Create(char_literal59);
            			adaptor.AddChild(root_0, char_literal59_tree);

            		char_literal60=(IToken)Match(input,29,FOLLOW_29_in_matrixelem713); 
            			char_literal60_tree = (object)adaptor.Create(char_literal60);
            			adaptor.AddChild(root_0, char_literal60_tree);

            		// spinach.g:129:5: (el3= int_literal | el5= variable )
            		int alt15 = 2;
            		int LA15_0 = input.LA(1);

            		if ( (LA15_0 == INT_LITERAL) )
            		{
            		    alt15 = 1;
            		}
            		else if ( (LA15_0 == VARIABLE) )
            		{
            		    alt15 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d15s0 =
            		        new NoViableAltException("", 15, 0, input);

            		    throw nvae_d15s0;
            		}
            		switch (alt15) 
            		{
            		    case 1 :
            		        // spinach.g:129:6: el3= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_matrixelem717);
            		        	el3 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el3.Tree);
            		        	retval.ret.setColumn(((el3 != null) ? el3.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:129:55: el5= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_matrixelem722);
            		        	el5 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el5.Tree);
            		        	retval.ret.setColumn(((el5 != null) ? el5.ret : null));

            		        }
            		        break;

            		}

            		char_literal61=(IToken)Match(input,30,FOLLOW_30_in_matrixelem725); 
            			char_literal61_tree = (object)adaptor.Create(char_literal61);
            			adaptor.AddChild(root_0, char_literal61_tree);


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matrixelem"

    public class vectorelem_return : ParserRuleReturnScope
    {
        public VectorElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "vectorelem"
    // spinach.g:131:1: vectorelem returns [VectorElement ret] : (el1= variable '[' (el2= int_literal | el3= variable ) ']' ) ;
    public spinachParser.vectorelem_return vectorelem() // throws RecognitionException [1]
    {   
        spinachParser.vectorelem_return retval = new spinachParser.vectorelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal62 = null;
        IToken char_literal63 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;


        object char_literal62_tree=null;
        object char_literal63_tree=null;


         retval.ret = new VectorElement();
         
        try 
    	{
            // spinach.g:135:2: ( (el1= variable '[' (el2= int_literal | el3= variable ) ']' ) )
            // spinach.g:135:3: (el1= variable '[' (el2= int_literal | el3= variable ) ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:135:3: (el1= variable '[' (el2= int_literal | el3= variable ) ']' )
            	// spinach.g:135:4: el1= variable '[' (el2= int_literal | el3= variable ) ']'
            	{
            		PushFollow(FOLLOW_variable_in_vectorelem747);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal62=(IToken)Match(input,29,FOLLOW_29_in_vectorelem753); 
            			char_literal62_tree = (object)adaptor.Create(char_literal62);
            			adaptor.AddChild(root_0, char_literal62_tree);

            		// spinach.g:136:6: (el2= int_literal | el3= variable )
            		int alt16 = 2;
            		int LA16_0 = input.LA(1);

            		if ( (LA16_0 == INT_LITERAL) )
            		{
            		    alt16 = 1;
            		}
            		else if ( (LA16_0 == VARIABLE) )
            		{
            		    alt16 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d16s0 =
            		        new NoViableAltException("", 16, 0, input);

            		    throw nvae_d16s0;
            		}
            		switch (alt16) 
            		{
            		    case 1 :
            		        // spinach.g:136:7: el2= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_vectorelem757);
            		        	el2 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el2.Tree);
            		        	retval.ret.setRange(((el2 != null) ? el2.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:136:56: el3= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_vectorelem763);
            		        	el3 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el3.Tree);
            		        	retval.ret.setRange(((el3 != null) ? el3.ret : null));

            		        }
            		        break;

            		}

            		char_literal63=(IToken)Match(input,30,FOLLOW_30_in_vectorelem766); 
            			char_literal63_tree = (object)adaptor.Create(char_literal63);
            			adaptor.AddChild(root_0, char_literal63_tree);


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "vectorelem"

    public class assignment_return : ParserRuleReturnScope
    {
        public AssignmentOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // spinach.g:138:1: assignment returns [AssignmentOperationElement ret] : ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) ) ;
    public spinachParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        spinachParser.assignment_return retval = new spinachParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT66 = null;
        IToken END_OF_STATEMENT71 = null;
        spinachParser.vectorelem_return e12 = null;

        spinachParser.matrixelem_return e11 = null;

        spinachParser.variable_return variable64 = null;

        spinachParser.structassign_return structassign65 = null;

        spinachParser.subtractive_exp_return subtractive_exp67 = null;

        spinachParser.dotproduct_return dotproduct68 = null;

        spinachParser.matrixtranspose_return matrixtranspose69 = null;

        spinachParser.string_literal_return string_literal70 = null;

        spinachParser.functioncall_return functioncall72 = null;


        object ASSIGNMENT66_tree=null;
        object END_OF_STATEMENT71_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // spinach.g:142:3: ( ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) ) )
            // spinach.g:142:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:142:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) )
            	// spinach.g:142:6: ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall )
            	{
            		// spinach.g:142:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )
            		int alt17 = 4;
            		alt17 = dfa17.Predict(input);
            		switch (alt17) 
            		{
            		    case 1 :
            		        // spinach.g:142:7: variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_assignment789);
            		        	variable64 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, variable64.Tree);
            		        	retval.ret.setLhs(((variable64 != null) ? variable64.ret : null)); 

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:143:7: structassign
            		        {
            		        	PushFollow(FOLLOW_structassign_in_assignment799);
            		        	structassign65 = structassign();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, structassign65.Tree);
            		        	retval.ret.setLhs(((structassign65 != null) ? structassign65.ret : null));

            		        }
            		        break;
            		    case 3 :
            		        // spinach.g:144:6: e12= vectorelem
            		        {
            		        	PushFollow(FOLLOW_vectorelem_in_assignment811);
            		        	e12 = vectorelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e12.Tree);
            		        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            		        }
            		        break;
            		    case 4 :
            		        // spinach.g:145:7: e11= matrixelem
            		        {
            		        	PushFollow(FOLLOW_matrixelem_in_assignment824);
            		        	e11 = matrixelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e11.Tree);
            		        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		        }
            		        break;

            		}

            		ASSIGNMENT66=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment832); 
            			ASSIGNMENT66_tree = (object)adaptor.Create(ASSIGNMENT66);
            			adaptor.AddChild(root_0, ASSIGNMENT66_tree);

            		// spinach.g:147:5: ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall )
            		int alt19 = 2;
            		int LA19_0 = input.LA(1);

            		if ( ((LA19_0 >= INT_LITERAL && LA19_0 <= DOUBLE_LITERAL) || LA19_0 == LEFTBRACE || LA19_0 == 45 || LA19_0 == 58) )
            		{
            		    alt19 = 1;
            		}
            		else if ( (LA19_0 == VARIABLE) )
            		{
            		    int LA19_2 = input.LA(2);

            		    if ( (LA19_2 == END_OF_STATEMENT || (LA19_2 >= PLUS && LA19_2 <= MULTIPLY) || LA19_2 == DOT || LA19_2 == 29 || LA19_2 == 33 || LA19_2 == 44) )
            		    {
            		        alt19 = 1;
            		    }
            		    else if ( (LA19_2 == LEFTBRACE) )
            		    {
            		        alt19 = 2;
            		    }
            		    else 
            		    {
            		        NoViableAltException nvae_d19s2 =
            		            new NoViableAltException("", 19, 2, input);

            		        throw nvae_d19s2;
            		    }
            		}
            		else 
            		{
            		    NoViableAltException nvae_d19s0 =
            		        new NoViableAltException("", 19, 0, input);

            		    throw nvae_d19s0;
            		}
            		switch (alt19) 
            		{
            		    case 1 :
            		        // spinach.g:147:6: ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT
            		        {
            		        	// spinach.g:147:6: ( subtractive_exp | dotproduct | matrixtranspose | string_literal )
            		        	int alt18 = 4;
            		        	switch ( input.LA(1) ) 
            		        	{
            		        	case INT_LITERAL:
            		        	case DOUBLE_LITERAL:
            		        	case LEFTBRACE:
            		        		{
            		        	    alt18 = 1;
            		        	    }
            		        	    break;
            		        	case VARIABLE:
            		        		{
            		        	    int LA18_2 = input.LA(2);

            		        	    if ( (LA18_2 == END_OF_STATEMENT || (LA18_2 >= PLUS && LA18_2 <= MULTIPLY) || LA18_2 == DOT || LA18_2 == 29 || LA18_2 == 33) )
            		        	    {
            		        	        alt18 = 1;
            		        	    }
            		        	    else if ( (LA18_2 == 44) )
            		        	    {
            		        	        alt18 = 2;
            		        	    }
            		        	    else 
            		        	    {
            		        	        NoViableAltException nvae_d18s2 =
            		        	            new NoViableAltException("", 18, 2, input);

            		        	        throw nvae_d18s2;
            		        	    }
            		        	    }
            		        	    break;
            		        	case 45:
            		        		{
            		        	    alt18 = 3;
            		        	    }
            		        	    break;
            		        	case 58:
            		        		{
            		        	    alt18 = 4;
            		        	    }
            		        	    break;
            		        		default:
            		        		    NoViableAltException nvae_d18s0 =
            		        		        new NoViableAltException("", 18, 0, input);

            		        		    throw nvae_d18s0;
            		        	}

            		        	switch (alt18) 
            		        	{
            		        	    case 1 :
            		        	        // spinach.g:147:8: subtractive_exp
            		        	        {
            		        	        	PushFollow(FOLLOW_subtractive_exp_in_assignment842);
            		        	        	subtractive_exp67 = subtractive_exp();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, subtractive_exp67.Tree);
            		        	        	retval.ret.setRhs(((subtractive_exp67 != null) ? subtractive_exp67.ret : null));

            		        	        }
            		        	        break;
            		        	    case 2 :
            		        	        // spinach.g:147:67: dotproduct
            		        	        {
            		        	        	PushFollow(FOLLOW_dotproduct_in_assignment846);
            		        	        	dotproduct68 = dotproduct();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, dotproduct68.Tree);
            		        	        	retval.ret.setRhs(((dotproduct68 != null) ? dotproduct68.ret : null));

            		        	        }
            		        	        break;
            		        	    case 3 :
            		        	        // spinach.g:148:7: matrixtranspose
            		        	        {
            		        	        	PushFollow(FOLLOW_matrixtranspose_in_assignment855);
            		        	        	matrixtranspose69 = matrixtranspose();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, matrixtranspose69.Tree);
            		        	        	retval.ret.setRhs(((matrixtranspose69 != null) ? matrixtranspose69.ret : null));

            		        	        }
            		        	        break;
            		        	    case 4 :
            		        	        // spinach.g:148:66: string_literal
            		        	        {
            		        	        	PushFollow(FOLLOW_string_literal_in_assignment859);
            		        	        	string_literal70 = string_literal();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, string_literal70.Tree);
            		        	        	retval.ret.setRhs(((string_literal70 != null) ? string_literal70.ret : null));

            		        	        }
            		        	        break;

            		        	}

            		        	END_OF_STATEMENT71=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment867); 
            		        		END_OF_STATEMENT71_tree = (object)adaptor.Create(END_OF_STATEMENT71);
            		        		adaptor.AddChild(root_0, END_OF_STATEMENT71_tree);


            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:150:7: functioncall
            		        {
            		        	PushFollow(FOLLOW_functioncall_in_assignment875);
            		        	functioncall72 = functioncall();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, functioncall72.Tree);
            		        	retval.ret.setRhs(((functioncall72 != null) ? functioncall72.ret : null));

            		        }
            		        break;

            		}


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class additive_expression_return : ParserRuleReturnScope
    {
        public AdditiveElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "additive_expression"
    // spinach.g:153:1: additive_expression returns [AdditiveElement ret] : ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) ;
    public spinachParser.additive_expression_return additive_expression() // throws RecognitionException [1]
    {   
        spinachParser.additive_expression_return retval = new spinachParser.additive_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal73 = null;
        spinachParser.multiplicative_expression_return e11 = null;

        spinachParser.additive_expression_return e12 = null;


        object char_literal73_tree=null;


        	retval.ret = new AdditiveElement();

        try 
    	{
            // spinach.g:157:2: ( ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) )
            // spinach.g:157:4: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:157:4: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            	// spinach.g:157:5: (e11= multiplicative_expression ) ( '+' e12= additive_expression )*
            	{
            		// spinach.g:157:5: (e11= multiplicative_expression )
            		// spinach.g:157:6: e11= multiplicative_expression
            		{
            			PushFollow(FOLLOW_multiplicative_expression_in_additive_expression906);
            			e11 = multiplicative_expression();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, e11.Tree);
            			retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		}

            		// spinach.g:157:69: ( '+' e12= additive_expression )*
            		do 
            		{
            		    int alt20 = 2;
            		    int LA20_0 = input.LA(1);

            		    if ( (LA20_0 == PLUS) )
            		    {
            		        alt20 = 1;
            		    }


            		    switch (alt20) 
            			{
            				case 1 :
            				    // spinach.g:157:70: '+' e12= additive_expression
            				    {
            				    	char_literal73=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_additive_expression911); 
            				    		char_literal73_tree = (object)adaptor.Create(char_literal73);
            				    		adaptor.AddChild(root_0, char_literal73_tree);

            				    	PushFollow(FOLLOW_additive_expression_in_additive_expression917);
            				    	e12 = additive_expression();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop20;
            		    }
            		} while (true);

            		loop20:
            			;	// Stops C# compiler whining that label 'loop20' has no statements


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additive_expression"

    public class multiplicative_expression_return : ParserRuleReturnScope
    {
        public MultiplicationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplicative_expression"
    // spinach.g:160:1: multiplicative_expression returns [MultiplicationElement ret] : (e11= var_int_or_double_literal | e12= bracket_exp ) ( '*' el5= multiplicative_expression )* ;
    public spinachParser.multiplicative_expression_return multiplicative_expression() // throws RecognitionException [1]
    {   
        spinachParser.multiplicative_expression_return retval = new spinachParser.multiplicative_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal74 = null;
        spinachParser.var_int_or_double_literal_return e11 = null;

        spinachParser.bracket_exp_return e12 = null;

        spinachParser.multiplicative_expression_return el5 = null;


        object char_literal74_tree=null;


        	retval.ret = new MultiplicationElement();

        try 
    	{
            // spinach.g:164:2: ( (e11= var_int_or_double_literal | e12= bracket_exp ) ( '*' el5= multiplicative_expression )* )
            // spinach.g:164:4: (e11= var_int_or_double_literal | e12= bracket_exp ) ( '*' el5= multiplicative_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:164:4: (e11= var_int_or_double_literal | e12= bracket_exp )
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( ((LA21_0 >= VARIABLE && LA21_0 <= DOUBLE_LITERAL)) )
            	{
            	    alt21 = 1;
            	}
            	else if ( (LA21_0 == LEFTBRACE) )
            	{
            	    alt21 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // spinach.g:164:5: e11= var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplicative_expression945);
            	        	e11 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e11.Tree);
            	        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:165:7: e12= bracket_exp
            	        {
            	        	PushFollow(FOLLOW_bracket_exp_in_multiplicative_expression957);
            	        	e12 = bracket_exp();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e12.Tree);
            	        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            	        }
            	        break;

            	}

            	// spinach.g:167:5: ( '*' el5= multiplicative_expression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == MULTIPLY) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // spinach.g:167:6: '*' el5= multiplicative_expression
            			    {
            			    	char_literal74=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplicative_expression971); 
            			    		char_literal74_tree = (object)adaptor.Create(char_literal74);
            			    		adaptor.AddChild(root_0, char_literal74_tree);

            			    	PushFollow(FOLLOW_multiplicative_expression_in_multiplicative_expression981);
            			    	el5 = multiplicative_expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, el5.Tree);
            			    	retval.ret.setRhs(el5.ret);

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicative_expression"

    public class bracket_exp_return : ParserRuleReturnScope
    {
        public BracketElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bracket_exp"
    // spinach.g:174:1: bracket_exp returns [BracketElement ret] : '(' subtractive_exp ')' ;
    public spinachParser.bracket_exp_return bracket_exp() // throws RecognitionException [1]
    {   
        spinachParser.bracket_exp_return retval = new spinachParser.bracket_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal75 = null;
        IToken char_literal77 = null;
        spinachParser.subtractive_exp_return subtractive_exp76 = null;


        object char_literal75_tree=null;
        object char_literal77_tree=null;


        	retval.ret = new BracketElement();

        try 
    	{
            // spinach.g:178:1: ( '(' subtractive_exp ')' )
            // spinach.g:178:3: '(' subtractive_exp ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal75=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_bracket_exp1027); 
            		char_literal75_tree = (object)adaptor.Create(char_literal75);
            		adaptor.AddChild(root_0, char_literal75_tree);

            	PushFollow(FOLLOW_subtractive_exp_in_bracket_exp1028);
            	subtractive_exp76 = subtractive_exp();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, subtractive_exp76.Tree);
            	retval.ret.setbracketexpression(((subtractive_exp76 != null) ? subtractive_exp76.ret : null));
            	char_literal77=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_bracket_exp1030); 
            		char_literal77_tree = (object)adaptor.Create(char_literal77);
            		adaptor.AddChild(root_0, char_literal77_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bracket_exp"

    public class subtractive_exp_return : ParserRuleReturnScope
    {
        public SubtractionElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "subtractive_exp"
    // spinach.g:184:1: subtractive_exp returns [SubtractionElement ret] : (e11= additive_expression ( '-' e12= subtractive_exp )* ) ;
    public spinachParser.subtractive_exp_return subtractive_exp() // throws RecognitionException [1]
    {   
        spinachParser.subtractive_exp_return retval = new spinachParser.subtractive_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal78 = null;
        spinachParser.additive_expression_return e11 = null;

        spinachParser.subtractive_exp_return e12 = null;


        object char_literal78_tree=null;


        	retval.ret = new SubtractionElement();

        try 
    	{
            // spinach.g:188:1: ( (e11= additive_expression ( '-' e12= subtractive_exp )* ) )
            // spinach.g:188:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:188:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            	// spinach.g:188:7: e11= additive_expression ( '-' e12= subtractive_exp )*
            	{
            		PushFollow(FOLLOW_additive_expression_in_subtractive_exp1059);
            		e11 = additive_expression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, e11.Tree);
            		retval.ret.setLhs(((e11 != null) ? e11.ret : null));
            		// spinach.g:188:64: ( '-' e12= subtractive_exp )*
            		do 
            		{
            		    int alt23 = 2;
            		    int LA23_0 = input.LA(1);

            		    if ( (LA23_0 == 33) )
            		    {
            		        alt23 = 1;
            		    }


            		    switch (alt23) 
            			{
            				case 1 :
            				    // spinach.g:188:65: '-' e12= subtractive_exp
            				    {
            				    	char_literal78=(IToken)Match(input,33,FOLLOW_33_in_subtractive_exp1064); 
            				    		char_literal78_tree = (object)adaptor.Create(char_literal78);
            				    		adaptor.AddChild(root_0, char_literal78_tree);

            				    	PushFollow(FOLLOW_subtractive_exp_in_subtractive_exp1070);
            				    	e12 = subtractive_exp();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop23;
            		    }
            		} while (true);

            		loop23:
            			;	// Stops C# compiler whining that label 'loop23' has no statements


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subtractive_exp"

    public class structdec_return : ParserRuleReturnScope
    {
        public StructDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structdec"
    // spinach.g:192:1: structdec returns [StructDeclaration ret] : ( 'struct' variable ( '{' ( (el1= scalarvardec | comment )+ )? '}' ) ) END_OF_STATEMENT ;
    public spinachParser.structdec_return structdec() // throws RecognitionException [1]
    {   
        spinachParser.structdec_return retval = new spinachParser.structdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal79 = null;
        IToken char_literal81 = null;
        IToken char_literal83 = null;
        IToken END_OF_STATEMENT84 = null;
        spinachParser.scalarvardec_return el1 = null;

        spinachParser.variable_return variable80 = null;

        spinachParser.comment_return comment82 = null;


        object string_literal79_tree=null;
        object char_literal81_tree=null;
        object char_literal83_tree=null;
        object END_OF_STATEMENT84_tree=null;


        retval.ret = new StructDeclaration();

        try 
    	{
            // spinach.g:196:1: ( ( 'struct' variable ( '{' ( (el1= scalarvardec | comment )+ )? '}' ) ) END_OF_STATEMENT )
            // spinach.g:196:3: ( 'struct' variable ( '{' ( (el1= scalarvardec | comment )+ )? '}' ) ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:196:3: ( 'struct' variable ( '{' ( (el1= scalarvardec | comment )+ )? '}' ) )
            	// spinach.g:196:4: 'struct' variable ( '{' ( (el1= scalarvardec | comment )+ )? '}' )
            	{
            		string_literal79=(IToken)Match(input,34,FOLLOW_34_in_structdec1100); 
            			string_literal79_tree = (object)adaptor.Create(string_literal79);
            			adaptor.AddChild(root_0, string_literal79_tree);

            		PushFollow(FOLLOW_variable_in_structdec1102);
            		variable80 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable80.Tree);
            		 retval.ret.setName(((variable80 != null) ? variable80.ret : null));
            		// spinach.g:197:1: ( '{' ( (el1= scalarvardec | comment )+ )? '}' )
            		// spinach.g:197:2: '{' ( (el1= scalarvardec | comment )+ )? '}'
            		{
            			char_literal81=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_structdec1107); 
            				char_literal81_tree = (object)adaptor.Create(char_literal81);
            				adaptor.AddChild(root_0, char_literal81_tree);

            			// spinach.g:197:5: ( (el1= scalarvardec | comment )+ )?
            			int alt25 = 2;
            			int LA25_0 = input.LA(1);

            			if ( (LA25_0 == VARTYPE || LA25_0 == STRINGTYPE || LA25_0 == 56) )
            			{
            			    alt25 = 1;
            			}
            			switch (alt25) 
            			{
            			    case 1 :
            			        // spinach.g:197:6: (el1= scalarvardec | comment )+
            			        {
            			        	// spinach.g:197:6: (el1= scalarvardec | comment )+
            			        	int cnt24 = 0;
            			        	do 
            			        	{
            			        	    int alt24 = 3;
            			        	    int LA24_0 = input.LA(1);

            			        	    if ( (LA24_0 == VARTYPE || LA24_0 == STRINGTYPE) )
            			        	    {
            			        	        alt24 = 1;
            			        	    }
            			        	    else if ( (LA24_0 == 56) )
            			        	    {
            			        	        alt24 = 2;
            			        	    }


            			        	    switch (alt24) 
            			        		{
            			        			case 1 :
            			        			    // spinach.g:197:7: el1= scalarvardec
            			        			    {
            			        			    	PushFollow(FOLLOW_scalarvardec_in_structdec1112);
            			        			    	el1 = scalarvardec();
            			        			    	state.followingStackPointer--;

            			        			    	adaptor.AddChild(root_0, el1.Tree);
            			        			    	 retval.ret.setVarType(((el1 != null) ? el1.ret : null));

            			        			    }
            			        			    break;
            			        			case 2 :
            			        			    // spinach.g:197:61: comment
            			        			    {
            			        			    	PushFollow(FOLLOW_comment_in_structdec1117);
            			        			    	comment82 = comment();
            			        			    	state.followingStackPointer--;

            			        			    	adaptor.AddChild(root_0, comment82.Tree);

            			        			    }
            			        			    break;

            			        			default:
            			        			    if ( cnt24 >= 1 ) goto loop24;
            			        		            EarlyExitException eee24 =
            			        		                new EarlyExitException(24, input);
            			        		            throw eee24;
            			        	    }
            			        	    cnt24++;
            			        	} while (true);

            			        	loop24:
            			        		;	// Stops C# compiler whining that label 'loop24' has no statements


            			        }
            			        break;

            			}

            			char_literal83=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_structdec1123); 
            				char_literal83_tree = (object)adaptor.Create(char_literal83);
            				adaptor.AddChild(root_0, char_literal83_tree);


            		}

            		retval.ret.setVar();

            	}

            	END_OF_STATEMENT84=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec1128); 
            		END_OF_STATEMENT84_tree = (object)adaptor.Create(END_OF_STATEMENT84);
            		adaptor.AddChild(root_0, END_OF_STATEMENT84_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "structdec"

    public class scalarvardec_return : ParserRuleReturnScope
    {
        public ScalarVariableDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "scalarvardec"
    // spinach.g:200:1: scalarvardec returns [ScalarVariableDeclaration ret] : ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT ;
    public spinachParser.scalarvardec_return scalarvardec() // throws RecognitionException [1]
    {   
        spinachParser.scalarvardec_return retval = new spinachParser.scalarvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE85 = null;
        IToken STRINGTYPE86 = null;
        IToken END_OF_STATEMENT88 = null;
        spinachParser.variable_return variable87 = null;


        object VARTYPE85_tree=null;
        object STRINGTYPE86_tree=null;
        object END_OF_STATEMENT88_tree=null;


        	retval.ret = new ScalarVariableDeclaration();
        	
        try 
    	{
            // spinach.g:204:2: ( ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT )
            // spinach.g:204:3: ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:204:3: ( ( VARTYPE | STRINGTYPE ) variable )
            	// spinach.g:204:4: ( VARTYPE | STRINGTYPE ) variable
            	{
            		// spinach.g:204:4: ( VARTYPE | STRINGTYPE )
            		int alt26 = 2;
            		int LA26_0 = input.LA(1);

            		if ( (LA26_0 == VARTYPE) )
            		{
            		    alt26 = 1;
            		}
            		else if ( (LA26_0 == STRINGTYPE) )
            		{
            		    alt26 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d26s0 =
            		        new NoViableAltException("", 26, 0, input);

            		    throw nvae_d26s0;
            		}
            		switch (alt26) 
            		{
            		    case 1 :
            		        // spinach.g:204:5: VARTYPE
            		        {
            		        	VARTYPE85=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarvardec1149); 
            		        		VARTYPE85_tree = (object)adaptor.Create(VARTYPE85);
            		        		adaptor.AddChild(root_0, VARTYPE85_tree);

            		        	 retval.ret.setType(((VARTYPE85 != null) ? VARTYPE85.Text : null));

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:205:4: STRINGTYPE
            		        {
            		        	STRINGTYPE86=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_scalarvardec1156); 
            		        		STRINGTYPE86_tree = (object)adaptor.Create(STRINGTYPE86);
            		        		adaptor.AddChild(root_0, STRINGTYPE86_tree);

            		        	 retval.ret.setType(((STRINGTYPE86 != null) ? STRINGTYPE86.Text : null));

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_variable_in_scalarvardec1163);
            		variable87 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable87.Tree);
            		 retval.ret.setVar(((variable87 != null) ? variable87.ret : null));

            	}

            	END_OF_STATEMENT88=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_scalarvardec1167); 
            		END_OF_STATEMENT88_tree = (object)adaptor.Create(END_OF_STATEMENT88);
            		adaptor.AddChild(root_0, END_OF_STATEMENT88_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "scalarvardec"

    public class structobjdec_return : ParserRuleReturnScope
    {
        public StructObjectDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structobjdec"
    // spinach.g:209:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
    public spinachParser.structobjdec_return structobjdec() // throws RecognitionException [1]
    {   
        spinachParser.structobjdec_return retval = new spinachParser.structobjdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT89 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object END_OF_STATEMENT89_tree=null;


        retval.ret = new StructObjectDeclaration();

        try 
    	{
            // spinach.g:213:1: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            // spinach.g:213:3: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:213:3: (el1= variable el2= variable )
            	// spinach.g:213:4: el1= variable el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structobjdec1189);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		PushFollow(FOLLOW_variable_in_structobjdec1196);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	END_OF_STATEMENT89=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec1202); 
            		END_OF_STATEMENT89_tree = (object)adaptor.Create(END_OF_STATEMENT89);
            		adaptor.AddChild(root_0, END_OF_STATEMENT89_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "structobjdec"

    public class structassign_return : ParserRuleReturnScope
    {
        public StructAssignDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structassign"
    // spinach.g:216:2: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
    public spinachParser.structassign_return structassign() // throws RecognitionException [1]
    {   
        spinachParser.structassign_return retval = new spinachParser.structassign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal90 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object char_literal90_tree=null;


        retval.ret = new StructAssignDeclaration();

        try 
    	{
            // spinach.g:220:1: ( (el1= variable '.' el2= variable ) )
            // spinach.g:220:2: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:220:2: (el1= variable '.' el2= variable )
            	// spinach.g:220:3: el1= variable '.' el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structassign1221);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setObjName(((el1 != null) ? el1.ret : null));
            		char_literal90=(IToken)Match(input,DOT,FOLLOW_DOT_in_structassign1224); 
            			char_literal90_tree = (object)adaptor.Create(char_literal90);
            			adaptor.AddChild(root_0, char_literal90_tree);

            		PushFollow(FOLLOW_variable_in_structassign1227);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setDataMember(((el2 != null) ? el2.ret : null));

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "structassign"

    public class deletionofvar_return : ParserRuleReturnScope
    {
        public DeleteVariable ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "deletionofvar"
    // spinach.g:223:1: deletionofvar returns [DeleteVariable ret] : ( 'delete' el1= variable ) END_OF_STATEMENT ;
    public spinachParser.deletionofvar_return deletionofvar() // throws RecognitionException [1]
    {   
        spinachParser.deletionofvar_return retval = new spinachParser.deletionofvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal91 = null;
        IToken END_OF_STATEMENT92 = null;
        spinachParser.variable_return el1 = null;


        object string_literal91_tree=null;
        object END_OF_STATEMENT92_tree=null;


        retval.ret = new DeleteVariable();

        try 
    	{
            // spinach.g:227:1: ( ( 'delete' el1= variable ) END_OF_STATEMENT )
            // spinach.g:227:2: ( 'delete' el1= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:227:2: ( 'delete' el1= variable )
            	// spinach.g:227:3: 'delete' el1= variable
            	{
            		string_literal91=(IToken)Match(input,35,FOLLOW_35_in_deletionofvar1248); 
            			string_literal91_tree = (object)adaptor.Create(string_literal91);
            			adaptor.AddChild(root_0, string_literal91_tree);

            		PushFollow(FOLLOW_variable_in_deletionofvar1252);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setVar(((el1 != null) ? el1.ret : null));

            	}

            	END_OF_STATEMENT92=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_deletionofvar1256); 
            		END_OF_STATEMENT92_tree = (object)adaptor.Create(END_OF_STATEMENT92);
            		adaptor.AddChild(root_0, END_OF_STATEMENT92_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "deletionofvar"

    public class print_return : ParserRuleReturnScope
    {
        public PrintOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "print"
    // spinach.g:229:1: print returns [PrintOperationElement ret] : 'print' ( varorstruct | string_literal ) END_OF_STATEMENT ;
    public spinachParser.print_return print() // throws RecognitionException [1]
    {   
        spinachParser.print_return retval = new spinachParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal93 = null;
        IToken END_OF_STATEMENT96 = null;
        spinachParser.varorstruct_return varorstruct94 = null;

        spinachParser.string_literal_return string_literal95 = null;


        object string_literal93_tree=null;
        object END_OF_STATEMENT96_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // spinach.g:233:3: ( 'print' ( varorstruct | string_literal ) END_OF_STATEMENT )
            // spinach.g:233:5: 'print' ( varorstruct | string_literal ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal93=(IToken)Match(input,36,FOLLOW_36_in_print1275); 
            		string_literal93_tree = (object)adaptor.Create(string_literal93);
            		adaptor.AddChild(root_0, string_literal93_tree);

            	// spinach.g:233:13: ( varorstruct | string_literal )
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == VARIABLE) )
            	{
            	    alt27 = 1;
            	}
            	else if ( (LA27_0 == 58) )
            	{
            	    alt27 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d27s0 =
            	        new NoViableAltException("", 27, 0, input);

            	    throw nvae_d27s0;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // spinach.g:233:14: varorstruct
            	        {
            	        	PushFollow(FOLLOW_varorstruct_in_print1278);
            	        	varorstruct94 = varorstruct();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, varorstruct94.Tree);
            	        	retval.ret.setChildElement(((varorstruct94 != null) ? varorstruct94.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:234:6: string_literal
            	        {
            	        	PushFollow(FOLLOW_string_literal_in_print1287);
            	        	string_literal95 = string_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, string_literal95.Tree);
            	        	retval.ret.setChildElement(((string_literal95 != null) ? string_literal95.ret : null));

            	        }
            	        break;

            	}

            	END_OF_STATEMENT96=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print1312); 
            		END_OF_STATEMENT96_tree = (object)adaptor.Create(END_OF_STATEMENT96);
            		adaptor.AddChild(root_0, END_OF_STATEMENT96_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "print"

    public class parallelfor_return : ParserRuleReturnScope
    {
        public ParallelForElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parallelfor"
    // spinach.g:241:1: parallelfor returns [ParallelForElement ret] : 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 ) ( 'SYNC' END_OF_STATEMENT )? )+ RIGHTPARANTHESIS ;
    public spinachParser.parallelfor_return parallelfor() // throws RecognitionException [1]
    {   
        spinachParser.parallelfor_return retval = new spinachParser.parallelfor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal97 = null;
        IToken LEFTBRACE98 = null;
        IToken POINT99 = null;
        IToken string_literal100 = null;
        IToken RIGHTBRACE101 = null;
        IToken LEFTPARANTHESIS102 = null;
        IToken string_literal103 = null;
        IToken END_OF_STATEMENT104 = null;
        IToken RIGHTPARANTHESIS105 = null;
        spinachParser.variable_return r11 = null;

        spinachParser.int_literal_return r12 = null;

        spinachParser.int_literal_return r13 = null;

        spinachParser.expr2_return e11 = null;


        object string_literal97_tree=null;
        object LEFTBRACE98_tree=null;
        object POINT99_tree=null;
        object string_literal100_tree=null;
        object RIGHTBRACE101_tree=null;
        object LEFTPARANTHESIS102_tree=null;
        object string_literal103_tree=null;
        object END_OF_STATEMENT104_tree=null;
        object RIGHTPARANTHESIS105_tree=null;


          retval.ret = new ParallelForElement();

        try 
    	{
            // spinach.g:244:2: ( 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 ) ( 'SYNC' END_OF_STATEMENT )? )+ RIGHTPARANTHESIS )
            // spinach.g:244:4: 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 ) ( 'SYNC' END_OF_STATEMENT )? )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal97=(IToken)Match(input,37,FOLLOW_37_in_parallelfor1334); 
            		string_literal97_tree = (object)adaptor.Create(string_literal97);
            		adaptor.AddChild(root_0, string_literal97_tree);

            	LEFTBRACE98=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_parallelfor1335); 
            		LEFTBRACE98_tree = (object)adaptor.Create(LEFTBRACE98);
            		adaptor.AddChild(root_0, LEFTBRACE98_tree);

            	PushFollow(FOLLOW_variable_in_parallelfor1341);
            	r11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGEVARIABLE = ((r11 != null) ? r11.ret : null);
            	POINT99=(IToken)Match(input,POINT,FOLLOW_POINT_in_parallelfor1344); 
            		POINT99_tree = (object)adaptor.Create(POINT99);
            		adaptor.AddChild(root_0, POINT99_tree);

            	PushFollow(FOLLOW_int_literal_in_parallelfor1350);
            	r12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r12.Tree);
            	retval.ret.STARTINGRANGE = ((r12 != null) ? r12.ret : null);
            	string_literal100=(IToken)Match(input,38,FOLLOW_38_in_parallelfor1353); 
            		string_literal100_tree = (object)adaptor.Create(string_literal100);
            		adaptor.AddChild(root_0, string_literal100_tree);

            	PushFollow(FOLLOW_int_literal_in_parallelfor1358);
            	r13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r13.Tree);
            	retval.ret.ENDINGRANGE = ((r13 != null) ? r13.ret : null);
            	RIGHTBRACE101=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_parallelfor1361); 
            		RIGHTBRACE101_tree = (object)adaptor.Create(RIGHTBRACE101);
            		adaptor.AddChild(root_0, RIGHTBRACE101_tree);

            	LEFTPARANTHESIS102=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_parallelfor1363); 
            		LEFTPARANTHESIS102_tree = (object)adaptor.Create(LEFTPARANTHESIS102);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS102_tree);

            	// spinach.g:244:228: ( (e11= expr2 ) ( 'SYNC' END_OF_STATEMENT )? )+
            	int cnt29 = 0;
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == VARIABLE || LA29_0 == VARTYPE || LA29_0 == STRINGTYPE || LA29_0 == 35 || LA29_0 == 40 || LA29_0 == 42) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // spinach.g:244:229: (e11= expr2 ) ( 'SYNC' END_OF_STATEMENT )?
            			    {
            			    	// spinach.g:244:229: (e11= expr2 )
            			    	// spinach.g:244:230: e11= expr2
            			    	{
            			    		PushFollow(FOLLOW_expr2_in_parallelfor1370);
            			    		e11 = expr2();
            			    		state.followingStackPointer--;

            			    		adaptor.AddChild(root_0, e11.Tree);
            			    		retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    	}

            			    	// spinach.g:244:271: ( 'SYNC' END_OF_STATEMENT )?
            			    	int alt28 = 2;
            			    	int LA28_0 = input.LA(1);

            			    	if ( (LA28_0 == 39) )
            			    	{
            			    	    alt28 = 1;
            			    	}
            			    	switch (alt28) 
            			    	{
            			    	    case 1 :
            			    	        // spinach.g:244:272: 'SYNC' END_OF_STATEMENT
            			    	        {
            			    	        	string_literal103=(IToken)Match(input,39,FOLLOW_39_in_parallelfor1374); 
            			    	        		string_literal103_tree = (object)adaptor.Create(string_literal103);
            			    	        		adaptor.AddChild(root_0, string_literal103_tree);

            			    	        	retval.ret.syncfunction();
            			    	        	END_OF_STATEMENT104=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_parallelfor1377); 
            			    	        		END_OF_STATEMENT104_tree = (object)adaptor.Create(END_OF_STATEMENT104);
            			    	        		adaptor.AddChild(root_0, END_OF_STATEMENT104_tree);


            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt29 >= 1 ) goto loop29;
            		            EarlyExitException eee29 =
            		                new EarlyExitException(29, input);
            		            throw eee29;
            	    }
            	    cnt29++;
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements

            	retval.ret.syncfunction();
            	RIGHTPARANTHESIS105=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_parallelfor1384); 
            		RIGHTPARANTHESIS105_tree = (object)adaptor.Create(RIGHTPARANTHESIS105);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS105_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parallelfor"

    public class ifelse_return : ParserRuleReturnScope
    {
        public IfStatementElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifelse"
    // spinach.g:247:1: ifelse returns [IfStatementElement ret] : ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? ;
    public spinachParser.ifelse_return ifelse() // throws RecognitionException [1]
    {   
        spinachParser.ifelse_return retval = new spinachParser.ifelse_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal106 = null;
        IToken LEFTBRACE107 = null;
        IToken string_literal109 = null;
        IToken string_literal110 = null;
        IToken char_literal111 = null;
        IToken string_literal112 = null;
        IToken char_literal113 = null;
        IToken string_literal114 = null;
        IToken RIGHTBRACE115 = null;
        IToken LEFTPARANTHESIS116 = null;
        IToken RIGHTPARANTHESIS117 = null;
        IToken string_literal118 = null;
        IToken LEFTPARANTHESIS119 = null;
        IToken RIGHTPARANTHESIS120 = null;
        spinachParser.var_int_or_double_literal_return e13 = null;

        spinachParser.string_literal_return e14 = null;

        spinachParser.ifloop_return e11 = null;

        spinachParser.ifloop_return e12 = null;

        spinachParser.varorstruct_return varorstruct108 = null;


        object string_literal106_tree=null;
        object LEFTBRACE107_tree=null;
        object string_literal109_tree=null;
        object string_literal110_tree=null;
        object char_literal111_tree=null;
        object string_literal112_tree=null;
        object char_literal113_tree=null;
        object string_literal114_tree=null;
        object RIGHTBRACE115_tree=null;
        object LEFTPARANTHESIS116_tree=null;
        object RIGHTPARANTHESIS117_tree=null;
        object string_literal118_tree=null;
        object LEFTPARANTHESIS119_tree=null;
        object RIGHTPARANTHESIS120_tree=null;


           retval.ret = new IfStatementElement();

        try 
    	{
            // spinach.g:251:1: ( ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? )
            // spinach.g:251:2: ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:251:2: ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS )
            	// spinach.g:251:3: 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS
            	{
            		string_literal106=(IToken)Match(input,40,FOLLOW_40_in_ifelse1401); 
            			string_literal106_tree = (object)adaptor.Create(string_literal106);
            			adaptor.AddChild(root_0, string_literal106_tree);

            		LEFTBRACE107=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_ifelse1403); 
            			LEFTBRACE107_tree = (object)adaptor.Create(LEFTBRACE107);
            			adaptor.AddChild(root_0, LEFTBRACE107_tree);

            		// spinach.g:251:18: ( varorstruct )
            		// spinach.g:251:19: varorstruct
            		{
            			PushFollow(FOLLOW_varorstruct_in_ifelse1406);
            			varorstruct108 = varorstruct();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, varorstruct108.Tree);
            			retval.ret.setLhs(((varorstruct108 != null) ? varorstruct108.ret : null));

            		}

            		// spinach.g:251:69: ( '==' | '!=' | '<' | '<=' | '>' | '>=' )
            		int alt30 = 6;
            		switch ( input.LA(1) ) 
            		{
            		case EQUALITYEXPRESSION:
            			{
            		    alt30 = 1;
            		    }
            		    break;
            		case NONEQUALITYEXPRESSION:
            			{
            		    alt30 = 2;
            		    }
            		    break;
            		case LESSTHANEXPRESSION:
            			{
            		    alt30 = 3;
            		    }
            		    break;
            		case LESSTHANEQUALTOEXPRESSION:
            			{
            		    alt30 = 4;
            		    }
            		    break;
            		case GREATERTHANEXPRESSION:
            			{
            		    alt30 = 5;
            		    }
            		    break;
            		case GREATERTHANEQUALTOEXPRESSION:
            			{
            		    alt30 = 6;
            		    }
            		    break;
            			default:
            			    NoViableAltException nvae_d30s0 =
            			        new NoViableAltException("", 30, 0, input);

            			    throw nvae_d30s0;
            		}

            		switch (alt30) 
            		{
            		    case 1 :
            		        // spinach.g:252:7: '=='
            		        {
            		        	string_literal109=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_ifelse1417); 
            		        		string_literal109_tree = (object)adaptor.Create(string_literal109);
            		        		adaptor.AddChild(root_0, string_literal109_tree);

            		        	 retval.ret.OP = "eq"; 

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:253:7: '!='
            		        {
            		        	string_literal110=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_ifelse1427); 
            		        		string_literal110_tree = (object)adaptor.Create(string_literal110);
            		        		adaptor.AddChild(root_0, string_literal110_tree);

            		        	 retval.ret.OP = "ne"; 

            		        }
            		        break;
            		    case 3 :
            		        // spinach.g:254:7: '<'
            		        {
            		        	char_literal111=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_ifelse1437); 
            		        		char_literal111_tree = (object)adaptor.Create(char_literal111);
            		        		adaptor.AddChild(root_0, char_literal111_tree);

            		        	 retval.ret.OP = "lt"; 

            		        }
            		        break;
            		    case 4 :
            		        // spinach.g:255:7: '<='
            		        {
            		        	string_literal112=(IToken)Match(input,LESSTHANEQUALTOEXPRESSION,FOLLOW_LESSTHANEQUALTOEXPRESSION_in_ifelse1448); 
            		        		string_literal112_tree = (object)adaptor.Create(string_literal112);
            		        		adaptor.AddChild(root_0, string_literal112_tree);

            		        	 retval.ret.OP = "le"; 

            		        }
            		        break;
            		    case 5 :
            		        // spinach.g:256:7: '>'
            		        {
            		        	char_literal113=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_ifelse1458); 
            		        		char_literal113_tree = (object)adaptor.Create(char_literal113);
            		        		adaptor.AddChild(root_0, char_literal113_tree);

            		        	 retval.ret.OP = "gt"; 

            		        }
            		        break;
            		    case 6 :
            		        // spinach.g:257:7: '>='
            		        {
            		        	string_literal114=(IToken)Match(input,GREATERTHANEQUALTOEXPRESSION,FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_ifelse1469); 
            		        		string_literal114_tree = (object)adaptor.Create(string_literal114);
            		        		adaptor.AddChild(root_0, string_literal114_tree);

            		        	 retval.ret.OP = "ge"; 

            		        }
            		        break;

            		}

            		// spinach.g:259:1: (e13= var_int_or_double_literal | e14= string_literal )
            		int alt31 = 2;
            		int LA31_0 = input.LA(1);

            		if ( ((LA31_0 >= VARIABLE && LA31_0 <= DOUBLE_LITERAL)) )
            		{
            		    alt31 = 1;
            		}
            		else if ( (LA31_0 == 58) )
            		{
            		    alt31 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d31s0 =
            		        new NoViableAltException("", 31, 0, input);

            		    throw nvae_d31s0;
            		}
            		switch (alt31) 
            		{
            		    case 1 :
            		        // spinach.g:259:2: e13= var_int_or_double_literal
            		        {
            		        	PushFollow(FOLLOW_var_int_or_double_literal_in_ifelse1482);
            		        	e13 = var_int_or_double_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e13.Tree);
            		        	retval.ret.setRhs(((e13 != null) ? e13.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:259:64: e14= string_literal
            		        {
            		        	PushFollow(FOLLOW_string_literal_in_ifelse1489);
            		        	e14 = string_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e14.Tree);
            		        	retval.ret.setRhs(((e14 != null) ? e14.ret : null));

            		        }
            		        break;

            		}

            		RIGHTBRACE115=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_ifelse1493); 
            			RIGHTBRACE115_tree = (object)adaptor.Create(RIGHTBRACE115);
            			adaptor.AddChild(root_0, RIGHTBRACE115_tree);

            		LEFTPARANTHESIS116=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1495); 
            			LEFTPARANTHESIS116_tree = (object)adaptor.Create(LEFTPARANTHESIS116);
            			adaptor.AddChild(root_0, LEFTPARANTHESIS116_tree);

            		// spinach.g:259:143: ( (e11= ifloop ) | )
            		int alt32 = 2;
            		int LA32_0 = input.LA(1);

            		if ( (LA32_0 == VARIABLE || LA32_0 == VARTYPE || LA32_0 == STRINGTYPE || LA32_0 == 28 || LA32_0 == 32 || (LA32_0 >= 35 && LA32_0 <= 36) || LA32_0 == 40 || LA32_0 == 42 || (LA32_0 >= 46 && LA32_0 <= 47) || (LA32_0 >= 51 && LA32_0 <= 56)) )
            		{
            		    alt32 = 1;
            		}
            		else if ( (LA32_0 == RIGHTPARANTHESIS) )
            		{
            		    alt32 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d32s0 =
            		        new NoViableAltException("", 32, 0, input);

            		    throw nvae_d32s0;
            		}
            		switch (alt32) 
            		{
            		    case 1 :
            		        // spinach.g:259:144: (e11= ifloop )
            		        {
            		        	// spinach.g:259:144: (e11= ifloop )
            		        	// spinach.g:259:145: e11= ifloop
            		        	{
            		        		PushFollow(FOLLOW_ifloop_in_ifelse1503);
            		        		e11 = ifloop();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, e11.Tree);
            		        		retval.ret.IFCODE = ((e11 != null) ? e11.ret : null);

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:259:190: 
            		        {
            		        }
            		        break;

            		}

            		RIGHTPARANTHESIS117=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1508); 
            			RIGHTPARANTHESIS117_tree = (object)adaptor.Create(RIGHTPARANTHESIS117);
            			adaptor.AddChild(root_0, RIGHTPARANTHESIS117_tree);


            	}

            	// spinach.g:259:208: ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == 41) )
            	{
            	    alt34 = 1;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // spinach.g:259:209: 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS
            	        {
            	        	string_literal118=(IToken)Match(input,41,FOLLOW_41_in_ifelse1511); 
            	        		string_literal118_tree = (object)adaptor.Create(string_literal118);
            	        		adaptor.AddChild(root_0, string_literal118_tree);

            	        	LEFTPARANTHESIS119=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1514); 
            	        		LEFTPARANTHESIS119_tree = (object)adaptor.Create(LEFTPARANTHESIS119);
            	        		adaptor.AddChild(root_0, LEFTPARANTHESIS119_tree);

            	        	// spinach.g:259:233: ( (e12= ifloop ) | )
            	        	int alt33 = 2;
            	        	int LA33_0 = input.LA(1);

            	        	if ( (LA33_0 == VARIABLE || LA33_0 == VARTYPE || LA33_0 == STRINGTYPE || LA33_0 == 28 || LA33_0 == 32 || (LA33_0 >= 35 && LA33_0 <= 36) || LA33_0 == 40 || LA33_0 == 42 || (LA33_0 >= 46 && LA33_0 <= 47) || (LA33_0 >= 51 && LA33_0 <= 56)) )
            	        	{
            	        	    alt33 = 1;
            	        	}
            	        	else if ( (LA33_0 == RIGHTPARANTHESIS) )
            	        	{
            	        	    alt33 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    NoViableAltException nvae_d33s0 =
            	        	        new NoViableAltException("", 33, 0, input);

            	        	    throw nvae_d33s0;
            	        	}
            	        	switch (alt33) 
            	        	{
            	        	    case 1 :
            	        	        // spinach.g:259:234: (e12= ifloop )
            	        	        {
            	        	        	// spinach.g:259:234: (e12= ifloop )
            	        	        	// spinach.g:259:235: e12= ifloop
            	        	        	{
            	        	        		PushFollow(FOLLOW_ifloop_in_ifelse1523);
            	        	        		e12 = ifloop();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, e12.Tree);
            	        	        		retval.ret.ELSECODE = ((e12 != null) ? e12.ret : null);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // spinach.g:259:283: 
            	        	        {
            	        	        }
            	        	        break;

            	        	}

            	        	RIGHTPARANTHESIS120=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1529); 
            	        		RIGHTPARANTHESIS120_tree = (object)adaptor.Create(RIGHTPARANTHESIS120);
            	        		adaptor.AddChild(root_0, RIGHTPARANTHESIS120_tree);


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ifelse"

    public class ifloop_return : ParserRuleReturnScope
    {
        public List<Element> ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifloop"
    // spinach.g:261:1: ifloop returns [List<Element> ret] : ( expr1 | functionreturn | comment )+ ;
    public spinachParser.ifloop_return ifloop() // throws RecognitionException [1]
    {   
        spinachParser.ifloop_return retval = new spinachParser.ifloop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr1121 = null;

        spinachParser.functionreturn_return functionreturn122 = null;

        spinachParser.comment_return comment123 = null;




           retval.ret = new List<Element>();

        try 
    	{
            // spinach.g:266:1: ( ( expr1 | functionreturn | comment )+ )
            // spinach.g:266:3: ( expr1 | functionreturn | comment )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:266:3: ( expr1 | functionreturn | comment )+
            	int cnt35 = 0;
            	do 
            	{
            	    int alt35 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case VARIABLE:
            	    case VARTYPE:
            	    case STRINGTYPE:
            	    case 28:
            	    case 32:
            	    case 35:
            	    case 36:
            	    case 40:
            	    case 42:
            	    case 47:
            	    case 51:
            	    case 52:
            	    case 53:
            	    case 54:
            	    case 55:
            	    	{
            	        alt35 = 1;
            	        }
            	        break;
            	    case 46:
            	    	{
            	        alt35 = 2;
            	        }
            	        break;
            	    case 56:
            	    	{
            	        alt35 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt35) 
            		{
            			case 1 :
            			    // spinach.g:266:4: expr1
            			    {
            			    	PushFollow(FOLLOW_expr1_in_ifloop1550);
            			    	expr1121 = expr1();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1121.Tree);
            			    	retval.ret.Add(((expr1121 != null) ? expr1121.ret : null));

            			    }
            			    break;
            			case 2 :
            			    // spinach.g:266:39: functionreturn
            			    {
            			    	PushFollow(FOLLOW_functionreturn_in_ifloop1553);
            			    	functionreturn122 = functionreturn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, functionreturn122.Tree);
            			    	retval.ret.Add(((functionreturn122 != null) ? functionreturn122.ret : null));

            			    }
            			    break;
            			case 3 :
            			    // spinach.g:266:92: comment
            			    {
            			    	PushFollow(FOLLOW_comment_in_ifloop1556);
            			    	comment123 = comment();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, comment123.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt35 >= 1 ) goto loop35;
            		            EarlyExitException eee35 =
            		                new EarlyExitException(35, input);
            		            throw eee35;
            	    }
            	    cnt35++;
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ifloop"

    public class forstatement_return : ParserRuleReturnScope
    {
        public ForStatementElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forstatement"
    // spinach.g:270:1: forstatement returns [ForStatementElement ret] : 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= forexpr | comment )+ RIGHTPARANTHESIS ;
    public spinachParser.forstatement_return forstatement() // throws RecognitionException [1]
    {   
        spinachParser.forstatement_return retval = new spinachParser.forstatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal124 = null;
        IToken LEFTBRACE125 = null;
        IToken POINT126 = null;
        IToken string_literal127 = null;
        IToken RIGHTBRACE128 = null;
        IToken LEFTPARANTHESIS129 = null;
        IToken RIGHTPARANTHESIS131 = null;
        spinachParser.variable_return r11 = null;

        spinachParser.int_literal_return r12 = null;

        spinachParser.int_literal_return r13 = null;

        spinachParser.forexpr_return e11 = null;

        spinachParser.comment_return comment130 = null;


        object string_literal124_tree=null;
        object LEFTBRACE125_tree=null;
        object POINT126_tree=null;
        object string_literal127_tree=null;
        object RIGHTBRACE128_tree=null;
        object LEFTPARANTHESIS129_tree=null;
        object RIGHTPARANTHESIS131_tree=null;


           retval.ret = new ForStatementElement();

        try 
    	{
            // spinach.g:273:2: ( 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= forexpr | comment )+ RIGHTPARANTHESIS )
            // spinach.g:273:3: 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= forexpr | comment )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal124=(IToken)Match(input,42,FOLLOW_42_in_forstatement1574); 
            		string_literal124_tree = (object)adaptor.Create(string_literal124);
            		adaptor.AddChild(root_0, string_literal124_tree);

            	LEFTBRACE125=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_forstatement1576); 
            		LEFTBRACE125_tree = (object)adaptor.Create(LEFTBRACE125);
            		adaptor.AddChild(root_0, LEFTBRACE125_tree);

            	PushFollow(FOLLOW_variable_in_forstatement1582);
            	r11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGEVARIABLE = ((r11 != null) ? r11.ret : null);
            	POINT126=(IToken)Match(input,POINT,FOLLOW_POINT_in_forstatement1585); 
            		POINT126_tree = (object)adaptor.Create(POINT126);
            		adaptor.AddChild(root_0, POINT126_tree);

            	PushFollow(FOLLOW_int_literal_in_forstatement1591);
            	r12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r12.Tree);
            	retval.ret.STARTINGRANGE = ((r12 != null) ? r12.ret : null);
            	string_literal127=(IToken)Match(input,38,FOLLOW_38_in_forstatement1594); 
            		string_literal127_tree = (object)adaptor.Create(string_literal127);
            		adaptor.AddChild(root_0, string_literal127_tree);

            	PushFollow(FOLLOW_int_literal_in_forstatement1599);
            	r13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r13.Tree);
            	retval.ret.ENDINGRANGE = ((r13 != null) ? r13.ret : null);
            	RIGHTBRACE128=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_forstatement1602); 
            		RIGHTBRACE128_tree = (object)adaptor.Create(RIGHTBRACE128);
            		adaptor.AddChild(root_0, RIGHTBRACE128_tree);

            	LEFTPARANTHESIS129=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_forstatement1604); 
            		LEFTPARANTHESIS129_tree = (object)adaptor.Create(LEFTPARANTHESIS129);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS129_tree);

            	// spinach.g:273:219: (e11= forexpr | comment )+
            	int cnt36 = 0;
            	do 
            	{
            	    int alt36 = 3;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == VARIABLE || LA36_0 == VARTYPE || LA36_0 == STRINGTYPE || LA36_0 == 28 || LA36_0 == 32 || LA36_0 == 35 || LA36_0 == 40 || LA36_0 == 42 || LA36_0 == 47 || (LA36_0 >= 51 && LA36_0 <= 55)) )
            	    {
            	        alt36 = 1;
            	    }
            	    else if ( (LA36_0 == 56) )
            	    {
            	        alt36 = 2;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // spinach.g:273:220: e11= forexpr
            			    {
            			    	PushFollow(FOLLOW_forexpr_in_forstatement1609);
            			    	e11 = forexpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e11.Tree);
            			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    }
            			    break;
            			case 2 :
            			    // spinach.g:273:263: comment
            			    {
            			    	PushFollow(FOLLOW_comment_in_forstatement1612);
            			    	comment130 = comment();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, comment130.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt36 >= 1 ) goto loop36;
            		            EarlyExitException eee36 =
            		                new EarlyExitException(36, input);
            		            throw eee36;
            	    }
            	    cnt36++;
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements

            	RIGHTPARANTHESIS131=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_forstatement1616); 
            		RIGHTPARANTHESIS131_tree = (object)adaptor.Create(RIGHTPARANTHESIS131);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS131_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forstatement"

    public class functioncall_return : ParserRuleReturnScope
    {
        public FunctionCallElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functioncall"
    // spinach.g:275:1: functioncall returns [FunctionCallElement ret] : variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT ;
    public spinachParser.functioncall_return functioncall() // throws RecognitionException [1]
    {   
        spinachParser.functioncall_return retval = new spinachParser.functioncall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal133 = null;
        IToken char_literal134 = null;
        IToken char_literal135 = null;
        IToken END_OF_STATEMENT136 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;

        spinachParser.string_literal_return e13 = null;

        spinachParser.var_int_or_double_literal_return el2 = null;

        spinachParser.variable_return variable132 = null;


        object char_literal133_tree=null;
        object char_literal134_tree=null;
        object char_literal135_tree=null;
        object END_OF_STATEMENT136_tree=null;

         retval.ret = new FunctionCallElement();
         
        try 
    	{
            // spinach.g:278:3: ( variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT )
            // spinach.g:278:4: variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_functioncall1634);
            	variable132 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable132.Tree);
            	retval.ret.setfunctioncallname(((variable132 != null) ? variable132.ret : null));
            	char_literal133=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functioncall1639); 
            		char_literal133_tree = (object)adaptor.Create(char_literal133);
            		adaptor.AddChild(root_0, char_literal133_tree);

            	// spinach.g:279:6: ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( ((LA40_0 >= VARIABLE && LA40_0 <= DOUBLE_LITERAL) || LA40_0 == 58) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // spinach.g:279:7: (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )*
            	        {
            	        	// spinach.g:279:7: (el1= var_int_or_double_literal | e13= string_literal )
            	        	int alt37 = 2;
            	        	int LA37_0 = input.LA(1);

            	        	if ( ((LA37_0 >= VARIABLE && LA37_0 <= DOUBLE_LITERAL)) )
            	        	{
            	        	    alt37 = 1;
            	        	}
            	        	else if ( (LA37_0 == 58) )
            	        	{
            	        	    alt37 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    NoViableAltException nvae_d37s0 =
            	        	        new NoViableAltException("", 37, 0, input);

            	        	    throw nvae_d37s0;
            	        	}
            	        	switch (alt37) 
            	        	{
            	        	    case 1 :
            	        	        // spinach.g:279:8: el1= var_int_or_double_literal
            	        	        {
            	        	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1644);
            	        	        	el1 = var_int_or_double_literal();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, el1.Tree);
            	        	        	retval.ret.setparameters(((el1 != null) ? el1.ret : null));

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // spinach.g:279:75: e13= string_literal
            	        	        {
            	        	        	PushFollow(FOLLOW_string_literal_in_functioncall1650);
            	        	        	e13 = string_literal();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, e13.Tree);
            	        	        	retval.ret.setparameters(((e13 != null) ? e13.ret : null));

            	        	        }
            	        	        break;

            	        	}

            	        	// spinach.g:279:133: ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )*
            	        	do 
            	        	{
            	        	    int alt39 = 2;
            	        	    int LA39_0 = input.LA(1);

            	        	    if ( (LA39_0 == 31) )
            	        	    {
            	        	        alt39 = 1;
            	        	    }


            	        	    switch (alt39) 
            	        		{
            	        			case 1 :
            	        			    // spinach.g:279:134: ',' (el2= var_int_or_double_literal | e13= string_literal )
            	        			    {
            	        			    	char_literal134=(IToken)Match(input,31,FOLLOW_31_in_functioncall1655); 
            	        			    		char_literal134_tree = (object)adaptor.Create(char_literal134);
            	        			    		adaptor.AddChild(root_0, char_literal134_tree);

            	        			    	// spinach.g:279:138: (el2= var_int_or_double_literal | e13= string_literal )
            	        			    	int alt38 = 2;
            	        			    	int LA38_0 = input.LA(1);

            	        			    	if ( ((LA38_0 >= VARIABLE && LA38_0 <= DOUBLE_LITERAL)) )
            	        			    	{
            	        			    	    alt38 = 1;
            	        			    	}
            	        			    	else if ( (LA38_0 == 58) )
            	        			    	{
            	        			    	    alt38 = 2;
            	        			    	}
            	        			    	else 
            	        			    	{
            	        			    	    NoViableAltException nvae_d38s0 =
            	        			    	        new NoViableAltException("", 38, 0, input);

            	        			    	    throw nvae_d38s0;
            	        			    	}
            	        			    	switch (alt38) 
            	        			    	{
            	        			    	    case 1 :
            	        			    	        // spinach.g:279:139: el2= var_int_or_double_literal
            	        			    	        {
            	        			    	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1660);
            	        			    	        	el2 = var_int_or_double_literal();
            	        			    	        	state.followingStackPointer--;

            	        			    	        	adaptor.AddChild(root_0, el2.Tree);
            	        			    	        	retval.ret.setparameters(((el2 != null) ? el2.ret : null));

            	        			    	        }
            	        			    	        break;
            	        			    	    case 2 :
            	        			    	        // spinach.g:279:206: e13= string_literal
            	        			    	        {
            	        			    	        	PushFollow(FOLLOW_string_literal_in_functioncall1666);
            	        			    	        	e13 = string_literal();
            	        			    	        	state.followingStackPointer--;

            	        			    	        	adaptor.AddChild(root_0, e13.Tree);
            	        			    	        	retval.ret.setparameters(((e13 != null) ? e13.ret : null));

            	        			    	        }
            	        			    	        break;

            	        			    	}


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop39;
            	        	    }
            	        	} while (true);

            	        	loop39:
            	        		;	// Stops C# compiler whining that label 'loop39' has no statements


            	        }
            	        break;

            	}

            	char_literal135=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functioncall1674); 
            		char_literal135_tree = (object)adaptor.Create(char_literal135);
            		adaptor.AddChild(root_0, char_literal135_tree);

            	END_OF_STATEMENT136=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functioncall1678); 
            		END_OF_STATEMENT136_tree = (object)adaptor.Create(END_OF_STATEMENT136);
            		adaptor.AddChild(root_0, END_OF_STATEMENT136_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functioncall"

    public class functiondefination_return : ParserRuleReturnScope
    {
        public FunctionElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functiondefination"
    // spinach.g:287:1: functiondefination returns [FunctionElement ret] : ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+ )? '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | comment | parallelfor | forstatement )+ )? '}' );
    public spinachParser.functiondefination_return functiondefination() // throws RecognitionException [1]
    {   
        spinachParser.functiondefination_return retval = new spinachParser.functiondefination_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE137 = null;
        IToken char_literal139 = null;
        IToken char_literal140 = null;
        IToken char_literal141 = null;
        IToken char_literal142 = null;
        IToken char_literal155 = null;
        IToken string_literal156 = null;
        IToken char_literal158 = null;
        IToken char_literal159 = null;
        IToken char_literal160 = null;
        IToken char_literal161 = null;
        IToken char_literal174 = null;
        spinachParser.arguments_return e11 = null;

        spinachParser.arguments_return e12 = null;

        spinachParser.variable_return variable138 = null;

        spinachParser.assignment_return assignment143 = null;

        spinachParser.functioncall_return functioncall144 = null;

        spinachParser.scalarvardec_return scalarvardec145 = null;

        spinachParser.vectorvardec_return vectorvardec146 = null;

        spinachParser.matrixvardec_return matrixvardec147 = null;

        spinachParser.deletionofvar_return deletionofvar148 = null;

        spinachParser.print_return print149 = null;

        spinachParser.ifelse_return ifelse150 = null;

        spinachParser.functionreturn_return functionreturn151 = null;

        spinachParser.parallelfor_return parallelfor152 = null;

        spinachParser.forstatement_return forstatement153 = null;

        spinachParser.comment_return comment154 = null;

        spinachParser.variable_return variable157 = null;

        spinachParser.assignment_return assignment162 = null;

        spinachParser.functioncall_return functioncall163 = null;

        spinachParser.scalarvardec_return scalarvardec164 = null;

        spinachParser.vectorvardec_return vectorvardec165 = null;

        spinachParser.matrixvardec_return matrixvardec166 = null;

        spinachParser.deletionofvar_return deletionofvar167 = null;

        spinachParser.print_return print168 = null;

        spinachParser.ifelse_return ifelse169 = null;

        spinachParser.functionreturn_return functionreturn170 = null;

        spinachParser.comment_return comment171 = null;

        spinachParser.parallelfor_return parallelfor172 = null;

        spinachParser.forstatement_return forstatement173 = null;


        object VARTYPE137_tree=null;
        object char_literal139_tree=null;
        object char_literal140_tree=null;
        object char_literal141_tree=null;
        object char_literal142_tree=null;
        object char_literal155_tree=null;
        object string_literal156_tree=null;
        object char_literal158_tree=null;
        object char_literal159_tree=null;
        object char_literal160_tree=null;
        object char_literal161_tree=null;
        object char_literal174_tree=null;


        retval.ret = new FunctionElement();

        try 
    	{
            // spinach.g:292:1: ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+ )? '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | comment | parallelfor | forstatement )+ )? '}' )
            int alt49 = 2;
            int LA49_0 = input.LA(1);

            if ( (LA49_0 == VARTYPE) )
            {
                alt49 = 1;
            }
            else if ( (LA49_0 == 43) )
            {
                alt49 = 2;
            }
            else 
            {
                NoViableAltException nvae_d49s0 =
                    new NoViableAltException("", 49, 0, input);

                throw nvae_d49s0;
            }
            switch (alt49) 
            {
                case 1 :
                    // spinach.g:292:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+ )? '}' )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:292:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+ )? '}' )
                    	// spinach.g:292:4: VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+ )? '}'
                    	{
                    		VARTYPE137=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_functiondefination1705); 
                    			VARTYPE137_tree = (object)adaptor.Create(VARTYPE137);
                    			adaptor.AddChild(root_0, VARTYPE137_tree);

                    		retval.ret.setreturntype(((VARTYPE137 != null) ? VARTYPE137.Text : null));
                    		PushFollow(FOLLOW_variable_in_functiondefination1710);
                    		variable138 = variable();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, variable138.Tree);
                    		retval.ret.setfunctionname(((variable138 != null) ? variable138.ret : null));
                    		char_literal139=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1716); 
                    			char_literal139_tree = (object)adaptor.Create(char_literal139);
                    			adaptor.AddChild(root_0, char_literal139_tree);

                    		// spinach.g:295:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    		// spinach.g:295:3: (e11= arguments ( ',' e12= arguments )* )?
                    		{
                    			// spinach.g:295:3: (e11= arguments ( ',' e12= arguments )* )?
                    			int alt42 = 2;
                    			int LA42_0 = input.LA(1);

                    			if ( (LA42_0 == VARTYPE || LA42_0 == 28 || LA42_0 == 32) )
                    			{
                    			    alt42 = 1;
                    			}
                    			switch (alt42) 
                    			{
                    			    case 1 :
                    			        // spinach.g:295:4: e11= arguments ( ',' e12= arguments )*
                    			        {
                    			        	PushFollow(FOLLOW_arguments_in_functiondefination1724);
                    			        	e11 = arguments();
                    			        	state.followingStackPointer--;

                    			        	adaptor.AddChild(root_0, e11.Tree);
                    			        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    			        	// spinach.g:295:54: ( ',' e12= arguments )*
                    			        	do 
                    			        	{
                    			        	    int alt41 = 2;
                    			        	    int LA41_0 = input.LA(1);

                    			        	    if ( (LA41_0 == 31) )
                    			        	    {
                    			        	        alt41 = 1;
                    			        	    }


                    			        	    switch (alt41) 
                    			        		{
                    			        			case 1 :
                    			        			    // spinach.g:295:55: ',' e12= arguments
                    			        			    {
                    			        			    	char_literal140=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1727); 
                    			        			    		char_literal140_tree = (object)adaptor.Create(char_literal140);
                    			        			    		adaptor.AddChild(root_0, char_literal140_tree);

                    			        			    	PushFollow(FOLLOW_arguments_in_functiondefination1732);
                    			        			    	e12 = arguments();
                    			        			    	state.followingStackPointer--;

                    			        			    	adaptor.AddChild(root_0, e12.Tree);
                    			        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    			        			    }
                    			        			    break;

                    			        			default:
                    			        			    goto loop41;
                    			        	    }
                    			        	} while (true);

                    			        	loop41:
                    			        		;	// Stops C# compiler whining that label 'loop41' has no statements


                    			        }
                    			        break;

                    			}


                    		}

                    		char_literal141=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1741); 
                    			char_literal141_tree = (object)adaptor.Create(char_literal141);
                    			adaptor.AddChild(root_0, char_literal141_tree);

                    		char_literal142=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1743); 
                    			char_literal142_tree = (object)adaptor.Create(char_literal142);
                    			adaptor.AddChild(root_0, char_literal142_tree);

                    		// spinach.g:297:5: ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+ )?
                    		int alt44 = 2;
                    		int LA44_0 = input.LA(1);

                    		if ( (LA44_0 == VARIABLE || LA44_0 == VARTYPE || LA44_0 == STRINGTYPE || LA44_0 == 28 || LA44_0 == 32 || (LA44_0 >= 35 && LA44_0 <= 37) || LA44_0 == 40 || LA44_0 == 42 || LA44_0 == 46 || LA44_0 == 56) )
                    		{
                    		    alt44 = 1;
                    		}
                    		switch (alt44) 
                    		{
                    		    case 1 :
                    		        // spinach.g:297:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+
                    		        {
                    		        	// spinach.g:297:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+
                    		        	int cnt43 = 0;
                    		        	do 
                    		        	{
                    		        	    int alt43 = 13;
                    		        	    alt43 = dfa43.Predict(input);
                    		        	    switch (alt43) 
                    		        		{
                    		        			case 1 :
                    		        			    // spinach.g:297:7: assignment
                    		        			    {
                    		        			    	PushFollow(FOLLOW_assignment_in_functiondefination1747);
                    		        			    	assignment143 = assignment();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, assignment143.Tree);
                    		        			    	retval.ret.setBody(((assignment143 != null) ? assignment143.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 2 :
                    		        			    // spinach.g:297:56: functioncall
                    		        			    {
                    		        			    	PushFollow(FOLLOW_functioncall_in_functiondefination1750);
                    		        			    	functioncall144 = functioncall();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, functioncall144.Tree);
                    		        			    	retval.ret.setBody(((functioncall144 != null) ? functioncall144.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 3 :
                    		        			    // spinach.g:297:110: scalarvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1754);
                    		        			    	scalarvardec145 = scalarvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, scalarvardec145.Tree);
                    		        			    	 retval.ret.setBody(((scalarvardec145 != null) ? scalarvardec145.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 4 :
                    		        			    // spinach.g:298:5: vectorvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1762);
                    		        			    	vectorvardec146 = vectorvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, vectorvardec146.Tree);
                    		        			    	 retval.ret.setBody(((vectorvardec146 != null) ? vectorvardec146.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 5 :
                    		        			    // spinach.g:299:5: matrixvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1770);
                    		        			    	matrixvardec147 = matrixvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, matrixvardec147.Tree);
                    		        			    	 retval.ret.setBody(((matrixvardec147 != null) ? matrixvardec147.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 6 :
                    		        			    // spinach.g:300:5: deletionofvar
                    		        			    {
                    		        			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1778);
                    		        			    	deletionofvar148 = deletionofvar();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, deletionofvar148.Tree);
                    		        			    	 retval.ret.setBody(((deletionofvar148 != null) ? deletionofvar148.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 7 :
                    		        			    // spinach.g:300:64: print
                    		        			    {
                    		        			    	PushFollow(FOLLOW_print_in_functiondefination1784);
                    		        			    	print149 = print();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, print149.Tree);
                    		        			    	 retval.ret.setBody(((print149 != null) ? print149.ret : null)); 

                    		        			    }
                    		        			    break;
                    		        			case 8 :
                    		        			    // spinach.g:301:5: ifelse
                    		        			    {
                    		        			    	PushFollow(FOLLOW_ifelse_in_functiondefination1792);
                    		        			    	ifelse150 = ifelse();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, ifelse150.Tree);
                    		        			    	retval.ret.setBody(((ifelse150 != null) ? ifelse150.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 9 :
                    		        			    // spinach.g:301:47: functionreturn
                    		        			    {
                    		        			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1796);
                    		        			    	functionreturn151 = functionreturn();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, functionreturn151.Tree);
                    		        			    	retval.ret.setBody(((functionreturn151 != null) ? functionreturn151.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 10 :
                    		        			    // spinach.g:301:105: parallelfor
                    		        			    {
                    		        			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1800);
                    		        			    	parallelfor152 = parallelfor();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, parallelfor152.Tree);
                    		        			    	retval.ret.setBody(((parallelfor152 != null) ? parallelfor152.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 11 :
                    		        			    // spinach.g:301:157: forstatement
                    		        			    {
                    		        			    	PushFollow(FOLLOW_forstatement_in_functiondefination1804);
                    		        			    	forstatement153 = forstatement();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, forstatement153.Tree);
                    		        			    	retval.ret.setBody(((forstatement153 != null) ? forstatement153.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 12 :
                    		        			    // spinach.g:301:210: comment
                    		        			    {
                    		        			    	PushFollow(FOLLOW_comment_in_functiondefination1807);
                    		        			    	comment154 = comment();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, comment154.Tree);

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    if ( cnt43 >= 1 ) goto loop43;
                    		        		            EarlyExitException eee43 =
                    		        		                new EarlyExitException(43, input);
                    		        		            throw eee43;
                    		        	    }
                    		        	    cnt43++;
                    		        	} while (true);

                    		        	loop43:
                    		        		;	// Stops C# compiler whining that label 'loop43' has no statements


                    		        }
                    		        break;

                    		}

                    		char_literal155=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1813); 
                    			char_literal155_tree = (object)adaptor.Create(char_literal155);
                    			adaptor.AddChild(root_0, char_literal155_tree);


                    	}


                    }
                    break;
                case 2 :
                    // spinach.g:302:6: 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | comment | parallelfor | forstatement )+ )? '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal156=(IToken)Match(input,43,FOLLOW_43_in_functiondefination1816); 
                    		string_literal156_tree = (object)adaptor.Create(string_literal156);
                    		adaptor.AddChild(root_0, string_literal156_tree);

                    	retval.ret.setreturntype("void");
                    	PushFollow(FOLLOW_variable_in_functiondefination1821);
                    	variable157 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable157.Tree);
                    	retval.ret.setfunctionname(((variable157 != null) ? variable157.ret : null));
                    	char_literal158=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1827); 
                    		char_literal158_tree = (object)adaptor.Create(char_literal158);
                    		adaptor.AddChild(root_0, char_literal158_tree);

                    	// spinach.g:305:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    	// spinach.g:305:3: (e11= arguments ( ',' e12= arguments )* )?
                    	{
                    		// spinach.g:305:3: (e11= arguments ( ',' e12= arguments )* )?
                    		int alt46 = 2;
                    		int LA46_0 = input.LA(1);

                    		if ( (LA46_0 == VARTYPE || LA46_0 == 28 || LA46_0 == 32) )
                    		{
                    		    alt46 = 1;
                    		}
                    		switch (alt46) 
                    		{
                    		    case 1 :
                    		        // spinach.g:305:4: e11= arguments ( ',' e12= arguments )*
                    		        {
                    		        	PushFollow(FOLLOW_arguments_in_functiondefination1836);
                    		        	e11 = arguments();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, e11.Tree);
                    		        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    		        	// spinach.g:305:55: ( ',' e12= arguments )*
                    		        	do 
                    		        	{
                    		        	    int alt45 = 2;
                    		        	    int LA45_0 = input.LA(1);

                    		        	    if ( (LA45_0 == 31) )
                    		        	    {
                    		        	        alt45 = 1;
                    		        	    }


                    		        	    switch (alt45) 
                    		        		{
                    		        			case 1 :
                    		        			    // spinach.g:305:56: ',' e12= arguments
                    		        			    {
                    		        			    	char_literal159=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1839); 
                    		        			    		char_literal159_tree = (object)adaptor.Create(char_literal159);
                    		        			    		adaptor.AddChild(root_0, char_literal159_tree);

                    		        			    	PushFollow(FOLLOW_arguments_in_functiondefination1843);
                    		        			    	e12 = arguments();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, e12.Tree);
                    		        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    goto loop45;
                    		        	    }
                    		        	} while (true);

                    		        	loop45:
                    		        		;	// Stops C# compiler whining that label 'loop45' has no statements


                    		        }
                    		        break;

                    		}


                    	}

                    	char_literal160=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1852); 
                    		char_literal160_tree = (object)adaptor.Create(char_literal160);
                    		adaptor.AddChild(root_0, char_literal160_tree);

                    	char_literal161=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1854); 
                    		char_literal161_tree = (object)adaptor.Create(char_literal161);
                    		adaptor.AddChild(root_0, char_literal161_tree);

                    	// spinach.g:307:5: ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | comment | parallelfor | forstatement )+ )?
                    	int alt48 = 2;
                    	int LA48_0 = input.LA(1);

                    	if ( (LA48_0 == VARIABLE || LA48_0 == VARTYPE || LA48_0 == STRINGTYPE || LA48_0 == 28 || LA48_0 == 32 || (LA48_0 >= 35 && LA48_0 <= 37) || LA48_0 == 40 || LA48_0 == 42 || LA48_0 == 46 || LA48_0 == 56) )
                    	{
                    	    alt48 = 1;
                    	}
                    	switch (alt48) 
                    	{
                    	    case 1 :
                    	        // spinach.g:307:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | comment | parallelfor | forstatement )+
                    	        {
                    	        	// spinach.g:307:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | comment | parallelfor | forstatement )+
                    	        	int cnt47 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt47 = 13;
                    	        	    alt47 = dfa47.Predict(input);
                    	        	    switch (alt47) 
                    	        		{
                    	        			case 1 :
                    	        			    // spinach.g:307:7: assignment
                    	        			    {
                    	        			    	PushFollow(FOLLOW_assignment_in_functiondefination1858);
                    	        			    	assignment162 = assignment();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, assignment162.Tree);
                    	        			    	retval.ret.setBody(((assignment162 != null) ? assignment162.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 2 :
                    	        			    // spinach.g:307:56: functioncall
                    	        			    {
                    	        			    	PushFollow(FOLLOW_functioncall_in_functiondefination1861);
                    	        			    	functioncall163 = functioncall();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, functioncall163.Tree);
                    	        			    	retval.ret.setBody(((functioncall163 != null) ? functioncall163.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 3 :
                    	        			    // spinach.g:307:110: scalarvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1865);
                    	        			    	scalarvardec164 = scalarvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, scalarvardec164.Tree);
                    	        			    	 retval.ret.setBody(((scalarvardec164 != null) ? scalarvardec164.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 4 :
                    	        			    // spinach.g:308:5: vectorvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1873);
                    	        			    	vectorvardec165 = vectorvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, vectorvardec165.Tree);
                    	        			    	 retval.ret.setBody(((vectorvardec165 != null) ? vectorvardec165.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 5 :
                    	        			    // spinach.g:309:5: matrixvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1881);
                    	        			    	matrixvardec166 = matrixvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, matrixvardec166.Tree);
                    	        			    	 retval.ret.setBody(((matrixvardec166 != null) ? matrixvardec166.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 6 :
                    	        			    // spinach.g:310:5: deletionofvar
                    	        			    {
                    	        			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1889);
                    	        			    	deletionofvar167 = deletionofvar();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, deletionofvar167.Tree);
                    	        			    	 retval.ret.setBody(((deletionofvar167 != null) ? deletionofvar167.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 7 :
                    	        			    // spinach.g:310:64: print
                    	        			    {
                    	        			    	PushFollow(FOLLOW_print_in_functiondefination1895);
                    	        			    	print168 = print();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, print168.Tree);
                    	        			    	 retval.ret.setBody(((print168 != null) ? print168.ret : null)); 

                    	        			    }
                    	        			    break;
                    	        			case 8 :
                    	        			    // spinach.g:311:5: ifelse
                    	        			    {
                    	        			    	PushFollow(FOLLOW_ifelse_in_functiondefination1903);
                    	        			    	ifelse169 = ifelse();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, ifelse169.Tree);
                    	        			    	retval.ret.setBody(((ifelse169 != null) ? ifelse169.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 9 :
                    	        			    // spinach.g:311:47: functionreturn
                    	        			    {
                    	        			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1907);
                    	        			    	functionreturn170 = functionreturn();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, functionreturn170.Tree);
                    	        			    	retval.ret.setBody(((functionreturn170 != null) ? functionreturn170.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 10 :
                    	        			    // spinach.g:311:104: comment
                    	        			    {
                    	        			    	PushFollow(FOLLOW_comment_in_functiondefination1910);
                    	        			    	comment171 = comment();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, comment171.Tree);

                    	        			    }
                    	        			    break;
                    	        			case 11 :
                    	        			    // spinach.g:311:113: parallelfor
                    	        			    {
                    	        			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1913);
                    	        			    	parallelfor172 = parallelfor();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, parallelfor172.Tree);
                    	        			    	retval.ret.setBody(((parallelfor172 != null) ? parallelfor172.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 12 :
                    	        			    // spinach.g:311:165: forstatement
                    	        			    {
                    	        			    	PushFollow(FOLLOW_forstatement_in_functiondefination1917);
                    	        			    	forstatement173 = forstatement();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, forstatement173.Tree);
                    	        			    	retval.ret.setBody(((forstatement173 != null) ? forstatement173.ret : null));

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    if ( cnt47 >= 1 ) goto loop47;
                    	        		            EarlyExitException eee47 =
                    	        		                new EarlyExitException(47, input);
                    	        		            throw eee47;
                    	        	    }
                    	        	    cnt47++;
                    	        	} while (true);

                    	        	loop47:
                    	        		;	// Stops C# compiler whining that label 'loop47' has no statements


                    	        }
                    	        break;

                    	}

                    	char_literal174=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1924); 
                    		char_literal174_tree = (object)adaptor.Create(char_literal174);
                    		adaptor.AddChild(root_0, char_literal174_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functiondefination"

    public class dotproduct_return : ParserRuleReturnScope
    {
        public DotProductElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dotproduct"
    // spinach.g:316:1: dotproduct returns [DotProductElement ret] : e11= variable 'DOT' e12= variable ;
    public spinachParser.dotproduct_return dotproduct() // throws RecognitionException [1]
    {   
        spinachParser.dotproduct_return retval = new spinachParser.dotproduct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal175 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.variable_return e12 = null;


        object string_literal175_tree=null;


        retval.ret = new DotProductElement ();

        try 
    	{
            // spinach.g:320:1: (e11= variable 'DOT' e12= variable )
            // spinach.g:320:3: e11= variable 'DOT' e12= variable
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_dotproduct1946);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLhs(((e11 != null) ? e11.ret : null)); 
            	string_literal175=(IToken)Match(input,44,FOLLOW_44_in_dotproduct1950); 
            		string_literal175_tree = (object)adaptor.Create(string_literal175);
            		adaptor.AddChild(root_0, string_literal175_tree);

            	PushFollow(FOLLOW_variable_in_dotproduct1956);
            	e12 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.setRhs(((e12 != null) ? e12.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "dotproduct"

    public class matrixtranspose_return : ParserRuleReturnScope
    {
        public MatrixTranspose ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixtranspose"
    // spinach.g:322:1: matrixtranspose returns [MatrixTranspose ret] : 'T' LEFTBRACE variable ')' ;
    public spinachParser.matrixtranspose_return matrixtranspose() // throws RecognitionException [1]
    {   
        spinachParser.matrixtranspose_return retval = new spinachParser.matrixtranspose_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal176 = null;
        IToken LEFTBRACE177 = null;
        IToken char_literal179 = null;
        spinachParser.variable_return variable178 = null;


        object char_literal176_tree=null;
        object LEFTBRACE177_tree=null;
        object char_literal179_tree=null;


        retval.ret = new MatrixTranspose();

        try 
    	{
            // spinach.g:327:1: ( 'T' LEFTBRACE variable ')' )
            // spinach.g:327:3: 'T' LEFTBRACE variable ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal176=(IToken)Match(input,45,FOLLOW_45_in_matrixtranspose1975); 
            		char_literal176_tree = (object)adaptor.Create(char_literal176);
            		adaptor.AddChild(root_0, char_literal176_tree);

            	LEFTBRACE177=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_matrixtranspose1977); 
            		LEFTBRACE177_tree = (object)adaptor.Create(LEFTBRACE177);
            		adaptor.AddChild(root_0, LEFTBRACE177_tree);

            	PushFollow(FOLLOW_variable_in_matrixtranspose1979);
            	variable178 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable178.Tree);
            	retval.ret.setvariable(((variable178 != null) ? variable178.ret : null)); 
            	char_literal179=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_matrixtranspose1982); 
            		char_literal179_tree = (object)adaptor.Create(char_literal179);
            		adaptor.AddChild(root_0, char_literal179_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matrixtranspose"

    public class matrixreference_return : ParserRuleReturnScope
    {
        public MatrixReference ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixreference"
    // spinach.g:330:1: matrixreference returns [MatrixReference ret] : 'matrix' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.matrixreference_return matrixreference() // throws RecognitionException [1]
    {   
        spinachParser.matrixreference_return retval = new spinachParser.matrixreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal180 = null;
        IToken char_literal181 = null;
        IToken char_literal182 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal180_tree=null;
        object char_literal181_tree=null;
        object char_literal182_tree=null;

         retval.ret = new MatrixReference();

        try 
    	{
            // spinach.g:333:1: ( 'matrix' '<' (el1= VARTYPE '>' el2= variable ) )
            // spinach.g:333:2: 'matrix' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal180=(IToken)Match(input,28,FOLLOW_28_in_matrixreference1998); 
            		string_literal180_tree = (object)adaptor.Create(string_literal180);
            		adaptor.AddChild(root_0, string_literal180_tree);

            	char_literal181=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixreference2000); 
            		char_literal181_tree = (object)adaptor.Create(char_literal181);
            		adaptor.AddChild(root_0, char_literal181_tree);

            	// spinach.g:333:15: (el1= VARTYPE '>' el2= variable )
            	// spinach.g:333:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixreference2005); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal182=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixreference2007); 
            			char_literal182_tree = (object)adaptor.Create(char_literal182);
            			adaptor.AddChild(root_0, char_literal182_tree);

            		PushFollow(FOLLOW_variable_in_matrixreference2011);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setvariable(((el2 != null) ? el2.ret : null));

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matrixreference"

    public class vectorreference_return : ParserRuleReturnScope
    {
        public VectorReference ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "vectorreference"
    // spinach.g:336:1: vectorreference returns [VectorReference ret] : 'vector' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.vectorreference_return vectorreference() // throws RecognitionException [1]
    {   
        spinachParser.vectorreference_return retval = new spinachParser.vectorreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal183 = null;
        IToken char_literal184 = null;
        IToken char_literal185 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal183_tree=null;
        object char_literal184_tree=null;
        object char_literal185_tree=null;

         retval.ret = new VectorReference();

        try 
    	{
            // spinach.g:339:1: ( 'vector' '<' (el1= VARTYPE '>' el2= variable ) )
            // spinach.g:339:2: 'vector' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal183=(IToken)Match(input,32,FOLLOW_32_in_vectorreference2030); 
            		string_literal183_tree = (object)adaptor.Create(string_literal183);
            		adaptor.AddChild(root_0, string_literal183_tree);

            	char_literal184=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorreference2032); 
            		char_literal184_tree = (object)adaptor.Create(char_literal184);
            		adaptor.AddChild(root_0, char_literal184_tree);

            	// spinach.g:339:15: (el1= VARTYPE '>' el2= variable )
            	// spinach.g:339:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorreference2037); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal185=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2039); 
            			char_literal185_tree = (object)adaptor.Create(char_literal185);
            			adaptor.AddChild(root_0, char_literal185_tree);

            		PushFollow(FOLLOW_variable_in_vectorreference2043);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setvariable(((el2 != null) ? el2.ret : null));

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "vectorreference"

    public class arguments_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arguments"
    // spinach.g:341:1: arguments returns [Element ret] : ( scalarargument | matrixreference | vectorreference ) ;
    public spinachParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        spinachParser.arguments_return retval = new spinachParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.scalarargument_return scalarargument186 = null;

        spinachParser.matrixreference_return matrixreference187 = null;

        spinachParser.vectorreference_return vectorreference188 = null;



        try 
    	{
            // spinach.g:342:1: ( ( scalarargument | matrixreference | vectorreference ) )
            // spinach.g:342:3: ( scalarargument | matrixreference | vectorreference )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:342:3: ( scalarargument | matrixreference | vectorreference )
            	int alt50 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARTYPE:
            		{
            	    alt50 = 1;
            	    }
            	    break;
            	case 28:
            		{
            	    alt50 = 2;
            	    }
            	    break;
            	case 32:
            		{
            	    alt50 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d50s0 =
            		        new NoViableAltException("", 50, 0, input);

            		    throw nvae_d50s0;
            	}

            	switch (alt50) 
            	{
            	    case 1 :
            	        // spinach.g:342:4: scalarargument
            	        {
            	        	PushFollow(FOLLOW_scalarargument_in_arguments2059);
            	        	scalarargument186 = scalarargument();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, scalarargument186.Tree);
            	        	 retval.ret = ((scalarargument186 != null) ? scalarargument186.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:343:3: matrixreference
            	        {
            	        	PushFollow(FOLLOW_matrixreference_in_arguments2065);
            	        	matrixreference187 = matrixreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixreference187.Tree);
            	        	retval.ret = ((matrixreference187 != null) ? matrixreference187.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:344:3: vectorreference
            	        {
            	        	PushFollow(FOLLOW_vectorreference_in_arguments2071);
            	        	vectorreference188 = vectorreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorreference188.Tree);
            	        	retval.ret = ((vectorreference188 != null) ? vectorreference188.ret : null);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class scalarargument_return : ParserRuleReturnScope
    {
        public ScalarArgument ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "scalarargument"
    // spinach.g:347:1: scalarargument returns [ScalarArgument ret] : ( (e11= VARTYPE ) e12= variable ) ;
    public spinachParser.scalarargument_return scalarargument() // throws RecognitionException [1]
    {   
        spinachParser.scalarargument_return retval = new spinachParser.scalarargument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken e11 = null;
        spinachParser.variable_return e12 = null;


        object e11_tree=null;

        retval.ret = new ScalarArgument();

        try 
    	{
            // spinach.g:349:2: ( ( (e11= VARTYPE ) e12= variable ) )
            // spinach.g:350:1: ( (e11= VARTYPE ) e12= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:350:1: ( (e11= VARTYPE ) e12= variable )
            	// spinach.g:350:2: (e11= VARTYPE ) e12= variable
            	{
            		// spinach.g:350:2: (e11= VARTYPE )
            		// spinach.g:350:3: e11= VARTYPE
            		{
            			e11=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarargument2095); 
            				e11_tree = (object)adaptor.Create(e11);
            				adaptor.AddChild(root_0, e11_tree);

            			retval.ret.settype(((e11 != null) ? e11.Text : null));

            		}

            		PushFollow(FOLLOW_variable_in_scalarargument2102);
            		e12 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, e12.Tree);
            		retval.ret.setvariable(((e12 != null) ? e12.ret : null)); 

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "scalarargument"

    public class functionreturn_return : ParserRuleReturnScope
    {
        public ReturnElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionreturn"
    // spinach.g:355:1: functionreturn returns [ReturnElement ret] : 'return' ( var_int_or_double_literal ) END_OF_STATEMENT ;
    public spinachParser.functionreturn_return functionreturn() // throws RecognitionException [1]
    {   
        spinachParser.functionreturn_return retval = new spinachParser.functionreturn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal189 = null;
        IToken END_OF_STATEMENT191 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal190 = null;


        object string_literal189_tree=null;
        object END_OF_STATEMENT191_tree=null;


        retval.ret = new ReturnElement();

        try 
    	{
            // spinach.g:359:1: ( 'return' ( var_int_or_double_literal ) END_OF_STATEMENT )
            // spinach.g:359:2: 'return' ( var_int_or_double_literal ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal189=(IToken)Match(input,46,FOLLOW_46_in_functionreturn2122); 
            		string_literal189_tree = (object)adaptor.Create(string_literal189);
            		adaptor.AddChild(root_0, string_literal189_tree);

            	// spinach.g:359:11: ( var_int_or_double_literal )
            	// spinach.g:359:12: var_int_or_double_literal
            	{
            		PushFollow(FOLLOW_var_int_or_double_literal_in_functionreturn2125);
            		var_int_or_double_literal190 = var_int_or_double_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, var_int_or_double_literal190.Tree);
            		retval.ret.setreturnvariable(((var_int_or_double_literal190 != null) ? var_int_or_double_literal190.ret : null));

            	}

            	END_OF_STATEMENT191=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functionreturn2129); 
            		END_OF_STATEMENT191_tree = (object)adaptor.Create(END_OF_STATEMENT191);
            		adaptor.AddChild(root_0, END_OF_STATEMENT191_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionreturn"

    public class plotfunctions_return : ParserRuleReturnScope
    {
        public PlotFunctionElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "plotfunctions"
    // spinach.g:362:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | 'setPlotAxis' '(' e112= double_literal ( ')' END_OF_STATEMENT | ',' e113= double_literal ( ')' END_OF_STATEMENT | ',' e114= double_literal ')' END_OF_STATEMENT ) ) | 'setAxisTitle' '(' v112= string_literal ( ')' END_OF_STATEMENT | ',' v113= string_literal ( ')' END_OF_STATEMENT | ',' v114= string_literal ')' END_OF_STATEMENT ) ) | ( 'setScaleMode(' SCALEMODE ')' END_OF_STATEMENT ) );
    public spinachParser.plotfunctions_return plotfunctions() // throws RecognitionException [1]
    {   
        spinachParser.plotfunctions_return retval = new spinachParser.plotfunctions_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal192 = null;
        IToken char_literal193 = null;
        IToken char_literal194 = null;
        IToken char_literal195 = null;
        IToken char_literal196 = null;
        IToken string_literal197 = null;
        IToken string_literal198 = null;
        IToken string_literal199 = null;
        IToken char_literal200 = null;
        IToken char_literal201 = null;
        IToken END_OF_STATEMENT202 = null;
        IToken string_literal203 = null;
        IToken char_literal204 = null;
        IToken char_literal205 = null;
        IToken char_literal206 = null;
        IToken string_literal207 = null;
        IToken string_literal208 = null;
        IToken string_literal209 = null;
        IToken char_literal210 = null;
        IToken char_literal211 = null;
        IToken END_OF_STATEMENT212 = null;
        IToken string_literal213 = null;
        IToken char_literal214 = null;
        IToken char_literal215 = null;
        IToken END_OF_STATEMENT216 = null;
        IToken string_literal217 = null;
        IToken char_literal218 = null;
        IToken char_literal219 = null;
        IToken END_OF_STATEMENT220 = null;
        IToken char_literal221 = null;
        IToken char_literal222 = null;
        IToken END_OF_STATEMENT223 = null;
        IToken char_literal224 = null;
        IToken char_literal225 = null;
        IToken END_OF_STATEMENT226 = null;
        IToken string_literal227 = null;
        IToken char_literal228 = null;
        IToken char_literal229 = null;
        IToken END_OF_STATEMENT230 = null;
        IToken char_literal231 = null;
        IToken char_literal232 = null;
        IToken END_OF_STATEMENT233 = null;
        IToken char_literal234 = null;
        IToken char_literal235 = null;
        IToken END_OF_STATEMENT236 = null;
        IToken string_literal237 = null;
        IToken SCALEMODE238 = null;
        IToken char_literal239 = null;
        IToken END_OF_STATEMENT240 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.variable_return vll1 = null;

        spinachParser.string_literal_return vll2 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.variable_return vll3 = null;

        spinachParser.string_literal_return vll4 = null;

        spinachParser.double_literal_return e112 = null;

        spinachParser.double_literal_return e113 = null;

        spinachParser.double_literal_return e114 = null;

        spinachParser.string_literal_return v112 = null;

        spinachParser.string_literal_return v113 = null;

        spinachParser.string_literal_return v114 = null;


        object string_literal192_tree=null;
        object char_literal193_tree=null;
        object char_literal194_tree=null;
        object char_literal195_tree=null;
        object char_literal196_tree=null;
        object string_literal197_tree=null;
        object string_literal198_tree=null;
        object string_literal199_tree=null;
        object char_literal200_tree=null;
        object char_literal201_tree=null;
        object END_OF_STATEMENT202_tree=null;
        object string_literal203_tree=null;
        object char_literal204_tree=null;
        object char_literal205_tree=null;
        object char_literal206_tree=null;
        object string_literal207_tree=null;
        object string_literal208_tree=null;
        object string_literal209_tree=null;
        object char_literal210_tree=null;
        object char_literal211_tree=null;
        object END_OF_STATEMENT212_tree=null;
        object string_literal213_tree=null;
        object char_literal214_tree=null;
        object char_literal215_tree=null;
        object END_OF_STATEMENT216_tree=null;
        object string_literal217_tree=null;
        object char_literal218_tree=null;
        object char_literal219_tree=null;
        object END_OF_STATEMENT220_tree=null;
        object char_literal221_tree=null;
        object char_literal222_tree=null;
        object END_OF_STATEMENT223_tree=null;
        object char_literal224_tree=null;
        object char_literal225_tree=null;
        object END_OF_STATEMENT226_tree=null;
        object string_literal227_tree=null;
        object char_literal228_tree=null;
        object char_literal229_tree=null;
        object END_OF_STATEMENT230_tree=null;
        object char_literal231_tree=null;
        object char_literal232_tree=null;
        object END_OF_STATEMENT233_tree=null;
        object char_literal234_tree=null;
        object char_literal235_tree=null;
        object END_OF_STATEMENT236_tree=null;
        object string_literal237_tree=null;
        object SCALEMODE238_tree=null;
        object char_literal239_tree=null;
        object END_OF_STATEMENT240_tree=null;

         retval.ret = new PlotFunctionElement();

        try 
    	{
            // spinach.g:365:1: ( ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | 'setPlotAxis' '(' e112= double_literal ( ')' END_OF_STATEMENT | ',' e113= double_literal ( ')' END_OF_STATEMENT | ',' e114= double_literal ')' END_OF_STATEMENT ) ) | 'setAxisTitle' '(' v112= string_literal ( ')' END_OF_STATEMENT | ',' v113= string_literal ( ')' END_OF_STATEMENT | ',' v114= string_literal ')' END_OF_STATEMENT ) ) | ( 'setScaleMode(' SCALEMODE ')' END_OF_STATEMENT ) )
            int alt59 = 6;
            switch ( input.LA(1) ) 
            {
            case 47:
            	{
                alt59 = 1;
                }
                break;
            case 51:
            	{
                alt59 = 2;
                }
                break;
            case 52:
            	{
                alt59 = 3;
                }
                break;
            case 53:
            	{
                alt59 = 4;
                }
                break;
            case 54:
            	{
                alt59 = 5;
                }
                break;
            case 55:
            	{
                alt59 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d59s0 =
            	        new NoViableAltException("", 59, 0, input);

            	    throw nvae_d59s0;
            }

            switch (alt59) 
            {
                case 1 :
                    // spinach.g:366:2: ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:366:2: ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:366:3: 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal192=(IToken)Match(input,47,FOLLOW_47_in_plotfunctions2150); 
                    			string_literal192_tree = (object)adaptor.Create(string_literal192);
                    			adaptor.AddChild(root_0, string_literal192_tree);

                    		retval.ret.setPlotFunction("subPlot");
                    		char_literal193=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2153); 
                    			char_literal193_tree = (object)adaptor.Create(char_literal193);
                    			adaptor.AddChild(root_0, char_literal193_tree);

                    		// spinach.g:367:1: (el1= int_literal )
                    		// spinach.g:367:2: el1= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2160);
                    			el1 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el1.Tree);
                    			retval.ret.setPeno(((el1 != null) ? el1.ret : null));

                    		}

                    		char_literal194=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2165); 
                    			char_literal194_tree = (object)adaptor.Create(char_literal194);
                    			adaptor.AddChild(root_0, char_literal194_tree);

                    		// spinach.g:368:1: (vll1= variable )
                    		// spinach.g:368:2: vll1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2172);
                    			vll1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll1.Tree);
                    			retval.ret.setData(((vll1 != null) ? vll1.ret : null));

                    		}

                    		char_literal195=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2177); 
                    			char_literal195_tree = (object)adaptor.Create(char_literal195);
                    			adaptor.AddChild(root_0, char_literal195_tree);

                    		// spinach.g:369:1: (vll2= string_literal )
                    		// spinach.g:369:2: vll2= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2184);
                    			vll2 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll2.Tree);
                    			retval.ret.setTitle(((vll2 != null) ? vll2.ret : null));

                    		}

                    		char_literal196=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2188); 
                    			char_literal196_tree = (object)adaptor.Create(char_literal196);
                    			adaptor.AddChild(root_0, char_literal196_tree);

                    		// spinach.g:370:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt52 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 48:
                    			{
                    		    alt52 = 1;
                    		    }
                    		    break;
                    		case 49:
                    			{
                    		    alt52 = 2;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt52 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d52s0 =
                    			        new NoViableAltException("", 52, 0, input);

                    			    throw nvae_d52s0;
                    		}

                    		switch (alt52) 
                    		{
                    		    case 1 :
                    		        // spinach.g:370:2: ( '1D' )
                    		        {
                    		        	// spinach.g:370:2: ( '1D' )
                    		        	// spinach.g:370:3: '1D'
                    		        	{
                    		        		string_literal197=(IToken)Match(input,48,FOLLOW_48_in_plotfunctions2192); 
                    		        			string_literal197_tree = (object)adaptor.Create(string_literal197);
                    		        			adaptor.AddChild(root_0, string_literal197_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // spinach.g:370:40: ( '2D' )
                    		        {
                    		        	// spinach.g:370:40: ( '2D' )
                    		        	// spinach.g:370:41: '2D'
                    		        	{
                    		        		string_literal198=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2197); 
                    		        			string_literal198_tree = (object)adaptor.Create(string_literal198);
                    		        			adaptor.AddChild(root_0, string_literal198_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // spinach.g:370:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// spinach.g:370:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// spinach.g:370:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal199=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2202); 
                    		        			string_literal199_tree = (object)adaptor.Create(string_literal199);
                    		        			adaptor.AddChild(root_0, string_literal199_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// spinach.g:370:114: ( ',' (el3= int_literal ) )?
                    		        		int alt51 = 2;
                    		        		int LA51_0 = input.LA(1);

                    		        		if ( (LA51_0 == 31) )
                    		        		{
                    		        		    alt51 = 1;
                    		        		}
                    		        		switch (alt51) 
                    		        		{
                    		        		    case 1 :
                    		        		        // spinach.g:370:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal200=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2205); 
                    		        		        		char_literal200_tree = (object)adaptor.Create(char_literal200);
                    		        		        		adaptor.AddChild(root_0, char_literal200_tree);

                    		        		        	// spinach.g:370:118: (el3= int_literal )
                    		        		        	// spinach.g:370:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2211);
                    		        		        		el3 = int_literal();
                    		        		        		state.followingStackPointer--;

                    		        		        		adaptor.AddChild(root_0, el3.Tree);
                    		        		        		retval.ret.setMode(((el3 != null) ? el3.ret : null));

                    		        		        	}


                    		        		        }
                    		        		        break;

                    		        		}


                    		        	}


                    		        }
                    		        break;

                    		}

                    		char_literal201=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2219); 
                    			char_literal201_tree = (object)adaptor.Create(char_literal201);
                    			adaptor.AddChild(root_0, char_literal201_tree);

                    		END_OF_STATEMENT202=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2220); 
                    			END_OF_STATEMENT202_tree = (object)adaptor.Create(END_OF_STATEMENT202);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT202_tree);


                    	}


                    }
                    break;
                case 2 :
                    // spinach.g:372:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:372:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:372:4: 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal203=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2226); 
                    			string_literal203_tree = (object)adaptor.Create(string_literal203);
                    			adaptor.AddChild(root_0, string_literal203_tree);

                    		retval.ret.setPlotFunction("plot");
                    		char_literal204=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2229); 
                    			char_literal204_tree = (object)adaptor.Create(char_literal204);
                    			adaptor.AddChild(root_0, char_literal204_tree);

                    		// spinach.g:373:1: (vll3= variable )
                    		// spinach.g:373:2: vll3= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2235);
                    			vll3 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll3.Tree);
                    			retval.ret.setData(((vll3 != null) ? vll3.ret : null));

                    		}

                    		char_literal205=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2240); 
                    			char_literal205_tree = (object)adaptor.Create(char_literal205);
                    			adaptor.AddChild(root_0, char_literal205_tree);

                    		// spinach.g:374:1: (vll4= string_literal )
                    		// spinach.g:374:2: vll4= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2246);
                    			vll4 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll4.Tree);
                    			retval.ret.setTitle(((vll4 != null) ? vll4.ret : null));

                    		}

                    		char_literal206=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2250); 
                    			char_literal206_tree = (object)adaptor.Create(char_literal206);
                    			adaptor.AddChild(root_0, char_literal206_tree);

                    		// spinach.g:375:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt54 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 48:
                    			{
                    		    alt54 = 1;
                    		    }
                    		    break;
                    		case 49:
                    			{
                    		    alt54 = 2;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt54 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d54s0 =
                    			        new NoViableAltException("", 54, 0, input);

                    			    throw nvae_d54s0;
                    		}

                    		switch (alt54) 
                    		{
                    		    case 1 :
                    		        // spinach.g:375:2: ( '1D' )
                    		        {
                    		        	// spinach.g:375:2: ( '1D' )
                    		        	// spinach.g:375:3: '1D'
                    		        	{
                    		        		string_literal207=(IToken)Match(input,48,FOLLOW_48_in_plotfunctions2254); 
                    		        			string_literal207_tree = (object)adaptor.Create(string_literal207);
                    		        			adaptor.AddChild(root_0, string_literal207_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // spinach.g:375:40: ( '2D' )
                    		        {
                    		        	// spinach.g:375:40: ( '2D' )
                    		        	// spinach.g:375:41: '2D'
                    		        	{
                    		        		string_literal208=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2259); 
                    		        			string_literal208_tree = (object)adaptor.Create(string_literal208);
                    		        			adaptor.AddChild(root_0, string_literal208_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // spinach.g:375:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// spinach.g:375:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// spinach.g:375:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal209=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2264); 
                    		        			string_literal209_tree = (object)adaptor.Create(string_literal209);
                    		        			adaptor.AddChild(root_0, string_literal209_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// spinach.g:375:114: ( ',' (el3= int_literal ) )?
                    		        		int alt53 = 2;
                    		        		int LA53_0 = input.LA(1);

                    		        		if ( (LA53_0 == 31) )
                    		        		{
                    		        		    alt53 = 1;
                    		        		}
                    		        		switch (alt53) 
                    		        		{
                    		        		    case 1 :
                    		        		        // spinach.g:375:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal210=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2267); 
                    		        		        		char_literal210_tree = (object)adaptor.Create(char_literal210);
                    		        		        		adaptor.AddChild(root_0, char_literal210_tree);

                    		        		        	// spinach.g:375:118: (el3= int_literal )
                    		        		        	// spinach.g:375:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2273);
                    		        		        		el3 = int_literal();
                    		        		        		state.followingStackPointer--;

                    		        		        		adaptor.AddChild(root_0, el3.Tree);
                    		        		        		retval.ret.setMode(((el3 != null) ? el3.ret : null));

                    		        		        	}


                    		        		        }
                    		        		        break;

                    		        		}


                    		        	}


                    		        }
                    		        break;

                    		}

                    		char_literal211=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2281); 
                    			char_literal211_tree = (object)adaptor.Create(char_literal211);
                    			adaptor.AddChild(root_0, char_literal211_tree);

                    		END_OF_STATEMENT212=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2282); 
                    			END_OF_STATEMENT212_tree = (object)adaptor.Create(END_OF_STATEMENT212);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT212_tree);


                    	}


                    }
                    break;
                case 3 :
                    // spinach.g:377:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:377:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    	// spinach.g:377:4: 'resetPlot' '(' ')' END_OF_STATEMENT
                    	{
                    		string_literal213=(IToken)Match(input,52,FOLLOW_52_in_plotfunctions2288); 
                    			string_literal213_tree = (object)adaptor.Create(string_literal213);
                    			adaptor.AddChild(root_0, string_literal213_tree);

                    		char_literal214=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2289); 
                    			char_literal214_tree = (object)adaptor.Create(char_literal214);
                    			adaptor.AddChild(root_0, char_literal214_tree);

                    		char_literal215=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2290); 
                    			char_literal215_tree = (object)adaptor.Create(char_literal215);
                    			adaptor.AddChild(root_0, char_literal215_tree);

                    		retval.ret.setPlotFunction("resetPlot");
                    		END_OF_STATEMENT216=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2292); 
                    			END_OF_STATEMENT216_tree = (object)adaptor.Create(END_OF_STATEMENT216);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT216_tree);


                    	}


                    }
                    break;
                case 4 :
                    // spinach.g:378:2: 'setPlotAxis' '(' e112= double_literal ( ')' END_OF_STATEMENT | ',' e113= double_literal ( ')' END_OF_STATEMENT | ',' e114= double_literal ')' END_OF_STATEMENT ) )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal217=(IToken)Match(input,53,FOLLOW_53_in_plotfunctions2296); 
                    		string_literal217_tree = (object)adaptor.Create(string_literal217);
                    		adaptor.AddChild(root_0, string_literal217_tree);

                    	retval.ret.setPlotFunction("setPlotAxis");
                    	char_literal218=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2300); 
                    		char_literal218_tree = (object)adaptor.Create(char_literal218);
                    		adaptor.AddChild(root_0, char_literal218_tree);

                    	PushFollow(FOLLOW_double_literal_in_plotfunctions2307);
                    	e112 = double_literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, e112.Tree);
                    	retval.ret.setXFact(((e112 != null) ? e112.ret : null));
                    	// spinach.g:380:2: ( ')' END_OF_STATEMENT | ',' e113= double_literal ( ')' END_OF_STATEMENT | ',' e114= double_literal ')' END_OF_STATEMENT ) )
                    	int alt56 = 2;
                    	int LA56_0 = input.LA(1);

                    	if ( (LA56_0 == RIGHTBRACE) )
                    	{
                    	    alt56 = 1;
                    	}
                    	else if ( (LA56_0 == 31) )
                    	{
                    	    alt56 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d56s0 =
                    	        new NoViableAltException("", 56, 0, input);

                    	    throw nvae_d56s0;
                    	}
                    	switch (alt56) 
                    	{
                    	    case 1 :
                    	        // spinach.g:380:3: ')' END_OF_STATEMENT
                    	        {
                    	        	char_literal219=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2312); 
                    	        		char_literal219_tree = (object)adaptor.Create(char_literal219);
                    	        		adaptor.AddChild(root_0, char_literal219_tree);

                    	        	END_OF_STATEMENT220=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2314); 
                    	        		END_OF_STATEMENT220_tree = (object)adaptor.Create(END_OF_STATEMENT220);
                    	        		adaptor.AddChild(root_0, END_OF_STATEMENT220_tree);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // spinach.g:380:24: ',' e113= double_literal ( ')' END_OF_STATEMENT | ',' e114= double_literal ')' END_OF_STATEMENT )
                    	        {
                    	        	char_literal221=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2316); 
                    	        		char_literal221_tree = (object)adaptor.Create(char_literal221);
                    	        		adaptor.AddChild(root_0, char_literal221_tree);

                    	        	PushFollow(FOLLOW_double_literal_in_plotfunctions2321);
                    	        	e113 = double_literal();
                    	        	state.followingStackPointer--;

                    	        	adaptor.AddChild(root_0, e113.Tree);
                    	        	retval.ret.setYFact(((e113 != null) ? e113.ret : null));
                    	        	// spinach.g:380:81: ( ')' END_OF_STATEMENT | ',' e114= double_literal ')' END_OF_STATEMENT )
                    	        	int alt55 = 2;
                    	        	int LA55_0 = input.LA(1);

                    	        	if ( (LA55_0 == RIGHTBRACE) )
                    	        	{
                    	        	    alt55 = 1;
                    	        	}
                    	        	else if ( (LA55_0 == 31) )
                    	        	{
                    	        	    alt55 = 2;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    NoViableAltException nvae_d55s0 =
                    	        	        new NoViableAltException("", 55, 0, input);

                    	        	    throw nvae_d55s0;
                    	        	}
                    	        	switch (alt55) 
                    	        	{
                    	        	    case 1 :
                    	        	        // spinach.g:380:82: ')' END_OF_STATEMENT
                    	        	        {
                    	        	        	char_literal222=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2324); 
                    	        	        		char_literal222_tree = (object)adaptor.Create(char_literal222);
                    	        	        		adaptor.AddChild(root_0, char_literal222_tree);

                    	        	        	END_OF_STATEMENT223=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2325); 
                    	        	        		END_OF_STATEMENT223_tree = (object)adaptor.Create(END_OF_STATEMENT223);
                    	        	        		adaptor.AddChild(root_0, END_OF_STATEMENT223_tree);


                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // spinach.g:380:102: ',' e114= double_literal ')' END_OF_STATEMENT
                    	        	        {
                    	        	        	char_literal224=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2327); 
                    	        	        		char_literal224_tree = (object)adaptor.Create(char_literal224);
                    	        	        		adaptor.AddChild(root_0, char_literal224_tree);

                    	        	        	PushFollow(FOLLOW_double_literal_in_plotfunctions2332);
                    	        	        	e114 = double_literal();
                    	        	        	state.followingStackPointer--;

                    	        	        	adaptor.AddChild(root_0, e114.Tree);
                    	        	        	retval.ret.setZFact(((e114 != null) ? e114.ret : null));
                    	        	        	char_literal225=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2335); 
                    	        	        		char_literal225_tree = (object)adaptor.Create(char_literal225);
                    	        	        		adaptor.AddChild(root_0, char_literal225_tree);

                    	        	        	END_OF_STATEMENT226=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2337); 
                    	        	        		END_OF_STATEMENT226_tree = (object)adaptor.Create(END_OF_STATEMENT226);
                    	        	        		adaptor.AddChild(root_0, END_OF_STATEMENT226_tree);


                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 5 :
                    // spinach.g:381:2: 'setAxisTitle' '(' v112= string_literal ( ')' END_OF_STATEMENT | ',' v113= string_literal ( ')' END_OF_STATEMENT | ',' v114= string_literal ')' END_OF_STATEMENT ) )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal227=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2342); 
                    		string_literal227_tree = (object)adaptor.Create(string_literal227);
                    		adaptor.AddChild(root_0, string_literal227_tree);

                    	retval.ret.setPlotFunction("setAxisTitle");
                    	char_literal228=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2346); 
                    		char_literal228_tree = (object)adaptor.Create(char_literal228);
                    		adaptor.AddChild(root_0, char_literal228_tree);

                    	PushFollow(FOLLOW_string_literal_in_plotfunctions2353);
                    	v112 = string_literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, v112.Tree);
                    	retval.ret.setXTitle(((v112 != null) ? v112.ret : null));
                    	// spinach.g:383:2: ( ')' END_OF_STATEMENT | ',' v113= string_literal ( ')' END_OF_STATEMENT | ',' v114= string_literal ')' END_OF_STATEMENT ) )
                    	int alt58 = 2;
                    	int LA58_0 = input.LA(1);

                    	if ( (LA58_0 == RIGHTBRACE) )
                    	{
                    	    alt58 = 1;
                    	}
                    	else if ( (LA58_0 == 31) )
                    	{
                    	    alt58 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d58s0 =
                    	        new NoViableAltException("", 58, 0, input);

                    	    throw nvae_d58s0;
                    	}
                    	switch (alt58) 
                    	{
                    	    case 1 :
                    	        // spinach.g:383:3: ')' END_OF_STATEMENT
                    	        {
                    	        	char_literal229=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2358); 
                    	        		char_literal229_tree = (object)adaptor.Create(char_literal229);
                    	        		adaptor.AddChild(root_0, char_literal229_tree);

                    	        	END_OF_STATEMENT230=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2360); 
                    	        		END_OF_STATEMENT230_tree = (object)adaptor.Create(END_OF_STATEMENT230);
                    	        		adaptor.AddChild(root_0, END_OF_STATEMENT230_tree);


                    	        }
                    	        break;
                    	    case 2 :
                    	        // spinach.g:383:24: ',' v113= string_literal ( ')' END_OF_STATEMENT | ',' v114= string_literal ')' END_OF_STATEMENT )
                    	        {
                    	        	char_literal231=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2362); 
                    	        		char_literal231_tree = (object)adaptor.Create(char_literal231);
                    	        		adaptor.AddChild(root_0, char_literal231_tree);

                    	        	PushFollow(FOLLOW_string_literal_in_plotfunctions2367);
                    	        	v113 = string_literal();
                    	        	state.followingStackPointer--;

                    	        	adaptor.AddChild(root_0, v113.Tree);
                    	        	retval.ret.setYTitle(((v113 != null) ? v113.ret : null));
                    	        	// spinach.g:383:82: ( ')' END_OF_STATEMENT | ',' v114= string_literal ')' END_OF_STATEMENT )
                    	        	int alt57 = 2;
                    	        	int LA57_0 = input.LA(1);

                    	        	if ( (LA57_0 == RIGHTBRACE) )
                    	        	{
                    	        	    alt57 = 1;
                    	        	}
                    	        	else if ( (LA57_0 == 31) )
                    	        	{
                    	        	    alt57 = 2;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    NoViableAltException nvae_d57s0 =
                    	        	        new NoViableAltException("", 57, 0, input);

                    	        	    throw nvae_d57s0;
                    	        	}
                    	        	switch (alt57) 
                    	        	{
                    	        	    case 1 :
                    	        	        // spinach.g:383:83: ')' END_OF_STATEMENT
                    	        	        {
                    	        	        	char_literal232=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2370); 
                    	        	        		char_literal232_tree = (object)adaptor.Create(char_literal232);
                    	        	        		adaptor.AddChild(root_0, char_literal232_tree);

                    	        	        	END_OF_STATEMENT233=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2371); 
                    	        	        		END_OF_STATEMENT233_tree = (object)adaptor.Create(END_OF_STATEMENT233);
                    	        	        		adaptor.AddChild(root_0, END_OF_STATEMENT233_tree);


                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // spinach.g:383:103: ',' v114= string_literal ')' END_OF_STATEMENT
                    	        	        {
                    	        	        	char_literal234=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2373); 
                    	        	        		char_literal234_tree = (object)adaptor.Create(char_literal234);
                    	        	        		adaptor.AddChild(root_0, char_literal234_tree);

                    	        	        	PushFollow(FOLLOW_string_literal_in_plotfunctions2378);
                    	        	        	v114 = string_literal();
                    	        	        	state.followingStackPointer--;

                    	        	        	adaptor.AddChild(root_0, v114.Tree);
                    	        	        	retval.ret.setZTitle(((v114 != null) ? v114.ret : null));
                    	        	        	char_literal235=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2381); 
                    	        	        		char_literal235_tree = (object)adaptor.Create(char_literal235);
                    	        	        		adaptor.AddChild(root_0, char_literal235_tree);

                    	        	        	END_OF_STATEMENT236=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2383); 
                    	        	        		END_OF_STATEMENT236_tree = (object)adaptor.Create(END_OF_STATEMENT236);
                    	        	        		adaptor.AddChild(root_0, END_OF_STATEMENT236_tree);


                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 6 :
                    // spinach.g:384:2: ( 'setScaleMode(' SCALEMODE ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:384:2: ( 'setScaleMode(' SCALEMODE ')' END_OF_STATEMENT )
                    	// spinach.g:384:3: 'setScaleMode(' SCALEMODE ')' END_OF_STATEMENT
                    	{
                    		string_literal237=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2389); 
                    			string_literal237_tree = (object)adaptor.Create(string_literal237);
                    			adaptor.AddChild(root_0, string_literal237_tree);

                    		retval.ret.setPlotFunction("setScaleMode");
                    		SCALEMODE238=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_plotfunctions2392); 
                    			SCALEMODE238_tree = (object)adaptor.Create(SCALEMODE238);
                    			adaptor.AddChild(root_0, SCALEMODE238_tree);

                    		retval.ret.setScaleMode(SCALEMODE238.Text);
                    		char_literal239=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2396); 
                    			char_literal239_tree = (object)adaptor.Create(char_literal239);
                    			adaptor.AddChild(root_0, char_literal239_tree);

                    		END_OF_STATEMENT240=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2398); 
                    			END_OF_STATEMENT240_tree = (object)adaptor.Create(END_OF_STATEMENT240);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT240_tree);


                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "plotfunctions"

    public class comment_return : ParserRuleReturnScope
    {
        public CommentElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "comment"
    // spinach.g:391:1: comment returns [CommentElement ret] : ( '//' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | PLUS | MULTIPLY | 'print' | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '\"' | 'delete' | 'return' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | '-' | ';' | ':' | 'SYNC' | PERCENT | '^' | '$' | '#' | '@' | '!' | '?' | '/' | '[' | ']' | ',' | 'T' | 'DOT' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'else' | 'if' | 'for' | 'parallelfor' | 'to' )* '//' ) ;
    public spinachParser.comment_return comment() // throws RecognitionException [1]
    {   
        spinachParser.comment_return retval = new spinachParser.comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el3 = null;
        IToken el2 = null;
        IToken el1 = null;
        IToken string_literal241 = null;
        IToken char_literal242 = null;
        IToken string_literal243 = null;
        IToken string_literal244 = null;
        IToken char_literal245 = null;
        IToken char_literal246 = null;
        IToken VARTYPE247 = null;
        IToken SCALEMODE248 = null;
        IToken STRINGTYPE249 = null;
        IToken ASSIGNMENT250 = null;
        IToken PLUS251 = null;
        IToken MULTIPLY252 = null;
        IToken string_literal253 = null;
        IToken string_literal254 = null;
        IToken string_literal255 = null;
        IToken string_literal256 = null;
        IToken string_literal257 = null;
        IToken string_literal258 = null;
        IToken string_literal259 = null;
        IToken char_literal260 = null;
        IToken string_literal261 = null;
        IToken string_literal262 = null;
        IToken char_literal263 = null;
        IToken char_literal264 = null;
        IToken char_literal265 = null;
        IToken char_literal266 = null;
        IToken string_literal267 = null;
        IToken string_literal268 = null;
        IToken string_literal269 = null;
        IToken string_literal270 = null;
        IToken char_literal271 = null;
        IToken char_literal272 = null;
        IToken char_literal273 = null;
        IToken char_literal274 = null;
        IToken string_literal275 = null;
        IToken PERCENT276 = null;
        IToken char_literal277 = null;
        IToken char_literal278 = null;
        IToken char_literal279 = null;
        IToken char_literal280 = null;
        IToken char_literal281 = null;
        IToken char_literal282 = null;
        IToken char_literal283 = null;
        IToken char_literal284 = null;
        IToken char_literal285 = null;
        IToken char_literal286 = null;
        IToken char_literal287 = null;
        IToken string_literal288 = null;
        IToken string_literal289 = null;
        IToken string_literal290 = null;
        IToken string_literal291 = null;
        IToken string_literal292 = null;
        IToken string_literal293 = null;
        IToken string_literal294 = null;
        IToken string_literal295 = null;
        IToken string_literal296 = null;
        IToken string_literal297 = null;
        IToken string_literal298 = null;
        IToken string_literal299 = null;

        object el3_tree=null;
        object el2_tree=null;
        object el1_tree=null;
        object string_literal241_tree=null;
        object char_literal242_tree=null;
        object string_literal243_tree=null;
        object string_literal244_tree=null;
        object char_literal245_tree=null;
        object char_literal246_tree=null;
        object VARTYPE247_tree=null;
        object SCALEMODE248_tree=null;
        object STRINGTYPE249_tree=null;
        object ASSIGNMENT250_tree=null;
        object PLUS251_tree=null;
        object MULTIPLY252_tree=null;
        object string_literal253_tree=null;
        object string_literal254_tree=null;
        object string_literal255_tree=null;
        object string_literal256_tree=null;
        object string_literal257_tree=null;
        object string_literal258_tree=null;
        object string_literal259_tree=null;
        object char_literal260_tree=null;
        object string_literal261_tree=null;
        object string_literal262_tree=null;
        object char_literal263_tree=null;
        object char_literal264_tree=null;
        object char_literal265_tree=null;
        object char_literal266_tree=null;
        object string_literal267_tree=null;
        object string_literal268_tree=null;
        object string_literal269_tree=null;
        object string_literal270_tree=null;
        object char_literal271_tree=null;
        object char_literal272_tree=null;
        object char_literal273_tree=null;
        object char_literal274_tree=null;
        object string_literal275_tree=null;
        object PERCENT276_tree=null;
        object char_literal277_tree=null;
        object char_literal278_tree=null;
        object char_literal279_tree=null;
        object char_literal280_tree=null;
        object char_literal281_tree=null;
        object char_literal282_tree=null;
        object char_literal283_tree=null;
        object char_literal284_tree=null;
        object char_literal285_tree=null;
        object char_literal286_tree=null;
        object char_literal287_tree=null;
        object string_literal288_tree=null;
        object string_literal289_tree=null;
        object string_literal290_tree=null;
        object string_literal291_tree=null;
        object string_literal292_tree=null;
        object string_literal293_tree=null;
        object string_literal294_tree=null;
        object string_literal295_tree=null;
        object string_literal296_tree=null;
        object string_literal297_tree=null;
        object string_literal298_tree=null;
        object string_literal299_tree=null;


         retval.ret = new CommentElement();

        try 
    	{
            // spinach.g:395:2: ( ( '//' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | PLUS | MULTIPLY | 'print' | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '\"' | 'delete' | 'return' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | '-' | ';' | ':' | 'SYNC' | PERCENT | '^' | '$' | '#' | '@' | '!' | '?' | '/' | '[' | ']' | ',' | 'T' | 'DOT' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'else' | 'if' | 'for' | 'parallelfor' | 'to' )* '//' ) )
            // spinach.g:395:3: ( '//' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | PLUS | MULTIPLY | 'print' | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '\"' | 'delete' | 'return' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | '-' | ';' | ':' | 'SYNC' | PERCENT | '^' | '$' | '#' | '@' | '!' | '?' | '/' | '[' | ']' | ',' | 'T' | 'DOT' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'else' | 'if' | 'for' | 'parallelfor' | 'to' )* '//' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:395:3: ( '//' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | PLUS | MULTIPLY | 'print' | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '\"' | 'delete' | 'return' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | '-' | ';' | ':' | 'SYNC' | PERCENT | '^' | '$' | '#' | '@' | '!' | '?' | '/' | '[' | ']' | ',' | 'T' | 'DOT' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'else' | 'if' | 'for' | 'parallelfor' | 'to' )* '//' )
            	// spinach.g:395:4: '//' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | PLUS | MULTIPLY | 'print' | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '\"' | 'delete' | 'return' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | '-' | ';' | ':' | 'SYNC' | PERCENT | '^' | '$' | '#' | '@' | '!' | '?' | '/' | '[' | ']' | ',' | 'T' | 'DOT' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'else' | 'if' | 'for' | 'parallelfor' | 'to' )* '//'
            	{
            		string_literal241=(IToken)Match(input,56,FOLLOW_56_in_comment2419); 
            			string_literal241_tree = (object)adaptor.Create(string_literal241);
            			adaptor.AddChild(root_0, string_literal241_tree);

            		// spinach.g:396:1: (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | PLUS | MULTIPLY | 'print' | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '\"' | 'delete' | 'return' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | '-' | ';' | ':' | 'SYNC' | PERCENT | '^' | '$' | '#' | '@' | '!' | '?' | '/' | '[' | ']' | ',' | 'T' | 'DOT' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'else' | 'if' | 'for' | 'parallelfor' | 'to' )*
            		do 
            		{
            		    int alt60 = 61;
            		    switch ( input.LA(1) ) 
            		    {
            		    case VARIABLE:
            		    	{
            		        alt60 = 1;
            		        }
            		        break;
            		    case INT_LITERAL:
            		    	{
            		        alt60 = 2;
            		        }
            		        break;
            		    case DOUBLE_LITERAL:
            		    	{
            		        alt60 = 3;
            		        }
            		        break;
            		    case DOT:
            		    	{
            		        alt60 = 4;
            		        }
            		        break;
            		    case 28:
            		    	{
            		        alt60 = 5;
            		        }
            		        break;
            		    case 32:
            		    	{
            		        alt60 = 6;
            		        }
            		        break;
            		    case LESSTHANEXPRESSION:
            		    	{
            		        alt60 = 7;
            		        }
            		        break;
            		    case GREATERTHANEXPRESSION:
            		    	{
            		        alt60 = 8;
            		        }
            		        break;
            		    case VARTYPE:
            		    	{
            		        alt60 = 9;
            		        }
            		        break;
            		    case SCALEMODE:
            		    	{
            		        alt60 = 10;
            		        }
            		        break;
            		    case STRINGTYPE:
            		    	{
            		        alt60 = 11;
            		        }
            		        break;
            		    case ASSIGNMENT:
            		    	{
            		        alt60 = 12;
            		        }
            		        break;
            		    case PLUS:
            		    	{
            		        alt60 = 13;
            		        }
            		        break;
            		    case MULTIPLY:
            		    	{
            		        alt60 = 14;
            		        }
            		        break;
            		    case 36:
            		    	{
            		        alt60 = 15;
            		        }
            		        break;
            		    case 47:
            		    	{
            		        alt60 = 16;
            		        }
            		        break;
            		    case 51:
            		    	{
            		        alt60 = 17;
            		        }
            		        break;
            		    case 52:
            		    	{
            		        alt60 = 18;
            		        }
            		        break;
            		    case 53:
            		    	{
            		        alt60 = 19;
            		        }
            		        break;
            		    case 54:
            		    	{
            		        alt60 = 20;
            		        }
            		        break;
            		    case 57:
            		    	{
            		        alt60 = 21;
            		        }
            		        break;
            		    case 58:
            		    	{
            		        alt60 = 22;
            		        }
            		        break;
            		    case 35:
            		    	{
            		        alt60 = 23;
            		        }
            		        break;
            		    case 46:
            		    	{
            		        alt60 = 24;
            		        }
            		        break;
            		    case LEFTBRACE:
            		    	{
            		        alt60 = 25;
            		        }
            		        break;
            		    case RIGHTBRACE:
            		    	{
            		        alt60 = 26;
            		        }
            		        break;
            		    case LEFTPARANTHESIS:
            		    	{
            		        alt60 = 27;
            		        }
            		        break;
            		    case RIGHTPARANTHESIS:
            		    	{
            		        alt60 = 28;
            		        }
            		        break;
            		    case POINT:
            		    	{
            		        alt60 = 29;
            		        }
            		        break;
            		    case EQUALITYEXPRESSION:
            		    	{
            		        alt60 = 30;
            		        }
            		        break;
            		    case NONEQUALITYEXPRESSION:
            		    	{
            		        alt60 = 31;
            		        }
            		        break;
            		    case LESSTHANEQUALTOEXPRESSION:
            		    	{
            		        alt60 = 32;
            		        }
            		        break;
            		    case 59:
            		    	{
            		        alt60 = 33;
            		        }
            		        break;
            		    case 33:
            		    	{
            		        alt60 = 34;
            		        }
            		        break;
            		    case END_OF_STATEMENT:
            		    	{
            		        alt60 = 35;
            		        }
            		        break;
            		    case 60:
            		    	{
            		        alt60 = 36;
            		        }
            		        break;
            		    case 39:
            		    	{
            		        alt60 = 37;
            		        }
            		        break;
            		    case PERCENT:
            		    	{
            		        alt60 = 38;
            		        }
            		        break;
            		    case 61:
            		    	{
            		        alt60 = 39;
            		        }
            		        break;
            		    case 62:
            		    	{
            		        alt60 = 40;
            		        }
            		        break;
            		    case 63:
            		    	{
            		        alt60 = 41;
            		        }
            		        break;
            		    case 64:
            		    	{
            		        alt60 = 42;
            		        }
            		        break;
            		    case 65:
            		    	{
            		        alt60 = 43;
            		        }
            		        break;
            		    case 66:
            		    	{
            		        alt60 = 44;
            		        }
            		        break;
            		    case 67:
            		    	{
            		        alt60 = 45;
            		        }
            		        break;
            		    case 29:
            		    	{
            		        alt60 = 46;
            		        }
            		        break;
            		    case 30:
            		    	{
            		        alt60 = 47;
            		        }
            		        break;
            		    case 31:
            		    	{
            		        alt60 = 48;
            		        }
            		        break;
            		    case 45:
            		    	{
            		        alt60 = 49;
            		        }
            		        break;
            		    case 44:
            		    	{
            		        alt60 = 50;
            		        }
            		        break;
            		    case 48:
            		    	{
            		        alt60 = 51;
            		        }
            		        break;
            		    case 49:
            		    	{
            		        alt60 = 52;
            		        }
            		        break;
            		    case 50:
            		    	{
            		        alt60 = 53;
            		        }
            		        break;
            		    case 43:
            		    	{
            		        alt60 = 54;
            		        }
            		        break;
            		    case 34:
            		    	{
            		        alt60 = 55;
            		        }
            		        break;
            		    case 41:
            		    	{
            		        alt60 = 56;
            		        }
            		        break;
            		    case 40:
            		    	{
            		        alt60 = 57;
            		        }
            		        break;
            		    case 42:
            		    	{
            		        alt60 = 58;
            		        }
            		        break;
            		    case 37:
            		    	{
            		        alt60 = 59;
            		        }
            		        break;
            		    case 38:
            		    	{
            		        alt60 = 60;
            		        }
            		        break;

            		    }

            		    switch (alt60) 
            			{
            				case 1 :
            				    // spinach.g:396:2: el3= VARIABLE
            				    {
            				    	el3=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_comment2424); 
            				    		el3_tree = (object)adaptor.Create(el3);
            				    		adaptor.AddChild(root_0, el3_tree);



            				    }
            				    break;
            				case 2 :
            				    // spinach.g:397:3: el2= INT_LITERAL
            				    {
            				    	el2=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_comment2431); 
            				    		el2_tree = (object)adaptor.Create(el2);
            				    		adaptor.AddChild(root_0, el2_tree);



            				    }
            				    break;
            				case 3 :
            				    // spinach.g:398:3: el1= DOUBLE_LITERAL
            				    {
            				    	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_comment2438); 
            				    		el1_tree = (object)adaptor.Create(el1);
            				    		adaptor.AddChild(root_0, el1_tree);



            				    }
            				    break;
            				case 4 :
            				    // spinach.g:399:3: '.'
            				    {
            				    	char_literal242=(IToken)Match(input,DOT,FOLLOW_DOT_in_comment2443); 
            				    		char_literal242_tree = (object)adaptor.Create(char_literal242);
            				    		adaptor.AddChild(root_0, char_literal242_tree);



            				    }
            				    break;
            				case 5 :
            				    // spinach.g:400:3: 'matrix'
            				    {
            				    	string_literal243=(IToken)Match(input,28,FOLLOW_28_in_comment2448); 
            				    		string_literal243_tree = (object)adaptor.Create(string_literal243);
            				    		adaptor.AddChild(root_0, string_literal243_tree);



            				    }
            				    break;
            				case 6 :
            				    // spinach.g:401:3: 'vector'
            				    {
            				    	string_literal244=(IToken)Match(input,32,FOLLOW_32_in_comment2453); 
            				    		string_literal244_tree = (object)adaptor.Create(string_literal244);
            				    		adaptor.AddChild(root_0, string_literal244_tree);



            				    }
            				    break;
            				case 7 :
            				    // spinach.g:402:3: '<'
            				    {
            				    	char_literal245=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_comment2458); 
            				    		char_literal245_tree = (object)adaptor.Create(char_literal245);
            				    		adaptor.AddChild(root_0, char_literal245_tree);



            				    }
            				    break;
            				case 8 :
            				    // spinach.g:403:3: '>'
            				    {
            				    	char_literal246=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_comment2463); 
            				    		char_literal246_tree = (object)adaptor.Create(char_literal246);
            				    		adaptor.AddChild(root_0, char_literal246_tree);



            				    }
            				    break;
            				case 9 :
            				    // spinach.g:404:3: VARTYPE
            				    {
            				    	VARTYPE247=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_comment2468); 
            				    		VARTYPE247_tree = (object)adaptor.Create(VARTYPE247);
            				    		adaptor.AddChild(root_0, VARTYPE247_tree);



            				    }
            				    break;
            				case 10 :
            				    // spinach.g:405:3: SCALEMODE
            				    {
            				    	SCALEMODE248=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_comment2473); 
            				    		SCALEMODE248_tree = (object)adaptor.Create(SCALEMODE248);
            				    		adaptor.AddChild(root_0, SCALEMODE248_tree);



            				    }
            				    break;
            				case 11 :
            				    // spinach.g:406:3: STRINGTYPE
            				    {
            				    	STRINGTYPE249=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_comment2478); 
            				    		STRINGTYPE249_tree = (object)adaptor.Create(STRINGTYPE249);
            				    		adaptor.AddChild(root_0, STRINGTYPE249_tree);



            				    }
            				    break;
            				case 12 :
            				    // spinach.g:407:3: ASSIGNMENT
            				    {
            				    	ASSIGNMENT250=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_comment2483); 
            				    		ASSIGNMENT250_tree = (object)adaptor.Create(ASSIGNMENT250);
            				    		adaptor.AddChild(root_0, ASSIGNMENT250_tree);



            				    }
            				    break;
            				case 13 :
            				    // spinach.g:408:3: PLUS
            				    {
            				    	PLUS251=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_comment2488); 
            				    		PLUS251_tree = (object)adaptor.Create(PLUS251);
            				    		adaptor.AddChild(root_0, PLUS251_tree);



            				    }
            				    break;
            				case 14 :
            				    // spinach.g:409:3: MULTIPLY
            				    {
            				    	MULTIPLY252=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_comment2493); 
            				    		MULTIPLY252_tree = (object)adaptor.Create(MULTIPLY252);
            				    		adaptor.AddChild(root_0, MULTIPLY252_tree);



            				    }
            				    break;
            				case 15 :
            				    // spinach.g:410:3: 'print'
            				    {
            				    	string_literal253=(IToken)Match(input,36,FOLLOW_36_in_comment2498); 
            				    		string_literal253_tree = (object)adaptor.Create(string_literal253);
            				    		adaptor.AddChild(root_0, string_literal253_tree);



            				    }
            				    break;
            				case 16 :
            				    // spinach.g:411:3: 'subPlot'
            				    {
            				    	string_literal254=(IToken)Match(input,47,FOLLOW_47_in_comment2503); 
            				    		string_literal254_tree = (object)adaptor.Create(string_literal254);
            				    		adaptor.AddChild(root_0, string_literal254_tree);



            				    }
            				    break;
            				case 17 :
            				    // spinach.g:412:3: 'plot'
            				    {
            				    	string_literal255=(IToken)Match(input,51,FOLLOW_51_in_comment2508); 
            				    		string_literal255_tree = (object)adaptor.Create(string_literal255);
            				    		adaptor.AddChild(root_0, string_literal255_tree);



            				    }
            				    break;
            				case 18 :
            				    // spinach.g:413:3: 'resetPlot'
            				    {
            				    	string_literal256=(IToken)Match(input,52,FOLLOW_52_in_comment2513); 
            				    		string_literal256_tree = (object)adaptor.Create(string_literal256);
            				    		adaptor.AddChild(root_0, string_literal256_tree);



            				    }
            				    break;
            				case 19 :
            				    // spinach.g:414:3: 'setPlotAxis'
            				    {
            				    	string_literal257=(IToken)Match(input,53,FOLLOW_53_in_comment2518); 
            				    		string_literal257_tree = (object)adaptor.Create(string_literal257);
            				    		adaptor.AddChild(root_0, string_literal257_tree);



            				    }
            				    break;
            				case 20 :
            				    // spinach.g:415:3: 'setAxisTitle'
            				    {
            				    	string_literal258=(IToken)Match(input,54,FOLLOW_54_in_comment2523); 
            				    		string_literal258_tree = (object)adaptor.Create(string_literal258);
            				    		adaptor.AddChild(root_0, string_literal258_tree);



            				    }
            				    break;
            				case 21 :
            				    // spinach.g:416:3: 'setScaleMode'
            				    {
            				    	string_literal259=(IToken)Match(input,57,FOLLOW_57_in_comment2528); 
            				    		string_literal259_tree = (object)adaptor.Create(string_literal259);
            				    		adaptor.AddChild(root_0, string_literal259_tree);



            				    }
            				    break;
            				case 22 :
            				    // spinach.g:417:3: '\"'
            				    {
            				    	char_literal260=(IToken)Match(input,58,FOLLOW_58_in_comment2533); 
            				    		char_literal260_tree = (object)adaptor.Create(char_literal260);
            				    		adaptor.AddChild(root_0, char_literal260_tree);



            				    }
            				    break;
            				case 23 :
            				    // spinach.g:418:3: 'delete'
            				    {
            				    	string_literal261=(IToken)Match(input,35,FOLLOW_35_in_comment2539); 
            				    		string_literal261_tree = (object)adaptor.Create(string_literal261);
            				    		adaptor.AddChild(root_0, string_literal261_tree);



            				    }
            				    break;
            				case 24 :
            				    // spinach.g:419:3: 'return'
            				    {
            				    	string_literal262=(IToken)Match(input,46,FOLLOW_46_in_comment2544); 
            				    		string_literal262_tree = (object)adaptor.Create(string_literal262);
            				    		adaptor.AddChild(root_0, string_literal262_tree);



            				    }
            				    break;
            				case 25 :
            				    // spinach.g:420:3: '('
            				    {
            				    	char_literal263=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_comment2549); 
            				    		char_literal263_tree = (object)adaptor.Create(char_literal263);
            				    		adaptor.AddChild(root_0, char_literal263_tree);



            				    }
            				    break;
            				case 26 :
            				    // spinach.g:421:3: ')'
            				    {
            				    	char_literal264=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_comment2554); 
            				    		char_literal264_tree = (object)adaptor.Create(char_literal264);
            				    		adaptor.AddChild(root_0, char_literal264_tree);



            				    }
            				    break;
            				case 27 :
            				    // spinach.g:422:3: '{'
            				    {
            				    	char_literal265=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_comment2559); 
            				    		char_literal265_tree = (object)adaptor.Create(char_literal265);
            				    		adaptor.AddChild(root_0, char_literal265_tree);



            				    }
            				    break;
            				case 28 :
            				    // spinach.g:423:3: '}'
            				    {
            				    	char_literal266=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_comment2564); 
            				    		char_literal266_tree = (object)adaptor.Create(char_literal266);
            				    		adaptor.AddChild(root_0, char_literal266_tree);



            				    }
            				    break;
            				case 29 :
            				    // spinach.g:424:3: '->'
            				    {
            				    	string_literal267=(IToken)Match(input,POINT,FOLLOW_POINT_in_comment2569); 
            				    		string_literal267_tree = (object)adaptor.Create(string_literal267);
            				    		adaptor.AddChild(root_0, string_literal267_tree);



            				    }
            				    break;
            				case 30 :
            				    // spinach.g:425:3: '=='
            				    {
            				    	string_literal268=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_comment2574); 
            				    		string_literal268_tree = (object)adaptor.Create(string_literal268);
            				    		adaptor.AddChild(root_0, string_literal268_tree);



            				    }
            				    break;
            				case 31 :
            				    // spinach.g:426:3: '!='
            				    {
            				    	string_literal269=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_comment2579); 
            				    		string_literal269_tree = (object)adaptor.Create(string_literal269);
            				    		adaptor.AddChild(root_0, string_literal269_tree);



            				    }
            				    break;
            				case 32 :
            				    // spinach.g:427:3: '<='
            				    {
            				    	string_literal270=(IToken)Match(input,LESSTHANEQUALTOEXPRESSION,FOLLOW_LESSTHANEQUALTOEXPRESSION_in_comment2584); 
            				    		string_literal270_tree = (object)adaptor.Create(string_literal270);
            				    		adaptor.AddChild(root_0, string_literal270_tree);



            				    }
            				    break;
            				case 33 :
            				    // spinach.g:428:3: '&'
            				    {
            				    	char_literal271=(IToken)Match(input,59,FOLLOW_59_in_comment2589); 
            				    		char_literal271_tree = (object)adaptor.Create(char_literal271);
            				    		adaptor.AddChild(root_0, char_literal271_tree);



            				    }
            				    break;
            				case 34 :
            				    // spinach.g:429:3: '-'
            				    {
            				    	char_literal272=(IToken)Match(input,33,FOLLOW_33_in_comment2594); 
            				    		char_literal272_tree = (object)adaptor.Create(char_literal272);
            				    		adaptor.AddChild(root_0, char_literal272_tree);



            				    }
            				    break;
            				case 35 :
            				    // spinach.g:430:3: ';'
            				    {
            				    	char_literal273=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_comment2599); 
            				    		char_literal273_tree = (object)adaptor.Create(char_literal273);
            				    		adaptor.AddChild(root_0, char_literal273_tree);



            				    }
            				    break;
            				case 36 :
            				    // spinach.g:431:3: ':'
            				    {
            				    	char_literal274=(IToken)Match(input,60,FOLLOW_60_in_comment2604); 
            				    		char_literal274_tree = (object)adaptor.Create(char_literal274);
            				    		adaptor.AddChild(root_0, char_literal274_tree);



            				    }
            				    break;
            				case 37 :
            				    // spinach.g:432:4: 'SYNC'
            				    {
            				    	string_literal275=(IToken)Match(input,39,FOLLOW_39_in_comment2610); 
            				    		string_literal275_tree = (object)adaptor.Create(string_literal275);
            				    		adaptor.AddChild(root_0, string_literal275_tree);



            				    }
            				    break;
            				case 38 :
            				    // spinach.g:433:4: PERCENT
            				    {
            				    	PERCENT276=(IToken)Match(input,PERCENT,FOLLOW_PERCENT_in_comment2617); 
            				    		PERCENT276_tree = (object)adaptor.Create(PERCENT276);
            				    		adaptor.AddChild(root_0, PERCENT276_tree);



            				    }
            				    break;
            				case 39 :
            				    // spinach.g:434:3: '^'
            				    {
            				    	char_literal277=(IToken)Match(input,61,FOLLOW_61_in_comment2623); 
            				    		char_literal277_tree = (object)adaptor.Create(char_literal277);
            				    		adaptor.AddChild(root_0, char_literal277_tree);



            				    }
            				    break;
            				case 40 :
            				    // spinach.g:435:3: '$'
            				    {
            				    	char_literal278=(IToken)Match(input,62,FOLLOW_62_in_comment2628); 
            				    		char_literal278_tree = (object)adaptor.Create(char_literal278);
            				    		adaptor.AddChild(root_0, char_literal278_tree);



            				    }
            				    break;
            				case 41 :
            				    // spinach.g:436:3: '#'
            				    {
            				    	char_literal279=(IToken)Match(input,63,FOLLOW_63_in_comment2633); 
            				    		char_literal279_tree = (object)adaptor.Create(char_literal279);
            				    		adaptor.AddChild(root_0, char_literal279_tree);



            				    }
            				    break;
            				case 42 :
            				    // spinach.g:437:3: '@'
            				    {
            				    	char_literal280=(IToken)Match(input,64,FOLLOW_64_in_comment2638); 
            				    		char_literal280_tree = (object)adaptor.Create(char_literal280);
            				    		adaptor.AddChild(root_0, char_literal280_tree);



            				    }
            				    break;
            				case 43 :
            				    // spinach.g:438:3: '!'
            				    {
            				    	char_literal281=(IToken)Match(input,65,FOLLOW_65_in_comment2643); 
            				    		char_literal281_tree = (object)adaptor.Create(char_literal281);
            				    		adaptor.AddChild(root_0, char_literal281_tree);



            				    }
            				    break;
            				case 44 :
            				    // spinach.g:439:3: '?'
            				    {
            				    	char_literal282=(IToken)Match(input,66,FOLLOW_66_in_comment2648); 
            				    		char_literal282_tree = (object)adaptor.Create(char_literal282);
            				    		adaptor.AddChild(root_0, char_literal282_tree);



            				    }
            				    break;
            				case 45 :
            				    // spinach.g:440:3: '/'
            				    {
            				    	char_literal283=(IToken)Match(input,67,FOLLOW_67_in_comment2653); 
            				    		char_literal283_tree = (object)adaptor.Create(char_literal283);
            				    		adaptor.AddChild(root_0, char_literal283_tree);



            				    }
            				    break;
            				case 46 :
            				    // spinach.g:441:3: '['
            				    {
            				    	char_literal284=(IToken)Match(input,29,FOLLOW_29_in_comment2660); 
            				    		char_literal284_tree = (object)adaptor.Create(char_literal284);
            				    		adaptor.AddChild(root_0, char_literal284_tree);



            				    }
            				    break;
            				case 47 :
            				    // spinach.g:442:3: ']'
            				    {
            				    	char_literal285=(IToken)Match(input,30,FOLLOW_30_in_comment2665); 
            				    		char_literal285_tree = (object)adaptor.Create(char_literal285);
            				    		adaptor.AddChild(root_0, char_literal285_tree);



            				    }
            				    break;
            				case 48 :
            				    // spinach.g:443:3: ','
            				    {
            				    	char_literal286=(IToken)Match(input,31,FOLLOW_31_in_comment2670); 
            				    		char_literal286_tree = (object)adaptor.Create(char_literal286);
            				    		adaptor.AddChild(root_0, char_literal286_tree);



            				    }
            				    break;
            				case 49 :
            				    // spinach.g:444:4: 'T'
            				    {
            				    	char_literal287=(IToken)Match(input,45,FOLLOW_45_in_comment2676); 
            				    		char_literal287_tree = (object)adaptor.Create(char_literal287);
            				    		adaptor.AddChild(root_0, char_literal287_tree);



            				    }
            				    break;
            				case 50 :
            				    // spinach.g:445:4: 'DOT'
            				    {
            				    	string_literal288=(IToken)Match(input,44,FOLLOW_44_in_comment2682); 
            				    		string_literal288_tree = (object)adaptor.Create(string_literal288);
            				    		adaptor.AddChild(root_0, string_literal288_tree);


            				    }
            				    break;
            				case 51 :
            				    // spinach.g:446:3: '1D'
            				    {
            				    	string_literal289=(IToken)Match(input,48,FOLLOW_48_in_comment2686); 
            				    		string_literal289_tree = (object)adaptor.Create(string_literal289);
            				    		adaptor.AddChild(root_0, string_literal289_tree);



            				    }
            				    break;
            				case 52 :
            				    // spinach.g:447:3: '2D'
            				    {
            				    	string_literal290=(IToken)Match(input,49,FOLLOW_49_in_comment2691); 
            				    		string_literal290_tree = (object)adaptor.Create(string_literal290);
            				    		adaptor.AddChild(root_0, string_literal290_tree);



            				    }
            				    break;
            				case 53 :
            				    // spinach.g:448:3: '3D'
            				    {
            				    	string_literal291=(IToken)Match(input,50,FOLLOW_50_in_comment2696); 
            				    		string_literal291_tree = (object)adaptor.Create(string_literal291);
            				    		adaptor.AddChild(root_0, string_literal291_tree);



            				    }
            				    break;
            				case 54 :
            				    // spinach.g:449:3: 'void'
            				    {
            				    	string_literal292=(IToken)Match(input,43,FOLLOW_43_in_comment2701); 
            				    		string_literal292_tree = (object)adaptor.Create(string_literal292);
            				    		adaptor.AddChild(root_0, string_literal292_tree);



            				    }
            				    break;
            				case 55 :
            				    // spinach.g:450:3: 'struct'
            				    {
            				    	string_literal293=(IToken)Match(input,34,FOLLOW_34_in_comment2706); 
            				    		string_literal293_tree = (object)adaptor.Create(string_literal293);
            				    		adaptor.AddChild(root_0, string_literal293_tree);



            				    }
            				    break;
            				case 56 :
            				    // spinach.g:451:4: 'else'
            				    {
            				    	string_literal294=(IToken)Match(input,41,FOLLOW_41_in_comment2712); 
            				    		string_literal294_tree = (object)adaptor.Create(string_literal294);
            				    		adaptor.AddChild(root_0, string_literal294_tree);



            				    }
            				    break;
            				case 57 :
            				    // spinach.g:452:4: 'if'
            				    {
            				    	string_literal295=(IToken)Match(input,40,FOLLOW_40_in_comment2719); 
            				    		string_literal295_tree = (object)adaptor.Create(string_literal295);
            				    		adaptor.AddChild(root_0, string_literal295_tree);


            				    }
            				    break;
            				case 58 :
            				    // spinach.g:453:4: 'for'
            				    {
            				    	string_literal296=(IToken)Match(input,42,FOLLOW_42_in_comment2724); 
            				    		string_literal296_tree = (object)adaptor.Create(string_literal296);
            				    		adaptor.AddChild(root_0, string_literal296_tree);


            				    }
            				    break;
            				case 59 :
            				    // spinach.g:454:3: 'parallelfor'
            				    {
            				    	string_literal297=(IToken)Match(input,37,FOLLOW_37_in_comment2728); 
            				    		string_literal297_tree = (object)adaptor.Create(string_literal297);
            				    		adaptor.AddChild(root_0, string_literal297_tree);


            				    }
            				    break;
            				case 60 :
            				    // spinach.g:455:4: 'to'
            				    {
            				    	string_literal298=(IToken)Match(input,38,FOLLOW_38_in_comment2733); 
            				    		string_literal298_tree = (object)adaptor.Create(string_literal298);
            				    		adaptor.AddChild(root_0, string_literal298_tree);


            				    }
            				    break;

            				default:
            				    goto loop60;
            		    }
            		} while (true);

            		loop60:
            			;	// Stops C# compiler whining that label 'loop60' has no statements

            		string_literal299=(IToken)Match(input,56,FOLLOW_56_in_comment2737); 
            			string_literal299_tree = (object)adaptor.Create(string_literal299);
            			adaptor.AddChild(root_0, string_literal299_tree);


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "comment"

    public class string_literal_return : ParserRuleReturnScope
    {
        public StringElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "string_literal"
    // spinach.g:461:1: string_literal returns [StringElement ret] : ( '\"' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | '-' | PLUS | MULTIPLY | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | PERCENT | '^' | '$' | '#' | '@' | ';' | '!' | '?' | '/' | ':' | '[' | ']' | ',' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'return' | 'delete' | 'DOT' | 'T' | 'else' | 'if' | 'for' | 'parallelfor' | 'SYNC' | 'print' | 'to' )* '\"' ) ;
    public spinachParser.string_literal_return string_literal() // throws RecognitionException [1]
    {   
        spinachParser.string_literal_return retval = new spinachParser.string_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el3 = null;
        IToken el2 = null;
        IToken el1 = null;
        IToken char_literal300 = null;
        IToken char_literal301 = null;
        IToken string_literal302 = null;
        IToken string_literal303 = null;
        IToken char_literal304 = null;
        IToken char_literal305 = null;
        IToken VARTYPE306 = null;
        IToken SCALEMODE307 = null;
        IToken STRINGTYPE308 = null;
        IToken ASSIGNMENT309 = null;
        IToken char_literal310 = null;
        IToken PLUS311 = null;
        IToken MULTIPLY312 = null;
        IToken string_literal313 = null;
        IToken string_literal314 = null;
        IToken string_literal315 = null;
        IToken string_literal316 = null;
        IToken string_literal317 = null;
        IToken string_literal318 = null;
        IToken char_literal319 = null;
        IToken char_literal320 = null;
        IToken char_literal321 = null;
        IToken char_literal322 = null;
        IToken string_literal323 = null;
        IToken string_literal324 = null;
        IToken string_literal325 = null;
        IToken string_literal326 = null;
        IToken char_literal327 = null;
        IToken PERCENT328 = null;
        IToken char_literal329 = null;
        IToken char_literal330 = null;
        IToken char_literal331 = null;
        IToken char_literal332 = null;
        IToken char_literal333 = null;
        IToken char_literal334 = null;
        IToken char_literal335 = null;
        IToken char_literal336 = null;
        IToken char_literal337 = null;
        IToken char_literal338 = null;
        IToken char_literal339 = null;
        IToken char_literal340 = null;
        IToken string_literal341 = null;
        IToken string_literal342 = null;
        IToken string_literal343 = null;
        IToken string_literal344 = null;
        IToken string_literal345 = null;
        IToken string_literal346 = null;
        IToken string_literal347 = null;
        IToken string_literal348 = null;
        IToken char_literal349 = null;
        IToken string_literal350 = null;
        IToken string_literal351 = null;
        IToken string_literal352 = null;
        IToken string_literal353 = null;
        IToken string_literal354 = null;
        IToken string_literal355 = null;
        IToken string_literal356 = null;
        IToken char_literal357 = null;

        object el3_tree=null;
        object el2_tree=null;
        object el1_tree=null;
        object char_literal300_tree=null;
        object char_literal301_tree=null;
        object string_literal302_tree=null;
        object string_literal303_tree=null;
        object char_literal304_tree=null;
        object char_literal305_tree=null;
        object VARTYPE306_tree=null;
        object SCALEMODE307_tree=null;
        object STRINGTYPE308_tree=null;
        object ASSIGNMENT309_tree=null;
        object char_literal310_tree=null;
        object PLUS311_tree=null;
        object MULTIPLY312_tree=null;
        object string_literal313_tree=null;
        object string_literal314_tree=null;
        object string_literal315_tree=null;
        object string_literal316_tree=null;
        object string_literal317_tree=null;
        object string_literal318_tree=null;
        object char_literal319_tree=null;
        object char_literal320_tree=null;
        object char_literal321_tree=null;
        object char_literal322_tree=null;
        object string_literal323_tree=null;
        object string_literal324_tree=null;
        object string_literal325_tree=null;
        object string_literal326_tree=null;
        object char_literal327_tree=null;
        object PERCENT328_tree=null;
        object char_literal329_tree=null;
        object char_literal330_tree=null;
        object char_literal331_tree=null;
        object char_literal332_tree=null;
        object char_literal333_tree=null;
        object char_literal334_tree=null;
        object char_literal335_tree=null;
        object char_literal336_tree=null;
        object char_literal337_tree=null;
        object char_literal338_tree=null;
        object char_literal339_tree=null;
        object char_literal340_tree=null;
        object string_literal341_tree=null;
        object string_literal342_tree=null;
        object string_literal343_tree=null;
        object string_literal344_tree=null;
        object string_literal345_tree=null;
        object string_literal346_tree=null;
        object string_literal347_tree=null;
        object string_literal348_tree=null;
        object char_literal349_tree=null;
        object string_literal350_tree=null;
        object string_literal351_tree=null;
        object string_literal352_tree=null;
        object string_literal353_tree=null;
        object string_literal354_tree=null;
        object string_literal355_tree=null;
        object string_literal356_tree=null;
        object char_literal357_tree=null;


         retval.ret = new StringElement();

        try 
    	{
            // spinach.g:465:2: ( ( '\"' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | '-' | PLUS | MULTIPLY | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | PERCENT | '^' | '$' | '#' | '@' | ';' | '!' | '?' | '/' | ':' | '[' | ']' | ',' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'return' | 'delete' | 'DOT' | 'T' | 'else' | 'if' | 'for' | 'parallelfor' | 'SYNC' | 'print' | 'to' )* '\"' ) )
            // spinach.g:465:3: ( '\"' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | '-' | PLUS | MULTIPLY | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | PERCENT | '^' | '$' | '#' | '@' | ';' | '!' | '?' | '/' | ':' | '[' | ']' | ',' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'return' | 'delete' | 'DOT' | 'T' | 'else' | 'if' | 'for' | 'parallelfor' | 'SYNC' | 'print' | 'to' )* '\"' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:465:3: ( '\"' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | '-' | PLUS | MULTIPLY | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | PERCENT | '^' | '$' | '#' | '@' | ';' | '!' | '?' | '/' | ':' | '[' | ']' | ',' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'return' | 'delete' | 'DOT' | 'T' | 'else' | 'if' | 'for' | 'parallelfor' | 'SYNC' | 'print' | 'to' )* '\"' )
            	// spinach.g:465:4: '\"' (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | '-' | PLUS | MULTIPLY | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | PERCENT | '^' | '$' | '#' | '@' | ';' | '!' | '?' | '/' | ':' | '[' | ']' | ',' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'return' | 'delete' | 'DOT' | 'T' | 'else' | 'if' | 'for' | 'parallelfor' | 'SYNC' | 'print' | 'to' )* '\"'
            	{
            		char_literal300=(IToken)Match(input,58,FOLLOW_58_in_string_literal2758); 
            			char_literal300_tree = (object)adaptor.Create(char_literal300);
            			adaptor.AddChild(root_0, char_literal300_tree);

            		// spinach.g:466:2: (el3= VARIABLE | el2= INT_LITERAL | el1= DOUBLE_LITERAL | '.' | 'matrix' | 'vector' | '<' | '>' | VARTYPE | SCALEMODE | STRINGTYPE | ASSIGNMENT | '-' | PLUS | MULTIPLY | 'subPlot' | 'plot' | 'resetPlot' | 'setPlotAxis' | 'setAxisTitle' | 'setScaleMode' | '(' | ')' | '{' | '}' | '->' | '==' | '!=' | '<=' | '&' | PERCENT | '^' | '$' | '#' | '@' | ';' | '!' | '?' | '/' | ':' | '[' | ']' | ',' | '1D' | '2D' | '3D' | 'void' | 'struct' | 'return' | 'delete' | 'DOT' | 'T' | 'else' | 'if' | 'for' | 'parallelfor' | 'SYNC' | 'print' | 'to' )*
            		do 
            		{
            		    int alt61 = 60;
            		    switch ( input.LA(1) ) 
            		    {
            		    case VARIABLE:
            		    	{
            		        alt61 = 1;
            		        }
            		        break;
            		    case INT_LITERAL:
            		    	{
            		        alt61 = 2;
            		        }
            		        break;
            		    case DOUBLE_LITERAL:
            		    	{
            		        alt61 = 3;
            		        }
            		        break;
            		    case DOT:
            		    	{
            		        alt61 = 4;
            		        }
            		        break;
            		    case 28:
            		    	{
            		        alt61 = 5;
            		        }
            		        break;
            		    case 32:
            		    	{
            		        alt61 = 6;
            		        }
            		        break;
            		    case LESSTHANEXPRESSION:
            		    	{
            		        alt61 = 7;
            		        }
            		        break;
            		    case GREATERTHANEXPRESSION:
            		    	{
            		        alt61 = 8;
            		        }
            		        break;
            		    case VARTYPE:
            		    	{
            		        alt61 = 9;
            		        }
            		        break;
            		    case SCALEMODE:
            		    	{
            		        alt61 = 10;
            		        }
            		        break;
            		    case STRINGTYPE:
            		    	{
            		        alt61 = 11;
            		        }
            		        break;
            		    case ASSIGNMENT:
            		    	{
            		        alt61 = 12;
            		        }
            		        break;
            		    case 33:
            		    	{
            		        alt61 = 13;
            		        }
            		        break;
            		    case PLUS:
            		    	{
            		        alt61 = 14;
            		        }
            		        break;
            		    case MULTIPLY:
            		    	{
            		        alt61 = 15;
            		        }
            		        break;
            		    case 47:
            		    	{
            		        alt61 = 16;
            		        }
            		        break;
            		    case 51:
            		    	{
            		        alt61 = 17;
            		        }
            		        break;
            		    case 52:
            		    	{
            		        alt61 = 18;
            		        }
            		        break;
            		    case 53:
            		    	{
            		        alt61 = 19;
            		        }
            		        break;
            		    case 54:
            		    	{
            		        alt61 = 20;
            		        }
            		        break;
            		    case 57:
            		    	{
            		        alt61 = 21;
            		        }
            		        break;
            		    case LEFTBRACE:
            		    	{
            		        alt61 = 22;
            		        }
            		        break;
            		    case RIGHTBRACE:
            		    	{
            		        alt61 = 23;
            		        }
            		        break;
            		    case LEFTPARANTHESIS:
            		    	{
            		        alt61 = 24;
            		        }
            		        break;
            		    case RIGHTPARANTHESIS:
            		    	{
            		        alt61 = 25;
            		        }
            		        break;
            		    case POINT:
            		    	{
            		        alt61 = 26;
            		        }
            		        break;
            		    case EQUALITYEXPRESSION:
            		    	{
            		        alt61 = 27;
            		        }
            		        break;
            		    case NONEQUALITYEXPRESSION:
            		    	{
            		        alt61 = 28;
            		        }
            		        break;
            		    case LESSTHANEQUALTOEXPRESSION:
            		    	{
            		        alt61 = 29;
            		        }
            		        break;
            		    case 59:
            		    	{
            		        alt61 = 30;
            		        }
            		        break;
            		    case PERCENT:
            		    	{
            		        alt61 = 31;
            		        }
            		        break;
            		    case 61:
            		    	{
            		        alt61 = 32;
            		        }
            		        break;
            		    case 62:
            		    	{
            		        alt61 = 33;
            		        }
            		        break;
            		    case 63:
            		    	{
            		        alt61 = 34;
            		        }
            		        break;
            		    case 64:
            		    	{
            		        alt61 = 35;
            		        }
            		        break;
            		    case END_OF_STATEMENT:
            		    	{
            		        alt61 = 36;
            		        }
            		        break;
            		    case 65:
            		    	{
            		        alt61 = 37;
            		        }
            		        break;
            		    case 66:
            		    	{
            		        alt61 = 38;
            		        }
            		        break;
            		    case 67:
            		    	{
            		        alt61 = 39;
            		        }
            		        break;
            		    case 60:
            		    	{
            		        alt61 = 40;
            		        }
            		        break;
            		    case 29:
            		    	{
            		        alt61 = 41;
            		        }
            		        break;
            		    case 30:
            		    	{
            		        alt61 = 42;
            		        }
            		        break;
            		    case 31:
            		    	{
            		        alt61 = 43;
            		        }
            		        break;
            		    case 48:
            		    	{
            		        alt61 = 44;
            		        }
            		        break;
            		    case 49:
            		    	{
            		        alt61 = 45;
            		        }
            		        break;
            		    case 50:
            		    	{
            		        alt61 = 46;
            		        }
            		        break;
            		    case 43:
            		    	{
            		        alt61 = 47;
            		        }
            		        break;
            		    case 34:
            		    	{
            		        alt61 = 48;
            		        }
            		        break;
            		    case 46:
            		    	{
            		        alt61 = 49;
            		        }
            		        break;
            		    case 35:
            		    	{
            		        alt61 = 50;
            		        }
            		        break;
            		    case 44:
            		    	{
            		        alt61 = 51;
            		        }
            		        break;
            		    case 45:
            		    	{
            		        alt61 = 52;
            		        }
            		        break;
            		    case 41:
            		    	{
            		        alt61 = 53;
            		        }
            		        break;
            		    case 40:
            		    	{
            		        alt61 = 54;
            		        }
            		        break;
            		    case 42:
            		    	{
            		        alt61 = 55;
            		        }
            		        break;
            		    case 37:
            		    	{
            		        alt61 = 56;
            		        }
            		        break;
            		    case 39:
            		    	{
            		        alt61 = 57;
            		        }
            		        break;
            		    case 36:
            		    	{
            		        alt61 = 58;
            		        }
            		        break;
            		    case 38:
            		    	{
            		        alt61 = 59;
            		        }
            		        break;

            		    }

            		    switch (alt61) 
            			{
            				case 1 :
            				    // spinach.g:466:3: el3= VARIABLE
            				    {
            				    	el3=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_string_literal2764); 
            				    		el3_tree = (object)adaptor.Create(el3);
            				    		adaptor.AddChild(root_0, el3_tree);

            				    	retval.ret.setText(((el3 != null) ? el3.Text : null));

            				    }
            				    break;
            				case 2 :
            				    // spinach.g:467:3: el2= INT_LITERAL
            				    {
            				    	el2=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_string_literal2771); 
            				    		el2_tree = (object)adaptor.Create(el2);
            				    		adaptor.AddChild(root_0, el2_tree);

            				    	retval.ret.setText(((el2 != null) ? el2.Text : null));

            				    }
            				    break;
            				case 3 :
            				    // spinach.g:468:3: el1= DOUBLE_LITERAL
            				    {
            				    	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_string_literal2778); 
            				    		el1_tree = (object)adaptor.Create(el1);
            				    		adaptor.AddChild(root_0, el1_tree);

            				    	retval.ret.setText(((el1 != null) ? el1.Text : null));

            				    }
            				    break;
            				case 4 :
            				    // spinach.g:469:3: '.'
            				    {
            				    	char_literal301=(IToken)Match(input,DOT,FOLLOW_DOT_in_string_literal2783); 
            				    		char_literal301_tree = (object)adaptor.Create(char_literal301);
            				    		adaptor.AddChild(root_0, char_literal301_tree);

            				    	retval.ret.setText(".");

            				    }
            				    break;
            				case 5 :
            				    // spinach.g:470:3: 'matrix'
            				    {
            				    	string_literal302=(IToken)Match(input,28,FOLLOW_28_in_string_literal2788); 
            				    		string_literal302_tree = (object)adaptor.Create(string_literal302);
            				    		adaptor.AddChild(root_0, string_literal302_tree);

            				    	retval.ret.setText("matrix");

            				    }
            				    break;
            				case 6 :
            				    // spinach.g:471:3: 'vector'
            				    {
            				    	string_literal303=(IToken)Match(input,32,FOLLOW_32_in_string_literal2793); 
            				    		string_literal303_tree = (object)adaptor.Create(string_literal303);
            				    		adaptor.AddChild(root_0, string_literal303_tree);

            				    	retval.ret.setText("vector");

            				    }
            				    break;
            				case 7 :
            				    // spinach.g:472:3: '<'
            				    {
            				    	char_literal304=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_string_literal2798); 
            				    		char_literal304_tree = (object)adaptor.Create(char_literal304);
            				    		adaptor.AddChild(root_0, char_literal304_tree);

            				    	retval.ret.setText("<");

            				    }
            				    break;
            				case 8 :
            				    // spinach.g:473:3: '>'
            				    {
            				    	char_literal305=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_string_literal2803); 
            				    		char_literal305_tree = (object)adaptor.Create(char_literal305);
            				    		adaptor.AddChild(root_0, char_literal305_tree);

            				    	retval.ret.setText(">");

            				    }
            				    break;
            				case 9 :
            				    // spinach.g:474:3: VARTYPE
            				    {
            				    	VARTYPE306=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_string_literal2808); 
            				    		VARTYPE306_tree = (object)adaptor.Create(VARTYPE306);
            				    		adaptor.AddChild(root_0, VARTYPE306_tree);

            				    	retval.ret.setText(((VARTYPE306 != null) ? VARTYPE306.Text : null));

            				    }
            				    break;
            				case 10 :
            				    // spinach.g:475:3: SCALEMODE
            				    {
            				    	SCALEMODE307=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_string_literal2813); 
            				    		SCALEMODE307_tree = (object)adaptor.Create(SCALEMODE307);
            				    		adaptor.AddChild(root_0, SCALEMODE307_tree);

            				    	retval.ret.setText(((SCALEMODE307 != null) ? SCALEMODE307.Text : null));

            				    }
            				    break;
            				case 11 :
            				    // spinach.g:476:3: STRINGTYPE
            				    {
            				    	STRINGTYPE308=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_string_literal2818); 
            				    		STRINGTYPE308_tree = (object)adaptor.Create(STRINGTYPE308);
            				    		adaptor.AddChild(root_0, STRINGTYPE308_tree);

            				    	retval.ret.setText(((STRINGTYPE308 != null) ? STRINGTYPE308.Text : null));

            				    }
            				    break;
            				case 12 :
            				    // spinach.g:477:3: ASSIGNMENT
            				    {
            				    	ASSIGNMENT309=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_string_literal2823); 
            				    		ASSIGNMENT309_tree = (object)adaptor.Create(ASSIGNMENT309);
            				    		adaptor.AddChild(root_0, ASSIGNMENT309_tree);

            				    	retval.ret.setText(((ASSIGNMENT309 != null) ? ASSIGNMENT309.Text : null));

            				    }
            				    break;
            				case 13 :
            				    // spinach.g:478:3: '-'
            				    {
            				    	char_literal310=(IToken)Match(input,33,FOLLOW_33_in_string_literal2828); 
            				    		char_literal310_tree = (object)adaptor.Create(char_literal310);
            				    		adaptor.AddChild(root_0, char_literal310_tree);

            				    	retval.ret.setText("-");

            				    }
            				    break;
            				case 14 :
            				    // spinach.g:479:3: PLUS
            				    {
            				    	PLUS311=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_string_literal2833); 
            				    		PLUS311_tree = (object)adaptor.Create(PLUS311);
            				    		adaptor.AddChild(root_0, PLUS311_tree);

            				    	retval.ret.setText(((PLUS311 != null) ? PLUS311.Text : null));

            				    }
            				    break;
            				case 15 :
            				    // spinach.g:480:3: MULTIPLY
            				    {
            				    	MULTIPLY312=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_string_literal2838); 
            				    		MULTIPLY312_tree = (object)adaptor.Create(MULTIPLY312);
            				    		adaptor.AddChild(root_0, MULTIPLY312_tree);

            				    	retval.ret.setText(((MULTIPLY312 != null) ? MULTIPLY312.Text : null));

            				    }
            				    break;
            				case 16 :
            				    // spinach.g:481:3: 'subPlot'
            				    {
            				    	string_literal313=(IToken)Match(input,47,FOLLOW_47_in_string_literal2843); 
            				    		string_literal313_tree = (object)adaptor.Create(string_literal313);
            				    		adaptor.AddChild(root_0, string_literal313_tree);

            				    	retval.ret.setText("subPlot");

            				    }
            				    break;
            				case 17 :
            				    // spinach.g:482:3: 'plot'
            				    {
            				    	string_literal314=(IToken)Match(input,51,FOLLOW_51_in_string_literal2848); 
            				    		string_literal314_tree = (object)adaptor.Create(string_literal314);
            				    		adaptor.AddChild(root_0, string_literal314_tree);

            				    	retval.ret.setText("plot");

            				    }
            				    break;
            				case 18 :
            				    // spinach.g:483:3: 'resetPlot'
            				    {
            				    	string_literal315=(IToken)Match(input,52,FOLLOW_52_in_string_literal2853); 
            				    		string_literal315_tree = (object)adaptor.Create(string_literal315);
            				    		adaptor.AddChild(root_0, string_literal315_tree);

            				    	retval.ret.setText("resetPlot");

            				    }
            				    break;
            				case 19 :
            				    // spinach.g:484:3: 'setPlotAxis'
            				    {
            				    	string_literal316=(IToken)Match(input,53,FOLLOW_53_in_string_literal2858); 
            				    		string_literal316_tree = (object)adaptor.Create(string_literal316);
            				    		adaptor.AddChild(root_0, string_literal316_tree);

            				    	retval.ret.setText("setPlotAxis");

            				    }
            				    break;
            				case 20 :
            				    // spinach.g:485:3: 'setAxisTitle'
            				    {
            				    	string_literal317=(IToken)Match(input,54,FOLLOW_54_in_string_literal2863); 
            				    		string_literal317_tree = (object)adaptor.Create(string_literal317);
            				    		adaptor.AddChild(root_0, string_literal317_tree);

            				    	retval.ret.setText("setAxisTitle");

            				    }
            				    break;
            				case 21 :
            				    // spinach.g:486:3: 'setScaleMode'
            				    {
            				    	string_literal318=(IToken)Match(input,57,FOLLOW_57_in_string_literal2868); 
            				    		string_literal318_tree = (object)adaptor.Create(string_literal318);
            				    		adaptor.AddChild(root_0, string_literal318_tree);

            				    	retval.ret.setText("setScaleMode");

            				    }
            				    break;
            				case 22 :
            				    // spinach.g:487:3: '('
            				    {
            				    	char_literal319=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_string_literal2873); 
            				    		char_literal319_tree = (object)adaptor.Create(char_literal319);
            				    		adaptor.AddChild(root_0, char_literal319_tree);

            				    	retval.ret.setText("(");

            				    }
            				    break;
            				case 23 :
            				    // spinach.g:488:3: ')'
            				    {
            				    	char_literal320=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_string_literal2878); 
            				    		char_literal320_tree = (object)adaptor.Create(char_literal320);
            				    		adaptor.AddChild(root_0, char_literal320_tree);

            				    	retval.ret.setText(")");

            				    }
            				    break;
            				case 24 :
            				    // spinach.g:489:3: '{'
            				    {
            				    	char_literal321=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_string_literal2883); 
            				    		char_literal321_tree = (object)adaptor.Create(char_literal321);
            				    		adaptor.AddChild(root_0, char_literal321_tree);

            				    	retval.ret.setText("{");

            				    }
            				    break;
            				case 25 :
            				    // spinach.g:490:3: '}'
            				    {
            				    	char_literal322=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_string_literal2888); 
            				    		char_literal322_tree = (object)adaptor.Create(char_literal322);
            				    		adaptor.AddChild(root_0, char_literal322_tree);

            				    	retval.ret.setText("}");

            				    }
            				    break;
            				case 26 :
            				    // spinach.g:491:3: '->'
            				    {
            				    	string_literal323=(IToken)Match(input,POINT,FOLLOW_POINT_in_string_literal2893); 
            				    		string_literal323_tree = (object)adaptor.Create(string_literal323);
            				    		adaptor.AddChild(root_0, string_literal323_tree);

            				    	retval.ret.setText("->");

            				    }
            				    break;
            				case 27 :
            				    // spinach.g:492:3: '=='
            				    {
            				    	string_literal324=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_string_literal2898); 
            				    		string_literal324_tree = (object)adaptor.Create(string_literal324);
            				    		adaptor.AddChild(root_0, string_literal324_tree);

            				    	retval.ret.setText("==");

            				    }
            				    break;
            				case 28 :
            				    // spinach.g:493:3: '!='
            				    {
            				    	string_literal325=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_string_literal2903); 
            				    		string_literal325_tree = (object)adaptor.Create(string_literal325);
            				    		adaptor.AddChild(root_0, string_literal325_tree);

            				    	retval.ret.setText("!=");

            				    }
            				    break;
            				case 29 :
            				    // spinach.g:494:3: '<='
            				    {
            				    	string_literal326=(IToken)Match(input,LESSTHANEQUALTOEXPRESSION,FOLLOW_LESSTHANEQUALTOEXPRESSION_in_string_literal2908); 
            				    		string_literal326_tree = (object)adaptor.Create(string_literal326);
            				    		adaptor.AddChild(root_0, string_literal326_tree);

            				    	retval.ret.setText("<=");

            				    }
            				    break;
            				case 30 :
            				    // spinach.g:495:3: '&'
            				    {
            				    	char_literal327=(IToken)Match(input,59,FOLLOW_59_in_string_literal2913); 
            				    		char_literal327_tree = (object)adaptor.Create(char_literal327);
            				    		adaptor.AddChild(root_0, char_literal327_tree);

            				    	retval.ret.setText("&");

            				    }
            				    break;
            				case 31 :
            				    // spinach.g:496:3: PERCENT
            				    {
            				    	PERCENT328=(IToken)Match(input,PERCENT,FOLLOW_PERCENT_in_string_literal2918); 
            				    		PERCENT328_tree = (object)adaptor.Create(PERCENT328);
            				    		adaptor.AddChild(root_0, PERCENT328_tree);

            				    	retval.ret.setText(((PERCENT328 != null) ? PERCENT328.Text : null));

            				    }
            				    break;
            				case 32 :
            				    // spinach.g:497:3: '^'
            				    {
            				    	char_literal329=(IToken)Match(input,61,FOLLOW_61_in_string_literal2923); 
            				    		char_literal329_tree = (object)adaptor.Create(char_literal329);
            				    		adaptor.AddChild(root_0, char_literal329_tree);

            				    	retval.ret.setText("^");

            				    }
            				    break;
            				case 33 :
            				    // spinach.g:498:3: '$'
            				    {
            				    	char_literal330=(IToken)Match(input,62,FOLLOW_62_in_string_literal2928); 
            				    		char_literal330_tree = (object)adaptor.Create(char_literal330);
            				    		adaptor.AddChild(root_0, char_literal330_tree);

            				    	retval.ret.setText("$");

            				    }
            				    break;
            				case 34 :
            				    // spinach.g:499:3: '#'
            				    {
            				    	char_literal331=(IToken)Match(input,63,FOLLOW_63_in_string_literal2933); 
            				    		char_literal331_tree = (object)adaptor.Create(char_literal331);
            				    		adaptor.AddChild(root_0, char_literal331_tree);

            				    	retval.ret.setText("#");

            				    }
            				    break;
            				case 35 :
            				    // spinach.g:500:3: '@'
            				    {
            				    	char_literal332=(IToken)Match(input,64,FOLLOW_64_in_string_literal2938); 
            				    		char_literal332_tree = (object)adaptor.Create(char_literal332);
            				    		adaptor.AddChild(root_0, char_literal332_tree);

            				    	retval.ret.setText("@");

            				    }
            				    break;
            				case 36 :
            				    // spinach.g:501:3: ';'
            				    {
            				    	char_literal333=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_string_literal2943); 
            				    		char_literal333_tree = (object)adaptor.Create(char_literal333);
            				    		adaptor.AddChild(root_0, char_literal333_tree);

            				    	retval.ret.setText(";");

            				    }
            				    break;
            				case 37 :
            				    // spinach.g:502:3: '!'
            				    {
            				    	char_literal334=(IToken)Match(input,65,FOLLOW_65_in_string_literal2948); 
            				    		char_literal334_tree = (object)adaptor.Create(char_literal334);
            				    		adaptor.AddChild(root_0, char_literal334_tree);

            				    	retval.ret.setText("!");

            				    }
            				    break;
            				case 38 :
            				    // spinach.g:503:3: '?'
            				    {
            				    	char_literal335=(IToken)Match(input,66,FOLLOW_66_in_string_literal2953); 
            				    		char_literal335_tree = (object)adaptor.Create(char_literal335);
            				    		adaptor.AddChild(root_0, char_literal335_tree);

            				    	retval.ret.setText("?");

            				    }
            				    break;
            				case 39 :
            				    // spinach.g:504:3: '/'
            				    {
            				    	char_literal336=(IToken)Match(input,67,FOLLOW_67_in_string_literal2958); 
            				    		char_literal336_tree = (object)adaptor.Create(char_literal336);
            				    		adaptor.AddChild(root_0, char_literal336_tree);

            				    	retval.ret.setText("/");

            				    }
            				    break;
            				case 40 :
            				    // spinach.g:505:3: ':'
            				    {
            				    	char_literal337=(IToken)Match(input,60,FOLLOW_60_in_string_literal2963); 
            				    		char_literal337_tree = (object)adaptor.Create(char_literal337);
            				    		adaptor.AddChild(root_0, char_literal337_tree);

            				    	retval.ret.setText(":");

            				    }
            				    break;
            				case 41 :
            				    // spinach.g:506:3: '['
            				    {
            				    	char_literal338=(IToken)Match(input,29,FOLLOW_29_in_string_literal2968); 
            				    		char_literal338_tree = (object)adaptor.Create(char_literal338);
            				    		adaptor.AddChild(root_0, char_literal338_tree);

            				    	retval.ret.setText("[");

            				    }
            				    break;
            				case 42 :
            				    // spinach.g:507:3: ']'
            				    {
            				    	char_literal339=(IToken)Match(input,30,FOLLOW_30_in_string_literal2973); 
            				    		char_literal339_tree = (object)adaptor.Create(char_literal339);
            				    		adaptor.AddChild(root_0, char_literal339_tree);

            				    	retval.ret.setText("]");

            				    }
            				    break;
            				case 43 :
            				    // spinach.g:508:3: ','
            				    {
            				    	char_literal340=(IToken)Match(input,31,FOLLOW_31_in_string_literal2979); 
            				    		char_literal340_tree = (object)adaptor.Create(char_literal340);
            				    		adaptor.AddChild(root_0, char_literal340_tree);

            				    	retval.ret.setText(",");

            				    }
            				    break;
            				case 44 :
            				    // spinach.g:509:3: '1D'
            				    {
            				    	string_literal341=(IToken)Match(input,48,FOLLOW_48_in_string_literal2984); 
            				    		string_literal341_tree = (object)adaptor.Create(string_literal341);
            				    		adaptor.AddChild(root_0, string_literal341_tree);

            				    	retval.ret.setText("1D");

            				    }
            				    break;
            				case 45 :
            				    // spinach.g:510:3: '2D'
            				    {
            				    	string_literal342=(IToken)Match(input,49,FOLLOW_49_in_string_literal2989); 
            				    		string_literal342_tree = (object)adaptor.Create(string_literal342);
            				    		adaptor.AddChild(root_0, string_literal342_tree);

            				    	retval.ret.setText("2D");

            				    }
            				    break;
            				case 46 :
            				    // spinach.g:511:3: '3D'
            				    {
            				    	string_literal343=(IToken)Match(input,50,FOLLOW_50_in_string_literal2994); 
            				    		string_literal343_tree = (object)adaptor.Create(string_literal343);
            				    		adaptor.AddChild(root_0, string_literal343_tree);

            				    	retval.ret.setText("3D");

            				    }
            				    break;
            				case 47 :
            				    // spinach.g:512:3: 'void'
            				    {
            				    	string_literal344=(IToken)Match(input,43,FOLLOW_43_in_string_literal2999); 
            				    		string_literal344_tree = (object)adaptor.Create(string_literal344);
            				    		adaptor.AddChild(root_0, string_literal344_tree);

            				    	retval.ret.setText("void");

            				    }
            				    break;
            				case 48 :
            				    // spinach.g:513:3: 'struct'
            				    {
            				    	string_literal345=(IToken)Match(input,34,FOLLOW_34_in_string_literal3004); 
            				    		string_literal345_tree = (object)adaptor.Create(string_literal345);
            				    		adaptor.AddChild(root_0, string_literal345_tree);

            				    	retval.ret.setText("struct");

            				    }
            				    break;
            				case 49 :
            				    // spinach.g:514:4: 'return'
            				    {
            				    	string_literal346=(IToken)Match(input,46,FOLLOW_46_in_string_literal3010); 
            				    		string_literal346_tree = (object)adaptor.Create(string_literal346);
            				    		adaptor.AddChild(root_0, string_literal346_tree);

            				    	retval.ret.setText("return");

            				    }
            				    break;
            				case 50 :
            				    // spinach.g:515:4: 'delete'
            				    {
            				    	string_literal347=(IToken)Match(input,35,FOLLOW_35_in_string_literal3016); 
            				    		string_literal347_tree = (object)adaptor.Create(string_literal347);
            				    		adaptor.AddChild(root_0, string_literal347_tree);

            				    	retval.ret.setText("delete");

            				    }
            				    break;
            				case 51 :
            				    // spinach.g:516:4: 'DOT'
            				    {
            				    	string_literal348=(IToken)Match(input,44,FOLLOW_44_in_string_literal3023); 
            				    		string_literal348_tree = (object)adaptor.Create(string_literal348);
            				    		adaptor.AddChild(root_0, string_literal348_tree);

            				    	retval.ret.setText("DOT");

            				    }
            				    break;
            				case 52 :
            				    // spinach.g:517:4: 'T'
            				    {
            				    	char_literal349=(IToken)Match(input,45,FOLLOW_45_in_string_literal3030); 
            				    		char_literal349_tree = (object)adaptor.Create(char_literal349);
            				    		adaptor.AddChild(root_0, char_literal349_tree);

            				    	retval.ret.setText("T");

            				    }
            				    break;
            				case 53 :
            				    // spinach.g:518:4: 'else'
            				    {
            				    	string_literal350=(IToken)Match(input,41,FOLLOW_41_in_string_literal3037); 
            				    		string_literal350_tree = (object)adaptor.Create(string_literal350);
            				    		adaptor.AddChild(root_0, string_literal350_tree);

            				    	retval.ret.setText("else");

            				    }
            				    break;
            				case 54 :
            				    // spinach.g:519:4: 'if'
            				    {
            				    	string_literal351=(IToken)Match(input,40,FOLLOW_40_in_string_literal3044); 
            				    		string_literal351_tree = (object)adaptor.Create(string_literal351);
            				    		adaptor.AddChild(root_0, string_literal351_tree);

            				    	retval.ret.setText("if");

            				    }
            				    break;
            				case 55 :
            				    // spinach.g:520:4: 'for'
            				    {
            				    	string_literal352=(IToken)Match(input,42,FOLLOW_42_in_string_literal3051); 
            				    		string_literal352_tree = (object)adaptor.Create(string_literal352);
            				    		adaptor.AddChild(root_0, string_literal352_tree);

            				    	retval.ret.setText("for");

            				    }
            				    break;
            				case 56 :
            				    // spinach.g:521:3: 'parallelfor'
            				    {
            				    	string_literal353=(IToken)Match(input,37,FOLLOW_37_in_string_literal3056); 
            				    		string_literal353_tree = (object)adaptor.Create(string_literal353);
            				    		adaptor.AddChild(root_0, string_literal353_tree);

            				    	retval.ret.setText("parallelfor");

            				    }
            				    break;
            				case 57 :
            				    // spinach.g:522:4: 'SYNC'
            				    {
            				    	string_literal354=(IToken)Match(input,39,FOLLOW_39_in_string_literal3062); 
            				    		string_literal354_tree = (object)adaptor.Create(string_literal354);
            				    		adaptor.AddChild(root_0, string_literal354_tree);

            				    	retval.ret.setText("SYNC");

            				    }
            				    break;
            				case 58 :
            				    // spinach.g:523:4: 'print'
            				    {
            				    	string_literal355=(IToken)Match(input,36,FOLLOW_36_in_string_literal3069); 
            				    		string_literal355_tree = (object)adaptor.Create(string_literal355);
            				    		adaptor.AddChild(root_0, string_literal355_tree);

            				    	retval.ret.setText("print");

            				    }
            				    break;
            				case 59 :
            				    // spinach.g:524:4: 'to'
            				    {
            				    	string_literal356=(IToken)Match(input,38,FOLLOW_38_in_string_literal3076); 
            				    		string_literal356_tree = (object)adaptor.Create(string_literal356);
            				    		adaptor.AddChild(root_0, string_literal356_tree);

            				    	retval.ret.setText("to");

            				    }
            				    break;

            				default:
            				    goto loop61;
            		    }
            		} while (true);

            		loop61:
            			;	// Stops C# compiler whining that label 'loop61' has no statements

            		char_literal357=(IToken)Match(input,58,FOLLOW_58_in_string_literal3084); 
            			char_literal357_tree = (object)adaptor.Create(char_literal357);
            			adaptor.AddChild(root_0, char_literal357_tree);


            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "string_literal"

    // Delegated rules


   	protected DFA7 dfa7;
   	protected DFA17 dfa17;
   	protected DFA43 dfa43;
   	protected DFA47 dfa47;
	private void InitializeCyclicDFAs()
	{
    	this.dfa7 = new DFA7(this);
    	this.dfa17 = new DFA17(this);
    	this.dfa43 = new DFA43(this);
    	this.dfa47 = new DFA47(this);




	}

    const string DFA7_eotS =
        "\x0a\uffff";
    const string DFA7_eofS =
        "\x0a\uffff";
    const string DFA7_minS =
        "\x01\x04\x01\x09\x01\uffff\x01\x04\x01\uffff\x02\x1e\x01\x09\x02"+
        "\uffff";
    const string DFA7_maxS =
        "\x01\x04\x01\x21\x01\uffff\x01\x05\x01\uffff\x02\x1e\x01\x21\x02"+
        "\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x04\x01\uffff\x01\x01\x03\uffff\x01\x02\x01\x03";
    const string DFA7_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x01",
            "\x01\x04\x03\uffff\x01\x04\x03\uffff\x02\x04\x01\uffff\x01"+
            "\x02\x01\uffff\x06\x04\x01\uffff\x01\x03\x01\uffff\x01\x04\x01"+
            "\uffff\x01\x04",
            "",
            "\x01\x06\x01\x05",
            "",
            "\x01\x07",
            "\x01\x07",
            "\x01\x09\x03\uffff\x01\x09\x03\uffff\x02\x09\x03\uffff\x06"+
            "\x09\x01\uffff\x01\x08\x01\uffff\x01\x09\x01\uffff\x01\x09",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "69:3: ( variable | matrixelem | vectorelem | structassign )"; }
        }

    }

    const string DFA17_eotS =
        "\x0a\uffff";
    const string DFA17_eofS =
        "\x0a\uffff";
    const string DFA17_minS =
        "\x01\x04\x01\x08\x01\uffff\x01\x04\x01\uffff\x02\x1e\x01\x08\x02"+
        "\uffff";
    const string DFA17_maxS =
        "\x01\x04\x01\x1d\x01\uffff\x01\x05\x01\uffff\x02\x1e\x01\x1d\x02"+
        "\uffff";
    const string DFA17_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff\x01\x04\x01\x03";
    const string DFA17_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x01",
            "\x01\x02\x0b\uffff\x01\x04\x08\uffff\x01\x03",
            "",
            "\x01\x06\x01\x05",
            "",
            "\x01\x07",
            "\x01\x07",
            "\x01\x09\x14\uffff\x01\x08",
            "",
            ""
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "142:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )"; }
        }

    }

    const string DFA43_eotS =
        "\x0f\uffff";
    const string DFA43_eofS =
        "\x0f\uffff";
    const string DFA43_minS =
        "\x01\x04\x01\uffff\x01\x08\x0c\uffff";
    const string DFA43_maxS =
        "\x01\x38\x01\uffff\x01\x1d\x0c\uffff";
    const string DFA43_acceptS =
        "\x01\uffff\x01\x0d\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x01\x01\x02";
    const string DFA43_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x04\uffff\x01"+
            "\x01\x0c\uffff\x01\x05\x03\uffff\x01\x04\x02\uffff\x01\x06\x01"+
            "\x07\x01\x0a\x02\uffff\x01\x08\x01\uffff\x01\x0b\x03\uffff\x01"+
            "\x09\x09\uffff\x01\x0c",
            "",
            "\x01\x0d\x02\uffff\x01\x0e\x08\uffff\x01\x0d\x08\uffff\x01"+
            "\x0d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA43_eot = DFA.UnpackEncodedString(DFA43_eotS);
    static readonly short[] DFA43_eof = DFA.UnpackEncodedString(DFA43_eofS);
    static readonly char[] DFA43_min = DFA.UnpackEncodedStringToUnsignedChars(DFA43_minS);
    static readonly char[] DFA43_max = DFA.UnpackEncodedStringToUnsignedChars(DFA43_maxS);
    static readonly short[] DFA43_accept = DFA.UnpackEncodedString(DFA43_acceptS);
    static readonly short[] DFA43_special = DFA.UnpackEncodedString(DFA43_specialS);
    static readonly short[][] DFA43_transition = DFA.UnpackEncodedStringArray(DFA43_transitionS);

    protected class DFA43 : DFA
    {
        public DFA43(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 43;
            this.eot = DFA43_eot;
            this.eof = DFA43_eof;
            this.min = DFA43_min;
            this.max = DFA43_max;
            this.accept = DFA43_accept;
            this.special = DFA43_special;
            this.transition = DFA43_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 297:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement | comment )+"; }
        }

    }

    const string DFA47_eotS =
        "\x0f\uffff";
    const string DFA47_eofS =
        "\x0f\uffff";
    const string DFA47_minS =
        "\x01\x04\x01\uffff\x01\x08\x0c\uffff";
    const string DFA47_maxS =
        "\x01\x38\x01\uffff\x01\x1d\x0c\uffff";
    const string DFA47_acceptS =
        "\x01\uffff\x01\x0d\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x01\x01\x02";
    const string DFA47_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA47_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x04\uffff\x01"+
            "\x01\x0c\uffff\x01\x05\x03\uffff\x01\x04\x02\uffff\x01\x06\x01"+
            "\x07\x01\x0b\x02\uffff\x01\x08\x01\uffff\x01\x0c\x03\uffff\x01"+
            "\x09\x09\uffff\x01\x0a",
            "",
            "\x01\x0d\x02\uffff\x01\x0e\x08\uffff\x01\x0d\x08\uffff\x01"+
            "\x0d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
    static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
    static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
    static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
    static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
    static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
    static readonly short[][] DFA47_transition = DFA.UnpackEncodedStringArray(DFA47_transitionS);

    protected class DFA47 : DFA
    {
        public DFA47(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 47;
            this.eot = DFA47_eot;
            this.eof = DFA47_eof;
            this.min = DFA47_min;
            this.max = DFA47_max;
            this.accept = DFA47_accept;
            this.special = DFA47_special;
            this.transition = DFA47_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 307:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | comment | parallelfor | forstatement )+"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program70 = new BitSet(new ulong[]{0x01F88D3D10000490UL});
    public static readonly BitSet FOLLOW_comment_in_program76 = new BitSet(new ulong[]{0x01F88D3D10000490UL});
    public static readonly BitSet FOLLOW_EOF_in_program82 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr1_in_expr105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallelfor_in_expr109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functiondefination_in_expr124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forexpr_in_expr1140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr1152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr2_in_forexpr185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_forexpr194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_plotfunctions_in_forexpr204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_forexpr213 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_forexpr222 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expr2242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifelse_in_expr2252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forstatement_in_expr2262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_expr2274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_expr2286 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr2293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_int_or_double_literal318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_double_literal_in_var_int_or_double_literal328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varorstruct_in_var_int_or_double_literal336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_varorstruct351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixelem_in_varorstruct355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorelem_in_varorstruct359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structassign_in_varorstruct365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_double_literal430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixvardec452 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixvardec454 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixvardec461 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec463 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec465 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec468 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec471 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec474 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec478 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec481 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixvardec489 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matrixvardec496 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec502 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec503 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec510 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec514 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec519 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec522 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec528 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec535 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec538 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec542 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec545 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec551 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matrixvardec562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorvardec580 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorvardec582 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorvardec584 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec587 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec589 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec592 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec595 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorvardec601 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_vectorvardec608 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec615 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec616 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec623 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec626 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec631 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec634 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec639 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec646 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec649 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec656 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec659 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec665 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_vectorvardec672 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem692 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem698 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem702 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem707 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem710 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem713 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem717 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem722 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem747 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorelem753 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorelem757 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem763 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorelem766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment789 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment799 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_vectorelem_in_assignment811 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_matrixelem_in_assignment824 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment832 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_assignment842 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_dotproduct_in_assignment846 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixtranspose_in_assignment855 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_assignment859 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment867 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_assignment875 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_additive_expression906 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additive_expression911 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_additive_expression_in_additive_expression917 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplicative_expression945 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_bracket_exp_in_multiplicative_expression957 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplicative_expression971 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_multiplicative_expression981 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_bracket_exp1027 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_bracket_exp1028 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_bracket_exp1030 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expression_in_subtractive_exp1059 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_33_in_subtractive_exp1064 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_subtractive_exp1070 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_34_in_structdec1100 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structdec1102 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_structdec1107 = new BitSet(new ulong[]{0x01F88D3D10008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_structdec1112 = new BitSet(new ulong[]{0x01F88D3D10008490UL});
    public static readonly BitSet FOLLOW_comment_in_structdec1117 = new BitSet(new ulong[]{0x01F88D3D10008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_structdec1123 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec1128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarvardec1149 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_scalarvardec1156 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarvardec1163 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_scalarvardec1167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1189 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1196 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec1202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1221 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_DOT_in_structassign1224 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1227 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_deletionofvar1248 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_deletionofvar1252 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_deletionofvar1256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_print1275 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_varorstruct_in_print1278 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_print1287 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print1312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parallelfor1334 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_parallelfor1335 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_parallelfor1341 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_POINT_in_parallelfor1344 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallelfor1350 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_parallelfor1353 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallelfor1358 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_parallelfor1361 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_parallelfor1363 = new BitSet(new ulong[]{0x0000050800000490UL});
    public static readonly BitSet FOLLOW_expr2_in_parallelfor1370 = new BitSet(new ulong[]{0x0000058800008490UL});
    public static readonly BitSet FOLLOW_39_in_parallelfor1374 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_parallelfor1377 = new BitSet(new ulong[]{0x0000050800008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_parallelfor1384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_ifelse1401 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_ifelse1403 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_varorstruct_in_ifelse1406 = new BitSet(new ulong[]{0x000000000FC00000UL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_ifelse1417 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_ifelse1427 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_ifelse1437 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_LESSTHANEQUALTOEXPRESSION_in_ifelse1448 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_ifelse1458 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_ifelse1469 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_ifelse1482 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_ifelse1489 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_ifelse1493 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1495 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1503 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1508 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_ifelse1511 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1514 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1523 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr1_in_ifloop1550 = new BitSet(new ulong[]{0x01F8CD3D10000492UL});
    public static readonly BitSet FOLLOW_functionreturn_in_ifloop1553 = new BitSet(new ulong[]{0x01F8CD3D10000492UL});
    public static readonly BitSet FOLLOW_comment_in_ifloop1556 = new BitSet(new ulong[]{0x01F8CD3D10000492UL});
    public static readonly BitSet FOLLOW_42_in_forstatement1574 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_forstatement1576 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_forstatement1582 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_POINT_in_forstatement1585 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_forstatement1591 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_forstatement1594 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_forstatement1599 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_forstatement1602 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_forstatement1604 = new BitSet(new ulong[]{0x01F88D3D10000490UL});
    public static readonly BitSet FOLLOW_forexpr_in_forstatement1609 = new BitSet(new ulong[]{0x01F88D3D10008490UL});
    public static readonly BitSet FOLLOW_comment_in_forstatement1612 = new BitSet(new ulong[]{0x01F88D3D10008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_forstatement1616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_functioncall1634 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functioncall1639 = new BitSet(new ulong[]{0x0400200000002870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1644 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_functioncall1650 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functioncall1655 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1660 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_functioncall1666 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functioncall1674 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functioncall1678 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_functiondefination1705 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1710 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1716 = new BitSet(new ulong[]{0x0000000110002080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1724 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1727 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1732 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1741 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1743 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1747 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1750 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1754 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1762 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1770 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1778 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1784 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1792 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1796 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1800 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1804 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_comment_in_functiondefination1807 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_functiondefination1816 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1821 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1827 = new BitSet(new ulong[]{0x0000000110002080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1836 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1839 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1843 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1852 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1854 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1858 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1861 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1865 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1873 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1881 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1889 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1895 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1903 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1907 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_comment_in_functiondefination1910 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1913 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1917 = new BitSet(new ulong[]{0x01F8CD3D10008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1924 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct1946 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_dotproduct1950 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct1956 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_matrixtranspose1975 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_matrixtranspose1977 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixtranspose1979 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_matrixtranspose1982 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixreference1998 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixreference2000 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixreference2005 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixreference2007 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixreference2011 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorreference2030 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorreference2032 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorreference2037 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2039 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorreference2043 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarargument_in_arguments2059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixreference_in_arguments2065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorreference_in_arguments2071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarargument2095 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarargument2102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_functionreturn2122 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functionreturn2125 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functionreturn2129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_plotfunctions2150 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2153 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2160 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2165 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2172 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2177 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2184 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2188 = new BitSet(new ulong[]{0x0007000000000000UL});
    public static readonly BitSet FOLLOW_48_in_plotfunctions2192 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2197 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2202 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2205 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2211 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2219 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2220 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2226 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2229 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2235 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2240 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2246 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2250 = new BitSet(new ulong[]{0x0007000000000000UL});
    public static readonly BitSet FOLLOW_48_in_plotfunctions2254 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2259 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2264 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2267 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2273 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2281 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_plotfunctions2288 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2289 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2290 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_plotfunctions2296 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2300 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2307 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2312 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2316 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2321 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2324 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2327 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2332 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2335 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2342 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2346 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2353 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2358 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2362 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2367 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2370 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2373 = new BitSet(new ulong[]{0x0400200000000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2378 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2381 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2389 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_plotfunctions2392 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2396 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_comment2419 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_VARIABLE_in_comment2424 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_comment2431 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_comment2438 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_DOT_in_comment2443 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_28_in_comment2448 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_32_in_comment2453 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_comment2458 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_comment2463 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_VARTYPE_in_comment2468 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_comment2473 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_comment2478 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_comment2483 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_PLUS_in_comment2488 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_comment2493 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_36_in_comment2498 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_47_in_comment2503 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_51_in_comment2508 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_52_in_comment2513 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_53_in_comment2518 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_54_in_comment2523 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_57_in_comment2528 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_58_in_comment2533 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_35_in_comment2539 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_46_in_comment2544 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_comment2549 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_comment2554 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_comment2559 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_comment2564 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_POINT_in_comment2569 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_comment2574 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_comment2579 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_LESSTHANEQUALTOEXPRESSION_in_comment2584 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_59_in_comment2589 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_33_in_comment2594 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_comment2599 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_60_in_comment2604 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_39_in_comment2610 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_PERCENT_in_comment2617 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_61_in_comment2623 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_62_in_comment2628 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_63_in_comment2633 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_64_in_comment2638 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_65_in_comment2643 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_66_in_comment2648 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_67_in_comment2653 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_29_in_comment2660 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_30_in_comment2665 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_31_in_comment2670 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_45_in_comment2676 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_44_in_comment2682 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_48_in_comment2686 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_49_in_comment2691 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_50_in_comment2696 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_43_in_comment2701 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_34_in_comment2706 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_41_in_comment2712 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_40_in_comment2719 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_42_in_comment2724 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_37_in_comment2728 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_38_in_comment2733 = new BitSet(new ulong[]{0xFF7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_56_in_comment2737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_string_literal2758 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_VARIABLE_in_string_literal2764 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_string_literal2771 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_string_literal2778 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_DOT_in_string_literal2783 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_28_in_string_literal2788 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_32_in_string_literal2793 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_string_literal2798 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_string_literal2803 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_VARTYPE_in_string_literal2808 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_string_literal2813 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_string_literal2818 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_string_literal2823 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_33_in_string_literal2828 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_PLUS_in_string_literal2833 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_string_literal2838 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_47_in_string_literal2843 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_51_in_string_literal2848 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_52_in_string_literal2853 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_53_in_string_literal2858 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_54_in_string_literal2863 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_57_in_string_literal2868 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_string_literal2873 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_string_literal2878 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_string_literal2883 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_string_literal2888 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_POINT_in_string_literal2893 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_string_literal2898 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_string_literal2903 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_LESSTHANEQUALTOEXPRESSION_in_string_literal2908 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_59_in_string_literal2913 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_PERCENT_in_string_literal2918 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_61_in_string_literal2923 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_62_in_string_literal2928 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_63_in_string_literal2933 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_64_in_string_literal2938 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_string_literal2943 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_65_in_string_literal2948 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_66_in_string_literal2953 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_67_in_string_literal2958 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_60_in_string_literal2963 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_29_in_string_literal2968 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_30_in_string_literal2973 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_31_in_string_literal2979 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_48_in_string_literal2984 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_49_in_string_literal2989 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_50_in_string_literal2994 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_43_in_string_literal2999 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_34_in_string_literal3004 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_46_in_string_literal3010 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_35_in_string_literal3016 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_44_in_string_literal3023 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_45_in_string_literal3030 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_41_in_string_literal3037 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_40_in_string_literal3044 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_42_in_string_literal3051 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_37_in_string_literal3056 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_39_in_string_literal3062 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_36_in_string_literal3069 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_38_in_string_literal3076 = new BitSet(new ulong[]{0xFE7FFFFFF7DFFFF0UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_58_in_string_literal3084 = new BitSet(new ulong[]{0x0000000000000002UL});

}
