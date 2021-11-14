// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ExpressionParser
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  internal sealed class ExpressionParser
  {
    private const int Empty = 0;
    private const int Scalar = 1;
    private const int Expr = 2;
    private static readonly ExpressionParser.ReservedWords[] reservedwords = new ExpressionParser.ReservedWords[12]
    {
      new ExpressionParser.ReservedWords("And", Tokens.BinaryOp, 26),
      new ExpressionParser.ReservedWords("Between", Tokens.BinaryOp, 6),
      new ExpressionParser.ReservedWords("Child", Tokens.Child, 0),
      new ExpressionParser.ReservedWords("False", Tokens.ZeroOp, 34),
      new ExpressionParser.ReservedWords("In", Tokens.BinaryOp, 5),
      new ExpressionParser.ReservedWords("Is", Tokens.BinaryOp, 13),
      new ExpressionParser.ReservedWords("Like", Tokens.BinaryOp, 14),
      new ExpressionParser.ReservedWords("Not", Tokens.UnaryOp, 3),
      new ExpressionParser.ReservedWords("Null", Tokens.ZeroOp, 32),
      new ExpressionParser.ReservedWords("Or", Tokens.BinaryOp, 27),
      new ExpressionParser.ReservedWords("Parent", Tokens.Parent, 0),
      new ExpressionParser.ReservedWords("True", Tokens.ZeroOp, 33)
    };
    private char Escape = '\\';
    private char DecimalSeparator = '.';
    private char ListSeparator = ',';
    private char ExponentL = 'e';
    private char ExponentU = 'E';
    internal char[] text;
    internal int pos;
    internal int start;
    internal Tokens token;
    internal int op;
    internal OperatorInfo[] ops = new OperatorInfo[100];
    internal int topOperator;
    internal int topNode;
    private readonly DataTable _table;
    private const int MaxPredicates = 100;
    internal ExpressionNode[] NodeStack = new ExpressionNode[100];
    internal int prevOperand;
    internal ExpressionNode expression;

    internal ExpressionParser(DataTable table) => this._table = table;

    internal void LoadExpression(string data)
    {
      int count;
      if (data == null)
      {
        count = 0;
        this.text = new char[count + 1];
      }
      else
      {
        count = data.Length;
        this.text = new char[count + 1];
        data.CopyTo(0, this.text, 0, count);
      }
      this.text[count] = char.MinValue;
      if (this.expression == null)
        return;
      this.expression = (ExpressionNode) null;
    }

    internal void StartScan()
    {
      this.op = 0;
      this.pos = 0;
      this.start = 0;
      this.topOperator = 0;
      this.ops[this.topOperator++] = new OperatorInfo(Nodes.Noop, 0, 0);
    }

    internal ExpressionNode Parse()
    {
      this.expression = (ExpressionNode) null;
      this.StartScan();
      int num1 = 0;
      while (this.token != Tokens.EOS)
      {
        OperatorInfo op1;
        while (true)
        {
          int num2 = (int) this.Scan();
          switch (this.token)
          {
            case Tokens.Name:
            case Tokens.Numeric:
            case Tokens.Decimal:
            case Tokens.Float:
            case Tokens.StringConst:
            case Tokens.Date:
            case Tokens.Parent:
              ExpressionNode node1 = (ExpressionNode) null;
              if (this.prevOperand == 0)
              {
                if (this.topOperator > 0)
                {
                  OperatorInfo op2 = this.ops[this.topOperator - 1];
                  if (op2.type == Nodes.Binop && op2.op == 5 && this.token != Tokens.Parent)
                    goto label_11;
                }
                this.prevOperand = 1;
                OperatorInfo op3;
                switch (this.token)
                {
                  case Tokens.Name:
                    op3 = this.ops[this.topOperator - 1];
                    node1 = (ExpressionNode) new NameNode(this._table, this.text, this.start, this.pos);
                    break;
                  case Tokens.Numeric:
                    node1 = (ExpressionNode) new ConstNode(this._table, ValueType.Numeric, (object) new string(this.text, this.start, this.pos - this.start));
                    break;
                  case Tokens.Decimal:
                    node1 = (ExpressionNode) new ConstNode(this._table, ValueType.Decimal, (object) new string(this.text, this.start, this.pos - this.start));
                    break;
                  case Tokens.Float:
                    node1 = (ExpressionNode) new ConstNode(this._table, ValueType.Float, (object) new string(this.text, this.start, this.pos - this.start));
                    break;
                  case Tokens.StringConst:
                    Debug.Assert(this.text[this.start] == '\'' && this.text[this.pos - 1] == '\'', "The expression contains an invalid string constant");
                    Debug.Assert(this.pos - this.start > 1, "The expression contains an invalid string constant");
                    node1 = (ExpressionNode) new ConstNode(this._table, ValueType.Str, (object) new string(this.text, this.start + 1, this.pos - this.start - 2));
                    break;
                  case Tokens.Date:
                    Debug.Assert(this.text[this.start] == '#' && this.text[this.pos - 1] == '#', "The expression contains invalid date constant.");
                    Debug.Assert(this.pos - this.start > 2, "The expression contains invalid date constant '{0}'.");
                    node1 = (ExpressionNode) new ConstNode(this._table, ValueType.Date, (object) new string(this.text, this.start + 1, this.pos - this.start - 2));
                    break;
                  case Tokens.Parent:
                    string relationName;
                    try
                    {
                      int num3 = (int) this.Scan();
                      if (this.token == Tokens.LeftParen)
                      {
                        this.ScanToken(Tokens.Name);
                        relationName = NameNode.ParseName(this.text, this.start, this.pos);
                        this.ScanToken(Tokens.RightParen);
                        this.ScanToken(Tokens.Dot);
                      }
                      else
                      {
                        relationName = (string) null;
                        this.CheckToken(Tokens.Dot);
                      }
                    }
                    catch (Exception ex)
                    {
                      if (ADP.IsCatchableExceptionType(ex))
                        throw ExprException.LookupArgument();
                      throw;
                    }
                    this.ScanToken(Tokens.Name);
                    string name = NameNode.ParseName(this.text, this.start, this.pos);
                    op3 = this.ops[this.topOperator - 1];
                    node1 = (ExpressionNode) new LookupNode(this._table, name, relationName);
                    break;
                  default:
                    Debug.Assert(false, "unhandled token");
                    break;
                }
                this.NodePush(node1);
                continue;
              }
              goto label_8;
            case Tokens.ListSeparator:
              if (this.prevOperand != 0)
              {
                this.BuildExpression(3);
                if (this.ops[this.topOperator - 1].type == Nodes.Call)
                {
                  ExpressionNode expressionNode = this.NodePop();
                  FunctionNode functionNode = (FunctionNode) this.NodePop();
                  functionNode.AddArgument(expressionNode);
                  this.NodePush((ExpressionNode) functionNode);
                  this.prevOperand = 0;
                  continue;
                }
                goto label_51;
              }
              else
                goto label_49;
            case Tokens.LeftParen:
              ++num1;
              if (this.prevOperand == 0)
              {
                Debug.Assert(this.topOperator > 0, "Empty operator stack!!");
                OperatorInfo op2 = this.ops[this.topOperator - 1];
                if (op2.type == Nodes.Binop && op2.op == 5)
                {
                  this.NodePush((ExpressionNode) new FunctionNode(this._table, "In"));
                  this.ops[this.topOperator++] = new OperatorInfo(Nodes.Call, 0, 2);
                  continue;
                }
                this.ops[this.topOperator++] = new OperatorInfo(Nodes.Paren, 0, 2);
                continue;
              }
              this.BuildExpression(22);
              this.prevOperand = 0;
              ExpressionNode expressionNode1 = this.NodePeek();
              if (expressionNode1 != null && expressionNode1.GetType() == typeof (NameNode))
              {
                ExpressionNode node2 = (ExpressionNode) new FunctionNode(this._table, ((NameNode) this.NodePop()).name);
                Aggregate aggregate = (Aggregate) ((FunctionNode) node2).Aggregate;
                if (aggregate != Aggregate.None)
                {
                  this.NodePush(this.ParseAggregateArgument((FunctionId) aggregate));
                  this.prevOperand = 2;
                  continue;
                }
                this.NodePush(node2);
                this.ops[this.topOperator++] = new OperatorInfo(Nodes.Call, 0, 2);
                continue;
              }
              goto label_33;
            case Tokens.RightParen:
              if (this.prevOperand != 0)
                this.BuildExpression(3);
              if (this.topOperator > 1)
              {
                Debug.Assert(this.topOperator > 1, "melformed operator stack.");
                --this.topOperator;
                op1 = this.ops[this.topOperator];
                if (this.prevOperand != 0 || op1.type == Nodes.Call)
                {
                  Debug.Assert(op1.priority == 2, "melformed operator stack.");
                  if (op1.type == Nodes.Call)
                  {
                    if (this.prevOperand != 0)
                    {
                      ExpressionNode expressionNode2 = this.NodePop();
                      Debug.Assert(this.topNode > 0 && this.NodePeek().GetType() == typeof (FunctionNode), "The function node should be created on '('");
                      FunctionNode functionNode = (FunctionNode) this.NodePop();
                      functionNode.AddArgument(expressionNode2);
                      functionNode.Check();
                      this.NodePush((ExpressionNode) functionNode);
                    }
                  }
                  else
                    this.NodePush((ExpressionNode) new UnaryNode(this._table, 0, this.NodePop()));
                  this.prevOperand = 2;
                  --num1;
                  continue;
                }
                goto label_42;
              }
              else
                goto label_40;
            case Tokens.ZeroOp:
              if (this.prevOperand == 0)
              {
                this.ops[this.topOperator++] = new OperatorInfo(Nodes.Zop, this.op, 24);
                this.prevOperand = 2;
                continue;
              }
              goto label_62;
            case Tokens.UnaryOp:
              this.ops[this.topOperator++] = new OperatorInfo(Nodes.Unop, this.op, Operators.Priority(this.op));
              continue;
            case Tokens.BinaryOp:
              if (this.prevOperand == 0)
              {
                if (this.op == 15)
                {
                  this.op = 2;
                  goto case Tokens.UnaryOp;
                }
                else if (this.op == 16)
                {
                  this.op = 1;
                  goto case Tokens.UnaryOp;
                }
                else
                  goto label_58;
              }
              else
              {
                this.prevOperand = 0;
                this.BuildExpression(Operators.Priority(this.op));
                this.ops[this.topOperator++] = new OperatorInfo(Nodes.Binop, this.op, Operators.Priority(this.op));
                continue;
              }
            case Tokens.Dot:
              ExpressionNode expressionNode3 = this.NodePeek();
              if (expressionNode3 != null && expressionNode3.GetType() == typeof (NameNode))
              {
                int num3 = (int) this.Scan();
                if (this.token == Tokens.Name)
                {
                  this.NodePush((ExpressionNode) new NameNode(this._table, ((NameNode) this.NodePop()).name + "." + NameNode.ParseName(this.text, this.start, this.pos)));
                  continue;
                }
                goto label_67;
              }
              else
                goto label_67;
            case Tokens.EOS:
              goto label_2;
            default:
              goto label_67;
          }
        }
label_2:
        if (this.prevOperand == 0)
        {
          if (this.topNode != 0)
            throw ExprException.MissingOperand(this.ops[this.topOperator - 1]);
          continue;
        }
        this.BuildExpression(3);
        if (this.topOperator != 1)
          throw ExprException.MissingRightParen();
        continue;
label_8:
        throw ExprException.MissingOperator(new string(this.text, this.start, this.pos - this.start));
label_11:
        throw ExprException.InWithoutParentheses();
label_33:
        throw ExprException.SyntaxError();
label_40:
        throw ExprException.TooManyRightParentheses();
label_42:
        throw ExprException.MissingOperand(op1);
label_49:
        throw ExprException.MissingOperandBefore(",");
label_51:
        throw ExprException.SyntaxError();
label_58:
        throw ExprException.MissingOperandBefore(Operators.ToString(this.op));
label_62:
        throw ExprException.MissingOperator(new string(this.text, this.start, this.pos - this.start));
label_67:
        throw ExprException.UnknownToken(new string(this.text, this.start, this.pos - this.start), this.start + 1);
      }
      Debug.Assert(this.topNode == 1 || this.topNode == 0, "Invalid Node Stack");
      this.expression = this.NodeStack[0];
      return this.expression;
    }

    private ExpressionNode ParseAggregateArgument(FunctionId aggregate)
    {
      Debug.Assert(this.token == Tokens.LeftParen, "ParseAggregateArgument(): Invalid argument, token <> '('");
      int num1 = (int) this.Scan();
      bool flag;
      string relationName;
      string name1;
      try
      {
        if (this.token != Tokens.Child)
        {
          if (this.token != Tokens.Name)
            throw ExprException.AggregateArgument();
          string name2 = NameNode.ParseName(this.text, this.start, this.pos);
          this.ScanToken(Tokens.RightParen);
          return (ExpressionNode) new AggregateNode(this._table, aggregate, name2);
        }
        flag = this.token == Tokens.Child;
        this.prevOperand = 1;
        int num2 = (int) this.Scan();
        if (this.token == Tokens.LeftParen)
        {
          this.ScanToken(Tokens.Name);
          relationName = NameNode.ParseName(this.text, this.start, this.pos);
          this.ScanToken(Tokens.RightParen);
          this.ScanToken(Tokens.Dot);
        }
        else
        {
          relationName = (string) null;
          this.CheckToken(Tokens.Dot);
        }
        this.ScanToken(Tokens.Name);
        name1 = NameNode.ParseName(this.text, this.start, this.pos);
        this.ScanToken(Tokens.RightParen);
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableExceptionType(ex))
          throw ExprException.AggregateArgument();
        throw;
      }
      return (ExpressionNode) new AggregateNode(this._table, aggregate, name1, !flag, relationName);
    }

    private ExpressionNode NodePop()
    {
      Debug.Assert(this.topNode > 0, "NodePop(): Corrupted node stack");
      ExpressionNode node = this.NodeStack[--this.topNode];
      Debug.Assert(node != null, "null NodePop");
      return node;
    }

    private ExpressionNode NodePeek() => this.topNode <= 0 ? (ExpressionNode) null : this.NodeStack[this.topNode - 1];

    private void NodePush(ExpressionNode node)
    {
      Debug.Assert(node != null, "null NodePush");
      this.NodeStack[this.topNode++] = this.topNode < 98 ? node : throw ExprException.ExpressionTooComplex();
    }

    private void BuildExpression(int pri)
    {
      Debug.Assert(pri > 0 && pri <= 24, "Invalid priority value");
      OperatorInfo op;
      while (true)
      {
        Debug.Assert(this.topOperator > 0, "Empty operator stack!!");
        op = this.ops[this.topOperator - 1];
        if (op.priority >= pri)
        {
          Debug.Assert(op.priority >= pri, "Invalid prioriry value");
          --this.topOperator;
          ExpressionNode node;
          switch (op.type)
          {
            case Nodes.Unop:
              ExpressionNode expressionNode = (ExpressionNode) null;
              ExpressionNode right1 = this.NodePop();
              switch (op.op)
              {
                case 25:
                  goto label_9;
                default:
                  Debug.Assert(expressionNode == null, "Invalid left operand");
                  Debug.Assert(right1 != null, "Invalid right operand");
                  node = (ExpressionNode) new UnaryNode(this._table, op.op, right1);
                  break;
              }
              break;
            case Nodes.Binop:
              ExpressionNode right2 = this.NodePop();
              ExpressionNode left = this.NodePop();
              switch (op.op)
              {
                case 4:
                case 6:
                case 22:
                case 23:
                case 24:
                case 25:
                  goto label_5;
                case 5:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 26:
                case 27:
                  Debug.Assert(left != null, "Invalid left operand");
                  Debug.Assert(right2 != null, "Invalid right operand");
                  node = op.op != 14 ? (ExpressionNode) new BinaryNode(this._table, op.op, left, right2) : (ExpressionNode) new LikeNode(this._table, op.op, left, right2);
                  break;
                default:
                  Debug.Assert(op.op == 15 || op.op == 16 || (op.op == 17 || op.op == 18) || op.op == 20, "Invalud Binary operation");
                  goto case 5;
              }
              break;
            case Nodes.Zop:
              node = (ExpressionNode) new ZeroOpNode(op.op);
              break;
            default:
              goto label_12;
          }
          Debug.Assert(node != null, "Failed to create expression");
          this.NodePush(node);
        }
        else
          break;
      }
      return;
label_5:
      throw ExprException.UnsupportedOperator(op.op);
label_9:
      throw ExprException.UnsupportedOperator(op.op);
label_12:
      Debug.Assert(false, "Unhandled operator type");
    }

    internal void CheckToken(Tokens token)
    {
      if (this.token != token)
        throw ExprException.UnknownToken(token, this.token, this.pos);
    }

    internal Tokens Scan()
    {
      char[] text = this.text;
      this.token = Tokens.None;
      char ch;
      while (true)
      {
        this.start = this.pos;
        this.op = 0;
        ch = text[this.pos++];
        switch (ch)
        {
          case char.MinValue:
            goto label_2;
          case '\t':
          case '\n':
          case '\r':
          case ' ':
            this.ScanWhite();
            continue;
          case '#':
            goto label_6;
          case '%':
            goto label_21;
          case '&':
            goto label_22;
          case '\'':
            goto label_7;
          case '(':
            goto label_4;
          case ')':
            goto label_5;
          case '*':
            goto label_19;
          case '+':
            goto label_17;
          case '-':
            goto label_18;
          case '/':
            goto label_20;
          case '<':
            goto label_12;
          case '=':
            goto label_8;
          case '>':
            goto label_9;
          case '[':
            goto label_26;
          case '^':
            goto label_24;
          case '`':
            goto label_27;
          case '|':
            goto label_23;
          case '~':
            goto label_25;
          default:
            goto label_28;
        }
      }
label_2:
      this.token = Tokens.EOS;
      goto label_43;
label_4:
      this.token = Tokens.LeftParen;
      goto label_43;
label_5:
      this.token = Tokens.RightParen;
      goto label_43;
label_6:
      this.ScanDate();
      this.CheckToken(Tokens.Date);
      goto label_43;
label_7:
      this.ScanString('\'');
      this.CheckToken(Tokens.StringConst);
      goto label_43;
label_8:
      this.token = Tokens.BinaryOp;
      this.op = 7;
      goto label_43;
label_9:
      this.token = Tokens.BinaryOp;
      this.ScanWhite();
      if (text[this.pos] == '=')
      {
        ++this.pos;
        this.op = 10;
        goto label_43;
      }
      else
      {
        this.op = 8;
        goto label_43;
      }
label_12:
      this.token = Tokens.BinaryOp;
      this.ScanWhite();
      if (text[this.pos] == '=')
      {
        ++this.pos;
        this.op = 11;
        goto label_43;
      }
      else if (text[this.pos] == '>')
      {
        ++this.pos;
        this.op = 12;
        goto label_43;
      }
      else
      {
        this.op = 9;
        goto label_43;
      }
label_17:
      this.token = Tokens.BinaryOp;
      this.op = 15;
      goto label_43;
label_18:
      this.token = Tokens.BinaryOp;
      this.op = 16;
      goto label_43;
label_19:
      this.token = Tokens.BinaryOp;
      this.op = 17;
      goto label_43;
label_20:
      this.token = Tokens.BinaryOp;
      this.op = 18;
      goto label_43;
label_21:
      this.token = Tokens.BinaryOp;
      this.op = 20;
      goto label_43;
label_22:
      this.token = Tokens.BinaryOp;
      this.op = 22;
      goto label_43;
label_23:
      this.token = Tokens.BinaryOp;
      this.op = 23;
      goto label_43;
label_24:
      this.token = Tokens.BinaryOp;
      this.op = 24;
      goto label_43;
label_25:
      this.token = Tokens.BinaryOp;
      this.op = 25;
      goto label_43;
label_26:
      this.ScanName(']', this.Escape, "]\\");
      this.CheckToken(Tokens.Name);
      goto label_43;
label_27:
      this.ScanName('`', '`', "`");
      this.CheckToken(Tokens.Name);
      goto label_43;
label_28:
      if ((int) ch == (int) this.ListSeparator)
      {
        this.token = Tokens.ListSeparator;
      }
      else
      {
        switch (ch)
        {
          case '.':
            if (this.prevOperand == 0)
            {
              this.ScanNumeric();
              goto label_43;
            }
            else
            {
              this.token = Tokens.Dot;
              goto label_43;
            }
          case '0':
            if (text[this.pos] == 'x' || text[this.pos] == 'X')
            {
              this.ScanBinaryConstant();
              this.token = Tokens.BinaryConst;
              goto label_43;
            }
            else
              break;
        }
        if (this.IsDigit(ch))
        {
          this.ScanNumeric();
        }
        else
        {
          this.ScanReserved();
          if (this.token == Tokens.None)
          {
            if (this.IsAlphaNumeric(ch))
            {
              this.ScanName();
              if (this.token != Tokens.None)
              {
                this.CheckToken(Tokens.Name);
                goto label_43;
              }
            }
            this.token = Tokens.Unknown;
            throw ExprException.UnknownToken(new string(text, this.start, this.pos - this.start), this.start + 1);
          }
        }
      }
label_43:
      return this.token;
    }

    private void ScanNumeric()
    {
      char[] text = this.text;
      bool flag1 = false;
      bool flag2 = false;
      Debug.Assert((uint) this.pos > 0U, "We have at least one digit in the buffer, ScanNumeric()");
      Debug.Assert(this.IsDigit(text[this.pos - 1]), "We have at least one digit in the buffer, ScanNumeric(), not a digit");
      while (this.IsDigit(text[this.pos]))
        ++this.pos;
      if ((int) text[this.pos] == (int) this.DecimalSeparator)
      {
        flag1 = true;
        ++this.pos;
      }
      while (this.IsDigit(text[this.pos]))
        ++this.pos;
      if ((int) text[this.pos] == (int) this.ExponentL || (int) text[this.pos] == (int) this.ExponentU)
      {
        flag2 = true;
        ++this.pos;
        if (text[this.pos] == '-' || text[this.pos] == '+')
          ++this.pos;
        while (this.IsDigit(text[this.pos]))
          ++this.pos;
      }
      if (flag2)
        this.token = Tokens.Float;
      else if (flag1)
        this.token = Tokens.Decimal;
      else
        this.token = Tokens.Numeric;
    }

    private void ScanName()
    {
      char[] text = this.text;
      while (this.IsAlphaNumeric(text[this.pos]))
        ++this.pos;
      this.token = Tokens.Name;
    }

    private void ScanName(char chEnd, char esc, string charsToEscape)
    {
      char[] text = this.text;
      Debug.Assert(chEnd > char.MinValue, "Invalid bracket value");
      Debug.Assert(esc > char.MinValue, "Invalid escape value");
      do
      {
        if ((int) text[this.pos] == (int) esc && this.pos + 1 < text.Length && charsToEscape.IndexOf(text[this.pos + 1]) >= 0)
          ++this.pos;
        ++this.pos;
      }
      while (this.pos < text.Length && (int) text[this.pos] != (int) chEnd);
      if (this.pos >= text.Length)
        throw ExprException.InvalidNameBracketing(new string(text, this.start, this.pos - 1 - this.start));
      Debug.Assert((int) text[this.pos] == (int) chEnd, "Invalid bracket value");
      ++this.pos;
      this.token = Tokens.Name;
    }

    private void ScanDate()
    {
      char[] text = this.text;
      do
      {
        ++this.pos;
      }
      while (this.pos < text.Length && text[this.pos] != '#');
      if (this.pos >= text.Length || text[this.pos] != '#')
      {
        if (this.pos >= text.Length)
          throw ExprException.InvalidDate(new string(text, this.start, this.pos - 1 - this.start));
        throw ExprException.InvalidDate(new string(text, this.start, this.pos - this.start));
      }
      this.token = Tokens.Date;
      ++this.pos;
    }

    private void ScanBinaryConstant()
    {
      char[] text = this.text;
    }

    private void ScanReserved()
    {
      char[] text = this.text;
      if (!this.IsAlpha(text[this.pos]))
        return;
      this.ScanName();
      Debug.Assert(this.token == Tokens.Name, "Exprecing an identifier.");
      Debug.Assert(this.pos > this.start, "Exprecing an identifier.");
      string string2 = new string(text, this.start, this.pos - this.start);
      Debug.Assert(string2 != null, "Make sure the arguments for Compare method are OK");
      CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
      int num1 = 0;
      int num2 = ExpressionParser.reservedwords.Length - 1;
      do
      {
        int index = (num1 + num2) / 2;
        Debug.Assert(ExpressionParser.reservedwords[index].word != null, "Make sure the arguments for Compare method are OK");
        int num3 = compareInfo.Compare(ExpressionParser.reservedwords[index].word, string2, CompareOptions.IgnoreCase);
        if (num3 == 0)
        {
          this.token = ExpressionParser.reservedwords[index].token;
          this.op = ExpressionParser.reservedwords[index].op;
          return;
        }
        if (num3 < 0)
          num1 = index + 1;
        else
          num2 = index - 1;
      }
      while (num1 <= num2);
      Debug.Assert(this.token == Tokens.Name, "Exprecing an identifier.");
    }

    private void ScanString(char escape)
    {
      char[] text = this.text;
      while (this.pos < text.Length)
      {
        char ch = text[this.pos++];
        if ((int) ch == (int) escape && this.pos < text.Length && (int) text[this.pos] == (int) escape)
          ++this.pos;
        else if ((int) ch == (int) escape)
          break;
      }
      if (this.pos >= text.Length)
        throw ExprException.InvalidString(new string(text, this.start, this.pos - 1 - this.start));
      this.token = Tokens.StringConst;
    }

    internal void ScanToken(Tokens token)
    {
      int num = (int) this.Scan();
      this.CheckToken(token);
    }

    private void ScanWhite()
    {
      char[] text = this.text;
      while (this.pos < text.Length && this.IsWhiteSpace(text[this.pos]))
        ++this.pos;
    }

    private bool IsWhiteSpace(char ch) => ch <= ' ' && ch > char.MinValue;

    private bool IsAlphaNumeric(char ch)
    {
      switch (ch)
      {
        case '$':
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case '_':
        case 'a':
        case 'b':
        case 'c':
        case 'd':
        case 'e':
        case 'f':
        case 'g':
        case 'h':
        case 'i':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'o':
        case 'p':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'w':
        case 'x':
        case 'y':
        case 'z':
          return true;
        default:
          return ch > '\u007F';
      }
    }

    private bool IsDigit(char ch)
    {
      switch (ch)
      {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
          return true;
        default:
          return false;
      }
    }

    private bool IsAlpha(char ch)
    {
      switch (ch)
      {
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case '_':
        case 'a':
        case 'b':
        case 'c':
        case 'd':
        case 'e':
        case 'f':
        case 'g':
        case 'h':
        case 'i':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'o':
        case 'p':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'w':
        case 'x':
        case 'y':
        case 'z':
          return true;
        default:
          return false;
      }
    }

    private struct ReservedWords
    {
      internal readonly string word;
      internal readonly Tokens token;
      internal readonly int op;

      internal ReservedWords(string word, Tokens token, int op)
      {
        this.word = word;
        this.token = token;
        this.op = op;
      }
    }
  }
}
