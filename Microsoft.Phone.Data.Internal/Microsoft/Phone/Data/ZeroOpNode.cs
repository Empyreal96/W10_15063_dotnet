// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ZeroOpNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class ZeroOpNode : ExpressionNode
  {
    internal readonly int op;
    internal const int zop_True = 1;
    internal const int zop_False = 0;
    internal const int zop_Null = -1;

    internal ZeroOpNode(int op)
      : base((DataTable) null)
    {
      this.op = op;
      Debug.Assert(op == 33 || op == 34 || op == 32, "Invalid zero-op");
    }

    internal override void Bind(DataTable table, List<DataColumn> list)
    {
    }

    internal override object Eval()
    {
      switch (this.op)
      {
        case 32:
          return (object) DBNull.Value;
        case 33:
          return (object) true;
        case 34:
          return (object) false;
        default:
          Debug.Assert(this.op == 33 || this.op == 34 || this.op == 32, "Invalid zero-op");
          return (object) DBNull.Value;
      }
    }

    internal override object Eval(DataRow row, DataRowVersion version) => this.Eval();

    internal override object Eval(int[] recordNos) => this.Eval();

    internal override bool IsConstant() => true;

    internal override bool IsTableConstant() => true;

    internal override bool HasLocalAggregate() => false;

    internal override bool HasRemoteAggregate() => false;

    internal override ExpressionNode Optimize() => (ExpressionNode) this;
  }
}
