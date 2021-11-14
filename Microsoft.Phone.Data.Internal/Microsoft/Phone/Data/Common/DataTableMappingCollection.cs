// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DataTableMappingCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data.Common
{
  public sealed class DataTableMappingCollection : 
    MarshalByValueComponent,
    ITableMappingCollection,
    IList,
    ICollection,
    IEnumerable
  {
    private List<DataTableMapping> items;

    bool ICollection.IsSynchronized => false;

    object ICollection.SyncRoot => (object) this;

    bool IList.IsReadOnly => false;

    bool IList.IsFixedSize => false;

    object IList.this[int index]
    {
      get => (object) this[index];
      set
      {
        this.ValidateType(value);
        this[index] = (DataTableMapping) value;
      }
    }

    object ITableMappingCollection.this[string index]
    {
      get => (object) this[index];
      set
      {
        this.ValidateType(value);
        this[index] = (DataTableMapping) value;
      }
    }

    ITableMapping ITableMappingCollection.Add(
      string sourceTableName,
      string dataSetTableName)
    {
      return (ITableMapping) this.Add(sourceTableName, dataSetTableName);
    }

    ITableMapping ITableMappingCollection.GetByDataSetTable(
      string dataSetTableName)
    {
      return (ITableMapping) this.GetByDataSetTable(dataSetTableName);
    }

    public int Count => this.items == null ? 0 : this.items.Count;

    private Type ItemType => typeof (DataTableMapping);

    public DataTableMapping this[int index]
    {
      get
      {
        this.RangeCheck(index);
        return this.items[index];
      }
      set
      {
        this.RangeCheck(index);
        this.Replace(index, value);
      }
    }

    public DataTableMapping this[string sourceTable]
    {
      get => this.items[this.RangeCheck(sourceTable)];
      set => this.Replace(this.RangeCheck(sourceTable), value);
    }

    public int Add(object value)
    {
      this.ValidateType(value);
      this.Add((DataTableMapping) value);
      return this.Count - 1;
    }

    private DataTableMapping Add(DataTableMapping value)
    {
      this.AddWithoutEvents(value);
      return value;
    }

    public void AddRange(DataTableMapping[] values) => this.AddEnumerableRange((IEnumerable) values, false);

    public void AddRange(Array values) => this.AddEnumerableRange((IEnumerable) values, false);

    private void AddEnumerableRange(IEnumerable values, bool doClone)
    {
      if (values == null)
        throw ADP.ArgumentNull(nameof (values));
      foreach (object obj in values)
        this.ValidateType(obj);
      if (doClone)
      {
        foreach (Microsoft.Phone.Data.Workaround.ICloneable cloneable in values)
          this.AddWithoutEvents(cloneable.Clone() as DataTableMapping);
      }
      else
      {
        foreach (DataTableMapping dataTableMapping in values)
          this.AddWithoutEvents(dataTableMapping);
      }
    }

    public DataTableMapping Add(string sourceTable, string dataSetTable) => this.Add(new DataTableMapping(sourceTable, dataSetTable));

    private void AddWithoutEvents(DataTableMapping value)
    {
      this.Validate(-1, value);
      value.Parent = this;
      this.ArrayList().Add(value);
    }

    private List<DataTableMapping> ArrayList()
    {
      if (this.items == null)
        this.items = new List<DataTableMapping>();
      return this.items;
    }

    public void Clear()
    {
      if (0 >= this.Count)
        return;
      this.ClearWithoutEvents();
    }

    private void ClearWithoutEvents()
    {
      if (this.items == null)
        return;
      foreach (DataTableMapping dataTableMapping in this.items)
        dataTableMapping.Parent = (DataTableMappingCollection) null;
      this.items.Clear();
    }

    public bool Contains(string value) => -1 != this.IndexOf(value);

    public bool Contains(object value) => -1 != this.IndexOf(value);

    public void CopyTo(Array array, int index) => ((ICollection) this.ArrayList()).CopyTo(array, index);

    public void CopyTo(DataTableMapping[] array, int index) => this.ArrayList().CopyTo(array, index);

    public DataTableMapping GetByDataSetTable(string dataSetTable)
    {
      int index = this.IndexOfDataSetTable(dataSetTable);
      return 0 <= index ? this.items[index] : throw ADP.TablesDataSetTable(dataSetTable);
    }

    public IEnumerator GetEnumerator() => (IEnumerator) this.ArrayList().GetEnumerator();

    public int IndexOf(object value)
    {
      if (value != null)
      {
        this.ValidateType(value);
        for (int index = 0; index < this.Count; ++index)
        {
          if (this.items[index] == value)
            return index;
        }
      }
      return -1;
    }

    public int IndexOf(string sourceTable)
    {
      if (!ADP.IsEmpty(sourceTable))
      {
        for (int index = 0; index < this.Count; ++index)
        {
          string sourceTable1 = this.items[index].SourceTable;
          if (sourceTable1 != null && ADP.SrcCompare(sourceTable, sourceTable1) == 0)
            return index;
        }
      }
      return -1;
    }

    public int IndexOfDataSetTable(string dataSetTable)
    {
      if (!ADP.IsEmpty(dataSetTable))
      {
        for (int index = 0; index < this.Count; ++index)
        {
          string dataSetTable1 = this.items[index].DataSetTable;
          if (dataSetTable1 != null && ADP.DstCompare(dataSetTable, dataSetTable1) == 0)
            return index;
        }
      }
      return -1;
    }

    public void Insert(int index, object value)
    {
      this.ValidateType(value);
      this.Insert(index, (DataTableMapping) value);
    }

    public void Insert(int index, DataTableMapping value)
    {
      if (value == null)
        throw ADP.TablesAddNullAttempt(nameof (value));
      this.Validate(-1, value);
      value.Parent = this;
      this.ArrayList().Insert(index, value);
    }

    private void RangeCheck(int index)
    {
      if (index < 0 || this.Count <= index)
        throw ADP.TablesIndexInt32(index, (ITableMappingCollection) this);
    }

    private int RangeCheck(string sourceTable)
    {
      int num = this.IndexOf(sourceTable);
      return num >= 0 ? num : throw ADP.TablesSourceIndex(sourceTable);
    }

    public void RemoveAt(int index)
    {
      this.RangeCheck(index);
      this.RemoveIndex(index);
    }

    public void RemoveAt(string sourceTable) => this.RemoveIndex(this.RangeCheck(sourceTable));

    private void RemoveIndex(int index)
    {
      Debug.Assert(this.items != null && 0 <= index && index < this.Count, "RemoveIndex, invalid");
      this.items[index].Parent = (DataTableMappingCollection) null;
      this.items.RemoveAt(index);
    }

    public void Remove(object value)
    {
      this.ValidateType(value);
      this.Remove((DataTableMapping) value);
    }

    public void Remove(DataTableMapping value)
    {
      int index = value != null ? this.IndexOf((object) value) : throw ADP.TablesAddNullAttempt(nameof (value));
      if (-1 == index)
        throw ADP.CollectionRemoveInvalidObject(this.ItemType, (ICollection) this);
      this.RemoveIndex(index);
    }

    private void Replace(int index, DataTableMapping newValue)
    {
      this.Validate(index, newValue);
      this.items[index].Parent = (DataTableMappingCollection) null;
      newValue.Parent = this;
      this.items[index] = newValue;
    }

    private void ValidateType(object value)
    {
      if (value == null)
        throw ADP.TablesAddNullAttempt(nameof (value));
      if (!this.ItemType.IsInstanceOfType(value))
        throw ADP.NotADataTableMapping(value);
    }

    private void Validate(int index, DataTableMapping value)
    {
      if (value == null)
        throw ADP.TablesAddNullAttempt(nameof (value));
      if (value.Parent != null)
      {
        if (this != value.Parent)
          throw ADP.TablesIsNotParent((ICollection) this);
        if (index != this.IndexOf((object) value))
          throw ADP.TablesIsParent((ICollection) this);
      }
      string sourceTable1 = value.SourceTable;
      if (ADP.IsEmpty(sourceTable1))
      {
        index = 1;
        string sourceTable2;
        do
        {
          sourceTable2 = "SourceTable" + index.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          ++index;
        }
        while (-1 != this.IndexOf(sourceTable2));
        value.SourceTable = sourceTable2;
      }
      else
        this.ValidateSourceTable(index, sourceTable1);
    }

    internal void ValidateSourceTable(int index, string value)
    {
      int num = this.IndexOf(value);
      if (-1 != num && index != num)
        throw ADP.TablesUniqueSourceTable(value);
    }

    public static DataTableMapping GetTableMappingBySchemaAction(
      DataTableMappingCollection tableMappings,
      string sourceTable,
      string dataSetTable,
      MissingMappingAction mappingAction)
    {
      if (tableMappings != null)
      {
        int index = tableMappings.IndexOf(sourceTable);
        if (-1 != index)
          return tableMappings.items[index];
      }
      if (ADP.IsEmpty(sourceTable))
        throw ADP.InvalidSourceTable(nameof (sourceTable));
      switch (mappingAction)
      {
        case MissingMappingAction.Passthrough:
          return new DataTableMapping(sourceTable, dataSetTable);
        case MissingMappingAction.Ignore:
          return (DataTableMapping) null;
        case MissingMappingAction.Error:
          throw ADP.MissingTableMapping(sourceTable);
        default:
          throw ADP.InvalidMissingMappingAction(mappingAction);
      }
    }
  }
}
