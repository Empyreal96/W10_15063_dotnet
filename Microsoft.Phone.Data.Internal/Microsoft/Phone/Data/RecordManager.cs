// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.RecordManager
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal sealed class RecordManager
  {
    private readonly DataTable table;
    private int lastFreeRecord;
    private int minimumCapacity = 50;
    private int recordCapacity;
    private readonly List<int> freeRecordList = new List<int>();
    private DataRow[] rows;

    internal RecordManager(DataTable table) => this.table = table != null ? table : throw ExceptionBuilder.ArgumentNull(nameof (table));

    private void GrowRecordCapacity()
    {
      this.RecordCapacity = RecordManager.NewCapacity(this.recordCapacity) >= this.NormalizedMinimumCapacity(this.minimumCapacity) ? RecordManager.NewCapacity(this.recordCapacity) : this.NormalizedMinimumCapacity(this.minimumCapacity);
      DataRow[] dataRowArray = this.table.NewRowArray(this.recordCapacity);
      if (this.rows != null)
        Array.Copy((Array) this.rows, 0, (Array) dataRowArray, 0, Math.Min(this.lastFreeRecord, this.rows.Length));
      this.rows = dataRowArray;
    }

    internal int LastFreeRecord => this.lastFreeRecord;

    internal int MinimumCapacity
    {
      get => this.minimumCapacity;
      set
      {
        if (this.minimumCapacity == value)
          return;
        this.minimumCapacity = value >= 0 ? value : throw ExceptionBuilder.NegativeMinimumCapacity();
      }
    }

    internal int RecordCapacity
    {
      get => this.recordCapacity;
      set
      {
        if (this.recordCapacity == value)
          return;
        for (int index = 0; index < this.table.Columns.Count; ++index)
          this.table.Columns[index].SetCapacity(value);
        this.recordCapacity = value;
      }
    }

    internal static int NewCapacity(int capacity)
    {
      if (capacity < 128)
        return 128;
      int num = capacity;
      return num + num;
    }

    private int NormalizedMinimumCapacity(int capacity)
    {
      if (capacity >= 1014)
        return (capacity + 10 >> 10) + 1 << 10;
      if (capacity >= 246)
        return 1024;
      return capacity < 54 ? 64 : 256;
    }

    internal int NewRecordBase()
    {
      int num;
      if (this.freeRecordList.Count != 0)
      {
        num = this.freeRecordList[this.freeRecordList.Count - 1];
        this.freeRecordList.RemoveAt(this.freeRecordList.Count - 1);
      }
      else
      {
        if (this.lastFreeRecord >= this.recordCapacity)
          this.GrowRecordCapacity();
        num = this.lastFreeRecord;
        ++this.lastFreeRecord;
      }
      Debug.Assert(num >= 0 && num < this.recordCapacity, "NewRecord: Invalid record");
      return num;
    }

    internal void FreeRecord(ref int record)
    {
      Debug.Assert(-1 <= record && record < this.recordCapacity, "invalid record");
      if (-1 == record)
        return;
      this[record] = (DataRow) null;
      int count = this.table.columnCollection.Count;
      for (int index = 0; index < count; ++index)
        this.table.columnCollection[index].FreeRecord(record);
      if (this.lastFreeRecord == record + 1)
        --this.lastFreeRecord;
      else if (record < this.lastFreeRecord)
        this.freeRecordList.Add(record);
      record = -1;
    }

    internal void Clear(bool clearAll)
    {
      if (clearAll)
      {
        for (int index = 0; index < this.recordCapacity; ++index)
          this.rows[index] = (DataRow) null;
        int count = this.table.columnCollection.Count;
        for (int index = 0; index < count; ++index)
        {
          DataColumn column = this.table.columnCollection[index];
          for (int record = 0; record < this.recordCapacity; ++record)
            column.FreeRecord(record);
        }
        this.lastFreeRecord = 0;
        this.freeRecordList.Clear();
      }
      else
      {
        this.freeRecordList.Capacity = this.freeRecordList.Count + this.table.Rows.Count;
        for (int index = 0; index < this.recordCapacity; ++index)
        {
          if (this.rows[index] != null && this.rows[index].rowID != -1)
          {
            int record = index;
            this.FreeRecord(ref record);
          }
        }
      }
    }

    internal DataRow this[int record]
    {
      get
      {
        Debug.Assert(record >= 0 && record < this.rows.Length, "Invalid record number");
        return this.rows[record];
      }
      set
      {
        Debug.Assert(record >= 0 && record < this.rows.Length, "Invalid record number");
        this.rows[record] = value;
      }
    }

    internal void SetKeyValues(int record, DataKey key, object[] keyValues)
    {
      for (int index = 0; index < keyValues.Length; ++index)
        key.ColumnsReference[index][record] = keyValues[index];
    }

    internal int ImportRecord(DataTable src, int record) => this.CopyRecord(src, record, -1);

    internal int CopyRecord(DataTable src, int record, int copy)
    {
      Debug.Assert(src != null, "Can not Merge record without a table");
      if (record == -1)
        return copy;
      int record1 = -1;
      try
      {
        record1 = copy != -1 ? copy : this.table.NewUninitializedRecord();
        int count = this.table.Columns.Count;
        for (int index = 0; index < count; ++index)
        {
          DataColumn column1 = this.table.Columns[index];
          DataColumn column2 = src.Columns[column1.ColumnName];
          if (column2 != null)
          {
            object obj = column2[record];
            column1[record1] = !(obj is Microsoft.Phone.Data.Workaround.ICloneable cloneable6) ? obj : cloneable6.Clone();
          }
          else if (-1 == copy)
            column1.Init(record1);
        }
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableOrSecurityExceptionType(ex) && -1 == copy)
          this.FreeRecord(ref record1);
        throw;
      }
      return record1;
    }

    [Conditional("DEBUG")]
    internal void VerifyRecord(int record)
    {
      Debug.Assert(record < this.lastFreeRecord && -1 == this.freeRecordList.IndexOf(record), "accesing free record");
      Debug.Assert(this.rows[record] == null || record == this.rows[record].oldRecord || record == this.rows[record].newRecord || record == this.rows[record].tempRecord, "record of a different row");
    }

    [Conditional("DEBUG")]
    internal void VerifyRecord(int record, DataRow row)
    {
      Debug.Assert(record < this.lastFreeRecord && -1 == this.freeRecordList.IndexOf(record), "accesing free record");
      Debug.Assert(this.rows[record] == null || row == this.rows[record], "record of a different row");
    }
  }
}
