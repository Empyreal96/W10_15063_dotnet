// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataRelation
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  public class DataRelation
  {
    private DataSet dataSet;
    internal PropertyCollection extendedProperties;
    internal string relationName = "";
    private PropertyChangedEventHandler onPropertyChangingDelegate;
    private DataKey childKey;
    private DataKey parentKey;
    private UniqueConstraint parentKeyConstraint;
    private ForeignKeyConstraint childKeyConstraint;
    internal string[] parentColumnNames;
    internal string[] childColumnNames;
    internal string parentTableName;
    internal string childTableName;
    internal string parentTableNamespace;
    internal string childTableNamespace;
    internal bool nested;
    internal bool createConstraints;
    private bool _checkMultipleNested = true;

    public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn)
      : this(relationName, parentColumn, childColumn, true)
    {
    }

    public DataRelation(
      string relationName,
      DataColumn parentColumn,
      DataColumn childColumn,
      bool createConstraints)
    {
      DataColumn[] parentColumns = new DataColumn[1]
      {
        parentColumn
      };
      DataColumn[] childColumns = new DataColumn[1]
      {
        childColumn
      };
      this.Create(relationName, parentColumns, childColumns, createConstraints);
    }

    public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns)
      : this(relationName, parentColumns, childColumns, true)
    {
    }

    public DataRelation(
      string relationName,
      DataColumn[] parentColumns,
      DataColumn[] childColumns,
      bool createConstraints)
    {
      this.Create(relationName, parentColumns, childColumns, createConstraints);
    }

    public DataRelation(
      string relationName,
      string parentTableName,
      string childTableName,
      string[] parentColumnNames,
      string[] childColumnNames,
      bool nested)
    {
      this.relationName = relationName;
      this.parentColumnNames = parentColumnNames;
      this.childColumnNames = childColumnNames;
      this.parentTableName = parentTableName;
      this.childTableName = childTableName;
      this.nested = nested;
    }

    public virtual DataColumn[] ChildColumns
    {
      get
      {
        this.CheckStateForProperty();
        return this.childKey.ToArray();
      }
    }

    internal DataColumn[] ChildColumnsReference
    {
      get
      {
        this.CheckStateForProperty();
        return this.childKey.ColumnsReference;
      }
    }

    internal DataKey ChildKey
    {
      get
      {
        this.CheckStateForProperty();
        return this.childKey;
      }
    }

    public virtual DataTable ChildTable
    {
      get
      {
        this.CheckStateForProperty();
        return this.childKey.Table;
      }
    }

    public virtual DataSet DataSet
    {
      get
      {
        this.CheckStateForProperty();
        return this.dataSet;
      }
    }

    private static bool IsKeyNull(object[] values)
    {
      for (int index = 0; index < values.Length; ++index)
      {
        if (!DataStorage.IsObjectNull(values[index]))
          return false;
      }
      return true;
    }

    internal static DataRow[] GetChildRows(
      DataKey parentKey,
      DataKey childKey,
      DataRow parentRow,
      DataRowVersion version)
    {
      object[] keyValues = parentRow.GetKeyValues(parentKey, version);
      return DataRelation.IsKeyNull(keyValues) ? childKey.Table.NewRowArray(0) : childKey.GetSortIndex(version == DataRowVersion.Original ? DataViewRowState.OriginalRows : DataViewRowState.CurrentRows).GetRows(keyValues);
    }

    internal static DataRow[] GetParentRows(
      DataKey parentKey,
      DataKey childKey,
      DataRow childRow,
      DataRowVersion version)
    {
      object[] keyValues = childRow.GetKeyValues(childKey, version);
      return DataRelation.IsKeyNull(keyValues) ? parentKey.Table.NewRowArray(0) : parentKey.GetSortIndex(version == DataRowVersion.Original ? DataViewRowState.OriginalRows : DataViewRowState.CurrentRows).GetRows(keyValues);
    }

    internal static DataRow GetParentRow(
      DataKey parentKey,
      DataKey childKey,
      DataRow childRow,
      DataRowVersion version)
    {
      if (!childRow.HasVersion(version == DataRowVersion.Original ? DataRowVersion.Original : DataRowVersion.Current) && childRow.tempRecord == -1)
        return (DataRow) null;
      object[] keyValues = childRow.GetKeyValues(childKey, version);
      if (DataRelation.IsKeyNull(keyValues))
        return (DataRow) null;
      Index sortIndex = parentKey.GetSortIndex(version == DataRowVersion.Original ? DataViewRowState.OriginalRows : DataViewRowState.CurrentRows);
      Range records = sortIndex.FindRecords(keyValues);
      if (records.IsNull)
        return (DataRow) null;
      if (records.Count > 1)
        throw ExceptionBuilder.MultipleParents();
      return parentKey.Table.recordManager[sortIndex.GetRecord(records.Min)];
    }

    internal void SetDataSet(DataSet dataSet)
    {
      if (this.dataSet == dataSet)
        return;
      this.dataSet = dataSet;
    }

    internal void SetParentRowRecords(DataRow childRow, DataRow parentRow)
    {
      object[] keyValues = parentRow.GetKeyValues(this.ParentKey);
      if (childRow.tempRecord != -1)
        this.ChildTable.recordManager.SetKeyValues(childRow.tempRecord, this.ChildKey, keyValues);
      if (childRow.newRecord != -1)
        this.ChildTable.recordManager.SetKeyValues(childRow.newRecord, this.ChildKey, keyValues);
      if (childRow.oldRecord == -1)
        return;
      this.ChildTable.recordManager.SetKeyValues(childRow.oldRecord, this.ChildKey, keyValues);
    }

    public virtual DataColumn[] ParentColumns
    {
      get
      {
        this.CheckStateForProperty();
        return this.parentKey.ToArray();
      }
    }

    internal DataColumn[] ParentColumnsReference => this.parentKey.ColumnsReference;

    internal DataKey ParentKey
    {
      get
      {
        this.CheckStateForProperty();
        return this.parentKey;
      }
    }

    public virtual DataTable ParentTable
    {
      get
      {
        this.CheckStateForProperty();
        return this.parentKey.Table;
      }
    }

    public virtual string RelationName
    {
      get
      {
        this.CheckStateForProperty();
        return this.relationName;
      }
      set
      {
        if (value == null)
          value = "";
        CultureInfo culture = this.dataSet != null ? this.dataSet.Locale : CultureInfo.CurrentCulture;
        if (string.Compare(this.relationName, value, culture, CompareOptions.IgnoreCase) != 0)
        {
          if (this.dataSet != null)
          {
            if (value.Length == 0)
              throw ExceptionBuilder.NoRelationName();
            this.dataSet.Relations.RegisterName(value);
            if (this.relationName.Length != 0)
              this.dataSet.Relations.UnregisterName(this.relationName);
          }
          this.relationName = value;
          ((DataRelationCollection.DataTableRelationCollection) this.ParentTable.ChildRelations).OnRelationPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, (object) this));
          ((DataRelationCollection.DataTableRelationCollection) this.ChildTable.ParentRelations).OnRelationPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, (object) this));
        }
        else
        {
          if (string.Compare(this.relationName, value, culture, CompareOptions.None) == 0)
            return;
          this.relationName = value;
          ((DataRelationCollection.DataTableRelationCollection) this.ParentTable.ChildRelations).OnRelationPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, (object) this));
          ((DataRelationCollection.DataTableRelationCollection) this.ChildTable.ParentRelations).OnRelationPropertyChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, (object) this));
        }
      }
    }

    internal void CheckNamespaceValidityForNestedRelations(string ns)
    {
      foreach (DataRelation parentRelation in (InternalDataCollectionBase) this.ChildTable.ParentRelations)
      {
        if ((parentRelation == this || parentRelation.Nested) && parentRelation.ParentTable.Namespace != ns)
          throw ExceptionBuilder.InValidNestedRelation(this.ChildTable.TableName);
      }
    }

    internal void CheckNestedRelations()
    {
      Debug.Assert(this.DataSet == null || !this.nested, "this relation supposed to be not in dataset or not nested");
      int count = this.ParentTable.DataSet.Tables.Count;
      DataTable parentTable = this.ParentTable;
      if (this.ChildTable == this.ParentTable)
      {
        if (string.Compare(this.ChildTable.TableName, this.ChildTable.DataSet.DataSetName, this.ChildTable.DataSet.Locale, CompareOptions.IgnoreCase) == 0)
          throw ExceptionBuilder.SelfnestedDatasetConflictingName(this.ChildTable.TableName);
      }
      else
      {
        List<DataTable> dataTableList = new List<DataTable>();
        dataTableList.Add(this.ChildTable);
        for (int index = 0; index < dataTableList.Count; ++index)
        {
          foreach (DataRelation nestedParentRelation in dataTableList[index].NestedParentRelations)
          {
            if (nestedParentRelation.ParentTable == this.ChildTable && nestedParentRelation.ChildTable != this.ChildTable)
              throw ExceptionBuilder.LoopInNestedRelations(this.ChildTable.TableName);
            if (!dataTableList.Contains(nestedParentRelation.ParentTable))
              dataTableList.Add(nestedParentRelation.ParentTable);
          }
        }
      }
    }

    public virtual bool Nested
    {
      get
      {
        this.CheckStateForProperty();
        return this.nested;
      }
      set
      {
        if (this.nested == value)
          return;
        if (this.dataSet != null && value)
        {
          if (this.ChildTable.IsNamespaceInherited())
            this.CheckNamespaceValidityForNestedRelations(this.ParentTable.Namespace);
          Debug.Assert(this.ChildTable != null, "On a DataSet, but not on Table. Bad state");
          ConstraintCollection constraints = this.ChildTable.Constraints;
          DataKey dataKey = this.ChildKey;
          DataColumn[] columnsReference1 = dataKey.ColumnsReference;
          dataKey = this.ParentKey;
          DataColumn[] columnsReference2 = dataKey.ColumnsReference;
          constraints.FindForeignKeyConstraint(columnsReference1, columnsReference2)?.CheckConstraint();
          this.ValidateMultipleNestedRelations();
        }
        if (!value && this.parentKey.ColumnsReference[0].ColumnMapping == MappingType.Hidden)
          throw ExceptionBuilder.RelationNestedReadOnly();
        if (value)
          this.ParentTable.Columns.RegisterColumnName(this.ChildTable.TableName, (DataColumn) null, this.ChildTable);
        else
          this.ParentTable.Columns.UnregisterName(this.ChildTable.TableName);
        this.RaisePropertyChanging(nameof (Nested));
        if (value)
        {
          this.CheckNestedRelations();
          if (this.DataSet != null)
          {
            if (this.ParentTable == this.ChildTable)
            {
              foreach (DataRow row in (InternalDataCollectionBase) this.ChildTable.Rows)
                row.CheckForLoops(this);
              if (this.ChildTable.DataSet != null && string.Compare(this.ChildTable.TableName, this.ChildTable.DataSet.DataSetName, this.ChildTable.DataSet.Locale, CompareOptions.IgnoreCase) == 0)
                throw ExceptionBuilder.DatasetConflictingName(this.dataSet.DataSetName);
              this.ChildTable.fNestedInDataset = false;
            }
            else
            {
              foreach (DataRow row in (InternalDataCollectionBase) this.ChildTable.Rows)
                row.GetParentRow(this);
            }
          }
          ++this.ParentTable.ElementColumnCount;
        }
        else
          --this.ParentTable.ElementColumnCount;
        this.nested = value;
        this.ChildTable.CacheNestedParent();
        if (!value || !ADP.IsEmpty(this.ChildTable.Namespace) || this.ChildTable.NestedParentsCount <= 1 && (this.ChildTable.NestedParentsCount <= 0 || this.ChildTable.DataSet.Relations.Contains(this.RelationName)))
          return;
        string strA = (string) null;
        foreach (DataRelation parentRelation in (InternalDataCollectionBase) this.ChildTable.ParentRelations)
        {
          if (parentRelation.Nested)
          {
            if (strA == null)
              strA = parentRelation.ParentTable.Namespace;
            else if (string.Compare(strA, parentRelation.ParentTable.Namespace, StringComparison.Ordinal) != 0)
            {
              this.nested = false;
              throw ExceptionBuilder.InvalidParentNamespaceinNestedRelation(this.ChildTable.TableName);
            }
          }
        }
        if (this.CheckMultipleNested && this.ChildTable.tableNamespace != null && this.ChildTable.tableNamespace.Length == 0)
          throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
        this.ChildTable.tableNamespace = (string) null;
      }
    }

    public virtual UniqueConstraint ParentKeyConstraint
    {
      get
      {
        this.CheckStateForProperty();
        return this.parentKeyConstraint;
      }
    }

    internal void SetParentKeyConstraint(UniqueConstraint value)
    {
      Debug.Assert(this.parentKeyConstraint == null || value == null, "ParentKeyConstraint should not have been set already.");
      this.parentKeyConstraint = value;
    }

    public virtual ForeignKeyConstraint ChildKeyConstraint
    {
      get
      {
        this.CheckStateForProperty();
        return this.childKeyConstraint;
      }
    }

    public PropertyCollection ExtendedProperties
    {
      get
      {
        if (this.extendedProperties == null)
          this.extendedProperties = new PropertyCollection();
        return this.extendedProperties;
      }
    }

    internal bool CheckMultipleNested
    {
      get => this._checkMultipleNested;
      set => this._checkMultipleNested = value;
    }

    internal void SetChildKeyConstraint(ForeignKeyConstraint value)
    {
      Debug.Assert(this.childKeyConstraint == null || value == null, "ChildKeyConstraint should not have been set already.");
      this.childKeyConstraint = value;
    }

    internal void CheckState()
    {
      if (this.dataSet != null)
        return;
      this.parentKey.CheckState();
      this.childKey.CheckState();
      if (this.parentKey.Table.DataSet != this.childKey.Table.DataSet)
        throw ExceptionBuilder.RelationDataSetMismatch();
      if (this.childKey.ColumnsEqual(this.parentKey))
        throw ExceptionBuilder.KeyColumnsIdentical();
      for (int index = 0; index < this.parentKey.ColumnsReference.Length; ++index)
      {
        if (this.parentKey.ColumnsReference[index].DataType != this.childKey.ColumnsReference[index].DataType || this.parentKey.ColumnsReference[index].DataType == typeof (DateTime) && this.parentKey.ColumnsReference[index].DateTimeMode != this.childKey.ColumnsReference[index].DateTimeMode && (this.parentKey.ColumnsReference[index].DateTimeMode & this.childKey.ColumnsReference[index].DateTimeMode) != DataSetDateTime.Unspecified)
          throw ExceptionBuilder.ColumnsTypeMismatch();
      }
    }

    protected void CheckStateForProperty()
    {
      try
      {
        this.CheckState();
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableExceptionType(ex))
          throw ExceptionBuilder.BadObjectPropertyAccess(ex.Message);
        throw;
      }
    }

    private void Create(
      string relationName,
      DataColumn[] parentColumns,
      DataColumn[] childColumns,
      bool createConstraints)
    {
      this.parentKey = new DataKey(parentColumns, true);
      this.childKey = new DataKey(childColumns, true);
      if (parentColumns.Length != childColumns.Length)
        throw ExceptionBuilder.KeyLengthMismatch();
      for (int index = 0; index < parentColumns.Length; ++index)
      {
        if (parentColumns[index].Table.DataSet == null || childColumns[index].Table.DataSet == null)
          throw ExceptionBuilder.ParentOrChildColumnsDoNotHaveDataSet();
      }
      this.CheckState();
      this.relationName = relationName == null ? "" : relationName;
      this.createConstraints = createConstraints;
    }

    internal DataRelation Clone(DataSet destination)
    {
      DataTable table1 = destination.Tables[this.ParentTable.TableName, this.ParentTable.Namespace];
      DataTable table2 = destination.Tables[this.ChildTable.TableName, this.ChildTable.Namespace];
      int length = this.parentKey.ColumnsReference.Length;
      DataColumn[] parentColumns = new DataColumn[length];
      DataColumn[] childColumns = new DataColumn[length];
      for (int index = 0; index < length; ++index)
      {
        parentColumns[index] = table1.Columns[this.ParentKey.ColumnsReference[index].ColumnName];
        childColumns[index] = table2.Columns[this.ChildKey.ColumnsReference[index].ColumnName];
      }
      DataRelation dataRelation = new DataRelation(this.relationName, parentColumns, childColumns, false)
      {
        CheckMultipleNested = false,
        Nested = this.Nested
      };
      dataRelation.CheckMultipleNested = true;
      if (this.extendedProperties != null)
      {
        foreach (object key in (IEnumerable) this.extendedProperties.Keys)
          dataRelation.ExtendedProperties[key] = this.extendedProperties[key];
      }
      return dataRelation;
    }

    protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent)
    {
      if (this.onPropertyChangingDelegate == null)
        return;
      this.onPropertyChangingDelegate((object) this, pcevent);
    }

    protected internal void RaisePropertyChanging(string name) => this.OnPropertyChanging(new PropertyChangedEventArgs(name));

    public override string ToString() => this.RelationName;

    internal void ValidateMultipleNestedRelations()
    {
      if (!this.Nested || !this.CheckMultipleNested || this.ChildTable.NestedParentRelations.Length == 0)
        return;
      DataColumn[] childColumns = this.ChildColumns;
      if (childColumns.Length != 1 || !this.IsAutoGenerated(childColumns[0]))
        throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
      if (!XmlTreeGen.AutoGenerated(this))
        throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
      foreach (Constraint constraint in (InternalDataCollectionBase) this.ChildTable.Constraints)
      {
        if (constraint is ForeignKeyConstraint)
        {
          if (!XmlTreeGen.AutoGenerated((ForeignKeyConstraint) constraint, true))
            throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
        }
        else if (!XmlTreeGen.AutoGenerated((UniqueConstraint) constraint))
          throw ExceptionBuilder.TableCantBeNestedInTwoTables(this.ChildTable.TableName);
      }
    }

    private bool IsAutoGenerated(DataColumn col)
    {
      if (col.ColumnMapping != MappingType.Hidden || col.DataType != typeof (int))
        return false;
      string str1 = col.Table.TableName + "_Id";
      if (col.ColumnName == str1 || col.ColumnName == str1 + "_0")
        return true;
      string str2 = this.ParentColumnsReference[0].Table.TableName + "_Id";
      return col.ColumnName == str2 || col.ColumnName == str2 + "_0";
    }
  }
}
