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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class CymbolParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, MUL=14, DIV=15, ADD=16, SUB=17, 
		INT=18, BOOL=19, STRING=20, ID=21, COMMENT=22, ML_COMMENT=23, WS=24;
	public const int
		RULE_program = 0, RULE_stmts = 1, RULE_stmt = 2, RULE_declaration = 3, 
		RULE_type = 4, RULE_function = 5, RULE_expr = 6;
	public static readonly string[] ruleNames = {
		"program", "stmts", "stmt", "declaration", "type", "function", "expr"
	};

	private static readonly string[] _LiteralNames = {
		null, "';'", "'='", "'int'", "'bool'", "'string'", "'fun'", "'('", "','", 
		"')'", "'{'", "'}'", "'print'", "'if'", "'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, "MUL", "DIV", "ADD", "SUB", "INT", "BOOL", "STRING", "ID", 
		"COMMENT", "ML_COMMENT", "WS"
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

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CymbolParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public CymbolParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public CymbolParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgramContext : ParserRuleContext {
		public StmtsContext stmts() {
			return GetRuleContext<StmtsContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(CymbolParser.Eof, 0); }
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 0, RULE_program);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; stmts();
			State = 15; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StmtsContext : ParserRuleContext {
		public StmtContext[] stmt() {
			return GetRuleContexts<StmtContext>();
		}
		public StmtContext stmt(int i) {
			return GetRuleContext<StmtContext>(i);
		}
		public StmtsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stmts; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStmts(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StmtsContext stmts() {
		StmtsContext _localctx = new StmtsContext(Context, State);
		EnterRule(_localctx, 2, RULE_stmts);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 22;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__11) | (1L << T__12) | (1L << INT) | (1L << BOOL) | (1L << STRING) | (1L << ID))) != 0)) {
				{
				{
				State = 17; stmt();
				State = 18; Match(T__0);
				}
				}
				State = 24;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StmtContext : ParserRuleContext {
		public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		public FunctionContext function() {
			return GetRuleContext<FunctionContext>(0);
		}
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public StmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stmt; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StmtContext stmt() {
		StmtContext _localctx = new StmtContext(Context, State);
		EnterRule(_localctx, 4, RULE_stmt);
		try {
			State = 28;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__2:
			case T__3:
			case T__4:
				EnterOuterAlt(_localctx, 1);
				{
				State = 25; declaration();
				}
				break;
			case T__5:
				EnterOuterAlt(_localctx, 2);
				{
				State = 26; function();
				}
				break;
			case T__11:
			case T__12:
			case INT:
			case BOOL:
			case STRING:
			case ID:
				EnterOuterAlt(_localctx, 3);
				{
				State = 27; expr(0);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationContext : ParserRuleContext {
		public TypeContext type() {
			return GetRuleContext<TypeContext>(0);
		}
		public ITerminalNode ID() { return GetToken(CymbolParser.ID, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDeclaration(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(Context, State);
		EnterRule(_localctx, 6, RULE_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 30; type();
			State = 31; Match(ID);
			State = 32; Match(T__1);
			State = 33; expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeContext : ParserRuleContext {
		public TypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitType(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TypeContext type() {
		TypeContext _localctx = new TypeContext(Context, State);
		EnterRule(_localctx, 8, RULE_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionContext : ParserRuleContext {
		public ITerminalNode[] ID() { return GetTokens(CymbolParser.ID); }
		public ITerminalNode ID(int i) {
			return GetToken(CymbolParser.ID, i);
		}
		public StmtContext[] stmt() {
			return GetRuleContexts<StmtContext>();
		}
		public StmtContext stmt(int i) {
			return GetRuleContext<StmtContext>(i);
		}
		public FunctionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_function; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunction(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FunctionContext function() {
		FunctionContext _localctx = new FunctionContext(Context, State);
		EnterRule(_localctx, 10, RULE_function);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37; Match(T__5);
			State = 38; Match(ID);
			State = 39; Match(T__6);
			State = 48;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ID) {
				{
				State = 40; Match(ID);
				State = 45;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__7) {
					{
					{
					State = 41; Match(T__7);
					State = 42; Match(ID);
					}
					}
					State = 47;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 50; Match(T__8);
			State = 51; Match(T__9);
			State = 57;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__11) | (1L << T__12) | (1L << INT) | (1L << BOOL) | (1L << STRING) | (1L << ID))) != 0)) {
				{
				{
				State = 52; stmt();
				State = 53; Match(T__0);
				}
				}
				State = 59;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 60; Match(T__10);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class CallContext : ExprContext {
		public ITerminalNode ID() { return GetToken(CymbolParser.ID, 0); }
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public CallContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCall(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PrintContext : ExprContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public PrintContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrint(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BoolContext : ExprContext {
		public ITerminalNode BOOL() { return GetToken(CymbolParser.BOOL, 0); }
		public BoolContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBool(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StringContext : ExprContext {
		public ITerminalNode STRING() { return GetToken(CymbolParser.STRING, 0); }
		public StringContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class VariableContext : ExprContext {
		public ITerminalNode ID() { return GetToken(CymbolParser.ID, 0); }
		public VariableContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVariable(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AddsubContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ITerminalNode ADD() { return GetToken(CymbolParser.ADD, 0); }
		public ITerminalNode SUB() { return GetToken(CymbolParser.SUB, 0); }
		public AddsubContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddsub(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IfContext : ExprContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public StmtsContext stmts() {
			return GetRuleContext<StmtsContext>(0);
		}
		public IfContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIf(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IntContext : ExprContext {
		public ITerminalNode INT() { return GetToken(CymbolParser.INT, 0); }
		public IntContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MuldivContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ITerminalNode MUL() { return GetToken(CymbolParser.MUL, 0); }
		public ITerminalNode DIV() { return GetToken(CymbolParser.DIV, 0); }
		public MuldivContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICymbolVisitor<TResult> typedVisitor = visitor as ICymbolVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMuldiv(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 12;
		EnterRecursionRule(_localctx, 12, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 94;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,8,Context) ) {
			case 1:
				{
				_localctx = new PrintContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 63; Match(T__11);
				State = 64; Match(T__6);
				State = 66;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__11) | (1L << T__12) | (1L << INT) | (1L << BOOL) | (1L << STRING) | (1L << ID))) != 0)) {
					{
					State = 65; expr(0);
					}
				}

				State = 68; Match(T__8);
				}
				break;
			case 2:
				{
				_localctx = new IfContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 69; Match(T__12);
				State = 70; Match(T__6);
				State = 71; expr(0);
				State = 72; Match(T__8);
				State = 73; Match(T__9);
				State = 74; stmts();
				State = 75; Match(T__10);
				}
				break;
			case 3:
				{
				_localctx = new CallContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 77; Match(ID);
				State = 78; Match(T__6);
				State = 87;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__11) | (1L << T__12) | (1L << INT) | (1L << BOOL) | (1L << STRING) | (1L << ID))) != 0)) {
					{
					State = 79; expr(0);
					State = 84;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==T__7) {
						{
						{
						State = 80; Match(T__7);
						State = 81; expr(0);
						}
						}
						State = 86;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				State = 89; Match(T__8);
				}
				break;
			case 4:
				{
				_localctx = new IntContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 90; Match(INT);
				}
				break;
			case 5:
				{
				_localctx = new BoolContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 91; Match(BOOL);
				}
				break;
			case 6:
				{
				_localctx = new StringContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 92; Match(STRING);
				}
				break;
			case 7:
				{
				_localctx = new VariableContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 93; Match(ID);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 104;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,10,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 102;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,9,Context) ) {
					case 1:
						{
						_localctx = new MuldivContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 96;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 97;
						((MuldivContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==MUL || _la==DIV) ) {
							((MuldivContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 98; expr(10);
						}
						break;
					case 2:
						{
						_localctx = new AddsubContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 99;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 100;
						((AddsubContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==ADD || _la==SUB) ) {
							((AddsubContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 101; expr(9);
						}
						break;
					}
					} 
				}
				State = 106;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,10,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 6: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 9);
		case 1: return Precpred(Context, 8);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x1A', 'n', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\a', '\x3', '\x17', '\n', '\x3', '\f', '\x3', '\xE', '\x3', 
		'\x1A', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', 
		'\x4', '\x1F', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\a', '\a', 
		'.', '\n', '\a', '\f', '\a', '\xE', '\a', '\x31', '\v', '\a', '\x5', '\a', 
		'\x33', '\n', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\a', '\a', ':', '\n', '\a', '\f', '\a', '\xE', '\a', '=', 
		'\v', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x5', '\b', '\x45', '\n', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\a', '\b', 'U', '\n', '\b', '\f', '\b', '\xE', '\b', 
		'X', '\v', '\b', '\x5', '\b', 'Z', '\n', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', '\x61', '\n', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\a', '\b', 'i', '\n', '\b', '\f', '\b', '\xE', '\b', 'l', '\v', 
		'\b', '\x3', '\b', '\x2', '\x3', '\xE', '\t', '\x2', '\x4', '\x6', '\b', 
		'\n', '\f', '\xE', '\x2', '\x5', '\x3', '\x2', '\x5', '\a', '\x3', '\x2', 
		'\x10', '\x11', '\x3', '\x2', '\x12', '\x13', '\x2', 'w', '\x2', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x4', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\x6', '\x1E', '\x3', '\x2', '\x2', '\x2', '\b', ' ', '\x3', '\x2', '\x2', 
		'\x2', '\n', '%', '\x3', '\x2', '\x2', '\x2', '\f', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\xE', '`', '\x3', '\x2', '\x2', '\x2', '\x10', '\x11', 
		'\x5', '\x4', '\x3', '\x2', '\x11', '\x12', '\a', '\x2', '\x2', '\x3', 
		'\x12', '\x3', '\x3', '\x2', '\x2', '\x2', '\x13', '\x14', '\x5', '\x6', 
		'\x4', '\x2', '\x14', '\x15', '\a', '\x3', '\x2', '\x2', '\x15', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x16', '\x13', '\x3', '\x2', '\x2', '\x2', 
		'\x17', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x18', '\x16', '\x3', '\x2', 
		'\x2', '\x2', '\x18', '\x19', '\x3', '\x2', '\x2', '\x2', '\x19', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x1A', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', '\x1F', '\x5', '\b', '\x5', '\x2', '\x1C', '\x1F', '\x5', '\f', 
		'\a', '\x2', '\x1D', '\x1F', '\x5', '\xE', '\b', '\x2', '\x1E', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\x1E', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'\x1E', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1F', '\a', '\x3', '\x2', 
		'\x2', '\x2', ' ', '!', '\x5', '\n', '\x6', '\x2', '!', '\"', '\a', '\x17', 
		'\x2', '\x2', '\"', '#', '\a', '\x4', '\x2', '\x2', '#', '$', '\x5', '\xE', 
		'\b', '\x2', '$', '\t', '\x3', '\x2', '\x2', '\x2', '%', '&', '\t', '\x2', 
		'\x2', '\x2', '&', '\v', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\a', 
		'\b', '\x2', '\x2', '(', ')', '\a', '\x17', '\x2', '\x2', ')', '\x32', 
		'\a', '\t', '\x2', '\x2', '*', '/', '\a', '\x17', '\x2', '\x2', '+', ',', 
		'\a', '\n', '\x2', '\x2', ',', '.', '\a', '\x17', '\x2', '\x2', '-', '+', 
		'\x3', '\x2', '\x2', '\x2', '.', '\x31', '\x3', '\x2', '\x2', '\x2', '/', 
		'-', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\x30', '\x33', '\x3', '\x2', '\x2', '\x2', '\x31', '/', '\x3', '\x2', 
		'\x2', '\x2', '\x32', '*', '\x3', '\x2', '\x2', '\x2', '\x32', '\x33', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\x3', '\x2', '\x2', '\x2', 
		'\x34', '\x35', '\a', '\v', '\x2', '\x2', '\x35', ';', '\a', '\f', '\x2', 
		'\x2', '\x36', '\x37', '\x5', '\x6', '\x4', '\x2', '\x37', '\x38', '\a', 
		'\x3', '\x2', '\x2', '\x38', ':', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\x36', '\x3', '\x2', '\x2', '\x2', ':', '=', '\x3', '\x2', '\x2', '\x2', 
		';', '\x39', '\x3', '\x2', '\x2', '\x2', ';', '<', '\x3', '\x2', '\x2', 
		'\x2', '<', '>', '\x3', '\x2', '\x2', '\x2', '=', ';', '\x3', '\x2', '\x2', 
		'\x2', '>', '?', '\a', '\r', '\x2', '\x2', '?', '\r', '\x3', '\x2', '\x2', 
		'\x2', '@', '\x41', '\b', '\b', '\x1', '\x2', '\x41', '\x42', '\a', '\xE', 
		'\x2', '\x2', '\x42', '\x44', '\a', '\t', '\x2', '\x2', '\x43', '\x45', 
		'\x5', '\xE', '\b', '\x2', '\x44', '\x43', '\x3', '\x2', '\x2', '\x2', 
		'\x44', '\x45', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\x3', '\x2', 
		'\x2', '\x2', '\x46', '\x61', '\a', '\v', '\x2', '\x2', 'G', 'H', '\a', 
		'\xF', '\x2', '\x2', 'H', 'I', '\a', '\t', '\x2', '\x2', 'I', 'J', '\x5', 
		'\xE', '\b', '\x2', 'J', 'K', '\a', '\v', '\x2', '\x2', 'K', 'L', '\a', 
		'\f', '\x2', '\x2', 'L', 'M', '\x5', '\x4', '\x3', '\x2', 'M', 'N', '\a', 
		'\r', '\x2', '\x2', 'N', '\x61', '\x3', '\x2', '\x2', '\x2', 'O', 'P', 
		'\a', '\x17', '\x2', '\x2', 'P', 'Y', '\a', '\t', '\x2', '\x2', 'Q', 'V', 
		'\x5', '\xE', '\b', '\x2', 'R', 'S', '\a', '\n', '\x2', '\x2', 'S', 'U', 
		'\x5', '\xE', '\b', '\x2', 'T', 'R', '\x3', '\x2', '\x2', '\x2', 'U', 
		'X', '\x3', '\x2', '\x2', '\x2', 'V', 'T', '\x3', '\x2', '\x2', '\x2', 
		'V', 'W', '\x3', '\x2', '\x2', '\x2', 'W', 'Z', '\x3', '\x2', '\x2', '\x2', 
		'X', 'V', '\x3', '\x2', '\x2', '\x2', 'Y', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'Y', 'Z', '\x3', '\x2', '\x2', '\x2', 'Z', '[', '\x3', '\x2', '\x2', '\x2', 
		'[', '\x61', '\a', '\v', '\x2', '\x2', '\\', '\x61', '\a', '\x14', '\x2', 
		'\x2', ']', '\x61', '\a', '\x15', '\x2', '\x2', '^', '\x61', '\a', '\x16', 
		'\x2', '\x2', '_', '\x61', '\a', '\x17', '\x2', '\x2', '`', '@', '\x3', 
		'\x2', '\x2', '\x2', '`', 'G', '\x3', '\x2', '\x2', '\x2', '`', 'O', '\x3', 
		'\x2', '\x2', '\x2', '`', '\\', '\x3', '\x2', '\x2', '\x2', '`', ']', 
		'\x3', '\x2', '\x2', '\x2', '`', '^', '\x3', '\x2', '\x2', '\x2', '`', 
		'_', '\x3', '\x2', '\x2', '\x2', '\x61', 'j', '\x3', '\x2', '\x2', '\x2', 
		'\x62', '\x63', '\f', '\v', '\x2', '\x2', '\x63', '\x64', '\t', '\x3', 
		'\x2', '\x2', '\x64', 'i', '\x5', '\xE', '\b', '\f', '\x65', '\x66', '\f', 
		'\n', '\x2', '\x2', '\x66', 'g', '\t', '\x4', '\x2', '\x2', 'g', 'i', 
		'\x5', '\xE', '\b', '\v', 'h', '\x62', '\x3', '\x2', '\x2', '\x2', 'h', 
		'\x65', '\x3', '\x2', '\x2', '\x2', 'i', 'l', '\x3', '\x2', '\x2', '\x2', 
		'j', 'h', '\x3', '\x2', '\x2', '\x2', 'j', 'k', '\x3', '\x2', '\x2', '\x2', 
		'k', '\xF', '\x3', '\x2', '\x2', '\x2', 'l', 'j', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\x18', '\x1E', '/', '\x32', ';', '\x44', 'V', 'Y', '`', 
		'h', 'j',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
