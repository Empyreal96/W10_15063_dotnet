// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DataColumnMappingCollection
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
  public sealed class DataColumnMappingCollection : 
    MarshalByValueComponent,
    IColumnMappingCollection,
    IList,
    ICollection,
    IEnumerable
  {
    private List<DataColumnMapping> items;

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
        this[index] = (DataColumnMapping) value;
      }
    }

    object IColumnMappingCollection.this[string index]
    {
      get => (object) this[index];
      set
      {
        this.ValidateType(value);
        this[index] = (DataColumnMapping) value;
      }
    }

    IColumnMapping IColumnMappingCollection.Add(
      string sourceColumnName,
      string dataSetColumnName)
    {
      return (IColumnMapping) this.Add(sourceColumnName, dataSetColumnName);
    }

    IColumnMapping IColumnMappingCollection.GetByDataSetColumn(
      string dataSetColumnName)
    {
      return (IColumnMapping) this.GetByDataSetColumn(dataSetColumnName);
    }

    public int Count => this.items == null ? 0 : this.items.Count;

    private Type ItemType => typeof (DataColumnMapping);

    public DataColumnMapping this[int index]
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

    public DataColumnMapping this[string sourceColumn]
    {
      get => this.items[this.RangeCheck(sourceColumn)];
      set => this.Replace(this.RangeCheck(sourceColumn), value);
    }

    public int Add(object value)
    {
      this.ValidateType(value);
      this.Add((DataColumnMapping) value);
      return this.Count - 1;
    }

    private DataColumnMapping Add(DataColumnMapping value)
    {
      this.AddWithoutEvents(value);
      return value;
    }

    public DataColumnMapping Add(string sourceColumn, string dataSetColumn) => this.Add(new DataColumnMapping(sourceColumn, dataSetColumn));

    public void AddRange(DataColumnMapping[] values) => this.AddEnumerableRange((IEnumerable) values, false);

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
          this.AddWithoutEvents(cloneable.Clone() as DataColumnMapping);
      }
      else
      {
        foreach (DataColumnMapping dataColumnMapping in values)
          this.AddWithoutEvents(dataColumnMapping);
      }
    }

    private void AddWithoutEvents(DataColumnMapping value)
    {
      this.Validate(-1, value);
      value.Parent = this;
      this.ArrayList().Add(value);
    }

    private List<DataColumnMapping> ArrayList()
    {
      if (this.items == null)
        this.items = new List<DataColumnMapping>();
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
      foreach (DataColumnMapping dataColumnMapping in this.items)
        dataColumnMapping.Parent = (DataColumnMappingCollection) null;
      this.items.Clear();
    }

    public bool Contains(string value) => -1 != this.IndexOf(value);

    public bool Contains(object value) => -1 != this.IndexOf(value);

    public void CopyTo(Array array, int index) => ((ICollection) this.ArrayList()).CopyTo(array, index);

    public void CopyTo(DataColumnMapping[] array, int index) => this.ArrayList().CopyTo(array, index);

    public DataColumnMapping GetByDataSetColumn(string value)
    {
      int index = this.IndexOfDataSetColumn(value);
      return 0 <= index ? this.items[index] : throw ADP.ColumnsDataSetColumn(value);
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

    public int IndexOf(string sourceColumn)
    {
      if (!ADP.IsEmpty(sourceColumn))
      {
        int count = this.Count;
        for (int index = 0; index < count; ++index)
        {
          if (ADP.SrcCompare(sourceColumn, this.items[index].SourceColumn) == 0)
            return index;
        }
      }
      return -1;
    }

    public int IndexOfDataSetColumn(string dataSetColumn)
    {
      if (!ADP.IsEmpty(dataSetColumn))
      {
        int count = this.Count;
        for (int index = 0; index < count; ++index)
        {
          if (ADP.DstCompare(dataSetColumn, this.items[index].DataSetColumn) == 0)
            return index;
        }
      }
      return -1;
    }

    public void Insert(int index, object value)
    {
      this.ValidateType(value);
      this.Insert(index, (DataColumnMapping) value);
    }

    public void Insert(int index, DataColumnMapping value)
    {
      if (value == null)
        throw ADP.ColumnsAddNullAttempt(nameof (value));
      this.Validate(-1, value);
      value.Parent = this;
      this.ArrayList().Insert(index, value);
    }

    private void RangeCheck(int index)
    {
      if (index < 0 || this.Count <= index)
        throw ADP.ColumnsIndexInt32(index, (IColumnMappingCollection) this);
    }

    private int RangeCheck(string sourceColumn)
    {
      int num = this.IndexOf(sourceColumn);
      return num >= 0 ? num : throw ADP.ColumnsIndexSource(sourceColumn);
    }

    public void RemoveAt(int index)
    {
      this.RangeCheck(index);
      this.RemoveIndex(index);
    }

    public void RemoveAt(string sourceColumn) => this.RemoveIndex(this.RangeCheck(sourceColumn));

    private void RemoveIndex(int index)
    {
      Debug.Assert(this.items != null && 0 <= index && index < this.Count, "RemoveIndex, invalid");
      this.items[index].Parent = (DataColumnMappingCollection) null;
      this.items.RemoveAt(index);
    }

    public void Remove(object value)
    {
      this.ValidateType(value);
      this.Remove((DataColumnMapping) value);
    }

    public void Remove(DataColumnMapping value)
    {
      int index = value != null ? this.IndexOf((object) value) : throw ADP.ColumnsAddNullAttempt(nameof (value));
      if (-1 == index)
        throw ADP.CollectionRemoveInvalidObject(this.ItemType, (ICollection) this);
      this.RemoveIndex(index);
    }

    private void Replace(int index, DataColumnMapping newValue)
    {
      Debug.Assert(this.items != null && 0 <= index && index < this.Count, "RemoveIndex, invalid");
      this.Validate(index, newValue);
      this.items[index].Parent = (DataColumnMappingCollection) null;
      newValue.Parent = this;
      this.items[index] = newValue;
    }

    private void ValidateType(object value)
    {
      if (value == null)
        throw ADP.ColumnsAddNullAttempt(nameof (value));
      if (!this.ItemType.IsInstanceOfType(value))
        throw ADP.NotADataColumnMapping(value);
    }

    private void Validate(int index, DataColumnMapping value)
    {
      if (value == null)
        throw ADP.ColumnsAddNullAttempt(nameof (value));
      if (value.Parent != null)
      {
        if (this != value.Parent)
          throw ADP.ColumnsIsNotParent((ICollection) this);
        if (index != this.IndexOf((object) value))
          throw ADP.ColumnsIsParent((ICollection) this);
      }
      string sourceColumn1 = value.SourceColumn;
      if (ADP.IsEmpty(sourceColumn1))
      {
        index = 1;
        string sourceColumn2;
        do
        {
          sourceColumn2 = "SourceColumn" + index.ToString((IFormatProvider) CultureInfo.InvariantCulture);
          ++index;
        }
        while (-1 != this.IndexOf(sourceColumn2));
        value.SourceColumn = sourceColumn2;
      }
      else
        this.ValidateSourceColumn(index, sourceColumn1);
    }

    internal void ValidateSourceColumn(int index, string value)
    {
      int num = this.IndexOf(value);
      if (-1 != num && index != num)
        throw ADP.ColumnsUniqueSourceColumn(value);
    }

    public static DataColumn GetDataColumn(
      DataColumnMappingCollection columnMappings,
      string sourceColumn,
      Type dataType,
      DataTable dataTable,
      MissingMappingAction mappingAction,
      MissingSchemaAction schemaAction)
    {
      if (columnMappings != null)
      {
        int index = columnMappings.IndexOf(sourceColumn);
        if (-1 != index)
          return columnMappings.items[index].GetDataColumnBySchemaAction(dataTable, dataType, schemaAction);
      }
      if (ADP.IsEmpty(sourceColumn))
        throw ADP.InvalidSourceColumn(nameof (sourceColumn));
      switch (mappingAction)
      {
        case MissingMappingAction.Passthrough:
          string str = sourceColumn;
          return DataColumnMapping.GetDataColumnBySchemaAction(str, str, dataTable, dataType, schemaAction);
        case MissingMappingAction.Ignore:
          return (DataColumn) null;
        case MissingMappingAction.Error:
          throw ADP.MissingColumnMapping(sourceColumn);
        default:
          throw ADP.InvalidMissingMappingAction(mappingAction);
      }
    }

    public static DataColumnMapping GetColumnMappingBySchemaAction(
      DataColumnMappingCollection columnMappings,
      string sourceColumn,
      MissingMappingAction mappingAction)
    {
      if (columnMappings != null)
      {
        int index = columnMappings.IndexOf(sourceColumn);
        if (-1 != index)
          return columnMappings.items[index];
      }
      if (ADP.IsEmpty(sourceColumn))
        throw ADP.InvalidSourceColumn(nameof (sourceColumn));
      switch (mappingAction)
      {
        case MissingMappingAction.Passthrough:
          string str = sourceColumn;
          return new DataColumnMapping(str, str);
        case MissingMappingAction.Ignore:
          return (DataColumnMapping) null;
        case MissingMappingAction.Error:
          throw ADP.MissingColumnMapping(sourceColumn);
        default:
          throw ADP.InvalidMissingMappingAction(mappingAction);
      }
    }
  }
}
