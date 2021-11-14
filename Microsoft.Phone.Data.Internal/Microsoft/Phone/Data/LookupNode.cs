// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.LookupNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class LookupNode : ExpressionNode
  {
    private readonly string relationName;
    private readonly string columnName;
    private DataColumn column;
    private DataRelation relation;

    internal LookupNode(DataTable table, string columnName, string relationName)
      : base(table)
    {
      this.relationName = relationName;
      this.columnName = columnName;
    }

    internal override void Bind(DataTable table, List<DataColumn> list)
    {
      this.BindTable(table);
      this.column = (DataColumn) null;
      this.relation = (DataRelation) null;
      DataRelationCollection relationCollection = table != null ? table.ParentRelations : throw ExprException.ExpressionUnbound(this.ToString());
      if (this.relationName == null)
        this.relation = relationCollection.Count <= 1 ? relationCollection[0] : throw ExprException.UnresolvedRelation(table.TableName, this.ToString());
      else
        this.relation = relationCollection[this.relationName];
      DataTable dataTable = this.relation != null ? this.relation.ParentTable : throw ExprException.BindFailure(this.relationName);
      Debug.Assert(this.relation != null, "Invalid relation: no parent table.");
      Debug.Assert(this.columnName != null, "All Lookup expressions have columnName set.");
      this.column = dataTable.Columns[this.columnName];
      if (this.column == null)
        throw ExprException.UnboundName(this.columnName);
      int index = 0;
      while (index < list.Count && this.column != list[index])
        ++index;
      if (index >= list.Count)
        list.Add(this.column);
      AggregateNode.Bind(this.relation, list);
    }

    internal override object Eval() => throw ExprException.EvalNoContext();

    internal override object Eval(DataRow row, DataRowVersion version)
    {
      if (this.column == null || this.relation == null)
        throw ExprException.ExpressionUnbound(this.ToString());
      DataRow parentRow = row.GetParentRow(this.relation, version);
      return parentRow == null ? (object) DBNull.Value : parentRow[this.column, parentRow.HasVersion(version) ? version : DataRowVersion.Current];
    }

    internal override object Eval(int[] recordNos) => throw ExprException.ComputeNotAggregate(this.ToString());

    internal override bool IsConstant() => false;

    internal override bool IsTableConstant() => false;

    internal override bool HasLocalAggregate() => false;

    internal override bool HasRemoteAggregate() => false;

    internal override bool DependsOn(DataColumn column) => this.column == column;

    internal override ExpressionNode Optimize() => (ExpressionNode) this;
  }
}
