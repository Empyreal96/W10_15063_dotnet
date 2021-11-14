// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Merger
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  internal sealed class Merger
  {
    private DataSet dataSet;
    private DataTable dataTable;
    private bool preserveChanges;
    private MissingSchemaAction missingSchemaAction;
    private bool isStandAlonetable;
    private bool _IgnoreNSforTableLookup;

    internal Merger(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction)
    {
      this.dataSet = dataSet;
      this.preserveChanges = preserveChanges;
      if (missingSchemaAction == MissingSchemaAction.AddWithKey)
        this.missingSchemaAction = MissingSchemaAction.Add;
      else
        this.missingSchemaAction = missingSchemaAction;
    }

    internal Merger(
      DataTable dataTable,
      bool preserveChanges,
      MissingSchemaAction missingSchemaAction)
    {
      this.isStandAlonetable = true;
      this.dataTable = dataTable;
      this.preserveChanges = preserveChanges;
      if (missingSchemaAction == MissingSchemaAction.AddWithKey)
        this.missingSchemaAction = MissingSchemaAction.Add;
      else
        this.missingSchemaAction = missingSchemaAction;
    }

    internal void MergeDataSet(DataSet source)
    {
      if (source == this.dataSet)
        return;
      bool enforceConstraints = this.dataSet.EnforceConstraints;
      this.dataSet.EnforceConstraints = false;
      this._IgnoreNSforTableLookup = this.dataSet.namespaceURI != source.namespaceURI;
      List<DataColumn> dataColumnList = (List<DataColumn>) null;
      if (MissingSchemaAction.Add == this.missingSchemaAction)
      {
        dataColumnList = new List<DataColumn>();
        foreach (DataTable table in (InternalDataCollectionBase) this.dataSet.Tables)
        {
          foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
            dataColumnList.Add(column);
        }
      }
      for (int index = 0; index < source.Tables.Count; ++index)
        this.MergeTableData(source.Tables[index]);
      if (MissingSchemaAction.Ignore != this.missingSchemaAction)
      {
        this.MergeConstraints(source);
        for (int index = 0; index < source.Relations.Count; ++index)
          this.MergeRelation(source.Relations[index]);
      }
      if (MissingSchemaAction.Add == this.missingSchemaAction)
      {
        foreach (DataTable table in (InternalDataCollectionBase) source.Tables)
        {
          DataTable dataTable = !this._IgnoreNSforTableLookup ? this.dataSet.Tables[table.TableName, table.Namespace] : this.dataSet.Tables[table.TableName];
          foreach (DataColumn column1 in (InternalDataCollectionBase) table.Columns)
          {
            if (column1.Computed)
            {
              DataColumn column2 = dataTable.Columns[column1.ColumnName];
              if (!dataColumnList.Contains(column2))
                column2.Expression = column1.Expression;
            }
          }
        }
      }
      this.MergeExtendedProperties(source.ExtendedProperties, this.dataSet.ExtendedProperties);
      foreach (DataTable table in (InternalDataCollectionBase) this.dataSet.Tables)
        table.EvaluateExpressions();
      this.dataSet.EnforceConstraints = enforceConstraints;
    }

    internal void MergeTable(DataTable src)
    {
      bool flag = false;
      if (!this.isStandAlonetable)
      {
        if (src.DataSet == this.dataSet)
          return;
        flag = this.dataSet.EnforceConstraints;
        this.dataSet.EnforceConstraints = false;
      }
      else
      {
        if (src == this.dataTable)
          return;
        this.dataTable.SuspendEnforceConstraints = true;
      }
      if (this.dataSet != null)
      {
        if (src.DataSet == null || src.DataSet.namespaceURI != this.dataSet.namespaceURI)
          this._IgnoreNSforTableLookup = true;
      }
      else if (this.dataTable.DataSet == null || src.DataSet == null || src.DataSet.namespaceURI != this.dataTable.DataSet.namespaceURI)
        this._IgnoreNSforTableLookup = true;
      this.MergeTableData(src);
      DataTable dataTable = this.dataTable;
      if (dataTable == null && this.dataSet != null)
        dataTable = !this._IgnoreNSforTableLookup ? this.dataSet.Tables[src.TableName, src.Namespace] : this.dataSet.Tables[src.TableName];
      dataTable?.EvaluateExpressions();
      if (!this.isStandAlonetable)
      {
        this.dataSet.EnforceConstraints = flag;
      }
      else
      {
        this.dataTable.SuspendEnforceConstraints = false;
        try
        {
          if (!this.dataTable.EnforceConstraints)
            return;
          this.dataTable.EnableConstraints();
        }
        catch (ConstraintException ex)
        {
          if (this.dataTable.DataSet != null)
            this.dataTable.DataSet.EnforceConstraints = false;
          throw;
        }
      }
    }

    private void MergeTable(DataTable src, DataTable dst)
    {
      int count = src.Rows.Count;
      bool flag = dst.Rows.Count == 0;
      if (0 < count)
      {
        Index index = (Index) null;
        DataKey key = new DataKey();
        dst.SuspendIndexEvents();
        try
        {
          if (!flag && dst.primaryKey != null)
          {
            key = this.GetSrcKey(src, dst);
            if (key.HasValue)
              index = dst.primaryKey.Key.GetSortIndex(DataViewRowState.OriginalRows | DataViewRowState.Added);
          }
          foreach (DataRow row in (InternalDataCollectionBase) src.Rows)
          {
            DataRow targetRow = (DataRow) null;
            if (index != null)
              targetRow = dst.FindMergeTarget(row, key, index);
            dst.MergeRow(row, targetRow, this.preserveChanges, index);
          }
        }
        finally
        {
          dst.RestoreIndexEvents(true);
        }
      }
      this.MergeExtendedProperties(src.ExtendedProperties, dst.ExtendedProperties);
    }

    internal void MergeRows(DataRow[] rows)
    {
      DataTable src = (DataTable) null;
      DataTable dst = (DataTable) null;
      DataKey key = new DataKey();
      Index index1 = (Index) null;
      bool enforceConstraints = this.dataSet.EnforceConstraints;
      this.dataSet.EnforceConstraints = false;
      Index index2;
      for (int index3 = 0; index3 < rows.Length; ++index3)
      {
        DataRow row1 = rows[index3];
        if (row1 == null)
          throw ExceptionBuilder.ArgumentNull("rows[" + (object) index3 + "]");
        if (row1.Table == null)
          throw ExceptionBuilder.ArgumentNull("rows[" + (object) index3 + "].Table");
        if (row1.Table.DataSet != this.dataSet)
        {
          if (src != row1.Table)
          {
            src = row1.Table;
            dst = this.MergeSchema(row1.Table);
            if (dst == null)
            {
              Debug.Assert(MissingSchemaAction.Ignore == this.missingSchemaAction, "MergeSchema failed");
              this.dataSet.EnforceConstraints = enforceConstraints;
              return;
            }
            if (dst.primaryKey != null)
              key = this.GetSrcKey(src, dst);
            if (key.HasValue)
            {
              if (index1 != null)
              {
                index1.RemoveRef();
                index2 = (Index) null;
              }
              DataTable table = dst;
              index1 = new Index(table, table.primaryKey.Key.GetIndexDesc(), DataViewRowState.OriginalRows | DataViewRowState.Added, (IFilter) null);
              index1.AddRef();
              index1.AddRef();
            }
          }
          if (row1.newRecord != -1 || row1.oldRecord != -1)
          {
            DataRow targetRow = (DataRow) null;
            if (0 < dst.Rows.Count && index1 != null)
              targetRow = dst.FindMergeTarget(row1, key, index1);
            DataRow row2 = dst.MergeRow(row1, targetRow, this.preserveChanges, index1);
            if (row2.Table.dependentColumns != null && row2.Table.dependentColumns.Count > 0)
              row2.Table.EvaluateExpressions(row2, DataRowAction.Change, (List<DataRow>) null);
          }
        }
      }
      if (index1 != null)
      {
        index1.RemoveRef();
        index2 = (Index) null;
      }
      this.dataSet.EnforceConstraints = enforceConstraints;
    }

    private DataTable MergeSchema(DataTable table)
    {
      DataTable table1 = (DataTable) null;
      if (!this.isStandAlonetable)
      {
        if (this.dataSet.Tables.Contains(table.TableName, true))
          table1 = !this._IgnoreNSforTableLookup ? this.dataSet.Tables[table.TableName, table.Namespace] : this.dataSet.Tables[table.TableName];
      }
      else
        table1 = this.dataTable;
      if (table1 == null)
      {
        if (MissingSchemaAction.Add == this.missingSchemaAction)
        {
          DataTable dataTable = table;
          table1 = dataTable.Clone(dataTable.DataSet);
          this.dataSet.Tables.Add(table1);
        }
        else if (MissingSchemaAction.Error == this.missingSchemaAction)
          throw ExceptionBuilder.MergeMissingDefinition(table.TableName);
      }
      else
      {
        if (MissingSchemaAction.Ignore != this.missingSchemaAction)
        {
          int count = table1.Columns.Count;
          for (int index = 0; index < table.Columns.Count; ++index)
          {
            DataColumn column1 = table.Columns[index];
            DataColumn dataColumn = table1.Columns.Contains(column1.ColumnName, true) ? table1.Columns[column1.ColumnName] : (DataColumn) null;
            if (dataColumn == null)
            {
              if (MissingSchemaAction.Add == this.missingSchemaAction)
              {
                DataColumn column2 = column1.Clone();
                table1.Columns.Add(column2);
              }
              else
              {
                if (this.isStandAlonetable)
                {
                  // ISSUE: reference to a compiler-generated method
                  throw ExceptionBuilder.MergeFailed(Res.GetString("DataMerge_MissingColumnDefinition", (object) table.TableName, (object) column1.ColumnName));
                }
                // ISSUE: reference to a compiler-generated method
                this.dataSet.RaiseMergeFailed(table1, Res.GetString("DataMerge_MissingColumnDefinition", (object) table.TableName, (object) column1.ColumnName), this.missingSchemaAction);
              }
            }
            else
            {
              if (dataColumn.DataType != column1.DataType || dataColumn.DataType == typeof (DateTime) && dataColumn.DateTimeMode != column1.DateTimeMode && (dataColumn.DateTimeMode & column1.DateTimeMode) != DataSetDateTime.Unspecified)
              {
                if (this.isStandAlonetable)
                {
                  // ISSUE: reference to a compiler-generated method
                  throw ExceptionBuilder.MergeFailed(Res.GetString("DataMerge_DataTypeMismatch", (object) column1.ColumnName));
                }
                // ISSUE: reference to a compiler-generated method
                this.dataSet.RaiseMergeFailed(table1, Res.GetString("DataMerge_DataTypeMismatch", (object) column1.ColumnName), MissingSchemaAction.Error);
              }
              this.MergeExtendedProperties(column1.ExtendedProperties, dataColumn.ExtendedProperties);
            }
          }
          if (this.isStandAlonetable)
          {
            for (int index = count; index < table1.Columns.Count; ++index)
              table1.Columns[index].Expression = table.Columns[table1.Columns[index].ColumnName].Expression;
          }
          DataColumn[] primaryKey1 = table1.PrimaryKey;
          DataColumn[] primaryKey2 = table.PrimaryKey;
          if (primaryKey1.Length != primaryKey2.Length)
          {
            if (primaryKey1.Length == 0)
            {
              DataColumn[] dataColumnArray = new DataColumn[primaryKey2.Length];
              for (int index = 0; index < primaryKey2.Length; ++index)
                dataColumnArray[index] = table1.Columns[primaryKey2[index].ColumnName];
              table1.PrimaryKey = dataColumnArray;
            }
            else if (primaryKey2.Length != 0)
            {
              // ISSUE: reference to a compiler-generated method
              this.dataSet.RaiseMergeFailed(table1, Res.GetString("DataMerge_PrimaryKeyMismatch"), this.missingSchemaAction);
            }
          }
          else
          {
            for (int index = 0; index < primaryKey1.Length; ++index)
            {
              if (string.Compare(primaryKey1[index].ColumnName, primaryKey2[index].ColumnName, table1.Locale, CompareOptions.None) != 0)
              {
                // ISSUE: reference to a compiler-generated method
                this.dataSet.RaiseMergeFailed(table, Res.GetString("DataMerge_PrimaryKeyColumnsMismatch", (object) primaryKey1[index].ColumnName, (object) primaryKey2[index].ColumnName), this.missingSchemaAction);
              }
            }
          }
        }
        this.MergeExtendedProperties(table.ExtendedProperties, table1.ExtendedProperties);
      }
      return table1;
    }

    private void MergeTableData(DataTable src)
    {
      DataTable dst = this.MergeSchema(src);
      if (dst == null)
        return;
      dst.MergingData = true;
      try
      {
        this.MergeTable(src, dst);
      }
      finally
      {
        dst.MergingData = false;
      }
    }

    private void MergeConstraints(DataSet source)
    {
      for (int index = 0; index < source.Tables.Count; ++index)
        this.MergeConstraints(source.Tables[index]);
    }

    private void MergeConstraints(DataTable table)
    {
      for (int index = 0; index < table.Constraints.Count; ++index)
      {
        Constraint constraint1 = table.Constraints[index];
        Constraint constraint2 = constraint1.Clone(this.dataSet, this._IgnoreNSforTableLookup);
        if (constraint2 == null)
        {
          // ISSUE: reference to a compiler-generated method
          this.dataSet.RaiseMergeFailed(table, Res.GetString("DataMerge_MissingConstraint", (object) constraint1.GetType().FullName, (object) constraint1.ConstraintName), this.missingSchemaAction);
        }
        else
        {
          Constraint constraint3 = constraint2.Table.Constraints.FindConstraint(constraint2);
          if (constraint3 == null)
          {
            if (MissingSchemaAction.Add == this.missingSchemaAction)
            {
              try
              {
                constraint2.Table.Constraints.Add(constraint2);
              }
              catch (DuplicateNameException ex)
              {
                constraint2.ConstraintName = "";
                constraint2.Table.Constraints.Add(constraint2);
              }
            }
            else if (MissingSchemaAction.Error == this.missingSchemaAction)
            {
              // ISSUE: reference to a compiler-generated method
              this.dataSet.RaiseMergeFailed(table, Res.GetString("DataMerge_MissingConstraint", (object) constraint1.GetType().FullName, (object) constraint1.ConstraintName), this.missingSchemaAction);
            }
          }
          else
            this.MergeExtendedProperties(constraint1.ExtendedProperties, constraint3.ExtendedProperties);
        }
      }
    }

    private void MergeRelation(DataRelation relation)
    {
      Debug.Assert(MissingSchemaAction.Error == this.missingSchemaAction || MissingSchemaAction.Add == this.missingSchemaAction, "Unexpected value of MissingSchemaAction parameter : " + this.missingSchemaAction.ToString());
      DataRelation relation1 = (DataRelation) null;
      int index1 = this.dataSet.Relations.InternalIndexOf(relation.RelationName);
      if (index1 >= 0)
      {
        relation1 = this.dataSet.Relations[index1];
        DataKey dataKey = relation.ParentKey;
        int length1 = dataKey.ColumnsReference.Length;
        dataKey = relation1.ParentKey;
        int length2 = dataKey.ColumnsReference.Length;
        if (length1 != length2)
        {
          // ISSUE: reference to a compiler-generated method
          this.dataSet.RaiseMergeFailed((DataTable) null, Res.GetString("DataMerge_MissingDefinition", (object) relation.RelationName), this.missingSchemaAction);
        }
        int index2 = 0;
        while (true)
        {
          int num = index2;
          dataKey = relation.ParentKey;
          int length3 = dataKey.ColumnsReference.Length;
          if (num < length3)
          {
            dataKey = relation1.ParentKey;
            DataColumn dataColumn1 = dataKey.ColumnsReference[index2];
            dataKey = relation.ParentKey;
            DataColumn dataColumn2 = dataKey.ColumnsReference[index2];
            if (string.Compare(dataColumn1.ColumnName, dataColumn2.ColumnName, dataColumn1.Table.Locale, CompareOptions.None) != 0)
            {
              // ISSUE: reference to a compiler-generated method
              this.dataSet.RaiseMergeFailed((DataTable) null, Res.GetString("DataMerge_ReltionKeyColumnsMismatch", (object) relation.RelationName), this.missingSchemaAction);
            }
            dataKey = relation1.ChildKey;
            DataColumn dataColumn3 = dataKey.ColumnsReference[index2];
            dataKey = relation.ChildKey;
            DataColumn dataColumn4 = dataKey.ColumnsReference[index2];
            if (string.Compare(dataColumn3.ColumnName, dataColumn4.ColumnName, dataColumn3.Table.Locale, CompareOptions.None) != 0)
            {
              // ISSUE: reference to a compiler-generated method
              this.dataSet.RaiseMergeFailed((DataTable) null, Res.GetString("DataMerge_ReltionKeyColumnsMismatch", (object) relation.RelationName), this.missingSchemaAction);
            }
            ++index2;
          }
          else
            break;
        }
      }
      else if (MissingSchemaAction.Add == this.missingSchemaAction)
      {
        DataTable dataTable1 = !this._IgnoreNSforTableLookup ? this.dataSet.Tables[relation.ParentTable.TableName, relation.ParentTable.Namespace] : this.dataSet.Tables[relation.ParentTable.TableName];
        DataTable dataTable2 = !this._IgnoreNSforTableLookup ? this.dataSet.Tables[relation.ChildTable.TableName, relation.ChildTable.Namespace] : this.dataSet.Tables[relation.ChildTable.TableName];
        DataKey dataKey = relation.ParentKey;
        DataColumn[] parentColumns = new DataColumn[dataKey.ColumnsReference.Length];
        dataKey = relation.ParentKey;
        DataColumn[] childColumns = new DataColumn[dataKey.ColumnsReference.Length];
        int index2 = 0;
        while (true)
        {
          int num = index2;
          dataKey = relation.ParentKey;
          int length = dataKey.ColumnsReference.Length;
          if (num < length)
          {
            DataColumn[] dataColumnArray1 = parentColumns;
            int index3 = index2;
            DataColumnCollection columns1 = dataTable1.Columns;
            dataKey = relation.ParentKey;
            string columnName1 = dataKey.ColumnsReference[index2].ColumnName;
            DataColumn dataColumn1 = columns1[columnName1];
            dataColumnArray1[index3] = dataColumn1;
            DataColumn[] dataColumnArray2 = childColumns;
            int index4 = index2;
            DataColumnCollection columns2 = dataTable2.Columns;
            dataKey = relation.ChildKey;
            string columnName2 = dataKey.ColumnsReference[index2].ColumnName;
            DataColumn dataColumn2 = columns2[columnName2];
            dataColumnArray2[index4] = dataColumn2;
            ++index2;
          }
          else
            break;
        }
        try
        {
          relation1 = new DataRelation(relation.RelationName, parentColumns, childColumns, relation.createConstraints);
          relation1.Nested = relation.Nested;
          this.dataSet.Relations.Add(relation1);
        }
        catch (Exception ex)
        {
          if (!ADP.IsCatchableExceptionType(ex))
          {
            throw;
          }
          else
          {
            ExceptionBuilder.TraceExceptionForCapture(ex);
            this.dataSet.RaiseMergeFailed((DataTable) null, ex.Message, this.missingSchemaAction);
          }
        }
      }
      else
      {
        Debug.Assert(MissingSchemaAction.Error == this.missingSchemaAction, "Unexpected value of MissingSchemaAction parameter : " + this.missingSchemaAction.ToString());
        throw ExceptionBuilder.MergeMissingDefinition(relation.RelationName);
      }
      this.MergeExtendedProperties(relation.ExtendedProperties, relation1.ExtendedProperties);
    }

    private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst)
    {
      if (MissingSchemaAction.Ignore == this.missingSchemaAction)
        return;
      IDictionaryEnumerator enumerator = src.GetEnumerator();
      while (enumerator.MoveNext())
      {
        if (!this.preserveChanges || dst[enumerator.Key] == null)
          dst[enumerator.Key] = enumerator.Value;
      }
    }

    private DataKey GetSrcKey(DataTable src, DataTable dst)
    {
      if (src.primaryKey != null)
        return src.primaryKey.Key;
      DataKey dataKey = new DataKey();
      if (dst.primaryKey != null)
      {
        DataColumn[] columnsReference = dst.primaryKey.Key.ColumnsReference;
        DataColumn[] columns = new DataColumn[columnsReference.Length];
        for (int index = 0; index < columnsReference.Length; ++index)
          columns[index] = src.Columns[columnsReference[index].ColumnName];
        dataKey = new DataKey(columns, false);
      }
      return dataKey;
    }
  }
}
