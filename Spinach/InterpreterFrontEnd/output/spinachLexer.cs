// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g 2009-11-26 01:37:19


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class spinachLexer : Lexer {
    public const int T__66 = 66;
    public const int T__29 = 29;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int T__28 = 28;
    public const int T__62 = 62;
    public const int T__27 = 27;
    public const int T__63 = 63;
    public const int POINT = 12;
    public const int EQUALITYEXPRESSION = 21;
    public const int DOUBLE_LITERAL = 6;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int NONEQUALITYEXPRESSION = 22;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int LEFTBRACE = 11;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int LESSTHANEQUALTOEXPRESSION = 24;
    public const int T__54 = 54;
    public const int MULTIPLY = 18;
    public const int T__59 = 59;
    public const int PLUS = 17;
    public const int RIGHTBRACE = 13;
    public const int LESSTHANEXPRESSION = 23;
    public const int DOT = 19;
    public const int T__50 = 50;
    public const int END_OF_STATEMENT = 9;
    public const int RIGHTPARANTHESIS = 15;
    public const int GREATERTHANEQUALTOEXPRESSION = 26;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int SCALEMODE = 16;
    public const int T__40 = 40;
    public const int INT_LITERAL = 5;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int WHITESPACE = 20;
    public const int VARTYPE = 7;
    public const int GREATERTHANEXPRESSION = 25;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int VARIABLE = 4;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRINGTYPE = 10;
    public const int LEFTPARANTHESIS = 14;
    public const int ASSIGNMENT = 8;

    // delegates
    // delegators

    public spinachLexer() 
    {
		InitializeCyclicDFAs();
    }
    public spinachLexer(ICharStream input)
		: this(input, null) {
    }
    public spinachLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g";} 
    }

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:11:7: ( 'matrix' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:11:9: 'matrix'
            {
            	Match("matrix"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:12:7: ( '[' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:12:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:13:7: ( ']' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:13:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:14:7: ( ',' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:14:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:15:7: ( 'vector' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:15:9: 'vector'
            {
            	Match("vector"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:16:7: ( '-' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:16:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:17:7: ( 'struct' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:17:9: 'struct'
            {
            	Match("struct"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:18:7: ( 'delete' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:18:9: 'delete'
            {
            	Match("delete"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:19:7: ( 'print' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:19:9: 'print'
            {
            	Match("print"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:20:7: ( 'parallelfor' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:20:9: 'parallelfor'
            {
            	Match("parallelfor"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:21:7: ( 'to' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:21:9: 'to'
            {
            	Match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:22:7: ( 'SYNC' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:22:9: 'SYNC'
            {
            	Match("SYNC"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:23:7: ( 'if' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:23:9: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:24:7: ( 'else' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:24:9: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:25:7: ( 'for' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:25:9: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:26:7: ( 'void' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:26:9: 'void'
            {
            	Match("void"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:27:7: ( 'DOT' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:27:9: 'DOT'
            {
            	Match("DOT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:28:7: ( 'T' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:28:9: 'T'
            {
            	Match('T'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:29:7: ( 'return' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:29:9: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:30:7: ( 'subPlot' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:30:9: 'subPlot'
            {
            	Match("subPlot"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:31:7: ( '1D' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:31:9: '1D'
            {
            	Match("1D"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:32:7: ( '2D' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:32:9: '2D'
            {
            	Match("2D"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:33:7: ( '3D' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:33:9: '3D'
            {
            	Match("3D"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:34:7: ( 'plot' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:34:9: 'plot'
            {
            	Match("plot"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:35:7: ( 'resetPlot' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:35:9: 'resetPlot'
            {
            	Match("resetPlot"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:36:7: ( 'setPlotAxis' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:36:9: 'setPlotAxis'
            {
            	Match("setPlotAxis"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:37:7: ( 'setAxisTitle' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:37:9: 'setAxisTitle'
            {
            	Match("setAxisTitle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:38:7: ( 'setScaleMode(' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:38:9: 'setScaleMode('
            {
            	Match("setScaleMode("); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:39:7: ( '//' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:39:9: '//'
            {
            	Match("//"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:40:7: ( 'setScaleMode' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:40:9: 'setScaleMode'
            {
            	Match("setScaleMode"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:41:7: ( '\"' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:41:9: '\"'
            {
            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:42:7: ( '&' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:42:9: '&'
            {
            	Match('&'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:43:7: ( ':' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:43:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:44:7: ( '^' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:44:9: '^'
            {
            	Match('^'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:45:7: ( '$' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:45:9: '$'
            {
            	Match('$'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:46:7: ( '#' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:46:9: '#'
            {
            	Match('#'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:47:7: ( '@' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:47:9: '@'
            {
            	Match('@'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:48:7: ( '!' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:48:9: '!'
            {
            	Match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:49:7: ( '?' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:49:9: '?'
            {
            	Match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:50:7: ( '/' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:50:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:535:17: ( ';' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:535:19: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END_OF_STATEMENT"

    // $ANTLR start "SCALEMODE"
    public void mSCALEMODE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SCALEMODE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:536:10: ( 'log' | 'linear' )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == 'l') )
            {
                int LA1_1 = input.LA(2);

                if ( (LA1_1 == 'o') )
                {
                    alt1 = 1;
                }
                else if ( (LA1_1 == 'i') )
                {
                    alt1 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d1s1 =
                        new NoViableAltException("", 1, 1, input);

                    throw nvae_d1s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:536:12: 'log'
                    {
                    	Match("log"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:536:20: 'linear'
                    {
                    	Match("linear"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SCALEMODE"

    // $ANTLR start "VARTYPE"
    public void mVARTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARTYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:537:9: ( 'int' | 'double' )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == 'i') )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 'd') )
            {
                alt2 = 2;
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:537:11: 'int'
                    {
                    	Match("int"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:537:19: 'double'
                    {
                    	Match("double"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VARTYPE"

    // $ANTLR start "STRINGTYPE"
    public void mSTRINGTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRINGTYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:538:12: ( 'string' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:538:14: 'string'
            {
            	Match("string"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRINGTYPE"

    // $ANTLR start "DOT"
    public void mDOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:539:5: ( '.' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:539:6: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOT"

    // $ANTLR start "ASSIGNMENT"
    public void mASSIGNMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGNMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:540:11: ( '=' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:540:13: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGNMENT"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:541:5: ( '+' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:541:7: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "MULTIPLY"
    public void mMULTIPLY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTIPLY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:542:9: ( '*' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:542:10: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULTIPLY"

    // $ANTLR start "VARIABLE"
    public void mVARIABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARIABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:543:9: ( ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( INT_LITERAL )* )+ )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:543:11: ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( INT_LITERAL )* )+
            {
            	// C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:543:11: ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( INT_LITERAL )* )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= 'A' && LA4_0 <= 'Z') || (LA4_0 >= 'a' && LA4_0 <= 'z')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:543:12: ( 'a' .. 'z' | 'A' .. 'Z' ) ( INT_LITERAL )*
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}

            			    	// C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:543:35: ( INT_LITERAL )*
            			    	do 
            			    	{
            			    	    int alt3 = 2;
            			    	    int LA3_0 = input.LA(1);

            			    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            			    	    {
            			    	        alt3 = 1;
            			    	    }


            			    	    switch (alt3) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:543:35: INT_LITERAL
            			    			    {
            			    			    	mINT_LITERAL(); 

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop3;
            			    	    }
            			    	} while (true);

            			    	loop3:
            			    		;	// Stops C# compiler whining that label 'loop3' has no statements


            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VARIABLE"

    // $ANTLR start "INT_LITERAL"
    public void mINT_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:544:12: ( ( '0' .. '9' )+ )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:544:14: ( '0' .. '9' )+
            {
            	// C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:544:14: ( '0' .. '9' )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:544:15: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee5 =
            		                new EarlyExitException(5, input);
            		            throw eee5;
            	    }
            	    cnt5++;
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT_LITERAL"

    // $ANTLR start "DOUBLE_LITERAL"
    public void mDOUBLE_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLE_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:545:15: ( ( INT_LITERAL DOT INT_LITERAL ) )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:545:16: ( INT_LITERAL DOT INT_LITERAL )
            {
            	// C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:545:16: ( INT_LITERAL DOT INT_LITERAL )
            	// C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:545:17: INT_LITERAL DOT INT_LITERAL
            	{
            		mINT_LITERAL(); 
            		mDOT(); 
            		mINT_LITERAL(); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOUBLE_LITERAL"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:546:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:546:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:546:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= '\t' && LA6_0 <= '\n') || LA6_0 == '\r' || LA6_0 == ' ') )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	_channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    // $ANTLR start "LEFTBRACE"
    public void mLEFTBRACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEFTBRACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:548:11: ( '(' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:548:12: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LEFTBRACE"

    // $ANTLR start "RIGHTBRACE"
    public void mRIGHTBRACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RIGHTBRACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:549:11: ( ')' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:549:12: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RIGHTBRACE"

    // $ANTLR start "LEFTPARANTHESIS"
    public void mLEFTPARANTHESIS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEFTPARANTHESIS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:550:16: ( '{' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:550:17: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LEFTPARANTHESIS"

    // $ANTLR start "RIGHTPARANTHESIS"
    public void mRIGHTPARANTHESIS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RIGHTPARANTHESIS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:551:17: ( '}' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:551:18: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RIGHTPARANTHESIS"

    // $ANTLR start "POINT"
    public void mPOINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = POINT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:552:6: ( '->' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:552:8: '->'
            {
            	Match("->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "POINT"

    // $ANTLR start "EQUALITYEXPRESSION"
    public void mEQUALITYEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUALITYEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:553:19: ( '==' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:553:21: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQUALITYEXPRESSION"

    // $ANTLR start "NONEQUALITYEXPRESSION"
    public void mNONEQUALITYEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NONEQUALITYEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:554:22: ( '!=' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:554:24: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NONEQUALITYEXPRESSION"

    // $ANTLR start "LESSTHANEXPRESSION"
    public void mLESSTHANEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESSTHANEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:555:20: ( '<' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:555:21: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LESSTHANEXPRESSION"

    // $ANTLR start "LESSTHANEQUALTOEXPRESSION"
    public void mLESSTHANEQUALTOEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESSTHANEQUALTOEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:556:26: ( '<=' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:556:27: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LESSTHANEQUALTOEXPRESSION"

    // $ANTLR start "GREATERTHANEXPRESSION"
    public void mGREATERTHANEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GREATERTHANEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:557:23: ( '>' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:557:24: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GREATERTHANEXPRESSION"

    // $ANTLR start "GREATERTHANEQUALTOEXPRESSION"
    public void mGREATERTHANEQUALTOEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GREATERTHANEQUALTOEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:558:29: ( '>=' )
            // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:558:30: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GREATERTHANEQUALTOEXPRESSION"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:8: ( T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | END_OF_STATEMENT | SCALEMODE | VARTYPE | STRINGTYPE | DOT | ASSIGNMENT | PLUS | MULTIPLY | VARIABLE | INT_LITERAL | DOUBLE_LITERAL | WHITESPACE | LEFTBRACE | RIGHTBRACE | LEFTPARANTHESIS | RIGHTPARANTHESIS | POINT | EQUALITYEXPRESSION | NONEQUALITYEXPRESSION | LESSTHANEXPRESSION | LESSTHANEQUALTOEXPRESSION | GREATERTHANEXPRESSION | GREATERTHANEQUALTOEXPRESSION )
        int alt7 = 63;
        alt7 = dfa7.Predict(input);
        switch (alt7) 
        {
            case 1 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:10: T__27
                {
                	mT__27(); 

                }
                break;
            case 2 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:16: T__28
                {
                	mT__28(); 

                }
                break;
            case 3 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:22: T__29
                {
                	mT__29(); 

                }
                break;
            case 4 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:28: T__30
                {
                	mT__30(); 

                }
                break;
            case 5 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:34: T__31
                {
                	mT__31(); 

                }
                break;
            case 6 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:40: T__32
                {
                	mT__32(); 

                }
                break;
            case 7 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:46: T__33
                {
                	mT__33(); 

                }
                break;
            case 8 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:52: T__34
                {
                	mT__34(); 

                }
                break;
            case 9 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:58: T__35
                {
                	mT__35(); 

                }
                break;
            case 10 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:64: T__36
                {
                	mT__36(); 

                }
                break;
            case 11 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:70: T__37
                {
                	mT__37(); 

                }
                break;
            case 12 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:76: T__38
                {
                	mT__38(); 

                }
                break;
            case 13 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:82: T__39
                {
                	mT__39(); 

                }
                break;
            case 14 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:88: T__40
                {
                	mT__40(); 

                }
                break;
            case 15 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:94: T__41
                {
                	mT__41(); 

                }
                break;
            case 16 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:100: T__42
                {
                	mT__42(); 

                }
                break;
            case 17 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:106: T__43
                {
                	mT__43(); 

                }
                break;
            case 18 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:112: T__44
                {
                	mT__44(); 

                }
                break;
            case 19 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:118: T__45
                {
                	mT__45(); 

                }
                break;
            case 20 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:124: T__46
                {
                	mT__46(); 

                }
                break;
            case 21 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:130: T__47
                {
                	mT__47(); 

                }
                break;
            case 22 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:136: T__48
                {
                	mT__48(); 

                }
                break;
            case 23 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:142: T__49
                {
                	mT__49(); 

                }
                break;
            case 24 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:148: T__50
                {
                	mT__50(); 

                }
                break;
            case 25 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:154: T__51
                {
                	mT__51(); 

                }
                break;
            case 26 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:160: T__52
                {
                	mT__52(); 

                }
                break;
            case 27 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:166: T__53
                {
                	mT__53(); 

                }
                break;
            case 28 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:172: T__54
                {
                	mT__54(); 

                }
                break;
            case 29 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:178: T__55
                {
                	mT__55(); 

                }
                break;
            case 30 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:184: T__56
                {
                	mT__56(); 

                }
                break;
            case 31 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:190: T__57
                {
                	mT__57(); 

                }
                break;
            case 32 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:196: T__58
                {
                	mT__58(); 

                }
                break;
            case 33 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:202: T__59
                {
                	mT__59(); 

                }
                break;
            case 34 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:208: T__60
                {
                	mT__60(); 

                }
                break;
            case 35 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:214: T__61
                {
                	mT__61(); 

                }
                break;
            case 36 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:220: T__62
                {
                	mT__62(); 

                }
                break;
            case 37 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:226: T__63
                {
                	mT__63(); 

                }
                break;
            case 38 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:232: T__64
                {
                	mT__64(); 

                }
                break;
            case 39 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:238: T__65
                {
                	mT__65(); 

                }
                break;
            case 40 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:244: T__66
                {
                	mT__66(); 

                }
                break;
            case 41 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:250: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 42 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:267: SCALEMODE
                {
                	mSCALEMODE(); 

                }
                break;
            case 43 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:277: VARTYPE
                {
                	mVARTYPE(); 

                }
                break;
            case 44 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:285: STRINGTYPE
                {
                	mSTRINGTYPE(); 

                }
                break;
            case 45 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:296: DOT
                {
                	mDOT(); 

                }
                break;
            case 46 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:300: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 47 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:311: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 48 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:316: MULTIPLY
                {
                	mMULTIPLY(); 

                }
                break;
            case 49 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:325: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 50 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:334: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 51 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:346: DOUBLE_LITERAL
                {
                	mDOUBLE_LITERAL(); 

                }
                break;
            case 52 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:361: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;
            case 53 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:372: LEFTBRACE
                {
                	mLEFTBRACE(); 

                }
                break;
            case 54 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:382: RIGHTBRACE
                {
                	mRIGHTBRACE(); 

                }
                break;
            case 55 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:393: LEFTPARANTHESIS
                {
                	mLEFTPARANTHESIS(); 

                }
                break;
            case 56 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:409: RIGHTPARANTHESIS
                {
                	mRIGHTPARANTHESIS(); 

                }
                break;
            case 57 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:426: POINT
                {
                	mPOINT(); 

                }
                break;
            case 58 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:432: EQUALITYEXPRESSION
                {
                	mEQUALITYEXPRESSION(); 

                }
                break;
            case 59 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:451: NONEQUALITYEXPRESSION
                {
                	mNONEQUALITYEXPRESSION(); 

                }
                break;
            case 60 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:473: LESSTHANEXPRESSION
                {
                	mLESSTHANEXPRESSION(); 

                }
                break;
            case 61 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:492: LESSTHANEQUALTOEXPRESSION
                {
                	mLESSTHANEQUALTOEXPRESSION(); 

                }
                break;
            case 62 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:518: GREATERTHANEXPRESSION
                {
                	mGREATERTHANEXPRESSION(); 

                }
                break;
            case 63 :
                // C:\\Users\\Jegan\\Desktop\\SpinachLatestVersion\\Spinach\\InterpreterFrontEnd\\spinach.g:1:540: GREATERTHANEQUALTOEXPRESSION
                {
                	mGREATERTHANEQUALTOEXPRESSION(); 

                }
                break;

        }

    }


    protected DFA7 dfa7;
	private void InitializeCyclicDFAs()
	{
	    this.dfa7 = new DFA7(this);
	}

    const string DFA7_eotS =
        "\x01\uffff\x01\x25\x03\uffff\x01\x25\x01\x32\x09\x25\x01\x42\x01"+
        "\x25\x03\x45\x01\x4a\x07\uffff\x01\x4c\x02\uffff\x01\x25\x01\uffff"+
        "\x01\x50\x03\uffff\x01\x45\x05\uffff\x01\x52\x01\x54\x03\x25\x02"+
        "\uffff\x08\x25\x01\x60\x01\x25\x01\x62\x04\x25\x01\uffff\x01\x25"+
        "\x09\uffff\x02\x25\x06\uffff\x0b\x25\x01\uffff\x01\x25\x01\uffff"+
        "\x01\x7a\x01\x25\x01\x7c\x01\x7d\x02\x25\x01\u0080\x03\x25\x01\u0084"+
        "\x0a\x25\x01\u008f\x01\u0090\x01\uffff\x01\u0091\x02\uffff\x02\x25"+
        "\x01\uffff\x03\x25\x01\uffff\x08\x25\x01\u009f\x01\x25\x03\uffff"+
        "\x03\x25\x01\u00a4\x01\u00a5\x01\u00a6\x01\u00a7\x04\x25\x01\u00ac"+
        "\x01\x7a\x01\uffff\x01\x25\x01\u00ae\x01\x25\x01\u0080\x04\uffff"+
        "\x01\u00b0\x03\x25\x01\uffff\x01\x25\x01\uffff\x01\x25\x01\uffff"+
        "\x09\x25\x01\u00bf\x04\x25\x01\uffff\x01\u00c4\x02\x25\x01\u00c7"+
        "\x01\uffff\x01\u00c8\x01\u00ca\x04\uffff";
    const string DFA7_eofS =
        "\u00cb\uffff";
    const string DFA7_minS =
        "\x01\x09\x01\x61\x03\uffff\x01\x65\x01\x3e\x02\x65\x01\x61\x01"+
        "\x6f\x01\x59\x01\x66\x01\x6c\x01\x6f\x01\x4f\x01\x30\x01\x65\x03"+
        "\x2e\x01\x2f\x07\uffff\x01\x3d\x02\uffff\x01\x69\x01\uffff\x01\x3d"+
        "\x03\uffff\x01\x2e\x05\uffff\x02\x3d\x01\x74\x01\x63\x01\x69\x02"+
        "\uffff\x01\x72\x01\x62\x01\x74\x01\x6c\x01\x75\x01\x69\x01\x72\x01"+
        "\x6f\x01\x30\x01\x4e\x01\x30\x01\x74\x01\x73\x01\x72\x01\x54\x01"+
        "\uffff\x01\x73\x09\uffff\x01\x67\x01\x6e\x06\uffff\x01\x72\x01\x74"+
        "\x01\x64\x01\x69\x01\x50\x01\x41\x01\x65\x01\x62\x01\x6e\x01\x61"+
        "\x01\x74\x01\uffff\x01\x43\x01\uffff\x01\x30\x01\x65\x02\x30\x01"+
        "\x75\x01\x65\x01\x30\x01\x65\x01\x69\x01\x6f\x01\x30\x01\x63\x01"+
        "\x6e\x02\x6c\x01\x78\x01\x63\x01\x74\x01\x6c\x01\x74\x01\x6c\x02"+
        "\x30\x01\uffff\x01\x30\x02\uffff\x01\x72\x01\x74\x01\uffff\x01\x61"+
        "\x01\x78\x01\x72\x01\uffff\x01\x74\x01\x67\x02\x6f\x01\x69\x01\x61"+
        "\x02\x65\x01\x30\x01\x6c\x03\uffff\x01\x6e\x01\x50\x01\x72\x04\x30"+
        "\x02\x74\x01\x73\x01\x6c\x02\x30\x01\uffff\x01\x65\x01\x30\x01\x6c"+
        "\x01\x30\x04\uffff\x01\x30\x01\x41\x01\x54\x01\x65\x01\uffff\x01"+
        "\x6c\x01\uffff\x01\x6f\x01\uffff\x01\x78\x01\x69\x01\x4d\x01\x66"+
        "\x01\x74\x01\x69\x01\x74\x02\x6f\x01\x30\x01\x73\x01\x6c\x01\x64"+
        "\x01\x72\x01\uffff\x01\x30\x02\x65\x01\x30\x01\uffff\x01\x30\x01"+
        "\x28\x04\uffff";
    const string DFA7_maxS =
        "\x01\x7d\x01\x61\x03\uffff\x01\x6f\x01\x3e\x01\x75\x01\x6f\x01"+
        "\x72\x01\x6f\x01\x59\x01\x6e\x01\x6c\x01\x6f\x01\x4f\x01\x7a\x01"+
        "\x65\x03\x44\x01\x2f\x07\uffff\x01\x3d\x02\uffff\x01\x6f\x01\uffff"+
        "\x01\x3d\x03\uffff\x01\x39\x05\uffff\x02\x3d\x01\x74\x01\x63\x01"+
        "\x69\x02\uffff\x01\x72\x01\x62\x01\x74\x01\x6c\x01\x75\x01\x69\x01"+
        "\x72\x01\x6f\x01\x7a\x01\x4e\x01\x7a\x01\x74\x01\x73\x01\x72\x01"+
        "\x54\x01\uffff\x01\x74\x09\uffff\x01\x67\x01\x6e\x06\uffff\x01\x72"+
        "\x01\x74\x01\x64\x01\x75\x01\x50\x01\x53\x01\x65\x01\x62\x01\x6e"+
        "\x01\x61\x01\x74\x01\uffff\x01\x43\x01\uffff\x01\x7a\x01\x65\x02"+
        "\x7a\x01\x75\x01\x65\x01\x7a\x01\x65\x01\x69\x01\x6f\x01\x7a\x01"+
        "\x63\x01\x6e\x02\x6c\x01\x78\x01\x63\x01\x74\x01\x6c\x01\x74\x01"+
        "\x6c\x02\x7a\x01\uffff\x01\x7a\x02\uffff\x01\x72\x01\x74\x01\uffff"+
        "\x01\x61\x01\x78\x01\x72\x01\uffff\x01\x74\x01\x67\x02\x6f\x01\x69"+
        "\x01\x61\x02\x65\x01\x7a\x01\x6c\x03\uffff\x01\x6e\x01\x50\x01\x72"+
        "\x04\x7a\x02\x74\x01\x73\x01\x6c\x02\x7a\x01\uffff\x01\x65\x01\x7a"+
        "\x01\x6c\x01\x7a\x04\uffff\x01\x7a\x01\x41\x01\x54\x01\x65\x01\uffff"+
        "\x01\x6c\x01\uffff\x01\x6f\x01\uffff\x01\x78\x01\x69\x01\x4d\x01"+
        "\x66\x01\x74\x01\x69\x01\x74\x02\x6f\x01\x7a\x01\x73\x01\x6c\x01"+
        "\x64\x01\x72\x01\uffff\x01\x7a\x02\x65\x01\x7a\x01\uffff\x02\x7a"+
        "\x04\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x11\uffff\x01\x1f\x01\x20\x01"+
        "\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01\uffff\x01\x27\x01\x29\x01"+
        "\uffff\x01\x2d\x01\uffff\x01\x2f\x01\x30\x01\x31\x01\uffff\x01\x34"+
        "\x01\x35\x01\x36\x01\x37\x01\x38\x05\uffff\x01\x39\x01\x06\x0f\uffff"+
        "\x01\x12\x01\uffff\x01\x15\x01\x32\x01\x33\x01\x16\x01\x17\x01\x1d"+
        "\x01\x28\x01\x3b\x01\x26\x02\uffff\x01\x3a\x01\x2e\x01\x3d\x01\x3c"+
        "\x01\x3f\x01\x3e\x0b\uffff\x01\x0b\x01\uffff\x01\x0d\x17\uffff\x01"+
        "\x2b\x01\uffff\x01\x0f\x01\x11\x02\uffff\x01\x2a\x03\uffff\x01\x10"+
        "\x0a\uffff\x01\x18\x01\x0c\x01\x0e\x0d\uffff\x01\x09\x04\uffff\x01"+
        "\x01\x01\x05\x01\x07\x01\x2c\x04\uffff\x01\x08\x01\uffff\x01\x13"+
        "\x01\uffff\x01\x14\x0e\uffff\x01\x19\x04\uffff\x01\x1a\x02\uffff"+
        "\x01\x0a\x01\x1b\x01\x1c\x01\x1e";
    const string DFA7_specialS =
        "\u00cb\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x02\x27\x02\uffff\x01\x27\x12\uffff\x01\x27\x01\x1d\x01\x16"+
            "\x01\x1b\x01\x1a\x01\uffff\x01\x17\x01\uffff\x01\x28\x01\x29"+
            "\x01\x24\x01\x23\x01\x04\x01\x06\x01\x21\x01\x15\x01\x26\x01"+
            "\x12\x01\x13\x01\x14\x06\x26\x01\x18\x01\x1f\x01\x2c\x01\x22"+
            "\x01\x2d\x01\x1e\x01\x1c\x03\x25\x01\x0f\x0e\x25\x01\x0b\x01"+
            "\x10\x06\x25\x01\x02\x01\uffff\x01\x03\x01\x19\x02\uffff\x03"+
            "\x25\x01\x08\x01\x0d\x01\x0e\x02\x25\x01\x0c\x02\x25\x01\x20"+
            "\x01\x01\x02\x25\x01\x09\x01\x25\x01\x11\x01\x07\x01\x0a\x01"+
            "\x25\x01\x05\x04\x25\x01\x2a\x01\uffff\x01\x2b",
            "\x01\x2e",
            "",
            "",
            "",
            "\x01\x2f\x09\uffff\x01\x30",
            "\x01\x31",
            "\x01\x35\x0e\uffff\x01\x33\x01\x34",
            "\x01\x36\x09\uffff\x01\x37",
            "\x01\x39\x0a\uffff\x01\x3a\x05\uffff\x01\x38",
            "\x01\x3b",
            "\x01\x3c",
            "\x01\x3d\x07\uffff\x01\x3e",
            "\x01\x3f",
            "\x01\x40",
            "\x01\x41",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\x43",
            "\x01\x46\x01\uffff\x0a\x26\x0a\uffff\x01\x44",
            "\x01\x46\x01\uffff\x0a\x26\x0a\uffff\x01\x47",
            "\x01\x46\x01\uffff\x0a\x26\x0a\uffff\x01\x48",
            "\x01\x49",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x4b",
            "",
            "",
            "\x01\x4e\x05\uffff\x01\x4d",
            "",
            "\x01\x4f",
            "",
            "",
            "",
            "\x01\x46\x01\uffff\x0a\x26",
            "",
            "",
            "",
            "",
            "",
            "\x01\x51",
            "\x01\x53",
            "\x01\x55",
            "\x01\x56",
            "\x01\x57",
            "",
            "",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\x61",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "",
            "\x01\x68\x01\x67",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x69",
            "\x01\x6a",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x6b",
            "\x01\x6c",
            "\x01\x6d",
            "\x01\x6f\x0b\uffff\x01\x6e",
            "\x01\x70",
            "\x01\x72\x0e\uffff\x01\x71\x02\uffff\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "",
            "\x01\x79",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\x7b",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\x7e",
            "\x01\x7f",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0083",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "\x01\u008d",
            "\x01\u008e",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "",
            "",
            "\x01\u0092",
            "\x01\u0093",
            "",
            "\x01\u0094",
            "\x01\u0095",
            "\x01\u0096",
            "",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "\x01\u009a",
            "\x01\u009b",
            "\x01\u009c",
            "\x01\u009d",
            "\x01\u009e",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u00a0",
            "",
            "",
            "",
            "\x01\u00a1",
            "\x01\u00a2",
            "\x01\u00a3",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x01\u00ab",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "",
            "\x01\u00ad",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u00af",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "",
            "",
            "",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u00b1",
            "\x01\u00b2",
            "\x01\u00b3",
            "",
            "\x01\u00b4",
            "",
            "\x01\u00b5",
            "",
            "\x01\u00b6",
            "\x01\u00b7",
            "\x01\u00b8",
            "\x01\u00b9",
            "\x01\u00ba",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x01\u00bd",
            "\x01\u00be",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u00c0",
            "\x01\u00c1",
            "\x01\u00c2",
            "\x01\u00c3",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u00c5",
            "\x01\u00c6",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a\x25",
            "\x01\u00c9\x07\uffff\x0a\x25\x07\uffff\x1a\x25\x06\uffff\x1a"+
            "\x25",
            "",
            "",
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
            get { return "1:1: Tokens : ( T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | END_OF_STATEMENT | SCALEMODE | VARTYPE | STRINGTYPE | DOT | ASSIGNMENT | PLUS | MULTIPLY | VARIABLE | INT_LITERAL | DOUBLE_LITERAL | WHITESPACE | LEFTBRACE | RIGHTBRACE | LEFTPARANTHESIS | RIGHTPARANTHESIS | POINT | EQUALITYEXPRESSION | NONEQUALITYEXPRESSION | LESSTHANEXPRESSION | LESSTHANEQUALTOEXPRESSION | GREATERTHANEXPRESSION | GREATERTHANEQUALTOEXPRESSION );"; }
        }

    }

 
    
}
