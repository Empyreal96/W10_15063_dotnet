// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.UnaryNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class UnaryNode : ExpressionNode
  {
    internal readonly int op;
    internal ExpressionNode right;

    internal UnaryNode(DataTable table, int op, ExpressionNode right)
      : base(table)
    {
      this.op = op;
      this.right = right;
    }

    internal override void Bind(DataTable table, List<DataColumn> list)
    {
      this.BindTable(table);
      this.right.Bind(table, list);
    }

    internal override object Eval() => this.Eval((DataRow) null, DataRowVersion.Default);

    internal override object Eval(DataRow row, DataRowVersion version) => this.EvalUnaryOp(this.op, this.right.Eval(row, version));

    internal override object Eval(int[] recordNos) => this.right.Eval(recordNos);

    private object EvalUnaryOp(int op, object vl)
    {
      object obj1 = (object) DBNull.Value;
      if (DataExpression.IsUnknown(vl))
        return (object) DBNull.Value;
      switch (op)
      {
        case 0:
          return vl;
        case 1:
          StorageType storageType = DataStorage.GetStorageType(vl.GetType());
          if (!ExpressionNode.IsNumericSql(storageType))
            throw ExprException.TypeMismatch(this.ToString());
          object obj2;
          switch (storageType)
          {
            case StorageType.Byte:
              obj2 = (object) (int) -(byte) vl;
              break;
            case StorageType.Int16:
              obj2 = (object) (int) -(short) vl;
              break;
            case StorageType.Int32:
              obj2 = (object) -(int) vl;
              break;
            case StorageType.Int64:
              obj2 = (object) -(long) vl;
              break;
            case StorageType.Single:
              obj2 = (object) (float) -(double) (float) vl;
              break;
            case StorageType.Double:
              obj2 = (object) -(double) vl;
              break;
            case StorageType.Decimal:
              obj2 = (object) -(Decimal) vl;
              break;
            default:
              Debug.Assert(false, "Missing a type conversion");
              obj2 = (object) DBNull.Value;
              break;
          }
          return obj2;
        case 2:
          return ExpressionNode.IsNumericSql(DataStorage.GetStorageType(vl.GetType())) ? vl : throw ExprException.TypeMismatch(this.ToString());
        case 3:
          return DataExpression.ToBoolean(vl) ? (object) false : (object) true;
        default:
          throw ExprException.UnsupportedOperator(op);
      }
    }

    internal override bool IsConstant() => this.right.IsConstant();

    internal override bool IsTableConstant() => this.right.IsTableConstant();

    internal override bool HasLocalAggregate() => this.right.HasLocalAggregate();

    internal override bool HasRemoteAggregate() => this.right.HasRemoteAggregate();

    internal override bool DependsOn(DataColumn column) => this.right.DependsOn(column);

    internal override ExpressionNode Optimize()
    {
      this.right = this.right.Optimize();
      return this.IsConstant() ? (ExpressionNode) new ConstNode(this.table, ValueType.Object, this.Eval(), false) : (ExpressionNode) this;
    }
  }
}
