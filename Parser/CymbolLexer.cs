//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Cymbol.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class CymbolLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, MUL=15, DIV=16, ADD=17, 
		SUB=18, GT=19, GE=20, LT=21, LE=22, EQ=23, NE=24, NOT=25, AND=26, OR=27, 
		INT=28, BOOL=29, STRING=30, ID=31, COMMENT=32, ML_COMMENT=33, WS=34;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "MUL", "DIV", "ADD", "SUB", 
		"GT", "GE", "LT", "LE", "EQ", "NE", "NOT", "AND", "OR", "INT", "BOOL", 
		"STRING", "ID", "COMMENT", "ML_COMMENT", "WS"
	};


	public CymbolLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CymbolLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'='", "'int'", "'bool'", "'string'", "'fun'", "'('", "','", 
		"')'", "'{'", "'}'", "'print'", "'if'", "'else'", "'*'", "'/'", "'+'", 
		"'-'", "'>'", "'>='", "'<'", "'<='", "'=='", "'!='", "'!'", "'&&'", "'||'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, "MUL", "DIV", "ADD", "SUB", "GT", "GE", "LT", "LE", 
		"EQ", "NE", "NOT", "AND", "OR", "INT", "BOOL", "STRING", "ID", "COMMENT", 
		"ML_COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Cymbol.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CymbolLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '$', '\xDE', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', 
		'\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', 
		'\x3', '\x1D', '\a', '\x1D', '\x9A', '\n', '\x1D', '\f', '\x1D', '\xE', 
		'\x1D', '\x9D', '\v', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1E', '\x5', '\x1E', '\xA8', '\n', '\x1E', '\x3', '\x1F', '\x3', 
		'\x1F', '\a', '\x1F', '\xAC', '\n', '\x1F', '\f', '\x1F', '\xE', '\x1F', 
		'\xAF', '\v', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', 
		' ', '\a', ' ', '\xB5', '\n', ' ', '\f', ' ', '\xE', ' ', '\xB8', '\v', 
		' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\a', '!', '\xBE', 
		'\n', '!', '\f', '!', '\xE', '!', '\xC1', '\v', '!', '\x3', '!', '\x5', 
		'!', '\xC4', '\n', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\a', '\"', '\xCE', 
		'\n', '\"', '\f', '\"', '\xE', '\"', '\xD1', '\v', '\"', '\x3', '\"', 
		'\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x6', 
		'#', '\xD9', '\n', '#', '\r', '#', '\xE', '#', '\xDA', '\x3', '#', '\x3', 
		'#', '\x5', '\xAD', '\xBF', '\xCF', '\x2', '$', '\x3', '\x3', '\x5', '\x4', 
		'\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', 
		'\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', 
		'\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', 
		'\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', '\x19', 
		'\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', '\x39', 
		'\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', '#', '\x45', 
		'$', '\x3', '\x2', '\a', '\x3', '\x2', '\x32', ';', '\x4', '\x2', '\x32', 
		';', '\x61', '\x61', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\xE5', 
		'\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x3', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\x5', 'I', '\x3', '\x2', '\x2', '\x2', '\a', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\t', 'O', '\x3', '\x2', '\x2', '\x2', '\v', 'T', '\x3', '\x2', 
		'\x2', '\x2', '\r', '[', '\x3', '\x2', '\x2', '\x2', '\xF', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\x61', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x63', '\x3', '\x2', '\x2', '\x2', '\x15', '\x65', '\x3', '\x2', '\x2', 
		'\x2', '\x17', 'g', '\x3', '\x2', '\x2', '\x2', '\x19', 'i', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', 'o', '\x3', '\x2', '\x2', '\x2', '\x1D', 'r', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', 'w', '\x3', '\x2', '\x2', '\x2', '!', 'y', 
		'\x3', '\x2', '\x2', '\x2', '#', '{', '\x3', '\x2', '\x2', '\x2', '%', 
		'}', '\x3', '\x2', '\x2', '\x2', '\'', '\x7F', '\x3', '\x2', '\x2', '\x2', 
		')', '\x81', '\x3', '\x2', '\x2', '\x2', '+', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '-', '\x86', '\x3', '\x2', '\x2', '\x2', '/', '\x89', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x33', '\x8F', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x91', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\x94', '\x3', '\x2', '\x2', '\x2', '\x39', '\x97', '\x3', '\x2', 
		'\x2', '\x2', ';', '\xA7', '\x3', '\x2', '\x2', '\x2', '=', '\xA9', '\x3', 
		'\x2', '\x2', '\x2', '?', '\xB2', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\xB9', '\x3', '\x2', '\x2', '\x2', '\x43', '\xC9', '\x3', '\x2', '\x2', 
		'\x2', '\x45', '\xD8', '\x3', '\x2', '\x2', '\x2', 'G', 'H', '\a', '=', 
		'\x2', '\x2', 'H', '\x4', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', 
		'?', '\x2', '\x2', 'J', '\x6', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', 
		'k', '\x2', '\x2', 'L', 'M', '\a', 'p', '\x2', '\x2', 'M', 'N', '\a', 
		'v', '\x2', '\x2', 'N', '\b', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', 
		'\x64', '\x2', '\x2', 'P', 'Q', '\a', 'q', '\x2', '\x2', 'Q', 'R', '\a', 
		'q', '\x2', '\x2', 'R', 'S', '\a', 'n', '\x2', '\x2', 'S', '\n', '\x3', 
		'\x2', '\x2', '\x2', 'T', 'U', '\a', 'u', '\x2', '\x2', 'U', 'V', '\a', 
		'v', '\x2', '\x2', 'V', 'W', '\a', 't', '\x2', '\x2', 'W', 'X', '\a', 
		'k', '\x2', '\x2', 'X', 'Y', '\a', 'p', '\x2', '\x2', 'Y', 'Z', '\a', 
		'i', '\x2', '\x2', 'Z', '\f', '\x3', '\x2', '\x2', '\x2', '[', '\\', '\a', 
		'h', '\x2', '\x2', '\\', ']', '\a', 'w', '\x2', '\x2', ']', '^', '\a', 
		'p', '\x2', '\x2', '^', '\xE', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', 
		'*', '\x2', '\x2', '`', '\x10', '\x3', '\x2', '\x2', '\x2', '\x61', '\x62', 
		'\a', '.', '\x2', '\x2', '\x62', '\x12', '\x3', '\x2', '\x2', '\x2', '\x63', 
		'\x64', '\a', '+', '\x2', '\x2', '\x64', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\x65', '\x66', '\a', '}', '\x2', '\x2', '\x66', '\x16', '\x3', 
		'\x2', '\x2', '\x2', 'g', 'h', '\a', '\x7F', '\x2', '\x2', 'h', '\x18', 
		'\x3', '\x2', '\x2', '\x2', 'i', 'j', '\a', 'r', '\x2', '\x2', 'j', 'k', 
		'\a', 't', '\x2', '\x2', 'k', 'l', '\a', 'k', '\x2', '\x2', 'l', 'm', 
		'\a', 'p', '\x2', '\x2', 'm', 'n', '\a', 'v', '\x2', '\x2', 'n', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', 'o', 'p', '\a', 'k', '\x2', '\x2', 'p', 'q', 
		'\a', 'h', '\x2', '\x2', 'q', '\x1C', '\x3', '\x2', '\x2', '\x2', 'r', 
		's', '\a', 'g', '\x2', '\x2', 's', 't', '\a', 'n', '\x2', '\x2', 't', 
		'u', '\a', 'u', '\x2', '\x2', 'u', 'v', '\a', 'g', '\x2', '\x2', 'v', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\a', ',', '\x2', '\x2', 
		'x', ' ', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\a', '\x31', '\x2', '\x2', 
		'z', '\"', '\x3', '\x2', '\x2', '\x2', '{', '|', '\a', '-', '\x2', '\x2', 
		'|', '$', '\x3', '\x2', '\x2', '\x2', '}', '~', '\a', '/', '\x2', '\x2', 
		'~', '&', '\x3', '\x2', '\x2', '\x2', '\x7F', '\x80', '\a', '@', '\x2', 
		'\x2', '\x80', '(', '\x3', '\x2', '\x2', '\x2', '\x81', '\x82', '\a', 
		'@', '\x2', '\x2', '\x82', '\x83', '\a', '?', '\x2', '\x2', '\x83', '*', 
		'\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', '>', '\x2', '\x2', '\x85', 
		',', '\x3', '\x2', '\x2', '\x2', '\x86', '\x87', '\a', '>', '\x2', '\x2', 
		'\x87', '\x88', '\a', '?', '\x2', '\x2', '\x88', '.', '\x3', '\x2', '\x2', 
		'\x2', '\x89', '\x8A', '\a', '?', '\x2', '\x2', '\x8A', '\x8B', '\a', 
		'?', '\x2', '\x2', '\x8B', '\x30', '\x3', '\x2', '\x2', '\x2', '\x8C', 
		'\x8D', '\a', '#', '\x2', '\x2', '\x8D', '\x8E', '\a', '?', '\x2', '\x2', 
		'\x8E', '\x32', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\a', '#', 
		'\x2', '\x2', '\x90', '\x34', '\x3', '\x2', '\x2', '\x2', '\x91', '\x92', 
		'\a', '(', '\x2', '\x2', '\x92', '\x93', '\a', '(', '\x2', '\x2', '\x93', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\a', '~', '\x2', 
		'\x2', '\x95', '\x96', '\a', '~', '\x2', '\x2', '\x96', '\x38', '\x3', 
		'\x2', '\x2', '\x2', '\x97', '\x9B', '\t', '\x2', '\x2', '\x2', '\x98', 
		'\x9A', '\t', '\x3', '\x2', '\x2', '\x99', '\x98', '\x3', '\x2', '\x2', 
		'\x2', '\x9A', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x99', '\x3', 
		'\x2', '\x2', '\x2', '\x9B', '\x9C', '\x3', '\x2', '\x2', '\x2', '\x9C', 
		':', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9B', '\x3', '\x2', '\x2', 
		'\x2', '\x9E', '\x9F', '\a', 'v', '\x2', '\x2', '\x9F', '\xA0', '\a', 
		't', '\x2', '\x2', '\xA0', '\xA1', '\a', 'w', '\x2', '\x2', '\xA1', '\xA8', 
		'\a', 'g', '\x2', '\x2', '\xA2', '\xA3', '\a', 'h', '\x2', '\x2', '\xA3', 
		'\xA4', '\a', '\x63', '\x2', '\x2', '\xA4', '\xA5', '\a', 'n', '\x2', 
		'\x2', '\xA5', '\xA6', '\a', 'u', '\x2', '\x2', '\xA6', '\xA8', '\a', 
		'g', '\x2', '\x2', '\xA7', '\x9E', '\x3', '\x2', '\x2', '\x2', '\xA7', 
		'\xA2', '\x3', '\x2', '\x2', '\x2', '\xA8', '<', '\x3', '\x2', '\x2', 
		'\x2', '\xA9', '\xAD', '\a', '$', '\x2', '\x2', '\xAA', '\xAC', '\v', 
		'\x2', '\x2', '\x2', '\xAB', '\xAA', '\x3', '\x2', '\x2', '\x2', '\xAC', 
		'\xAF', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xAE', '\x3', '\x2', '\x2', 
		'\x2', '\xAD', '\xAB', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xB0', '\x3', 
		'\x2', '\x2', '\x2', '\xAF', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xB0', 
		'\xB1', '\a', '$', '\x2', '\x2', '\xB1', '>', '\x3', '\x2', '\x2', '\x2', 
		'\xB2', '\xB6', '\t', '\x4', '\x2', '\x2', '\xB3', '\xB5', '\t', '\x5', 
		'\x2', '\x2', '\xB4', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB8', 
		'\x3', '\x2', '\x2', '\x2', '\xB6', '\xB4', '\x3', '\x2', '\x2', '\x2', 
		'\xB6', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB7', '@', '\x3', '\x2', 
		'\x2', '\x2', '\xB8', '\xB6', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', 
		'\a', '\x31', '\x2', '\x2', '\xBA', '\xBB', '\a', '\x31', '\x2', '\x2', 
		'\xBB', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBE', '\v', '\x2', 
		'\x2', '\x2', '\xBD', '\xBC', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xC1', 
		'\x3', '\x2', '\x2', '\x2', '\xBF', '\xC0', '\x3', '\x2', '\x2', '\x2', 
		'\xBF', '\xBD', '\x3', '\x2', '\x2', '\x2', '\xC0', '\xC3', '\x3', '\x2', 
		'\x2', '\x2', '\xC1', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC4', 
		'\a', '\xF', '\x2', '\x2', '\xC3', '\xC2', '\x3', '\x2', '\x2', '\x2', 
		'\xC3', '\xC4', '\x3', '\x2', '\x2', '\x2', '\xC4', '\xC5', '\x3', '\x2', 
		'\x2', '\x2', '\xC5', '\xC6', '\a', '\f', '\x2', '\x2', '\xC6', '\xC7', 
		'\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\b', '!', '\x2', '\x2', '\xC8', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\a', '\x31', '\x2', 
		'\x2', '\xCA', '\xCB', '\a', ',', '\x2', '\x2', '\xCB', '\xCF', '\x3', 
		'\x2', '\x2', '\x2', '\xCC', '\xCE', '\v', '\x2', '\x2', '\x2', '\xCD', 
		'\xCC', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xD1', '\x3', '\x2', '\x2', 
		'\x2', '\xCF', '\xD0', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xCD', '\x3', 
		'\x2', '\x2', '\x2', '\xD0', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD1', 
		'\xCF', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD3', '\a', ',', '\x2', 
		'\x2', '\xD3', '\xD4', '\a', '\x31', '\x2', '\x2', '\xD4', '\xD5', '\x3', 
		'\x2', '\x2', '\x2', '\xD5', '\xD6', '\b', '\"', '\x2', '\x2', '\xD6', 
		'\x44', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD9', '\t', '\x6', '\x2', 
		'\x2', '\xD8', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xDA', '\x3', 
		'\x2', '\x2', '\x2', '\xDA', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xDA', 
		'\xDB', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xDC', '\x3', '\x2', '\x2', 
		'\x2', '\xDC', '\xDD', '\b', '#', '\x2', '\x2', '\xDD', '\x46', '\x3', 
		'\x2', '\x2', '\x2', '\v', '\x2', '\x9B', '\xA7', '\xAD', '\xB6', '\xBF', 
		'\xC3', '\xCF', '\xDA', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
