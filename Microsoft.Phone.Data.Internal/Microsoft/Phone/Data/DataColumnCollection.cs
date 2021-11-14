// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataColumnCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  public sealed class DataColumnCollection : InternalDataCollectionBase
  {
    private readonly DataTable table;
    private readonly ArrayList _list = new ArrayList();
    private int defaultNameIndex = 1;
    private DataColumn[] delayedAddRangeColumns;
    private readonly Hashtable columnFromName;
    private CollectionChangeEventHandler onCollectionChangedDelegate;
    private CollectionChangeEventHandler onColumnPropertyChangedDelegate;
    private bool fInClear;
    private DataColumn[] columnsImplementingIChangeTracking = DataTable.zeroColumns;
    private int nColumnsImplementingIChangeTracking;
    private int nColumnsImplementingIRevertibleChangeTracking;

    internal DataColumnCollection(DataTable table)
    {
      this.table = table;
      this.columnFromName = new Hashtable();
    }

    protected override ArrayList List => this._list;

    internal DataColumn[] ColumnsImplementingIChangeTracking => this.columnsImplementingIChangeTracking;

    internal int ColumnsImplementingIChangeTrackingCount => this.nColumnsImplementingIChangeTracking;

    internal int ColumnsImplementingIRevertibleChangeTrackingCount => this.nColumnsImplementingIRevertibleChangeTracking;

    public DataColumn this[int index]
    {
      get
      {
        try
        {
          return (DataColumn) this._list[index];
        }
        catch (ArgumentOutOfRangeException ex)
        {
          throw ExceptionBuilder.ColumnOutOfRange(index);
        }
      }
    }

    public DataColumn this[string name]
    {
      get
      {
        if (name == null)
          throw ExceptionBuilder.ArgumentNull(nameof (name));
        if (!(this.columnFromName[(object) name] is DataColumn dataColumn))
        {
          int index = this.IndexOfCaseInsensitive(name);
          if (0 <= index)
            dataColumn = (DataColumn) this._list[index];
          else if (-2 == index)
            throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
        }
        return dataColumn;
      }
    }

    internal DataColumn this[string name, string ns] => this.columnFromName[(object) name] is DataColumn dataColumn && dataColumn.Namespace == ns ? dataColumn : (DataColumn) null;

    public void Add(DataColumn column) => this.AddAt(-1, column);

    internal void AddAt(int index, DataColumn column)
    {
      if (column != null && column.ColumnMapping == MappingType.SimpleContent)
      {
        if (this.table.XmlText != null && this.table.XmlText != column)
          throw ExceptionBuilder.CannotAddColumn3();
        if (this.table.ElementColumnCount > 0)
          throw ExceptionBuilder.CannotAddColumn4(column.ColumnName);
        this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, (object) column));
        this.BaseAdd(column);
        if (index != -1)
          this.ArrayAdd(index, column);
        else
          this.ArrayAdd(column);
        this.table.XmlText = column;
      }
      else
      {
        this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, (object) column));
        this.BaseAdd(column);
        if (index != -1)
          this.ArrayAdd(index, column);
        else
          this.ArrayAdd(column);
        if (column.ColumnMapping == MappingType.Element)
          ++this.table.ElementColumnCount;
      }
      if (!this.table.fInitInProgress && column != null && column.Computed)
      {
        DataColumn dataColumn = column;
        dataColumn.Expression = dataColumn.Expression;
      }
      this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, (object) column));
    }

    public void AddRange(DataColumn[] columns)
    {
      if (this.table.fInitInProgress)
      {
        this.delayedAddRangeColumns = columns;
      }
      else
      {
        if (columns == null)
          return;
        foreach (DataColumn column in columns)
        {
          if (column != null)
            this.Add(column);
        }
      }
    }

    public DataColumn Add(string columnName, Type type, string expression)
    {
      DataColumn column = new DataColumn(columnName, type, expression);
      this.Add(column);
      return column;
    }

    public DataColumn Add(string columnName, Type type)
    {
      DataColumn column = new DataColumn(columnName, type);
      this.Add(column);
      return column;
    }

    public DataColumn Add(string columnName)
    {
      DataColumn column = new DataColumn(columnName);
      this.Add(column);
      return column;
    }

    public DataColumn Add()
    {
      DataColumn column = new DataColumn();
      this.Add(column);
      return column;
    }

    public event CollectionChangeEventHandler CollectionChanged
    {
      add => this.onCollectionChangedDelegate += value;
      remove => this.onCollectionChangedDelegate -= value;
    }

    internal event CollectionChangeEventHandler ColumnPropertyChanged
    {
      add => this.onColumnPropertyChangedDelegate += value;
      remove => this.onColumnPropertyChangedDelegate -= value;
    }

    private void ArrayAdd(DataColumn column)
    {
      this._list.Add((object) column);
      column.SetOrdinalInternal(this._list.Count - 1);
      this.CheckIChangeTracking(column);
    }

    private void ArrayAdd(int index, DataColumn column)
    {
      this._list.Insert(index, (object) column);
      this.CheckIChangeTracking(column);
    }

    private void ArrayRemove(DataColumn column)
    {
      column.SetOrdinalInternal(-1);
      this._list.Remove((object) column);
      int count = this._list.Count;
      for (int index = 0; index < count; ++index)
        ((DataColumn) this._list[index]).SetOrdinalInternal(index);
      if (!column.ImplementsIChangeTracking)
        return;
      this.RemoveColumnsImplementingIChangeTrackingList(column);
    }

    internal string AssignName()
    {
      string str = this.MakeName(this.defaultNameIndex++);
      while (this.columnFromName[(object) str] != null)
        str = this.MakeName(this.defaultNameIndex++);
      return str;
    }

    private void BaseAdd(DataColumn column)
    {
      if (column == null)
        throw ExceptionBuilder.ArgumentNull(nameof (column));
      if (column.table == this.table)
        throw ExceptionBuilder.CannotAddColumn1(column.ColumnName);
      if (column.table != null)
        throw ExceptionBuilder.CannotAddColumn2(column.ColumnName);
      if (column.ColumnName.Length == 0)
        column.ColumnName = this.AssignName();
      this.RegisterColumnName(column.ColumnName, column, (DataTable) null);
      try
      {
        column.SetTable(this.table);
        if (!this.table.fInitInProgress && column.Computed && column.DataExpression.DependsOn(column))
          throw ExceptionBuilder.ExpressionCircular();
        if (0 < this.table.RecordCapacity)
          column.SetCapacity(this.table.RecordCapacity);
        for (int record = 0; record < this.table.RecordCapacity; ++record)
          column.InitializeRecord(record);
        if (this.table.DataSet == null)
          return;
        column.OnSetDataSet();
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableOrSecurityExceptionType(ex))
          this.UnregisterName(column.ColumnName);
        throw;
      }
    }

    private void BaseGroupSwitch(
      DataColumn[] oldArray,
      int oldLength,
      DataColumn[] newArray,
      int newLength)
    {
      int num = 0;
      for (int index1 = 0; index1 < oldLength; ++index1)
      {
        bool flag = false;
        for (int index2 = num; index2 < newLength; ++index2)
        {
          if (oldArray[index1] == newArray[index2])
          {
            if (num == index2)
              ++num;
            flag = true;
            break;
          }
        }
        if (!flag && oldArray[index1].Table == this.table)
        {
          this.BaseRemove(oldArray[index1]);
          this._list.Remove((object) oldArray[index1]);
          oldArray[index1].SetOrdinalInternal(-1);
        }
      }
      for (int ordinal = 0; ordinal < newLength; ++ordinal)
      {
        if (newArray[ordinal].Table != this.table)
        {
          this.BaseAdd(newArray[ordinal]);
          this._list.Add((object) newArray[ordinal]);
        }
        newArray[ordinal].SetOrdinalInternal(ordinal);
      }
    }

    private void BaseRemove(DataColumn column)
    {
      if (!this.CanRemove(column, true))
        return;
      if (column.errors > 0)
      {
        for (int index = 0; index < this.table.Rows.Count; ++index)
          this.table.Rows[index].ClearError(column);
      }
      this.UnregisterName(column.ColumnName);
      column.SetTable((DataTable) null);
    }

    public bool CanRemove(DataColumn column) => this.CanRemove(column, false);

    internal bool CanRemove(DataColumn column, bool fThrowException)
    {
      if (column == null)
      {
        if (!fThrowException)
          return false;
        throw ExceptionBuilder.ArgumentNull(nameof (column));
      }
      if (column.table != this.table)
      {
        if (!fThrowException)
          return false;
        throw ExceptionBuilder.CannotRemoveColumn();
      }
      DataKey dataKey;
      if (this.table.primaryKey != null)
      {
        dataKey = this.table.primaryKey.Key;
        if (dataKey.ContainsColumn(column))
        {
          if (!fThrowException)
            return false;
          throw ExceptionBuilder.CannotRemovePrimaryKey();
        }
      }
      for (int index = 0; index < this.table.ParentRelations.Count; ++index)
      {
        dataKey = this.table.ParentRelations[index].ChildKey;
        if (dataKey.ContainsColumn(column))
        {
          if (!fThrowException)
            return false;
          throw ExceptionBuilder.CannotRemoveChildKey(this.table.ParentRelations[index].RelationName);
        }
      }
      for (int index = 0; index < this.table.ChildRelations.Count; ++index)
      {
        dataKey = this.table.ChildRelations[index].ParentKey;
        if (dataKey.ContainsColumn(column))
        {
          if (!fThrowException)
            return false;
          throw ExceptionBuilder.CannotRemoveChildKey(this.table.ChildRelations[index].RelationName);
        }
      }
      for (int index = 0; index < this.table.Constraints.Count; ++index)
      {
        if (this.table.Constraints[index].ContainsColumn(column))
        {
          if (!fThrowException)
            return false;
          throw ExceptionBuilder.CannotRemoveConstraint(this.table.Constraints[index].ConstraintName, this.table.Constraints[index].Table.TableName);
        }
      }
      if (this.table.DataSet != null)
      {
        ParentForeignKeyConstraintEnumerator constraintEnumerator = new ParentForeignKeyConstraintEnumerator(this.table.DataSet, this.table);
        while (constraintEnumerator.GetNext())
        {
          Constraint constraint = constraintEnumerator.GetConstraint();
          dataKey = ((ForeignKeyConstraint) constraint).ParentKey;
          if (dataKey.ContainsColumn(column))
          {
            if (!fThrowException)
              return false;
            throw ExceptionBuilder.CannotRemoveConstraint(constraint.ConstraintName, constraint.Table.TableName);
          }
        }
      }
      if (column.dependentColumns != null)
      {
        for (int index = 0; index < column.dependentColumns.Count; ++index)
        {
          DataColumn dependentColumn = column.dependentColumns[index];
          if ((!this.fInClear || dependentColumn.Table != this.table && dependentColumn.Table != null) && dependentColumn.Table != null)
          {
            Debug.Assert(dependentColumn.Computed, "invalid (non an expression) column in the expression dependent columns");
            DataExpression dataExpression = dependentColumn.DataExpression;
            if (dataExpression != null && dataExpression.DependsOn(column))
            {
              if (!fThrowException)
                return false;
              throw ExceptionBuilder.CannotRemoveExpression(dependentColumn.ColumnName, dependentColumn.Expression);
            }
          }
        }
      }
      foreach (Index liveIndex in this.table.LiveIndexes)
      {
        if (liveIndex != column.sortIndex)
        {
          foreach (IndexField indexField in liveIndex.IndexFields)
          {
            if (indexField.Column == column)
            {
              if (fThrowException)
                throw ExceptionBuilder.CannotRemoveExpression("DataView", column.ColumnName);
              return false;
            }
          }
        }
      }
      return true;
    }

    private void CheckIChangeTracking(DataColumn column)
    {
      if (column.ImplementsIRevertibleChangeTracking)
      {
        ++this.nColumnsImplementingIRevertibleChangeTracking;
        ++this.nColumnsImplementingIChangeTracking;
        this.AddColumnsImplementingIChangeTrackingList(column);
      }
      else
      {
        if (!column.ImplementsIChangeTracking)
          return;
        ++this.nColumnsImplementingIChangeTracking;
        this.AddColumnsImplementingIChangeTrackingList(column);
      }
    }

    public void Clear()
    {
      int count = this._list.Count;
      DataColumn[] dataColumnArray = new DataColumn[this._list.Count];
      this._list.CopyTo((Array) dataColumnArray, 0);
      this.OnCollectionChanging(InternalDataCollectionBase.RefreshEventArgs);
      if (this.table.fInitInProgress && this.delayedAddRangeColumns != null)
        this.delayedAddRangeColumns = (DataColumn[]) null;
      try
      {
        this.fInClear = true;
        this.BaseGroupSwitch(dataColumnArray, count, (DataColumn[]) null, 0);
        this.fInClear = false;
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableOrSecurityExceptionType(ex))
        {
          this.fInClear = false;
          this.BaseGroupSwitch((DataColumn[]) null, 0, dataColumnArray, count);
          this._list.Clear();
          for (int index = 0; index < count; ++index)
            this._list.Add((object) dataColumnArray[index]);
        }
        throw;
      }
      this._list.Clear();
      this.table.ElementColumnCount = 0;
      this.OnCollectionChanged(InternalDataCollectionBase.RefreshEventArgs);
    }

    public bool Contains(string name) => this.columnFromName[(object) name] is DataColumn || this.IndexOfCaseInsensitive(name) >= 0;

    internal bool Contains(string name, bool caseSensitive)
    {
      if (this.columnFromName[(object) name] is DataColumn)
        return true;
      return !caseSensitive && this.IndexOfCaseInsensitive(name) >= 0;
    }

    public void CopyTo(DataColumn[] array, int index)
    {
      if (array == null)
        throw ExceptionBuilder.ArgumentNull(nameof (array));
      if (index < 0)
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (index));
      if (array.Length - index < this._list.Count)
        throw ExceptionBuilder.InvalidOffsetLength();
      for (int index1 = 0; index1 < this._list.Count; ++index1)
        array[index + index1] = (DataColumn) this._list[index1];
    }

    public int IndexOf(DataColumn column)
    {
      int count = this._list.Count;
      for (int index = 0; index < count; ++index)
      {
        if (column == (DataColumn) this._list[index])
          return index;
      }
      return -1;
    }

    public int IndexOf(string columnName)
    {
      if (columnName != null && 0 < columnName.Length)
      {
        int count = this.Count;
        if (this.columnFromName[(object) columnName] is DataColumn dataColumn2)
        {
          for (int index = 0; index < count; ++index)
          {
            if (dataColumn2 == this._list[index])
              return index;
          }
        }
        else
        {
          int num = this.IndexOfCaseInsensitive(columnName);
          return num >= 0 ? num : -1;
        }
      }
      return -1;
    }

    internal int IndexOfCaseInsensitive(string name)
    {
      int specialHashCode = this.table.GetSpecialHashCode(name);
      int num = -1;
      for (int index = 0; index < this.Count; ++index)
      {
        DataColumn dataColumn = (DataColumn) this._list[index];
        if ((specialHashCode == 0 || dataColumn._hashCode == 0 || dataColumn._hashCode == specialHashCode) && this.NamesEqual(dataColumn.ColumnName, name, false, this.table.Locale) != 0)
        {
          if (num != -1)
            return -2;
          num = index;
        }
      }
      return num;
    }

    internal void FinishInitCollection()
    {
      if (this.delayedAddRangeColumns == null)
        return;
      foreach (DataColumn delayedAddRangeColumn in this.delayedAddRangeColumns)
      {
        if (delayedAddRangeColumn != null)
          this.Add(delayedAddRangeColumn);
      }
      foreach (DataColumn delayedAddRangeColumn in this.delayedAddRangeColumns)
        delayedAddRangeColumn?.FinishInitInProgress();
      this.delayedAddRangeColumns = (DataColumn[]) null;
    }

    private string MakeName(int index) => 1 == index ? "Column1" : "Column" + index.ToString((IFormatProvider) CultureInfo.InvariantCulture);

    internal void MoveTo(DataColumn column, int newPosition)
    {
      if (0 > newPosition || newPosition > this.Count - 1)
        throw ExceptionBuilder.InvalidOrdinal("ordinal", newPosition);
      if (column.ImplementsIChangeTracking)
        this.RemoveColumnsImplementingIChangeTrackingList(column);
      this._list.Remove((object) column);
      this._list.Insert(newPosition, (object) column);
      int count = this._list.Count;
      for (int index = 0; index < count; ++index)
        ((DataColumn) this._list[index]).SetOrdinalInternal(index);
      this.CheckIChangeTracking(column);
      this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, (object) column));
    }

    private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
    {
      if (ccevent != null && !this.table.SchemaLoading && !this.table.fInitInProgress)
      {
        DataColumn element = (DataColumn) ccevent.Element;
      }
      if (this.onCollectionChangedDelegate == null)
        return;
      this.onCollectionChangedDelegate((object) this, ccevent);
    }

    private void OnCollectionChanging(CollectionChangeEventArgs ccevent)
    {
    }

    internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent)
    {
      if (this.onColumnPropertyChangedDelegate == null)
        return;
      this.onColumnPropertyChangedDelegate((object) this, ccevent);
    }

    internal void RegisterColumnName(string name, DataColumn column, DataTable table)
    {
      Debug.Assert(name != null);
      Debug.Assert(column == null != (table == null), "RegisterColumnName wrong usage");
      object obj = this.columnFromName[(object) name];
      if (obj != null)
      {
        if (!(obj is DataColumn))
          throw ExceptionBuilder.CannotAddDuplicate2(name);
        if (column != null)
          throw ExceptionBuilder.CannotAddDuplicate(name);
        throw ExceptionBuilder.CannotAddDuplicate3(name);
      }
      if (table != null && this.NamesEqual(name, this.MakeName(this.defaultNameIndex), true, this.table.Locale) != 0)
      {
        do
        {
          ++this.defaultNameIndex;
        }
        while (this.Contains(this.MakeName(this.defaultNameIndex)));
      }
      if (column != null)
      {
        column._hashCode = this.table.GetSpecialHashCode(name);
        this.columnFromName.Add((object) name, (object) column);
      }
      else
        this.columnFromName.Add((object) name, (object) table);
    }

    internal bool CanRegisterName(string name)
    {
      Debug.Assert(name != null);
      return this.columnFromName[(object) name] == null;
    }

    public void Remove(DataColumn column)
    {
      this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Remove, (object) column));
      this.BaseRemove(column);
      this.ArrayRemove(column);
      this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, (object) column));
      if (column.ColumnMapping != MappingType.Element)
        return;
      --this.table.ElementColumnCount;
    }

    public void RemoveAt(int index) => this.Remove(this[index] ?? throw ExceptionBuilder.ColumnOutOfRange(index));

    public void Remove(string name) => this.Remove(this[name] ?? throw ExceptionBuilder.ColumnNotInTheTable(name, this.table.TableName));

    internal void UnregisterName(string name)
    {
      if (this.columnFromName[(object) name] != null)
        this.columnFromName.Remove((object) name);
      if (this.NamesEqual(name, this.MakeName(this.defaultNameIndex - 1), true, this.table.Locale) == 0)
        return;
      do
      {
        --this.defaultNameIndex;
      }
      while (this.defaultNameIndex > 1 && !this.Contains(this.MakeName(this.defaultNameIndex - 1)));
    }

    private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
    {
      DataColumn[] implementingIchangeTracking = this.columnsImplementingIChangeTracking;
      DataColumn[] dataColumnArray = new DataColumn[implementingIchangeTracking.Length + 1];
      implementingIchangeTracking.CopyTo((Array) dataColumnArray, 0);
      dataColumnArray[implementingIchangeTracking.Length] = dataColumn;
      this.columnsImplementingIChangeTracking = dataColumnArray;
    }

    private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
    {
      DataColumn[] implementingIchangeTracking = this.columnsImplementingIChangeTracking;
      DataColumn[] dataColumnArray = new DataColumn[implementingIchangeTracking.Length - 1];
      int index = 0;
      int num = 0;
      for (; index < implementingIchangeTracking.Length; ++index)
      {
        if (implementingIchangeTracking[index] != dataColumn)
          dataColumnArray[num++] = implementingIchangeTracking[index];
      }
      this.columnsImplementingIChangeTracking = dataColumnArray;
    }
  }
}
