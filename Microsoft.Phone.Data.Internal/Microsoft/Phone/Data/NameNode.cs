// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.NameNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  internal sealed class NameNode : ExpressionNode
  {
    internal char open;
    internal char close;
    internal string name;
    internal bool found;
    internal bool type;
    internal DataColumn column;

    internal NameNode(DataTable table, char[] text, int start, int pos)
      : base(table)
    {
      this.name = NameNode.ParseName(text, start, pos);
    }

    internal NameNode(DataTable table, string name)
      : base(table)
    {
      this.name = name;
    }

    internal override bool IsSqlColumn => this.column.IsSqlType;

    internal override void Bind(DataTable table, List<DataColumn> list)
    {
      this.BindTable(table);
      if (table == null)
        throw ExprException.UnboundName(this.name);
      try
      {
        this.column = table.Columns[this.name];
      }
      catch (Exception ex)
      {
        this.found = false;
        if (ADP.IsCatchableExceptionType(ex))
          throw ExprException.UnboundName(this.name);
        throw;
      }
      this.name = this.column != null ? this.column.ColumnName : throw ExprException.UnboundName(this.name);
      this.found = true;
      Debug.Assert(this.column != null, "Failed to bind column " + this.name);
      int index = 0;
      while (index < list.Count && this.column != list[index])
        ++index;
      if (index < list.Count)
        return;
      list.Add(this.column);
    }

    internal override object Eval() => throw ExprException.EvalNoContext();

    internal override object Eval(DataRow row, DataRowVersion version)
    {
      if (!this.found)
        throw ExprException.UnboundName(this.name);
      if (row != null)
        return this.column[row.GetRecordFromVersion(version)];
      if (this.IsTableConstant())
        return this.column.DataExpression.Evaluate();
      throw ExprException.UnboundName(this.name);
    }

    internal override object Eval(int[] records) => throw ExprException.ComputeNotAggregate(this.ToString());

    internal override bool IsConstant() => false;

    internal override bool IsTableConstant() => this.column != null && this.column.Computed && this.column.DataExpression.IsTableAggregate();

    internal override bool HasLocalAggregate() => this.column != null && this.column.Computed && this.column.DataExpression.HasLocalAggregate();

    internal override bool HasRemoteAggregate() => this.column != null && this.column.Computed && this.column.DataExpression.HasRemoteAggregate();

    internal override bool DependsOn(DataColumn column)
    {
      if (this.column == column)
        return true;
      return this.column.Computed && this.column.DataExpression.DependsOn(column);
    }

    internal override ExpressionNode Optimize() => (ExpressionNode) this;

    internal static string ParseName(char[] text, int start, int pos)
    {
      char ch = char.MinValue;
      string str = "";
      int startIndex = start;
      int num = pos;
      if (text[start] == '`')
      {
        Debug.Assert(text[checked (pos - 1)] == '`', "Invalid identifyer bracketing, pos = " + pos.ToString((IFormatProvider) CultureInfo.InvariantCulture) + ", end = " + text[checked (pos - 1)].ToString((IFormatProvider) CultureInfo.InvariantCulture));
        checked { ++start; }
        checked { --pos; }
        ch = '\\';
        str = "`";
      }
      else if (text[start] == '[')
      {
        Debug.Assert((text[checked (pos - 1)] == ']' ? 1 : 0) != 0, "Invalid identifyer bracketing of name " + new string(text, start, pos - start) + " pos = " + pos.ToString((IFormatProvider) CultureInfo.InvariantCulture) + ", end = " + text[checked (pos - 1)].ToString((IFormatProvider) CultureInfo.InvariantCulture));
        checked { ++start; }
        checked { --pos; }
        ch = '\\';
        str = "]\\";
      }
      if (ch != char.MinValue)
      {
        int index1 = start;
        for (int index2 = start; index2 < pos; ++index2)
        {
          if ((int) text[index2] == (int) ch && index2 + 1 < pos && str.IndexOf(text[index2 + 1]) >= 0)
            ++index2;
          text[index1] = text[index2];
          ++index1;
        }
        pos = index1;
      }
      if (pos == start)
        throw ExprException.InvalidName(new string(text, startIndex, num - startIndex));
      return new string(text, start, pos - start);
    }
  }
}
