// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ConstNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  internal sealed class ConstNode : ExpressionNode
  {
    internal readonly object val;

    internal ConstNode(DataTable table, ValueType type, object constant)
      : this(table, type, constant, true)
    {
    }

    internal ConstNode(DataTable table, ValueType type, object constant, bool fParseQuotes)
      : base(table)
    {
      switch (type)
      {
        case ValueType.Null:
          this.val = (object) DBNull.Value;
          break;
        case ValueType.Bool:
          this.val = (object) Convert.ToBoolean(constant, (IFormatProvider) CultureInfo.InvariantCulture);
          break;
        case ValueType.Numeric:
          this.val = this.SmallestNumeric(constant);
          break;
        case ValueType.Str:
          if (fParseQuotes)
          {
            this.val = (object) ((string) constant).Replace("''", "'");
            break;
          }
          this.val = (object) (string) constant;
          break;
        case ValueType.Float:
          this.val = (object) Convert.ToDouble(constant, (IFormatProvider) NumberFormatInfo.InvariantInfo);
          break;
        case ValueType.Decimal:
          this.val = this.SmallestDecimal(constant);
          break;
        case ValueType.Object:
          this.val = constant;
          break;
        case ValueType.Date:
          this.val = (object) DateTime.Parse((string) constant, (IFormatProvider) CultureInfo.InvariantCulture);
          break;
        default:
          Debug.Assert(false, "NYI");
          goto case ValueType.Object;
      }
    }

    internal override void Bind(DataTable table, List<DataColumn> list) => this.BindTable(table);

    internal override object Eval() => this.val;

    internal override object Eval(DataRow row, DataRowVersion version) => this.Eval();

    internal override object Eval(int[] recordNos) => this.Eval();

    internal override bool IsConstant() => true;

    internal override bool IsTableConstant() => true;

    internal override bool HasLocalAggregate() => false;

    internal override bool HasRemoteAggregate() => false;

    internal override ExpressionNode Optimize() => (ExpressionNode) this;

    private object SmallestDecimal(object constant)
    {
      if (constant == null)
        return (object) 0.0;
      if (constant is IConvertible convertible)
      {
        try
        {
          return (object) convertible.ToDecimal((IFormatProvider) NumberFormatInfo.InvariantInfo);
        }
        catch (ArgumentException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (FormatException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (InvalidCastException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (OverflowException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        try
        {
          return (object) convertible.ToDouble((IFormatProvider) NumberFormatInfo.InvariantInfo);
        }
        catch (ArgumentException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (FormatException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (InvalidCastException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (OverflowException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
      }
      return constant;
    }

    private object SmallestNumeric(object constant)
    {
      if (constant == null)
        return (object) 0;
      if (constant is IConvertible convertible)
      {
        try
        {
          return (object) convertible.ToInt32((IFormatProvider) NumberFormatInfo.InvariantInfo);
        }
        catch (ArgumentException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (FormatException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (InvalidCastException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (OverflowException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        try
        {
          return (object) convertible.ToInt64((IFormatProvider) NumberFormatInfo.InvariantInfo);
        }
        catch (ArgumentException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (FormatException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (InvalidCastException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (OverflowException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        try
        {
          return (object) convertible.ToDouble((IFormatProvider) NumberFormatInfo.InvariantInfo);
        }
        catch (ArgumentException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (FormatException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (InvalidCastException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
        catch (OverflowException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
      }
      return constant;
    }
  }
}
