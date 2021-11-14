// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataRow
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.Phone.Data
{
  public class DataRow
  {
    private readonly DataTable _table;
    private readonly DataColumnCollection _columns;
    internal int oldRecord = -1;
    internal int newRecord = -1;
    internal int tempRecord;
    internal int _rowID = -1;
    internal DataRowAction _action;
    internal bool inChangingEvent;
    internal bool inDeletingEvent;
    internal bool inCascade;
    private DataColumn _lastChangedColumn;
    private int _countColumnChange;
    private DataError error;
    private int _rbTreeNodeId;
    private static int _objectTypeCount;
    internal readonly int ObjectID = Interlocked.Increment(ref DataRow._objectTypeCount);

    protected internal DataRow(DataRowBuilder builder)
    {
      this.tempRecord = builder._record;
      this._table = builder._table;
      this._columns = this._table.Columns;
    }

    internal DataColumn LastChangedColumn
    {
      get => this._countColumnChange != 1 ? (DataColumn) null : this._lastChangedColumn;
      set
      {
        ++this._countColumnChange;
        this._lastChangedColumn = value;
      }
    }

    internal bool HasPropertyChanged => 0 < this._countColumnChange;

    internal int RBTreeNodeId
    {
      get => this._rbTreeNodeId;
      set => this._rbTreeNodeId = value;
    }

    public string RowError
    {
      get => this.error != null ? this.error.Text : string.Empty;
      set
      {
        if (this.error == null)
        {
          if (!ADP.IsEmpty(value))
            this.error = new DataError(value);
          this.RowErrorChanged();
        }
        else
        {
          if (!(this.error.Text != value))
            return;
          this.error.Text = value;
          this.RowErrorChanged();
        }
      }
    }

    private void RowErrorChanged()
    {
      if (this.oldRecord != -1)
        this._table.RecordChanged(this.oldRecord);
      if (this.newRecord == -1)
        return;
      this._table.RecordChanged(this.newRecord);
    }

    internal int rowID
    {
      get => this._rowID;
      set
      {
        this.ResetLastChangedColumn();
        this._rowID = value;
      }
    }

    public DataRowState RowState
    {
      get
      {
        if (this.oldRecord == this.newRecord)
        {
          if (this.oldRecord == -1)
            return DataRowState.Detached;
          if (0 < this._columns.ColumnsImplementingIChangeTrackingCount)
          {
            foreach (DataColumn column in this._columns.ColumnsImplementingIChangeTracking)
            {
              object obj = this[column];
              if (DBNull.Value != obj && ((IChangeTracking) obj).IsChanged)
                return DataRowState.Modified;
            }
          }
          return DataRowState.Unchanged;
        }
        if (this.oldRecord == -1)
          return DataRowState.Added;
        return this.newRecord == -1 ? DataRowState.Deleted : DataRowState.Modified;
      }
    }

    public DataTable Table => this._table;

    public object this[int columnIndex]
    {
      get
      {
        DataColumn column = this._columns[columnIndex];
        int defaultRecord = this.GetDefaultRecord();
        this._table.recordManager.VerifyRecord(defaultRecord, this);
        this.VerifyValueFromStorage(column, DataRowVersion.Default, column[defaultRecord]);
        return column[defaultRecord];
      }
      set => this[this._columns[columnIndex]] = value;
    }

    internal void CheckForLoops(DataRelation rel)
    {
      if (this._table.fInLoadDiffgram || this._table.DataSet != null && this._table.DataSet.fInLoadDiffgram)
        return;
      int count = this._table.Rows.Count;
      int num = 0;
      for (DataRow parentRow = this.GetParentRow(rel); parentRow != null; parentRow = parentRow.GetParentRow(rel))
      {
        if (parentRow == this || num > count)
          throw ExceptionBuilder.NestedCircular(this._table.TableName);
        ++num;
      }
    }

    internal int GetNestedParentCount()
    {
      int num = 0;
      foreach (DataRelation nestedParentRelation in this._table.NestedParentRelations)
      {
        if (nestedParentRelation != null)
        {
          if (nestedParentRelation.ParentTable == this._table)
            this.CheckForLoops(nestedParentRelation);
          if (this.GetParentRow(nestedParentRelation) != null)
            ++num;
        }
      }
      return num;
    }

    public object this[string columnName]
    {
      get
      {
        DataColumn dataColumn = this.GetDataColumn(columnName);
        int defaultRecord = this.GetDefaultRecord();
        this._table.recordManager.VerifyRecord(defaultRecord, this);
        this.VerifyValueFromStorage(dataColumn, DataRowVersion.Default, dataColumn[defaultRecord]);
        return dataColumn[defaultRecord];
      }
      set => this[this.GetDataColumn(columnName)] = value;
    }

    public object this[DataColumn column]
    {
      get
      {
        this.CheckColumn(column);
        int defaultRecord = this.GetDefaultRecord();
        this._table.recordManager.VerifyRecord(defaultRecord, this);
        this.VerifyValueFromStorage(column, DataRowVersion.Default, column[defaultRecord]);
        return column[defaultRecord];
      }
      set
      {
        this.CheckColumn(column);
        if (this.inChangingEvent)
          throw ExceptionBuilder.EditInRowChanging();
        if (-1 != this.rowID && column.ReadOnly)
          throw ExceptionBuilder.ReadOnly(column.ColumnName);
        DataColumnChangeEventArgs e = (DataColumnChangeEventArgs) null;
        if (this._table.NeedColumnChangeEvents)
        {
          e = new DataColumnChangeEventArgs(this, column, value);
          this._table.OnColumnChanging(e);
        }
        if (column.Table != this._table)
          throw ExceptionBuilder.ColumnNotInTheTable(column.ColumnName, this._table.TableName);
        if (-1 != this.rowID && column.ReadOnly)
          throw ExceptionBuilder.ReadOnly(column.ColumnName);
        object obj = e != null ? e.ProposedValue : value;
        if (obj == null)
        {
          if (column.IsValueType)
            throw ExceptionBuilder.CannotSetToNull(column);
          obj = (object) DBNull.Value;
        }
        bool flag = this.BeginEditInternal();
        try
        {
          int proposedRecordNo = this.GetProposedRecordNo();
          this._table.recordManager.VerifyRecord(proposedRecordNo, this);
          column[proposedRecordNo] = obj;
        }
        catch (Exception ex)
        {
          if (ADP.IsCatchableOrSecurityExceptionType(ex) && flag)
          {
            Debug.Assert(!this.inChangingEvent, "how are we in a changing event to cancel?");
            Debug.Assert(-1 != this.tempRecord, "how no propsed record to cancel?");
            this.CancelEdit();
          }
          throw;
        }
        this.LastChangedColumn = column;
        if (e != null)
          this._table.OnColumnChanged(e);
        if (!flag)
          return;
        Debug.Assert(!this.inChangingEvent, "how are we in a changing event to end?");
        this.EndEdit();
      }
    }

    public object this[int columnIndex, DataRowVersion version]
    {
      get
      {
        DataColumn column = this._columns[columnIndex];
        int recordFromVersion = this.GetRecordFromVersion(version);
        this._table.recordManager.VerifyRecord(recordFromVersion, this);
        this.VerifyValueFromStorage(column, version, column[recordFromVersion]);
        return column[recordFromVersion];
      }
    }

    public object this[string columnName, DataRowVersion version]
    {
      get
      {
        DataColumn dataColumn = this.GetDataColumn(columnName);
        int recordFromVersion = this.GetRecordFromVersion(version);
        this._table.recordManager.VerifyRecord(recordFromVersion, this);
        this.VerifyValueFromStorage(dataColumn, version, dataColumn[recordFromVersion]);
        return dataColumn[recordFromVersion];
      }
    }

    public object this[DataColumn column, DataRowVersion version]
    {
      get
      {
        this.CheckColumn(column);
        int recordFromVersion = this.GetRecordFromVersion(version);
        this._table.recordManager.VerifyRecord(recordFromVersion, this);
        this.VerifyValueFromStorage(column, version, column[recordFromVersion]);
        return column[recordFromVersion];
      }
    }

    public object[] ItemArray
    {
      get
      {
        int defaultRecord = this.GetDefaultRecord();
        this._table.recordManager.VerifyRecord(defaultRecord, this);
        object[] objArray = new object[this._columns.Count];
        for (int index = 0; index < objArray.Length; ++index)
        {
          DataColumn column = this._columns[index];
          this.VerifyValueFromStorage(column, DataRowVersion.Default, column[defaultRecord]);
          objArray[index] = column[defaultRecord];
        }
        return objArray;
      }
      set
      {
        if (value == null)
          throw ExceptionBuilder.ArgumentNull(nameof (ItemArray));
        if (this._columns.Count < value.Length)
          throw ExceptionBuilder.ValueArrayLength();
        DataColumnChangeEventArgs e = (DataColumnChangeEventArgs) null;
        if (this._table.NeedColumnChangeEvents)
          e = new DataColumnChangeEventArgs(this);
        bool flag = this.BeginEditInternal();
        for (int index = 0; index < value.Length; ++index)
        {
          if (value[index] != null)
          {
            DataColumn column = this._columns[index];
            if (-1 != this.rowID && column.ReadOnly)
              throw ExceptionBuilder.ReadOnly(column.ColumnName);
            if (e != null)
            {
              e.InitializeColumnChangeEvent(column, value[index]);
              this._table.OnColumnChanging(e);
            }
            if (column.Table != this._table)
              throw ExceptionBuilder.ColumnNotInTheTable(column.ColumnName, this._table.TableName);
            if (-1 != this.rowID && column.ReadOnly)
              throw ExceptionBuilder.ReadOnly(column.ColumnName);
            if (this.tempRecord == -1)
              this.BeginEditInternal();
            object obj = e != null ? e.ProposedValue : value[index];
            if (obj == null)
            {
              if (column.IsValueType)
                throw ExceptionBuilder.CannotSetToNull(column);
              obj = (object) DBNull.Value;
            }
            try
            {
              int proposedRecordNo = this.GetProposedRecordNo();
              this._table.recordManager.VerifyRecord(proposedRecordNo, this);
              column[proposedRecordNo] = obj;
            }
            catch (Exception ex)
            {
              if (ADP.IsCatchableOrSecurityExceptionType(ex) && flag)
              {
                Debug.Assert(!this.inChangingEvent, "how are we in a changing event to cancel?");
                Debug.Assert(-1 != this.tempRecord, "how no propsed record to cancel?");
                this.CancelEdit();
              }
              throw;
            }
            this.LastChangedColumn = column;
            if (e != null)
              this._table.OnColumnChanged(e);
          }
        }
        Debug.Assert(!this.inChangingEvent, "how are we in a changing event to end?");
        this.EndEdit();
      }
    }

    public void AcceptChanges()
    {
      this.EndEdit();
      if (this.RowState != DataRowState.Detached && this.RowState != DataRowState.Deleted && this._columns.ColumnsImplementingIChangeTrackingCount > 0)
      {
        foreach (DataColumn column in this._columns.ColumnsImplementingIChangeTracking)
        {
          object obj = this[column];
          if (DBNull.Value != obj)
          {
            IChangeTracking changeTracking = (IChangeTracking) obj;
            if (changeTracking.IsChanged)
              changeTracking.AcceptChanges();
          }
        }
      }
      this._table.CommitRow(this);
    }

    public void BeginEdit() => this.BeginEditInternal();

    private bool BeginEditInternal()
    {
      if (this.inChangingEvent)
        throw ExceptionBuilder.BeginEditInRowChanging();
      if (this.tempRecord != -1)
      {
        if (this.tempRecord < this._table.recordManager.LastFreeRecord)
          return false;
        this.tempRecord = -1;
        this._table.recordManager.VerifyRecord(this.tempRecord, this);
      }
      if (this.oldRecord != -1 && this.newRecord == -1)
        throw ExceptionBuilder.DeletedRowInaccessible();
      this.ResetLastChangedColumn();
      this.tempRecord = this._table.NewRecord(this.newRecord);
      Debug.Assert(-1 != this.tempRecord, "missing temp record");
      Debug.Assert(this._countColumnChange == 0, "unexpected column change count");
      Debug.Assert(this._lastChangedColumn == null, "unexpected last column change");
      return true;
    }

    public void CancelEdit()
    {
      if (this.inChangingEvent)
        throw ExceptionBuilder.CancelEditInRowChanging();
      this._table.FreeRecord(ref this.tempRecord);
      Debug.Assert(-1 == this.tempRecord, "unexpected temp record");
      this.ResetLastChangedColumn();
    }

    private void CheckColumn(DataColumn column)
    {
      if (column == null)
        throw ExceptionBuilder.ArgumentNull(nameof (column));
      if (column.Table != this._table)
        throw ExceptionBuilder.ColumnNotInTheTable(column.ColumnName, this._table.TableName);
    }

    internal void CheckInTable()
    {
      if (this.rowID == -1)
        throw ExceptionBuilder.RowNotInTheTable();
    }

    public void Delete()
    {
      if (this.inDeletingEvent)
        throw ExceptionBuilder.DeleteInRowDeleting();
      if (this.newRecord == -1)
        return;
      this._table.DeleteRow(this);
    }

    public void EndEdit()
    {
      if (this.inChangingEvent)
        throw ExceptionBuilder.EndEditInRowChanging();
      if (this.newRecord == -1)
        return;
      if (this.tempRecord == -1)
        return;
      try
      {
        this.SetNewRecord(this.tempRecord);
      }
      finally
      {
        this.ResetLastChangedColumn();
      }
    }

    public void SetColumnError(int columnIndex, string error) => this.SetColumnError(this._columns[columnIndex] ?? throw ExceptionBuilder.ColumnOutOfRange(columnIndex), error);

    public void SetColumnError(string columnName, string error) => this.SetColumnError(this.GetDataColumn(columnName), error);

    public void SetColumnError(DataColumn column, string error)
    {
      this.CheckColumn(column);
      if (this.error == null)
        this.error = new DataError();
      if (!(this.GetColumnError(column) != error))
        return;
      this.error.SetColumnError(column, error);
      this.RowErrorChanged();
    }

    public string GetColumnError(int columnIndex) => this.GetColumnError(this._columns[columnIndex]);

    public string GetColumnError(string columnName) => this.GetColumnError(this.GetDataColumn(columnName));

    public string GetColumnError(DataColumn column)
    {
      this.CheckColumn(column);
      if (this.error == null)
        this.error = new DataError();
      return this.error.GetColumnError(column);
    }

    public void ClearErrors()
    {
      if (this.error == null)
        return;
      this.error.Clear();
      this.RowErrorChanged();
    }

    internal void ClearError(DataColumn column)
    {
      if (this.error == null)
        return;
      this.error.Clear(column);
      this.RowErrorChanged();
    }

    public bool HasErrors => this.error != null && this.error.HasErrors;

    public DataColumn[] GetColumnsInError() => this.error == null ? DataTable.zeroColumns : this.error.GetColumnsInError();

    public DataRow[] GetChildRows(string relationName) => this.GetChildRows(this._table.ChildRelations[relationName], DataRowVersion.Default);

    public DataRow[] GetChildRows(string relationName, DataRowVersion version) => this.GetChildRows(this._table.ChildRelations[relationName], version);

    public DataRow[] GetChildRows(DataRelation relation) => this.GetChildRows(relation, DataRowVersion.Default);

    public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version)
    {
      if (relation == null)
        return this._table.NewRowArray(0);
      if (relation.DataSet != this._table.DataSet)
        throw ExceptionBuilder.RowNotInTheDataSet();
      if (relation.ParentKey.Table != this._table)
        throw ExceptionBuilder.RelationForeignTable(relation.ParentTable.TableName, this._table.TableName);
      return DataRelation.GetChildRows(relation.ParentKey, relation.ChildKey, this, version);
    }

    internal DataColumn GetDataColumn(string columnName) => this._columns[columnName] ?? throw ExceptionBuilder.ColumnNotInTheTable(columnName, this._table.TableName);

    public DataRow GetParentRow(string relationName) => this.GetParentRow(this._table.ParentRelations[relationName], DataRowVersion.Default);

    public DataRow GetParentRow(string relationName, DataRowVersion version) => this.GetParentRow(this._table.ParentRelations[relationName], version);

    public DataRow GetParentRow(DataRelation relation) => this.GetParentRow(relation, DataRowVersion.Default);

    public DataRow GetParentRow(DataRelation relation, DataRowVersion version)
    {
      if (relation == null)
        return (DataRow) null;
      if (relation.DataSet != this._table.DataSet)
        throw ExceptionBuilder.RelationForeignRow();
      if (relation.ChildKey.Table != this._table)
        throw ExceptionBuilder.GetParentRowTableMismatch(relation.ChildTable.TableName, this._table.TableName);
      return DataRelation.GetParentRow(relation.ParentKey, relation.ChildKey, this, version);
    }

    internal DataRow GetNestedParentRow(DataRowVersion version)
    {
      foreach (DataRelation nestedParentRelation in this._table.NestedParentRelations)
      {
        if (nestedParentRelation != null)
        {
          if (nestedParentRelation.ParentTable == this._table)
            this.CheckForLoops(nestedParentRelation);
          DataRow parentRow = this.GetParentRow(nestedParentRelation, version);
          if (parentRow != null)
            return parentRow;
        }
      }
      return (DataRow) null;
    }

    public DataRow[] GetParentRows(string relationName) => this.GetParentRows(this._table.ParentRelations[relationName], DataRowVersion.Default);

    public DataRow[] GetParentRows(string relationName, DataRowVersion version) => this.GetParentRows(this._table.ParentRelations[relationName], version);

    public DataRow[] GetParentRows(DataRelation relation) => this.GetParentRows(relation, DataRowVersion.Default);

    public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version)
    {
      if (relation == null)
        return this._table.NewRowArray(0);
      if (relation.DataSet != this._table.DataSet)
        throw ExceptionBuilder.RowNotInTheDataSet();
      if (relation.ChildKey.Table != this._table)
        throw ExceptionBuilder.GetParentRowTableMismatch(relation.ChildTable.TableName, this._table.TableName);
      return DataRelation.GetParentRows(relation.ParentKey, relation.ChildKey, this, version);
    }

    internal object[] GetColumnValues(DataColumn[] columns) => this.GetColumnValues(columns, DataRowVersion.Default);

    internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) => this.GetKeyValues(new DataKey(columns, false), version);

    internal object[] GetKeyValues(DataKey key)
    {
      int defaultRecord = this.GetDefaultRecord();
      return key.GetKeyValues(defaultRecord);
    }

    internal object[] GetKeyValues(DataKey key, DataRowVersion version)
    {
      int recordFromVersion = this.GetRecordFromVersion(version);
      return key.GetKeyValues(recordFromVersion);
    }

    internal int GetCurrentRecordNo() => this.newRecord != -1 ? this.newRecord : throw ExceptionBuilder.NoCurrentData();

    internal int GetDefaultRecord()
    {
      if (this.tempRecord != -1)
        return this.tempRecord;
      if (this.newRecord != -1)
        return this.newRecord;
      if (this.oldRecord == -1)
        throw ExceptionBuilder.RowRemovedFromTheTable();
      throw ExceptionBuilder.DeletedRowInaccessible();
    }

    internal int GetOriginalRecordNo() => this.oldRecord != -1 ? this.oldRecord : throw ExceptionBuilder.NoOriginalData();

    private int GetProposedRecordNo() => this.tempRecord != -1 ? this.tempRecord : throw ExceptionBuilder.NoProposedData();

    internal int GetRecordFromVersion(DataRowVersion version)
    {
      switch (version)
      {
        case DataRowVersion.Original:
          return this.GetOriginalRecordNo();
        case DataRowVersion.Current:
          return this.GetCurrentRecordNo();
        case DataRowVersion.Proposed:
          return this.GetProposedRecordNo();
        case DataRowVersion.Default:
          return this.GetDefaultRecord();
        default:
          throw ExceptionBuilder.InvalidRowVersion();
      }
    }

    internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState)
    {
      if (this.oldRecord == this.newRecord)
      {
        if (this.oldRecord == -1)
          return DataRowVersion.Default;
        Debug.Assert((uint) (DataViewRowState.Unchanged & viewState) > 0U, "not DataViewRowState.Unchanged");
        return DataRowVersion.Default;
      }
      if (this.oldRecord == -1)
      {
        Debug.Assert((uint) (DataViewRowState.Added & viewState) > 0U, "not DataViewRowState.Added");
        return DataRowVersion.Default;
      }
      if (this.newRecord == -1)
      {
        Debug.Assert((uint) (DataViewRowState.Deleted & viewState) > 0U, "not DataViewRowState.Deleted");
        return DataRowVersion.Original;
      }
      if ((DataViewRowState.ModifiedCurrent & viewState) != DataViewRowState.None)
        return DataRowVersion.Default;
      Debug.Assert((uint) (DataViewRowState.ModifiedOriginal & viewState) > 0U, "not DataViewRowState.ModifiedOriginal");
      return DataRowVersion.Original;
    }

    internal DataViewRowState GetRecordState(int record)
    {
      if (record == -1)
        return DataViewRowState.None;
      if (record == this.oldRecord && record == this.newRecord)
        return DataViewRowState.Unchanged;
      if (record == this.oldRecord)
        return this.newRecord == -1 ? DataViewRowState.Deleted : DataViewRowState.ModifiedOriginal;
      if (record != this.newRecord)
        return DataViewRowState.None;
      return this.oldRecord == -1 ? DataViewRowState.Added : DataViewRowState.ModifiedCurrent;
    }

    internal bool HasKeyChanged(DataKey key) => this.HasKeyChanged(key, DataRowVersion.Current, DataRowVersion.Proposed);

    internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) => !this.HasVersion(version1) || !this.HasVersion(version2) || !key.RecordsEqual(this.GetRecordFromVersion(version1), this.GetRecordFromVersion(version2));

    public bool HasVersion(DataRowVersion version)
    {
      switch (version)
      {
        case DataRowVersion.Original:
          return this.oldRecord != -1;
        case DataRowVersion.Current:
          return this.newRecord != -1;
        case DataRowVersion.Proposed:
          return this.tempRecord != -1;
        case DataRowVersion.Default:
          return this.tempRecord != -1 || this.newRecord != -1;
        default:
          throw ExceptionBuilder.InvalidRowVersion();
      }
    }

    internal bool HasChanges()
    {
      if (!this.HasVersion(DataRowVersion.Original) || !this.HasVersion(DataRowVersion.Current))
        return true;
      foreach (DataColumn column in (InternalDataCollectionBase) this.Table.Columns)
      {
        if (column.Compare(this.oldRecord, this.newRecord) != 0)
          return true;
      }
      return false;
    }

    internal bool HaveValuesChanged(DataColumn[] columns) => this.HaveValuesChanged(columns, DataRowVersion.Current, DataRowVersion.Proposed);

    internal bool HaveValuesChanged(
      DataColumn[] columns,
      DataRowVersion version1,
      DataRowVersion version2)
    {
      for (int index = 0; index < columns.Length; ++index)
        this.CheckColumn(columns[index]);
      return this.HasKeyChanged(new DataKey(columns, false), version1, version2);
    }

    public bool IsNull(int columnIndex) => this._columns[columnIndex].IsNull(this.GetDefaultRecord());

    public bool IsNull(string columnName) => this.GetDataColumn(columnName).IsNull(this.GetDefaultRecord());

    public bool IsNull(DataColumn column)
    {
      this.CheckColumn(column);
      int defaultRecord = this.GetDefaultRecord();
      return column.IsNull(defaultRecord);
    }

    public bool IsNull(DataColumn column, DataRowVersion version)
    {
      this.CheckColumn(column);
      int recordFromVersion = this.GetRecordFromVersion(version);
      return column.IsNull(recordFromVersion);
    }

    public void RejectChanges()
    {
      if (this.RowState != DataRowState.Detached)
      {
        if (this._columns.ColumnsImplementingIChangeTrackingCount != this._columns.ColumnsImplementingIRevertibleChangeTrackingCount)
        {
          foreach (DataColumn column in this._columns.ColumnsImplementingIChangeTracking)
          {
            if (!column.ImplementsIRevertibleChangeTracking)
            {
              object obj = this.RowState == DataRowState.Deleted ? this[column, DataRowVersion.Original] : this[column];
              if (DBNull.Value != obj && ((IChangeTracking) obj).IsChanged)
                throw ExceptionBuilder.UDTImplementsIChangeTrackingButnotIRevertible(column.DataType.AssemblyQualifiedName);
            }
          }
        }
        foreach (DataColumn column in this._columns.ColumnsImplementingIChangeTracking)
        {
          object obj = this.RowState == DataRowState.Deleted ? this[column, DataRowVersion.Original] : this[column];
          if (DBNull.Value != obj && ((IChangeTracking) obj).IsChanged)
            ((IRevertibleChangeTracking) obj).RejectChanges();
        }
      }
      this._table.RollbackRow(this);
    }

    internal void ResetLastChangedColumn()
    {
      this._lastChangedColumn = (DataColumn) null;
      this._countColumnChange = 0;
    }

    internal void SetKeyValues(DataKey key, object[] keyValues)
    {
      bool flag1 = true;
      bool flag2 = this.tempRecord == -1;
      for (int index = 0; index < keyValues.Length; ++index)
      {
        if (!this[key.ColumnsReference[index]].Equals(keyValues[index]))
        {
          if (flag2 & flag1)
          {
            flag1 = false;
            this.BeginEditInternal();
          }
          this[key.ColumnsReference[index]] = keyValues[index];
        }
      }
      if (flag1)
        return;
      this.EndEdit();
    }

    internal void SetNewRecord(int record) => this._table.SetNewRecord(this, record, DataRowAction.Change, false, true);

    protected void SetNull(DataColumn column) => this[column] = (object) DBNull.Value;

    internal void SetNestedParentRow(DataRow parentRow, bool setNonNested)
    {
      if (parentRow == null)
      {
        this.SetParentRowToDBNull();
      }
      else
      {
        foreach (DataRelation parentRelation in (InternalDataCollectionBase) this._table.ParentRelations)
        {
          if (parentRelation.Nested | setNonNested && parentRelation.ParentKey.Table == parentRow._table)
          {
            object[] keyValues = parentRow.GetKeyValues(parentRelation.ParentKey);
            this.SetKeyValues(parentRelation.ChildKey, keyValues);
            if (parentRelation.Nested)
            {
              if (parentRow._table == this._table)
                this.CheckForLoops(parentRelation);
              else
                this.GetParentRow(parentRelation);
            }
          }
        }
      }
    }

    public void SetParentRow(DataRow parentRow) => this.SetNestedParentRow(parentRow, true);

    public void SetParentRow(DataRow parentRow, DataRelation relation)
    {
      if (relation == null)
        this.SetParentRow(parentRow);
      else if (parentRow == null)
      {
        this.SetParentRowToDBNull(relation);
      }
      else
      {
        if (this._table.DataSet != parentRow._table.DataSet)
          throw ExceptionBuilder.ParentRowNotInTheDataSet();
        if (relation.ChildKey.Table != this._table)
          throw ExceptionBuilder.SetParentRowTableMismatch(relation.ChildKey.Table.TableName, this._table.TableName);
        if (relation.ParentKey.Table != parentRow._table)
          throw ExceptionBuilder.SetParentRowTableMismatch(relation.ParentKey.Table.TableName, parentRow._table.TableName);
        object[] keyValues = parentRow.GetKeyValues(relation.ParentKey);
        this.SetKeyValues(relation.ChildKey, keyValues);
      }
    }

    internal void SetParentRowToDBNull()
    {
      foreach (DataRelation parentRelation in (InternalDataCollectionBase) this._table.ParentRelations)
        this.SetParentRowToDBNull(parentRelation);
    }

    internal void SetParentRowToDBNull(DataRelation relation)
    {
      Debug.Assert(relation != null, "The relation should not be null here.");
      if (relation.ChildKey.Table != this._table)
        throw ExceptionBuilder.SetParentRowTableMismatch(relation.ChildKey.Table.TableName, this._table.TableName);
      object[] keyValues = new object[1]
      {
        (object) DBNull.Value
      };
      this.SetKeyValues(relation.ChildKey, keyValues);
    }

    public void SetAdded()
    {
      if (this.RowState != DataRowState.Unchanged)
        throw ExceptionBuilder.SetAddedAndModifiedCalledOnnonUnchanged();
      this._table.SetOldRecord(this, -1);
    }

    public void SetModified()
    {
      if (this.RowState != DataRowState.Unchanged)
        throw ExceptionBuilder.SetAddedAndModifiedCalledOnnonUnchanged();
      this.tempRecord = this._table.NewRecord(this.newRecord);
      if (this.tempRecord == -1)
        return;
      this.SetNewRecord(this.tempRecord);
    }

    [Conditional("DEBUG")]
    private void VerifyValueFromStorage(
      DataColumn column,
      DataRowVersion version,
      object valueFromStorage)
    {
      if (column.DataExpression == null || this.inChangingEvent || (this.tempRecord != -1 || version != DataRowVersion.Original) || this.oldRecord != this.newRecord)
        return;
      version = DataRowVersion.Current;
    }
  }
}
