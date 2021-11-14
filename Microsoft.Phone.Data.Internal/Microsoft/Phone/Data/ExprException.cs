// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ExprException
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  internal sealed class ExprException
  {
    private ExprException()
    {
    }

    private static OverflowException _Overflow(string error)
    {
      OverflowException overflowException = new OverflowException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) overflowException);
      return overflowException;
    }

    private static InvalidExpressionException _Expr(string error)
    {
      InvalidExpressionException expressionException = new InvalidExpressionException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) expressionException);
      return expressionException;
    }

    private static SyntaxErrorException _Syntax(string error)
    {
      SyntaxErrorException syntaxErrorException = new SyntaxErrorException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) syntaxErrorException);
      return syntaxErrorException;
    }

    private static EvaluateException _Eval(string error)
    {
      EvaluateException evaluateException = new EvaluateException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) evaluateException);
      return evaluateException;
    }

    private static EvaluateException _Eval(string error, Exception innerException)
    {
      EvaluateException evaluateException = new EvaluateException(error);
      ExceptionBuilder.TraceExceptionAsReturnValue((Exception) evaluateException);
      return evaluateException;
    }

    public static Exception InvokeArgument() => (Exception) ExceptionBuilder._Argument(Res.GetString("Expr_InvokeArgument"));

    public static Exception NYI(string moreinfo)
    {
      // ISSUE: reference to a compiler-generated method
      string str = Res.GetString("Expr_NYI", (object) moreinfo);
      Debug.Assert(false, str);
      return (Exception) ExprException._Expr(str);
    }

    public static Exception MissingOperand(OperatorInfo before) => (Exception) ExprException._Syntax(Res.GetString("Expr_MissingOperand", (object) Operators.ToString(before.op)));

    public static Exception MissingOperator(string token) => (Exception) ExprException._Syntax(Res.GetString("Expr_MissingOperand", (object) token));

    public static Exception TypeMismatch(string expr) => (Exception) ExprException._Eval(Res.GetString("Expr_TypeMismatch", (object) expr));

    public static Exception FunctionArgumentOutOfRange(string arg, string func) => (Exception) ExceptionBuilder._ArgumentOutOfRange(arg, Res.GetString("Expr_ArgumentOutofRange", (object) func));

    public static Exception ExpressionTooComplex() => (Exception) ExprException._Eval(Res.GetString("Expr_ExpressionTooComplex"));

    public static Exception UnboundName(string name) => (Exception) ExprException._Eval(Res.GetString("Expr_UnboundName", (object) name));

    public static Exception InvalidString(string str) => (Exception) ExprException._Syntax(Res.GetString("Expr_InvalidString", (object) str));

    public static Exception UndefinedFunction(string name) => (Exception) ExprException._Eval(Res.GetString("Expr_UndefinedFunction", (object) name));

    public static Exception SyntaxError() => (Exception) ExprException._Syntax(Res.GetString("Expr_Syntax"));

    public static Exception FunctionArgumentCount(string name) => (Exception) ExprException._Eval(Res.GetString("Expr_FunctionArgumentCount", (object) name));

    public static Exception MissingRightParen() => (Exception) ExprException._Syntax(Res.GetString("Expr_MissingRightParen"));

    public static Exception UnknownToken(string token, int position) => (Exception) ExprException._Syntax(Res.GetString("Expr_UnknownToken", (object) token, (object) position.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) => (Exception) ExprException._Syntax(Res.GetString("Expr_UnknownToken1", (object) tokExpected.ToString(), (object) tokCurr.ToString(), (object) position.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception DatatypeConvertion(Type type1, Type type2) => (Exception) ExprException._Eval(Res.GetString("Expr_DatatypeConvertion", (object) type1.ToString(), (object) type2.ToString()));

    public static Exception DatavalueConvertion(
      object value,
      Type type,
      Exception innerException)
    {
      // ISSUE: reference to a compiler-generated method
      return (Exception) ExprException._Eval(Res.GetString("Expr_DatavalueConvertion", (object) value.ToString(), (object) type.ToString()), innerException);
    }

    public static Exception InvalidName(string name) => (Exception) ExprException._Syntax(Res.GetString("Expr_InvalidName", (object) name));

    public static Exception InvalidDate(string date) => (Exception) ExprException._Syntax(Res.GetString("Expr_InvalidDate", (object) date));

    public static Exception NonConstantArgument() => (Exception) ExprException._Eval(Res.GetString("Expr_NonConstantArgument"));

    public static Exception InvalidPattern(string pat) => (Exception) ExprException._Eval(Res.GetString("Expr_InvalidPattern", (object) pat));

    public static Exception InWithoutParentheses() => (Exception) ExprException._Syntax(Res.GetString("Expr_InWithoutParentheses"));

    public static Exception InWithoutList() => (Exception) ExprException._Syntax(Res.GetString("Expr_InWithoutList"));

    public static Exception InvalidIsSyntax() => (Exception) ExprException._Syntax(Res.GetString("Expr_IsSyntax"));

    public static Exception Overflow(Type type) => (Exception) ExprException._Overflow(Res.GetString("Expr_Overflow", (object) type.Name));

    public static Exception ArgumentType(string function, int arg, Type type) => (Exception) ExprException._Eval(Res.GetString("Expr_ArgumentType", (object) function, (object) arg.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) type.ToString()));

    public static Exception ArgumentTypeInteger(string function, int arg) => (Exception) ExprException._Eval(Res.GetString("Expr_ArgumentTypeInteger", (object) function, (object) arg.ToString((IFormatProvider) CultureInfo.InvariantCulture)));

    public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) => (Exception) ExprException._Eval(Res.GetString("Expr_TypeMismatchInBinop", (object) Operators.ToString(op), (object) type1.ToString(), (object) type2.ToString()));

    public static Exception AmbiguousBinop(int op, Type type1, Type type2) => (Exception) ExprException._Eval(Res.GetString("Expr_AmbiguousBinop", (object) Operators.ToString(op), (object) type1.ToString(), (object) type2.ToString()));

    public static Exception UnsupportedOperator(int op) => (Exception) ExprException._Eval(Res.GetString("Expr_UnsupportedOperator", (object) Operators.ToString(op)));

    public static Exception InvalidNameBracketing(string name) => (Exception) ExprException._Syntax(Res.GetString("Expr_InvalidNameBracketing", (object) name));

    public static Exception MissingOperandBefore(string op) => (Exception) ExprException._Syntax(Res.GetString("Expr_MissingOperandBefore", (object) op));

    public static Exception TooManyRightParentheses() => (Exception) ExprException._Syntax(Res.GetString("Expr_TooManyRightParentheses"));

    public static Exception UnresolvedRelation(string name, string expr) => (Exception) ExprException._Eval(Res.GetString("Expr_UnresolvedRelation", (object) name, (object) expr));

    internal static EvaluateException BindFailure(string relationName) => ExprException._Eval(Res.GetString("Expr_BindFailure", (object) relationName));

    public static Exception AggregateArgument() => (Exception) ExprException._Syntax(Res.GetString("Expr_AggregateArgument"));

    public static Exception AggregateUnbound(string expr) => (Exception) ExprException._Eval(Res.GetString("Expr_AggregateUnbound", (object) expr));

    public static Exception EvalNoContext() => (Exception) ExprException._Eval(Res.GetString("Expr_EvalNoContext"));

    public static Exception ExpressionUnbound(string expr) => (Exception) ExprException._Eval(Res.GetString("Expr_ExpressionUnbound", (object) expr));

    public static Exception ComputeNotAggregate(string expr) => (Exception) ExprException._Eval(Res.GetString("Expr_ComputeNotAggregate", (object) expr));

    public static Exception FilterConvertion(string expr) => (Exception) ExprException._Eval(Res.GetString("Expr_FilterConvertion", (object) expr));

    public static Exception LookupArgument() => (Exception) ExprException._Syntax(Res.GetString("Expr_LookupArgument"));

    public static Exception InvalidType(string typeName) => (Exception) ExprException._Eval(Res.GetString("Expr_InvalidType", (object) typeName));
  }
}
