// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ForeignKeyConstraint
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  public class ForeignKeyConstraint : Constraint
  {
    internal const Rule Rule_Default = Rule.Cascade;
    internal const AcceptRejectRule AcceptRejectRule_Default = AcceptRejectRule.None;
    internal Rule deleteRule = Rule.Cascade;
    internal Rule updateRule = Rule.Cascade;
    internal AcceptRejectRule acceptRejectRule;
    private DataKey childKey;
    private DataKey parentKey;
    internal string constraintName;
    internal string[] parentColumnNames;
    internal string[] childColumnNames;
    internal string parentTableName;
    internal string parentTableNamespace;

    public ForeignKeyConstraint(DataColumn parentColumn, DataColumn childColumn)
      : this((string) null, parentColumn, childColumn)
    {
    }

    public ForeignKeyConstraint(
      string constraintName,
      DataColumn parentColumn,
      DataColumn childColumn)
    {
      DataColumn[] parentColumns = new DataColumn[1]
      {
        parentColumn
      };
      DataColumn[] childColumns = new DataColumn[1]
      {
        childColumn
      };
      this.Create(constraintName, parentColumns, childColumns);
    }

    public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns)
      : this((string) null, parentColumns, childColumns)
    {
    }

    public ForeignKeyConstraint(
      string constraintName,
      DataColumn[] parentColumns,
      DataColumn[] childColumns)
    {
      this.Create(constraintName, parentColumns, childColumns);
    }

    public ForeignKeyConstraint(
      string constraintName,
      string parentTableName,
      string[] parentColumnNames,
      string[] childColumnNames,
      AcceptRejectRule acceptRejectRule,
      Rule deleteRule,
      Rule updateRule)
    {
      this.constraintName = constraintName;
      this.parentColumnNames = parentColumnNames;
      this.childColumnNames = childColumnNames;
      this.parentTableName = parentTableName;
      this.acceptRejectRule = acceptRejectRule;
      this.deleteRule = deleteRule;
      this.updateRule = updateRule;
    }

    public ForeignKeyConstraint(
      string constraintName,
      string parentTableName,
      string parentTableNamespace,
      string[] parentColumnNames,
      string[] childColumnNames,
      AcceptRejectRule acceptRejectRule,
      Rule deleteRule,
      Rule updateRule)
    {
      this.constraintName = constraintName;
      this.parentColumnNames = parentColumnNames;
      this.childColumnNames = childColumnNames;
      this.parentTableName = parentTableName;
      this.parentTableNamespace = parentTableNamespace;
      this.acceptRejectRule = acceptRejectRule;
      this.deleteRule = deleteRule;
      this.updateRule = updateRule;
    }

    internal DataKey ChildKey
    {
      get
      {
        this.CheckStateForProperty();
        return this.childKey;
      }
    }

    public virtual DataColumn[] Columns
    {
      get
      {
        this.CheckStateForProperty();
        return this.childKey.ToArray();
      }
    }

    public override DataTable Table
    {
      get
      {
        this.CheckStateForProperty();
        return this.childKey.Table;
      }
    }

    internal override void CheckCanAddToCollection(ConstraintCollection constraints)
    {
      if (this.Table != constraints.Table)
        throw ExceptionBuilder.ConstraintAddFailed(constraints.Table);
      if (!CultureInfoCompareWorkaround.CultureEqual(this.Table.Locale, this.RelatedTable.Locale) || this.Table.CaseSensitive != this.RelatedTable.CaseSensitive)
        throw ExceptionBuilder.CaseLocaleMismatch();
    }

    internal override bool CanBeRemovedFromCollection(
      ConstraintCollection constraints,
      bool fThrowException)
    {
      return true;
    }

    internal bool IsKeyNull(object[] values)
    {
      for (int index = 0; index < values.Length; ++index)
      {
        if (!DataStorage.IsObjectNull(values[index]))
          return false;
      }
      return true;
    }

    internal override bool IsConstraintViolated()
    {
      Index sortIndex1 = this.childKey.GetSortIndex();
      object[] uniqueKeyValues = sortIndex1.GetUniqueKeyValues();
      bool flag = false;
      Index sortIndex2 = this.parentKey.GetSortIndex();
      for (int index1 = 0; index1 < uniqueKeyValues.Length; ++index1)
      {
        object[] objArray = (object[]) uniqueKeyValues[index1];
        if (!this.IsKeyNull(objArray) && !sortIndex2.IsKeyInIndex(objArray))
        {
          Index index2 = sortIndex1;
          DataRow[] rows = index2.GetRows(index2.FindRecords(objArray));
          // ISSUE: reference to a compiler-generated method
          string str = Res.GetString("DataConstraint_ForeignKeyViolation", (object) this.ConstraintName, (object) ExceptionBuilder.KeysToString(objArray));
          for (int index3 = 0; index3 < rows.Length; ++index3)
            rows[index3].RowError = str;
          flag = true;
        }
      }
      return flag;
    }

    internal override bool CanEnableConstraint()
    {
      if (this.Table.DataSet == null || !this.Table.DataSet.EnforceConstraints)
        return true;
      object[] uniqueKeyValues = this.childKey.GetSortIndex().GetUniqueKeyValues();
      Index sortIndex = this.parentKey.GetSortIndex();
      for (int index = 0; index < uniqueKeyValues.Length; ++index)
      {
        object[] objArray = (object[]) uniqueKeyValues[index];
        if (!this.IsKeyNull(objArray) && !sortIndex.IsKeyInIndex(objArray))
          return false;
      }
      return true;
    }

    internal void CascadeCommit(DataRow row)
    {
      if (row.RowState == DataRowState.Detached || this.acceptRejectRule != AcceptRejectRule.Cascade)
        return;
      Index sortIndex = this.childKey.GetSortIndex(row.RowState == DataRowState.Deleted ? DataViewRowState.Deleted : DataViewRowState.CurrentRows);
      object[] keyValues = row.GetKeyValues(this.parentKey, row.RowState == DataRowState.Deleted ? DataRowVersion.Original : DataRowVersion.Default);
      if (this.IsKeyNull(keyValues))
        return;
      Range records = sortIndex.FindRecords(keyValues);
      if (records.IsNull)
        return;
      foreach (DataRow row1 in sortIndex.GetRows(records))
      {
        if (DataRowState.Detached != row1.RowState && !row1.inCascade)
          row1.AcceptChanges();
      }
    }

    internal void CascadeDelete(DataRow row)
    {
      if (-1 == row.newRecord)
        return;
      object[] keyValues1 = row.GetKeyValues(this.parentKey, DataRowVersion.Current);
      if (this.IsKeyNull(keyValues1))
        return;
      Index sortIndex = this.childKey.GetSortIndex();
      switch (this.DeleteRule)
      {
        case Rule.None:
          if (!row.Table.DataSet.EnforceConstraints)
            break;
          Range records1 = sortIndex.FindRecords(keyValues1);
          if (records1.IsNull || records1.Count == 1 && sortIndex.GetRow(records1.Min) == row)
            break;
          throw ExceptionBuilder.FailedCascadeDelete(this.ConstraintName);
        case Rule.Cascade:
          object[] keyValues2 = row.GetKeyValues(this.parentKey, DataRowVersion.Default);
          Range records2 = sortIndex.FindRecords(keyValues2);
          if (records2.IsNull)
            break;
          foreach (DataRow row1 in sortIndex.GetRows(records2))
          {
            if (!row1.inCascade)
              row1.Table.DeleteRow(row1);
          }
          break;
        case Rule.SetNull:
          object[] keyValues3 = new object[this.childKey.ColumnsReference.Length];
          for (int index = 0; index < this.childKey.ColumnsReference.Length; ++index)
            keyValues3[index] = (object) DBNull.Value;
          Range records3 = sortIndex.FindRecords(keyValues1);
          if (records3.IsNull)
            break;
          DataRow[] rows1 = sortIndex.GetRows(records3);
          for (int index = 0; index < rows1.Length; ++index)
          {
            if (row != rows1[index])
              rows1[index].SetKeyValues(this.childKey, keyValues3);
          }
          break;
        case Rule.SetDefault:
          object[] keyValues4 = new object[this.childKey.ColumnsReference.Length];
          for (int index = 0; index < this.childKey.ColumnsReference.Length; ++index)
            keyValues4[index] = this.childKey.ColumnsReference[index].DefaultValue;
          Range records4 = sortIndex.FindRecords(keyValues1);
          if (records4.IsNull)
            break;
          DataRow[] rows2 = sortIndex.GetRows(records4);
          for (int index = 0; index < rows2.Length; ++index)
          {
            if (row != rows2[index])
              rows2[index].SetKeyValues(this.childKey, keyValues4);
          }
          break;
        default:
          Debug.Assert(false, "Unknown Rule value");
          break;
      }
    }

    internal void CascadeRollback(DataRow row)
    {
      Index sortIndex = this.childKey.GetSortIndex(row.RowState == DataRowState.Deleted ? DataViewRowState.OriginalRows : DataViewRowState.CurrentRows);
      object[] keyValues = row.GetKeyValues(this.parentKey, row.RowState == DataRowState.Modified ? DataRowVersion.Current : DataRowVersion.Default);
      if (this.IsKeyNull(keyValues))
        return;
      Range records = sortIndex.FindRecords(keyValues);
      if (this.acceptRejectRule == AcceptRejectRule.Cascade)
      {
        if (records.IsNull)
          return;
        DataRow[] rows = sortIndex.GetRows(records);
        for (int index = 0; index < rows.Length; ++index)
        {
          if (!rows[index].inCascade)
            rows[index].RejectChanges();
        }
      }
      else if (row.RowState != DataRowState.Deleted && row.Table.DataSet.EnforceConstraints && !records.IsNull && ((records.Count != 1 || sortIndex.GetRow(records.Min) != row) && row.HasKeyChanged(this.parentKey)))
        throw ExceptionBuilder.FailedCascadeUpdate(this.ConstraintName);
    }

    internal void CascadeUpdate(DataRow row)
    {
      if (-1 == row.newRecord)
        return;
      object[] keyValues1 = row.GetKeyValues(this.parentKey, DataRowVersion.Current);
      if (!this.Table.DataSet.fInReadXml && this.IsKeyNull(keyValues1))
        return;
      Index sortIndex = this.childKey.GetSortIndex();
      switch (this.UpdateRule)
      {
        case Rule.None:
          if (!row.Table.DataSet.EnforceConstraints || sortIndex.FindRecords(keyValues1).IsNull)
            break;
          throw ExceptionBuilder.FailedCascadeUpdate(this.ConstraintName);
        case Rule.Cascade:
          Range records1 = sortIndex.FindRecords(keyValues1);
          if (records1.IsNull)
            break;
          object[] keyValues2 = row.GetKeyValues(this.parentKey, DataRowVersion.Proposed);
          foreach (DataRow row1 in sortIndex.GetRows(records1))
            row1.SetKeyValues(this.childKey, keyValues2);
          break;
        case Rule.SetNull:
          object[] keyValues3 = new object[this.childKey.ColumnsReference.Length];
          for (int index = 0; index < this.childKey.ColumnsReference.Length; ++index)
            keyValues3[index] = (object) DBNull.Value;
          Range records2 = sortIndex.FindRecords(keyValues1);
          if (records2.IsNull)
            break;
          foreach (DataRow row1 in sortIndex.GetRows(records2))
            row1.SetKeyValues(this.childKey, keyValues3);
          break;
        case Rule.SetDefault:
          object[] keyValues4 = new object[this.childKey.ColumnsReference.Length];
          for (int index = 0; index < this.childKey.ColumnsReference.Length; ++index)
            keyValues4[index] = this.childKey.ColumnsReference[index].DefaultValue;
          Range records3 = sortIndex.FindRecords(keyValues1);
          if (records3.IsNull)
            break;
          foreach (DataRow row1 in sortIndex.GetRows(records3))
            row1.SetKeyValues(this.childKey, keyValues4);
          break;
        default:
          Debug.Assert(false, "Unknown Rule value");
          break;
      }
    }

    internal void CheckCanClearParentTable(DataTable table)
    {
      if (this.Table.DataSet.EnforceConstraints && this.Table.Rows.Count > 0)
        throw ExceptionBuilder.FailedClearParentTable(table.TableName, this.ConstraintName, this.Table.TableName);
    }

    internal void CheckCanRemoveParentRow(DataRow row)
    {
      Debug.Assert(this.Table.DataSet != null, "Relation " + this.ConstraintName + " isn't part of a DataSet, so this check shouldn't be happening.");
      if (this.Table.DataSet.EnforceConstraints && DataRelation.GetChildRows(this.ParentKey, this.ChildKey, row, DataRowVersion.Default).Length != 0)
        throw ExceptionBuilder.RemoveParentRow(this);
    }

    internal void CheckCascade(DataRow row, DataRowAction action)
    {
      Debug.Assert(this.Table.DataSet != null, "ForeignKeyConstraint " + this.ConstraintName + " isn't part of a DataSet, so this check shouldn't be happening.");
      if (row.inCascade)
        return;
      row.inCascade = true;
      try
      {
        switch (action)
        {
          case DataRowAction.Delete:
            this.CascadeDelete(row);
            break;
          case DataRowAction.Change:
            if (!row.HasKeyChanged(this.parentKey))
              break;
            this.CascadeUpdate(row);
            break;
          case DataRowAction.Rollback:
            this.CascadeRollback(row);
            break;
          case DataRowAction.Commit:
            this.CascadeCommit(row);
            break;
          case DataRowAction.Add:
            break;
          default:
            Debug.Assert(false, "attempt to cascade unknown action: " + action.ToString());
            break;
        }
      }
      finally
      {
        row.inCascade = false;
      }
    }

    internal override void CheckConstraint(DataRow childRow, DataRowAction action)
    {
      if (action != DataRowAction.Change && action != DataRowAction.Add && action != DataRowAction.Rollback || (this.Table.DataSet == null || !this.Table.DataSet.EnforceConstraints || !childRow.HasKeyChanged(this.childKey)))
        return;
      DataRowVersion version = action == DataRowAction.Rollback ? DataRowVersion.Original : DataRowVersion.Current;
      object[] keyValues1 = childRow.GetKeyValues(this.childKey);
      if (childRow.HasVersion(version))
      {
        DataRow parentRow = DataRelation.GetParentRow(this.ParentKey, this.ChildKey, childRow, version);
        if (parentRow != null && parentRow.inCascade)
        {
          object[] keyValues2 = parentRow.GetKeyValues(this.parentKey, action == DataRowAction.Rollback ? version : DataRowVersion.Default);
          int num = childRow.Table.NewRecord();
          childRow.Table.SetKeyValues(this.childKey, keyValues2, num);
          if (this.childKey.RecordsEqual(childRow.tempRecord, num))
            return;
        }
      }
      object[] keyValues3 = childRow.GetKeyValues(this.childKey);
      if (!this.IsKeyNull(keyValues3) && !this.parentKey.GetSortIndex().IsKeyInIndex(keyValues3))
      {
        if (this.childKey.Table == this.parentKey.Table && childRow.tempRecord != -1)
        {
          int index;
          for (index = 0; index < keyValues3.Length; ++index)
          {
            DataColumn dataColumn = this.parentKey.ColumnsReference[index];
            object obj = dataColumn.ConvertValue(keyValues3[index]);
            if (dataColumn.CompareValueTo(childRow.tempRecord, obj) != 0)
              break;
          }
          if (index == keyValues3.Length)
            return;
        }
        throw ExceptionBuilder.ForeignKeyViolation(this.ConstraintName, keyValues1);
      }
    }

    private void NonVirtualCheckState()
    {
      if (this._DataSet != null)
        return;
      this.parentKey.CheckState();
      this.childKey.CheckState();
      if (this.parentKey.Table.DataSet != this.childKey.Table.DataSet)
        throw ExceptionBuilder.TablesInDifferentSets();
      for (int index = 0; index < this.parentKey.ColumnsReference.Length; ++index)
      {
        if (this.parentKey.ColumnsReference[index].DataType != this.childKey.ColumnsReference[index].DataType || this.parentKey.ColumnsReference[index].DataType == typeof (DateTime) && this.parentKey.ColumnsReference[index].DateTimeMode != this.childKey.ColumnsReference[index].DateTimeMode && (this.parentKey.ColumnsReference[index].DateTimeMode & this.childKey.ColumnsReference[index].DateTimeMode) != DataSetDateTime.Unspecified)
          throw ExceptionBuilder.ColumnsTypeMismatch();
      }
      if (this.childKey.ColumnsEqual(this.parentKey))
        throw ExceptionBuilder.KeyColumnsIdentical();
    }

    internal override void CheckState() => this.NonVirtualCheckState();

    public virtual AcceptRejectRule AcceptRejectRule
    {
      get
      {
        this.CheckStateForProperty();
        return this.acceptRejectRule;
      }
      set => this.acceptRejectRule = value == AcceptRejectRule.None || value == AcceptRejectRule.Cascade ? value : throw ADP.InvalidAcceptRejectRule(value);
    }

    internal override bool ContainsColumn(DataColumn column) => this.parentKey.ContainsColumn(column) || this.childKey.ContainsColumn(column);

    internal override Constraint Clone(DataSet destination) => this.Clone(destination, false);

    internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
    {
      int index1 = !ignorNSforTableLookup ? destination.Tables.IndexOf(this.Table.TableName, this.Table.Namespace, false) : destination.Tables.IndexOf(this.Table.TableName);
      if (index1 < 0)
        return (Constraint) null;
      DataTable table1 = destination.Tables[index1];
      int index2 = !ignorNSforTableLookup ? destination.Tables.IndexOf(this.RelatedTable.TableName, this.RelatedTable.Namespace, false) : destination.Tables.IndexOf(this.RelatedTable.TableName);
      if (index2 < 0)
        return (Constraint) null;
      DataTable table2 = destination.Tables[index2];
      int length = this.Columns.Length;
      DataColumn[] childColumns = new DataColumn[length];
      DataColumn[] parentColumns = new DataColumn[length];
      for (int index3 = 0; index3 < length; ++index3)
      {
        DataColumn column = this.Columns[index3];
        int index4 = table1.Columns.IndexOf(column.ColumnName);
        if (index4 < 0)
          return (Constraint) null;
        childColumns[index3] = table1.Columns[index4];
        DataColumn dataColumn = this.RelatedColumnsReference[index3];
        int index5 = table2.Columns.IndexOf(dataColumn.ColumnName);
        if (index5 < 0)
          return (Constraint) null;
        parentColumns[index3] = table2.Columns[index5];
      }
      ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint(this.ConstraintName, parentColumns, childColumns);
      foreignKeyConstraint.UpdateRule = this.UpdateRule;
      foreignKeyConstraint.DeleteRule = this.DeleteRule;
      foreignKeyConstraint.AcceptRejectRule = this.AcceptRejectRule;
      foreach (object key in (IEnumerable) this.ExtendedProperties.Keys)
        foreignKeyConstraint.ExtendedProperties[key] = this.ExtendedProperties[key];
      return (Constraint) foreignKeyConstraint;
    }

    internal ForeignKeyConstraint Clone(DataTable destination)
    {
      Debug.Assert(this.Table == this.RelatedTable, "We call this clone just if we have the same datatable as parent and child ");
      int length = this.Columns.Length;
      DataColumn[] childColumns = new DataColumn[length];
      DataColumn[] parentColumns = new DataColumn[length];
      for (int index1 = 0; index1 < length; ++index1)
      {
        DataColumn column = this.Columns[index1];
        int index2 = destination.Columns.IndexOf(column.ColumnName);
        if (index2 < 0)
          return (ForeignKeyConstraint) null;
        childColumns[index1] = destination.Columns[index2];
        DataColumn dataColumn = this.RelatedColumnsReference[index1];
        int index3 = destination.Columns.IndexOf(dataColumn.ColumnName);
        if (index3 < 0)
          return (ForeignKeyConstraint) null;
        parentColumns[index1] = destination.Columns[index3];
      }
      ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint(this.ConstraintName, parentColumns, childColumns);
      foreignKeyConstraint.UpdateRule = this.UpdateRule;
      foreignKeyConstraint.DeleteRule = this.DeleteRule;
      foreignKeyConstraint.AcceptRejectRule = this.AcceptRejectRule;
      foreach (object key in (IEnumerable) this.ExtendedProperties.Keys)
        foreignKeyConstraint.ExtendedProperties[key] = this.ExtendedProperties[key];
      return foreignKeyConstraint;
    }

    private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns)
    {
      if (parentColumns.Length == 0 || childColumns.Length == 0)
        throw ExceptionBuilder.KeyLengthZero();
      if (parentColumns.Length != childColumns.Length)
        throw ExceptionBuilder.KeyLengthMismatch();
      for (int index = 0; index < parentColumns.Length; ++index)
      {
        if (parentColumns[index].Computed)
          throw ExceptionBuilder.ExpressionInConstraint(parentColumns[index]);
        if (childColumns[index].Computed)
          throw ExceptionBuilder.ExpressionInConstraint(childColumns[index]);
      }
      this.parentKey = new DataKey(parentColumns, true);
      this.childKey = new DataKey(childColumns, true);
      this.ConstraintName = relationName;
      this.NonVirtualCheckState();
    }

    public virtual Rule DeleteRule
    {
      get
      {
        this.CheckStateForProperty();
        return this.deleteRule;
      }
      set
      {
        switch (value)
        {
          case Rule.None:
          case Rule.Cascade:
          case Rule.SetNull:
          case Rule.SetDefault:
            this.deleteRule = value;
            break;
          default:
            throw ADP.InvalidRule(value);
        }
      }
    }

    public override bool Equals(object key)
    {
      if (!(key is ForeignKeyConstraint))
        return false;
      ForeignKeyConstraint foreignKeyConstraint = (ForeignKeyConstraint) key;
      return this.ParentKey.ColumnsEqual(foreignKeyConstraint.ParentKey) && this.ChildKey.ColumnsEqual(foreignKeyConstraint.ChildKey);
    }

    public override int GetHashCode() => base.GetHashCode();

    public virtual DataColumn[] RelatedColumns
    {
      get
      {
        this.CheckStateForProperty();
        return this.parentKey.ToArray();
      }
    }

    internal DataColumn[] RelatedColumnsReference
    {
      get
      {
        this.CheckStateForProperty();
        return this.parentKey.ColumnsReference;
      }
    }

    internal DataKey ParentKey
    {
      get
      {
        this.CheckStateForProperty();
        return this.parentKey;
      }
    }

    internal DataRelation FindParentRelation()
    {
      DataRelationCollection parentRelations = this.Table.ParentRelations;
      for (int index = 0; index < parentRelations.Count; ++index)
      {
        if (parentRelations[index].ChildKeyConstraint == this)
          return parentRelations[index];
      }
      return (DataRelation) null;
    }

    public virtual DataTable RelatedTable
    {
      get
      {
        this.CheckStateForProperty();
        return this.parentKey.Table;
      }
    }

    public virtual Rule UpdateRule
    {
      get
      {
        this.CheckStateForProperty();
        return this.updateRule;
      }
      set
      {
        switch (value)
        {
          case Rule.None:
          case Rule.Cascade:
          case Rule.SetNull:
          case Rule.SetDefault:
            this.updateRule = value;
            break;
          default:
            throw ADP.InvalidRule(value);
        }
      }
    }
  }
}
