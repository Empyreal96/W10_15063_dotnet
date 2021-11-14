// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataTableCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  public sealed class DataTableCollection : InternalDataCollectionBase
  {
    private readonly DataSet dataSet;
    private readonly Microsoft.Phone.Data.Workaround.ArrayList _list = new Microsoft.Phone.Data.Workaround.ArrayList();
    private int defaultNameIndex = 1;
    private DataTable[] delayedAddRangeTables;
    private CollectionChangeEventHandler onCollectionChangedDelegate;
    private CollectionChangeEventHandler onCollectionChangingDelegate;

    internal DataTableCollection(DataSet dataSet) => this.dataSet = dataSet;

    protected override Microsoft.Phone.Data.Workaround.ArrayList List => this._list;

    public DataTable this[int index]
    {
      get
      {
        try
        {
          return (DataTable) this._list[index];
        }
        catch (ArgumentOutOfRangeException ex)
        {
          throw ExceptionBuilder.TableOutOfRange(index);
        }
      }
    }

    public DataTable this[string name]
    {
      get
      {
        int index = this.InternalIndexOf(name);
        if (index == -2)
          throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
        if (index == -3)
          throw ExceptionBuilder.NamespaceNameConflict(name);
        return index >= 0 ? (DataTable) this._list[index] : (DataTable) null;
      }
    }

    public DataTable this[string name, string tableNamespace]
    {
      get
      {
        int index = tableNamespace != null ? this.InternalIndexOf(name, tableNamespace) : throw ExceptionBuilder.ArgumentNull(nameof (tableNamespace));
        if (index == -2)
          throw ExceptionBuilder.CaseInsensitiveNameConflict(name);
        return index >= 0 ? (DataTable) this._list[index] : (DataTable) null;
      }
    }

    internal DataTable GetTable(string name, string ns)
    {
      for (int index = 0; index < this._list.Count; ++index)
      {
        DataTable dataTable = (DataTable) this._list[index];
        if (dataTable.TableName == name && dataTable.Namespace == ns)
          return dataTable;
      }
      return (DataTable) null;
    }

    internal DataTable GetTableSmart(string name, string ns)
    {
      int num = 0;
      DataTable dataTable1 = (DataTable) null;
      for (int index = 0; index < this._list.Count; ++index)
      {
        DataTable dataTable2 = (DataTable) this._list[index];
        if (dataTable2.TableName == name)
        {
          if (dataTable2.Namespace == ns)
            return dataTable2;
          ++num;
          dataTable1 = dataTable2;
        }
      }
      return num != 1 ? (DataTable) null : dataTable1;
    }

    public void Add(DataTable table)
    {
      this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Add, (object) table));
      this.BaseAdd(table);
      this.ArrayAdd(table);
      if (table.SetLocaleValue(this.dataSet.Locale, false, false) || table.SetCaseSensitiveValue(this.dataSet.CaseSensitive, false, false))
        table.ResetIndexes();
      this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, (object) table));
    }

    public void AddRange(DataTable[] tables)
    {
      if (this.dataSet.fInitInProgress)
      {
        this.delayedAddRangeTables = tables;
      }
      else
      {
        if (tables == null)
          return;
        foreach (DataTable table in tables)
        {
          if (table != null)
            this.Add(table);
        }
      }
    }

    public DataTable Add(string name)
    {
      DataTable table = new DataTable(name);
      this.Add(table);
      return table;
    }

    public DataTable Add(string name, string tableNamespace)
    {
      DataTable table = new DataTable(name, tableNamespace);
      this.Add(table);
      return table;
    }

    public DataTable Add()
    {
      DataTable table = new DataTable();
      this.Add(table);
      return table;
    }

    public event CollectionChangeEventHandler CollectionChanged
    {
      add => this.onCollectionChangedDelegate += value;
      remove => this.onCollectionChangedDelegate -= value;
    }

    public event CollectionChangeEventHandler CollectionChanging
    {
      add => this.onCollectionChangingDelegate += value;
      remove => this.onCollectionChangingDelegate -= value;
    }

    private void ArrayAdd(DataTable table) => this._list.Add((object) table);

    internal string AssignName()
    {
      string str;
      while (this.Contains(str = this.MakeName(this.defaultNameIndex)))
        ++this.defaultNameIndex;
      return str;
    }

    private void BaseAdd(DataTable table)
    {
      if (table == null)
        throw ExceptionBuilder.ArgumentNull(nameof (table));
      if (table.DataSet == this.dataSet)
        throw ExceptionBuilder.TableAlreadyInTheDataSet();
      if (table.DataSet != null)
        throw ExceptionBuilder.TableAlreadyInOtherDataSet();
      if (table.TableName.Length == 0)
      {
        table.TableName = this.AssignName();
      }
      else
      {
        if (this.NamesEqual(table.TableName, this.dataSet.DataSetName, false, this.dataSet.Locale) != 0 && !table.fNestedInDataset)
          throw ExceptionBuilder.DatasetConflictingName(this.dataSet.DataSetName);
        this.RegisterName(table.TableName, table.Namespace);
      }
      table.SetDataSet(this.dataSet);
    }

    private void BaseGroupSwitch(
      DataTable[] oldArray,
      int oldLength,
      DataTable[] newArray,
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
        if (!flag && oldArray[index1].DataSet == this.dataSet)
          this.BaseRemove(oldArray[index1]);
      }
      for (int index = 0; index < newLength; ++index)
      {
        if (newArray[index].DataSet != this.dataSet)
        {
          this.BaseAdd(newArray[index]);
          this._list.Add((object) newArray[index]);
        }
      }
    }

    private void BaseRemove(DataTable table)
    {
      if (this.CanRemove(table, true))
      {
        this.UnregisterName(table.TableName);
        table.SetDataSet((DataSet) null);
      }
      this._list.Remove((object) table);
      this.dataSet.OnRemovedTable(table);
    }

    public bool CanRemove(DataTable table) => this.CanRemove(table, false);

    internal bool CanRemove(DataTable table, bool fThrowException)
    {
      if (table == null)
      {
        if (!fThrowException)
          return false;
        throw ExceptionBuilder.ArgumentNull(nameof (table));
      }
      if (table.DataSet != this.dataSet)
      {
        if (!fThrowException)
          return false;
        throw ExceptionBuilder.TableNotInTheDataSet(table.TableName);
      }
      this.dataSet.OnRemoveTable(table);
      if (table.ChildRelations.Count != 0 || table.ParentRelations.Count != 0)
      {
        if (!fThrowException)
          return false;
        throw ExceptionBuilder.TableInRelation();
      }
      ParentForeignKeyConstraintEnumerator constraintEnumerator1 = new ParentForeignKeyConstraintEnumerator(this.dataSet, table);
      while (constraintEnumerator1.GetNext())
      {
        ForeignKeyConstraint foreignKeyConstraint = constraintEnumerator1.GetForeignKeyConstraint();
        if (foreignKeyConstraint.Table != table || foreignKeyConstraint.RelatedTable != table)
        {
          if (!fThrowException)
            return false;
          throw ExceptionBuilder.TableInConstraint(table, (Constraint) foreignKeyConstraint);
        }
      }
      ChildForeignKeyConstraintEnumerator constraintEnumerator2 = new ChildForeignKeyConstraintEnumerator(this.dataSet, table);
      while (constraintEnumerator2.GetNext())
      {
        ForeignKeyConstraint foreignKeyConstraint = constraintEnumerator2.GetForeignKeyConstraint();
        if (foreignKeyConstraint.Table != table || foreignKeyConstraint.RelatedTable != table)
        {
          if (!fThrowException)
            return false;
          throw ExceptionBuilder.TableInConstraint(table, (Constraint) foreignKeyConstraint);
        }
      }
      return true;
    }

    public void Clear()
    {
      int count = this._list.Count;
      DataTable[] oldArray = new DataTable[this._list.Count];
      this._list.CopyTo((Array) oldArray, 0);
      this.OnCollectionChanging(InternalDataCollectionBase.RefreshEventArgs);
      if (this.dataSet.fInitInProgress && this.delayedAddRangeTables != null)
        this.delayedAddRangeTables = (DataTable[]) null;
      this.BaseGroupSwitch(oldArray, count, (DataTable[]) null, 0);
      this._list.Clear();
      this.OnCollectionChanged(InternalDataCollectionBase.RefreshEventArgs);
    }

    public bool Contains(string name) => this.InternalIndexOf(name) >= 0;

    public bool Contains(string name, string tableNamespace)
    {
      if (name == null)
        throw ExceptionBuilder.ArgumentNull(nameof (name));
      if (tableNamespace == null)
        throw ExceptionBuilder.ArgumentNull(nameof (tableNamespace));
      return this.InternalIndexOf(name, tableNamespace) >= 0;
    }

    internal bool Contains(
      string name,
      string tableNamespace,
      bool checkProperty,
      bool caseSensitive)
    {
      if (!caseSensitive)
        return this.InternalIndexOf(name) >= 0;
      int count = this._list.Count;
      for (int index = 0; index < count; ++index)
      {
        DataTable dataTable = (DataTable) this._list[index];
        string str = checkProperty ? dataTable.Namespace : dataTable.tableNamespace;
        if (this.NamesEqual(dataTable.TableName, name, true, this.dataSet.Locale) == 1 && str == tableNamespace)
          return true;
      }
      return false;
    }

    internal bool Contains(string name, bool caseSensitive)
    {
      if (!caseSensitive)
        return this.InternalIndexOf(name) >= 0;
      int count = this._list.Count;
      for (int index = 0; index < count; ++index)
      {
        if (this.NamesEqual(((DataTable) this._list[index]).TableName, name, true, this.dataSet.Locale) == 1)
          return true;
      }
      return false;
    }

    public void CopyTo(DataTable[] array, int index)
    {
      if (array == null)
        throw ExceptionBuilder.ArgumentNull(nameof (array));
      if (index < 0)
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (index));
      if (array.Length - index < this._list.Count)
        throw ExceptionBuilder.InvalidOffsetLength();
      for (int index1 = 0; index1 < this._list.Count; ++index1)
        array[index + index1] = (DataTable) this._list[index1];
    }

    public int IndexOf(DataTable table)
    {
      int count = this._list.Count;
      for (int index = 0; index < count; ++index)
      {
        if (table == (DataTable) this._list[index])
          return index;
      }
      return -1;
    }

    public int IndexOf(string tableName)
    {
      int num = this.InternalIndexOf(tableName);
      return num >= 0 ? num : -1;
    }

    public int IndexOf(string tableName, string tableNamespace) => this.IndexOf(tableName, tableNamespace, true);

    internal int IndexOf(string tableName, string tableNamespace, bool chekforNull)
    {
      if (chekforNull)
      {
        if (tableName == null)
          throw ExceptionBuilder.ArgumentNull(nameof (tableName));
        if (tableNamespace == null)
          throw ExceptionBuilder.ArgumentNull(nameof (tableNamespace));
      }
      int num = this.InternalIndexOf(tableName, tableNamespace);
      return num >= 0 ? num : -1;
    }

    internal void ReplaceFromInference(System.Collections.Generic.List<DataTable> tableList)
    {
      Debug.Assert(this._list.Count == tableList.Count, "Both lists should have equal numbers of tables");
      this._list.Clear();
      this._list.AddRange((ICollection) tableList);
    }

    internal int InternalIndexOf(string tableName)
    {
      int num = -1;
      if (tableName != null && 0 < tableName.Length)
      {
        int count = this._list.Count;
        for (int index1 = 0; index1 < count; ++index1)
        {
          switch (this.NamesEqual(((DataTable) this._list[index1]).TableName, tableName, false, this.dataSet.Locale))
          {
            case -1:
              num = num == -1 ? index1 : -2;
              break;
            case 1:
              for (int index2 = index1 + 1; index2 < count; ++index2)
              {
                if (this.NamesEqual(((DataTable) this._list[index2]).TableName, tableName, false, this.dataSet.Locale) == 1)
                  return -3;
              }
              return index1;
          }
        }
      }
      return num;
    }

    internal int InternalIndexOf(string tableName, string tableNamespace)
    {
      int num1 = -1;
      if (tableName != null && 0 < tableName.Length)
      {
        int count = this._list.Count;
        for (int index = 0; index < count; ++index)
        {
          DataTable dataTable = (DataTable) this._list[index];
          int num2 = this.NamesEqual(dataTable.TableName, tableName, false, this.dataSet.Locale);
          if (num2 == 1 && dataTable.Namespace == tableNamespace)
            return index;
          if (num2 == -1 && dataTable.Namespace == tableNamespace)
            num1 = num1 == -1 ? index : -2;
        }
      }
      return num1;
    }

    internal void FinishInitCollection()
    {
      if (this.delayedAddRangeTables == null)
        return;
      foreach (DataTable delayedAddRangeTable in this.delayedAddRangeTables)
      {
        if (delayedAddRangeTable != null)
          this.Add(delayedAddRangeTable);
      }
      this.delayedAddRangeTables = (DataTable[]) null;
    }

    private string MakeName(int index) => 1 == index ? "Table1" : "Table" + index.ToString((IFormatProvider) CultureInfo.InvariantCulture);

    private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
    {
      if (this.onCollectionChangedDelegate == null)
        return;
      this.onCollectionChangedDelegate((object) this, ccevent);
    }

    private void OnCollectionChanging(CollectionChangeEventArgs ccevent)
    {
      if (this.onCollectionChangingDelegate == null)
        return;
      this.onCollectionChangingDelegate((object) this, ccevent);
    }

    internal void RegisterName(string name, string tbNamespace)
    {
      Debug.Assert(name != null);
      CultureInfo locale = this.dataSet.Locale;
      int count = this._list.Count;
      for (int index = 0; index < count; ++index)
      {
        DataTable dataTable = (DataTable) this._list[index];
        if (this.NamesEqual(name, dataTable.TableName, true, locale) != 0 && tbNamespace == dataTable.Namespace)
          throw ExceptionBuilder.DuplicateTableName(((DataTable) this._list[index]).TableName);
      }
      if (this.NamesEqual(name, this.MakeName(this.defaultNameIndex), true, locale) == 0)
        return;
      ++this.defaultNameIndex;
    }

    public void Remove(DataTable table)
    {
      this.OnCollectionChanging(new CollectionChangeEventArgs(CollectionChangeAction.Remove, (object) table));
      this.BaseRemove(table);
      this.OnCollectionChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, (object) table));
    }

    public void RemoveAt(int index) => this.Remove(this[index] ?? throw ExceptionBuilder.TableOutOfRange(index));

    public void Remove(string name) => this.Remove(this[name] ?? throw ExceptionBuilder.TableNotInTheDataSet(name));

    public void Remove(string name, string tableNamespace)
    {
      if (name == null)
        throw ExceptionBuilder.ArgumentNull(nameof (name));
      this.Remove((tableNamespace != null ? this[name, tableNamespace] : throw ExceptionBuilder.ArgumentNull(nameof (tableNamespace))) ?? throw ExceptionBuilder.TableNotInTheDataSet(name));
    }

    internal void UnregisterName(string name)
    {
      if (this.NamesEqual(name, this.MakeName(this.defaultNameIndex - 1), true, this.dataSet.Locale) == 0)
        return;
      do
      {
        --this.defaultNameIndex;
      }
      while (this.defaultNameIndex > 1 && !this.Contains(this.MakeName(this.defaultNameIndex - 1)));
    }
  }
}
