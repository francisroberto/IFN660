// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  TUPHAM-LAPTOP
// DateTime: 5/24/2017 3:44:16 AM
// UserName: Ngoc Tu Pham
// Input file <parser.y - 5/24/2017 3:43:59 AM>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace GPLexTutorial
{
public enum Tokens {
    error=127,EOF=128,IntegerLiteral=129,Identifier=130,PUBLIC=131,CLASS=132,
    STATIC=133,VOID=134,INT=135,PRIVATE=136,PROTECTED=137};

public struct ValueType
#line 8 "parser.y"
{
    public int num;
    public string name;
    public CompilationUnit compUnit;
    public NormalClassDeclaration normclassDecl;
    public ClassModifier classModi;  
    public ClassBody classBodi;
    public MethodDeclaration methDecl;
    public MethodModifier methModi;
    public Result result;
	public List<Statement> stmts;
	public Block block;
	public MethodDeclarator methodecla;
	public MethodHeader methodhea;
	public Statement stmt;
	public List<MethodModifier> methodmodilist;
	public FormalParameter	fmpara;
	public List<FormalParameter> fmparalist;
	public UnannType untype;
	public VariableModifier varmodi;
	public Identifier ident;
	public List<VariableModifier> varmodis;
	public Assignment assign;
	public Expression expr;
	public LocalVariableDeclaration localvardcl;
	public IntegralType inttype;
}
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from parser.y - 5/24/2017 3:43:59 AM
#line 4 "parser.y"
  public static Node root;
#line default
  // End verbatim content from parser.y - 5/24/2017 3:43:59 AM

#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[58];
  private static State[] states = new State[86];
  private static string[] nonTerms = new string[] {
      "CompilationUnit", "NormalClassDeclaration", "TypeDeclaration", "ClassModifier", 
      "ClassBody", "MethodModifier", "MethodDeclaration", "Result", "BlockStatement", 
      "LocalVariableDeclarationStatement", "ExpressionStatement", "Statement", 
      "BlockStatements", "MethodDeclarator", "MethodHeader", "Block", "MethodBody", 
      "MethodModifiers", "FormalParameter", "FormalParameterList", "UnannType", 
      "UnannPrimitiveType", "UnannReferenceType", "NumericType", "IntegralType", 
      "UnannClassType", "UnannArrayType", "UnannClassOrInterfaceType", "VariableModifier", 
      "VariableModifiers", "Assignment", "Expression", "LeftHandSide", "LocalVariableDeclaration", 
      "VariableDeclaratorId", "VariableDeclarator", "$accept", "PackageDeclaration", 
      "ImportDeclarations", "empty", "TypeParameters", "Dims", "Annotations", 
      "MoreDims", "TypeArguments_opt", "AssignmentOperator", };

  static Parser() {
    states[0] = new State(-3,new int[]{-1,1,-38,3,-40,85});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(-3,new int[]{-39,4,-40,84});
    states[4] = new State(new int[]{131,83},new int[]{-3,5,-2,6,-4,7});
    states[5] = new State(-2);
    states[6] = new State(-6);
    states[7] = new State(new int[]{132,8});
    states[8] = new State(new int[]{130,9});
    states[9] = new State(-3,new int[]{-41,10,-40,82});
    states[10] = new State(new int[]{123,11});
    states[11] = new State(new int[]{131,78,133,79,125,-3,134,-3},new int[]{-5,12,-7,14,-18,15,-6,76,-40,81});
    states[12] = new State(new int[]{125,13});
    states[13] = new State(-7);
    states[14] = new State(-10);
    states[15] = new State(new int[]{134,75},new int[]{-15,16,-8,64});
    states[16] = new State(new int[]{123,19},new int[]{-17,17,-16,18});
    states[17] = new State(-12);
    states[18] = new State(-24);
    states[19] = new State(-3,new int[]{-13,20,-40,63});
    states[20] = new State(new int[]{125,21,130,62,135,-3},new int[]{-9,22,-10,23,-34,24,-30,26,-29,50,-40,52,-12,53,-11,54,-31,55,-33,57});
    states[21] = new State(-25);
    states[22] = new State(-26);
    states[23] = new State(-28);
    states[24] = new State(new int[]{59,25});
    states[25] = new State(-30);
    states[26] = new State(new int[]{135,34,130,46},new int[]{-21,27,-22,31,-24,32,-25,33,-23,35,-28,36,-26,45,-27,49});
    states[27] = new State(new int[]{130,30},new int[]{-36,28,-35,29});
    states[28] = new State(-31);
    states[29] = new State(-50);
    states[30] = new State(-51);
    states[31] = new State(-35);
    states[32] = new State(-47);
    states[33] = new State(-48);
    states[34] = new State(-49);
    states[35] = new State(-36);
    states[36] = new State(new int[]{130,-37,91,-3},new int[]{-42,37,-43,38,-40,44});
    states[37] = new State(-39);
    states[38] = new State(new int[]{91,39});
    states[39] = new State(new int[]{93,40});
    states[40] = new State(-3,new int[]{-44,41,-42,42,-43,38,-40,43});
    states[41] = new State(-40);
    states[42] = new State(-41);
    states[43] = new State(new int[]{91,-43,130,-42});
    states[44] = new State(-43);
    states[45] = new State(-44);
    states[46] = new State(-3,new int[]{-45,47,-40,48});
    states[47] = new State(-45);
    states[48] = new State(-46);
    states[49] = new State(-38);
    states[50] = new State(-3,new int[]{-30,51,-29,50,-40,52});
    states[51] = new State(-32);
    states[52] = new State(-33);
    states[53] = new State(-29);
    states[54] = new State(-52);
    states[55] = new State(new int[]{59,56});
    states[56] = new State(-53);
    states[57] = new State(new int[]{61,61},new int[]{-46,58});
    states[58] = new State(new int[]{129,60},new int[]{-32,59});
    states[59] = new State(-54);
    states[60] = new State(-57);
    states[61] = new State(-56);
    states[62] = new State(-55);
    states[63] = new State(-27);
    states[64] = new State(new int[]{130,66},new int[]{-14,65});
    states[65] = new State(-18);
    states[66] = new State(new int[]{40,67});
    states[67] = new State(-3,new int[]{-20,68,-40,74});
    states[68] = new State(new int[]{41,69,135,-3,130,-3},new int[]{-19,70,-30,71,-29,50,-40,52});
    states[69] = new State(-20);
    states[70] = new State(-21);
    states[71] = new State(new int[]{135,34,130,46},new int[]{-21,72,-22,31,-24,32,-25,33,-23,35,-28,36,-26,45,-27,49});
    states[72] = new State(new int[]{130,30},new int[]{-35,73});
    states[73] = new State(-23);
    states[74] = new State(-22);
    states[75] = new State(-19);
    states[76] = new State(new int[]{131,78,133,79,134,-3},new int[]{-18,77,-6,76,-40,80});
    states[77] = new State(-14);
    states[78] = new State(-16);
    states[79] = new State(-17);
    states[80] = new State(-15);
    states[81] = new State(new int[]{134,-15,125,-11});
    states[82] = new State(-9);
    states[83] = new State(-8);
    states[84] = new State(-5);
    states[85] = new State(-4);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-37, new int[]{-1,128});
    rules[2] = new Rule(-1, new int[]{-38,-39,-3});
    rules[3] = new Rule(-40, new int[]{});
    rules[4] = new Rule(-38, new int[]{-40});
    rules[5] = new Rule(-39, new int[]{-40});
    rules[6] = new Rule(-3, new int[]{-2});
    rules[7] = new Rule(-2, new int[]{-4,132,130,-41,123,-5,125});
    rules[8] = new Rule(-4, new int[]{131});
    rules[9] = new Rule(-41, new int[]{-40});
    rules[10] = new Rule(-5, new int[]{-7});
    rules[11] = new Rule(-5, new int[]{-40});
    rules[12] = new Rule(-7, new int[]{-18,-15,-17});
    rules[13] = new Rule(-7, new int[]{-40});
    rules[14] = new Rule(-18, new int[]{-6,-18});
    rules[15] = new Rule(-18, new int[]{-40});
    rules[16] = new Rule(-6, new int[]{131});
    rules[17] = new Rule(-6, new int[]{133});
    rules[18] = new Rule(-15, new int[]{-8,-14});
    rules[19] = new Rule(-8, new int[]{134});
    rules[20] = new Rule(-14, new int[]{130,40,-20,41});
    rules[21] = new Rule(-20, new int[]{-20,-19});
    rules[22] = new Rule(-20, new int[]{-40});
    rules[23] = new Rule(-19, new int[]{-30,-21,-35});
    rules[24] = new Rule(-17, new int[]{-16});
    rules[25] = new Rule(-16, new int[]{123,-13,125});
    rules[26] = new Rule(-13, new int[]{-13,-9});
    rules[27] = new Rule(-13, new int[]{-40});
    rules[28] = new Rule(-9, new int[]{-10});
    rules[29] = new Rule(-9, new int[]{-12});
    rules[30] = new Rule(-10, new int[]{-34,59});
    rules[31] = new Rule(-34, new int[]{-30,-21,-36});
    rules[32] = new Rule(-30, new int[]{-29,-30});
    rules[33] = new Rule(-30, new int[]{-40});
    rules[34] = new Rule(-29, new int[]{-40});
    rules[35] = new Rule(-21, new int[]{-22});
    rules[36] = new Rule(-21, new int[]{-23});
    rules[37] = new Rule(-23, new int[]{-28});
    rules[38] = new Rule(-23, new int[]{-27});
    rules[39] = new Rule(-27, new int[]{-28,-42});
    rules[40] = new Rule(-42, new int[]{-43,91,93,-44});
    rules[41] = new Rule(-44, new int[]{-42});
    rules[42] = new Rule(-44, new int[]{-40});
    rules[43] = new Rule(-43, new int[]{-40});
    rules[44] = new Rule(-28, new int[]{-26});
    rules[45] = new Rule(-26, new int[]{130,-45});
    rules[46] = new Rule(-45, new int[]{-40});
    rules[47] = new Rule(-22, new int[]{-24});
    rules[48] = new Rule(-24, new int[]{-25});
    rules[49] = new Rule(-25, new int[]{135});
    rules[50] = new Rule(-36, new int[]{-35});
    rules[51] = new Rule(-35, new int[]{130});
    rules[52] = new Rule(-12, new int[]{-11});
    rules[53] = new Rule(-11, new int[]{-31,59});
    rules[54] = new Rule(-31, new int[]{-33,-46,-32});
    rules[55] = new Rule(-33, new int[]{130});
    rules[56] = new Rule(-46, new int[]{61});
    rules[57] = new Rule(-32, new int[]{129});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // CompilationUnit -> PackageDeclaration, ImportDeclarations, TypeDeclaration
#line 72 "parser.y"
                                                           { root = new CompilationUnit(null,null,ValueStack[ValueStack.Depth-1].normclassDecl); }
#line default
        break;
      case 6: // TypeDeclaration -> NormalClassDeclaration
#line 88 "parser.y"
                                 { CurrentSemanticValue.normclassDecl = ValueStack[ValueStack.Depth-1].normclassDecl; }
#line default
        break;
      case 7: // NormalClassDeclaration -> ClassModifier, CLASS, Identifier, TypeParameters, '{', 
              //                           ClassBody, '}'
#line 92 "parser.y"
                                                                    {CurrentSemanticValue.normclassDecl = new NormalClassDeclaration(ValueStack[ValueStack.Depth-7].classModi,new Identifier(ValueStack[ValueStack.Depth-5].name),ValueStack[ValueStack.Depth-2].classBodi);}
#line default
        break;
      case 8: // ClassModifier -> PUBLIC
#line 96 "parser.y"
                     { CurrentSemanticValue.classModi = ClassModifier.Public; }
#line default
        break;
      case 10: // ClassBody -> MethodDeclaration
#line 104 "parser.y"
                              {CurrentSemanticValue.classBodi = new ClassBody(ValueStack[ValueStack.Depth-1].methDecl);}
#line default
        break;
      case 12: // MethodDeclaration -> MethodModifiers, MethodHeader, MethodBody
#line 109 "parser.y"
                                                 { CurrentSemanticValue.methDecl = new MethodDeclaration(ValueStack[ValueStack.Depth-3].methodmodilist,ValueStack[ValueStack.Depth-2].methodhea,ValueStack[ValueStack.Depth-1].block); }
#line default
        break;
      case 14: // MethodModifiers -> MethodModifier, MethodModifiers
#line 114 "parser.y"
                                       { CurrentSemanticValue.methodmodilist = ValueStack[ValueStack.Depth-1].methodmodilist; CurrentSemanticValue.methodmodilist.Add(ValueStack[ValueStack.Depth-2].methModi); }
#line default
        break;
      case 15: // MethodModifiers -> empty
#line 115 "parser.y"
                     { CurrentSemanticValue.methodmodilist = new List<MethodModifier>(); }
#line default
        break;
      case 16: // MethodModifier -> PUBLIC
#line 119 "parser.y"
                        { CurrentSemanticValue.methModi = MethodModifier.Public; }
#line default
        break;
      case 17: // MethodModifier -> STATIC
#line 120 "parser.y"
                     { CurrentSemanticValue.methModi = MethodModifier.Static; }
#line default
        break;
      case 18: // MethodHeader -> Result, MethodDeclarator
#line 124 "parser.y"
                                     {CurrentSemanticValue.methodhea = new MethodHeader(ValueStack[ValueStack.Depth-2].result,ValueStack[ValueStack.Depth-1].methodecla);}
#line default
        break;
      case 19: // Result -> VOID
#line 128 "parser.y"
                       { CurrentSemanticValue.result = Result.Void; }
#line default
        break;
      case 20: // MethodDeclarator -> Identifier, '(', FormalParameterList, ')'
#line 132 "parser.y"
                                                {CurrentSemanticValue.methodecla = new MethodDeclarator(new Identifier(ValueStack[ValueStack.Depth-4].name),ValueStack[ValueStack.Depth-2].fmparalist);}
#line default
        break;
      case 21: // FormalParameterList -> FormalParameterList, FormalParameter
#line 136 "parser.y"
                                              { CurrentSemanticValue.fmparalist = ValueStack[ValueStack.Depth-2].fmparalist; CurrentSemanticValue.fmparalist.Add(ValueStack[ValueStack.Depth-1].fmpara); }
#line default
        break;
      case 22: // FormalParameterList -> empty
#line 137 "parser.y"
                        { CurrentSemanticValue.fmparalist = new List<FormalParameter>(); }
#line default
        break;
      case 23: // FormalParameter -> VariableModifiers, UnannType, VariableDeclaratorId
#line 141 "parser.y"
                                                        { CurrentSemanticValue.fmpara = new FormalParameter(ValueStack[ValueStack.Depth-2].untype,ValueStack[ValueStack.Depth-1].ident); }
#line default
        break;
      case 24: // MethodBody -> Block
#line 146 "parser.y"
                     { CurrentSemanticValue.block = ValueStack[ValueStack.Depth-1].block; }
#line default
        break;
      case 25: // Block -> '{', BlockStatements, '}'
#line 150 "parser.y"
                                     {CurrentSemanticValue.block = new Block(ValueStack[ValueStack.Depth-2].stmts);}
#line default
        break;
      case 26: // BlockStatements -> BlockStatements, BlockStatement
#line 154 "parser.y"
                                       { CurrentSemanticValue.stmts = ValueStack[ValueStack.Depth-2].stmts; CurrentSemanticValue.stmts.Add(ValueStack[ValueStack.Depth-1].stmt); }
#line default
        break;
      case 27: // BlockStatements -> empty
#line 155 "parser.y"
                     { CurrentSemanticValue.stmts = new List<Statement>(); }
#line default
        break;
      case 28: // BlockStatement -> LocalVariableDeclarationStatement
#line 159 "parser.y"
                                          { CurrentSemanticValue.stmt = ValueStack[ValueStack.Depth-1].stmt; }
#line default
        break;
      case 29: // BlockStatement -> Statement
#line 160 "parser.y"
                        { CurrentSemanticValue.stmt = ValueStack[ValueStack.Depth-1].stmt; }
#line default
        break;
      case 30: // LocalVariableDeclarationStatement -> LocalVariableDeclaration, ';'
#line 164 "parser.y"
                                      { CurrentSemanticValue.stmt = ValueStack[ValueStack.Depth-2].localvardcl; }
#line default
        break;
      case 31: // LocalVariableDeclaration -> VariableModifiers, UnannType, VariableDeclarator
#line 168 "parser.y"
                                                   { CurrentSemanticValue.localvardcl = new LocalVariableDeclaration(ValueStack[ValueStack.Depth-2].untype,ValueStack[ValueStack.Depth-1].ident); }
#line default
        break;
      case 32: // VariableModifiers -> VariableModifier, VariableModifiers
#line 172 "parser.y"
                                          { CurrentSemanticValue.varmodis = ValueStack[ValueStack.Depth-1].varmodis; CurrentSemanticValue.varmodis.Add(ValueStack[ValueStack.Depth-2].varmodi); }
#line default
        break;
      case 33: // VariableModifiers -> empty
#line 173 "parser.y"
                     { CurrentSemanticValue.varmodis = new List<VariableModifier>(); }
#line default
        break;
      case 34: // VariableModifier -> empty
#line 177 "parser.y"
                     { CurrentSemanticValue.varmodi = null; }
#line default
        break;
      case 35: // UnannType -> UnannPrimitiveType
#line 181 "parser.y"
                              { CurrentSemanticValue.untype = ValueStack[ValueStack.Depth-1].untype; }
#line default
        break;
      case 36: // UnannType -> UnannReferenceType
#line 182 "parser.y"
                              { CurrentSemanticValue.untype = ValueStack[ValueStack.Depth-1].untype; }
#line default
        break;
      case 37: // UnannReferenceType -> UnannClassOrInterfaceType
#line 186 "parser.y"
                                    { CurrentSemanticValue.untype = ValueStack[ValueStack.Depth-1].untype; }
#line default
        break;
      case 38: // UnannReferenceType -> UnannArrayType
#line 187 "parser.y"
                           { CurrentSemanticValue.untype = ValueStack[ValueStack.Depth-1].untype; }
#line default
        break;
      case 39: // UnannArrayType -> UnannClassOrInterfaceType, Dims
#line 191 "parser.y"
                                       { CurrentSemanticValue.untype = new ArrayType(ValueStack[ValueStack.Depth-2].untype); }
#line default
        break;
      case 44: // UnannClassOrInterfaceType -> UnannClassType
#line 208 "parser.y"
                           { CurrentSemanticValue.untype = ValueStack[ValueStack.Depth-1].untype; }
#line default
        break;
      case 45: // UnannClassType -> Identifier, TypeArguments_opt
#line 212 "parser.y"
                                     { CurrentSemanticValue.untype = new NamedType(ValueStack[ValueStack.Depth-2].name); }
#line default
        break;
      case 47: // UnannPrimitiveType -> NumericType
#line 220 "parser.y"
                         { CurrentSemanticValue.untype = ValueStack[ValueStack.Depth-1].untype; }
#line default
        break;
      case 48: // NumericType -> IntegralType
#line 224 "parser.y"
                          { CurrentSemanticValue.untype = ValueStack[ValueStack.Depth-1].untype; }
#line default
        break;
      case 49: // IntegralType -> INT
#line 228 "parser.y"
                   { CurrentSemanticValue.untype = new PrimitiveType(IntegralType.Int); }
#line default
        break;
      case 50: // VariableDeclarator -> VariableDeclaratorId
#line 232 "parser.y"
                                { CurrentSemanticValue.ident = ValueStack[ValueStack.Depth-1].ident; }
#line default
        break;
      case 51: // VariableDeclaratorId -> Identifier
#line 236 "parser.y"
                        { CurrentSemanticValue.ident = new Identifier(ValueStack[ValueStack.Depth-1].name); }
#line default
        break;
      case 52: // Statement -> ExpressionStatement
#line 240 "parser.y"
                               { CurrentSemanticValue.stmt = ValueStack[ValueStack.Depth-1].stmt; }
#line default
        break;
      case 53: // ExpressionStatement -> Assignment, ';'
#line 244 "parser.y"
                           { CurrentSemanticValue.stmt = new ExpressionStatement(ValueStack[ValueStack.Depth-2].assign); }
#line default
        break;
      case 54: // Assignment -> LeftHandSide, AssignmentOperator, Expression
#line 248 "parser.y"
                                                { CurrentSemanticValue.assign = new Assignment(ValueStack[ValueStack.Depth-3].expr,ValueStack[ValueStack.Depth-1].expr); }
#line default
        break;
      case 55: // LeftHandSide -> Identifier
#line 252 "parser.y"
                        { CurrentSemanticValue.expr = new Identifier(ValueStack[ValueStack.Depth-1].name); }
#line default
        break;
      case 56: // AssignmentOperator -> '='
#line 256 "parser.y"
                   { CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
#line default
        break;
      case 57: // Expression -> IntegerLiteral
#line 260 "parser.y"
                           { CurrentSemanticValue.expr = new IntegerLiteral(ValueStack[ValueStack.Depth-1].num); }
#line default
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 264 "parser.y"

public Parser(Scanner scanner) : base(scanner)
{

}
#line default
}
}
