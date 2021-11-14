// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.AggregateNode
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class AggregateNode : ExpressionNode
  {
    private readonly AggregateType type;
    private readonly Aggregate aggregate;
    private readonly bool local;
    private readonly string relationName;
    private readonly string columnName;
    private DataTable childTable;
    private DataColumn column;
    private DataRelation relation;

    internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName)
      : this(table, aggregateType, columnName, true, (string) null)
    {
    }

    internal AggregateNode(
      DataTable table,
      FunctionId aggregateType,
      string columnName,
      bool local,
      string relationName)
      : base(table)
    {
      Debug.Assert(columnName != null, "Invalid parameter column name (null).");
      this.aggregate = (Aggregate) aggregateType;
      switch (aggregateType)
      {
        case FunctionId.Sum:
          this.type = AggregateType.Sum;
          break;
        case FunctionId.Avg:
          this.type = AggregateType.Mean;
          break;
        case FunctionId.Min:
          this.type = AggregateType.Min;
          break;
        case FunctionId.Max:
          this.type = AggregateType.Max;
          break;
        case FunctionId.Count:
          this.type = AggregateType.Count;
          break;
        case FunctionId.StDev:
          this.type = AggregateType.StDev;
          break;
        case FunctionId.Var:
          this.type = AggregateType.Var;
          break;
        default:
          throw ExprException.UndefinedFunction(Function.FunctionName[(int) aggregateType]);
      }
      this.local = local;
      this.relationName = relationName;
      this.columnName = columnName;
    }

    internal override void Bind(DataTable table, List<DataColumn> list)
    {
      this.BindTable(table);
      if (table == null)
        throw ExprException.AggregateUnbound(this.ToString());
      if (this.local)
      {
        this.relation = (DataRelation) null;
      }
      else
      {
        DataRelationCollection childRelations = table.ChildRelations;
        if (this.relationName == null)
        {
          if (childRelations.Count > 1)
            throw ExprException.UnresolvedRelation(table.TableName, this.ToString());
          this.relation = childRelations.Count == 1 ? childRelations[0] : throw ExprException.AggregateUnbound(this.ToString());
        }
        else
          this.relation = childRelations[this.relationName];
      }
      this.childTable = this.relation == null ? table : this.relation.ChildTable;
      this.column = this.childTable.Columns[this.columnName];
      if (this.column == null)
        throw ExprException.UnboundName(this.columnName);
      Debug.Assert(this.column != null, "Failed to bind column " + this.columnName);
      int index = 0;
      while (index < list.Count && this.column != list[index])
        ++index;
      if (index >= list.Count)
        list.Add(this.column);
      AggregateNode.Bind(this.relation, list);
    }

    internal static void Bind(DataRelation relation, List<DataColumn> list)
    {
      if (relation == null)
        return;
      foreach (DataColumn dataColumn in relation.ChildColumnsReference)
      {
        if (!list.Contains(dataColumn))
          list.Add(dataColumn);
      }
      foreach (DataColumn dataColumn in relation.ParentColumnsReference)
      {
        if (!list.Contains(dataColumn))
          list.Add(dataColumn);
      }
    }

    internal override object Eval() => this.Eval((DataRow) null, DataRowVersion.Default);

    internal override object Eval(DataRow row, DataRowVersion version)
    {
      if (this.childTable == null)
        throw ExprException.AggregateUnbound(this.ToString());
      DataRow[] array;
      if (this.local)
      {
        array = new DataRow[this.childTable.Rows.Count];
        this.childTable.Rows.CopyTo(array, 0);
      }
      else
      {
        if (row == null)
          throw ExprException.EvalNoContext();
        if (this.relation == null)
          throw ExprException.AggregateUnbound(this.ToString());
        array = row.GetChildRows(this.relation, version);
      }
      if (version == DataRowVersion.Proposed)
        version = DataRowVersion.Default;
      List<int> intList = new List<int>();
      for (int index = 0; index < array.Length; ++index)
      {
        if (array[index].RowState == DataRowState.Deleted)
        {
          if (DataRowAction.Rollback == array[index]._action)
          {
            Debug.Assert(DataRowVersion.Original == version, "wrong version");
            version = DataRowVersion.Original;
          }
          else
            continue;
        }
        else if (DataRowAction.Rollback == array[index]._action && array[index].RowState == DataRowState.Added)
          continue;
        if (version != DataRowVersion.Original || array[index].oldRecord != -1)
          intList.Add(array[index].GetRecordFromVersion(version));
      }
      return this.column.GetAggregateValue(intList.ToArray(), this.type);
    }

    internal override object Eval(int[] records)
    {
      if (this.childTable == null)
        throw ExprException.AggregateUnbound(this.ToString());
      if (!this.local)
        throw ExprException.ComputeNotAggregate(this.ToString());
      return this.column.GetAggregateValue(records, this.type);
    }

    internal override bool IsConstant() => false;

    internal override bool IsTableConstant() => this.local;

    internal override bool HasLocalAggregate() => this.local;

    internal override bool HasRemoteAggregate() => !this.local;

    internal override bool DependsOn(DataColumn column)
    {
      if (this.column == column)
        return true;
      return this.column.Computed && this.column.DataExpression.DependsOn(column);
    }

    internal override ExpressionNode Optimize() => (ExpressionNode) this;
  }
}
