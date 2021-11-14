// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DateTimeStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class DateTimeStorage : DataStorage
  {
    private static readonly DateTime defaultValue = DateTime.MinValue;
    private DateTime[] values;

    internal DateTimeStorage(DataColumn column)
      : base(column, typeof (DateTime), (object) DateTimeStorage.defaultValue)
    {
    }

    public override object Aggregate(int[] records, AggregateType kind)
    {
      bool flag = false;
      try
      {
        switch (kind)
        {
          case AggregateType.Min:
            DateTime t2_1 = DateTime.MaxValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (this.HasValue(record))
              {
                t2_1 = DateTime.Compare(this.values[record], t2_1) < 0 ? this.values[record] : t2_1;
                flag = true;
              }
            }
            return flag ? (object) t2_1 : this.NullValue;
          case AggregateType.Max:
            DateTime t2_2 = DateTime.MinValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (this.HasValue(record))
              {
                t2_2 = DateTime.Compare(this.values[record], t2_2) >= 0 ? this.values[record] : t2_2;
                flag = true;
              }
            }
            return flag ? (object) t2_2 : this.NullValue;
          case AggregateType.First:
            return records.Length != 0 ? (object) this.values[records[0]] : (object) null;
          case AggregateType.Count:
            int num = 0;
            for (int index = 0; index < records.Length; ++index)
            {
              if (this.HasValue(records[index]))
                ++num;
            }
            return (object) num;
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (DateTime));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      DateTime t1 = this.values[recordNo1];
      DateTime t2 = this.values[recordNo2];
      if (t1 == DateTimeStorage.defaultValue || t2 == DateTimeStorage.defaultValue)
      {
        int num = this.CompareBits(recordNo1, recordNo2);
        if (num != 0)
          return num;
      }
      return DateTime.Compare(t1, t2);
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(0 <= recordNo, "Invalid record");
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        return !this.HasValue(recordNo) ? 0 : 1;
      DateTime t1 = this.values[recordNo];
      return DateTimeStorage.defaultValue == t1 && !this.HasValue(recordNo) ? -1 : DateTime.Compare(t1, (DateTime) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
      {
        if (value != null)
        {
          if (!(value is DateTime dateTime3))
            dateTime3 = ((IConvertible) value).ToDateTime(this.FormatProvider);
          value = (object) dateTime3;
        }
        else
          value = this.NullValue;
      }
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2)
    {
      this.CopyBits(recordNo1, recordNo2);
      this.values[recordNo2] = this.values[recordNo1];
    }

    public override object Get(int record)
    {
      DateTime dateTime = this.values[record];
      return dateTime != DateTimeStorage.defaultValue || this.HasValue(record) ? (object) dateTime : this.NullValue;
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = DateTimeStorage.defaultValue;
        this.SetNullBit(record, true);
      }
      else
      {
        if (!(value is DateTime dateTime5))
          dateTime5 = ((IConvertible) value).ToDateTime(this.FormatProvider);
        DateTime dateTime2 = dateTime5;
        DateTime dateTime3;
        switch (this.DateTimeMode)
        {
          case DataSetDateTime.Local:
            dateTime3 = dateTime2.Kind != DateTimeKind.Local ? (dateTime2.Kind != DateTimeKind.Utc ? DateTime.SpecifyKind(dateTime2, DateTimeKind.Local) : dateTime2.ToLocalTime()) : dateTime2;
            break;
          case DataSetDateTime.Unspecified:
          case DataSetDateTime.UnspecifiedLocal:
            dateTime3 = DateTime.SpecifyKind(dateTime2, DateTimeKind.Unspecified);
            break;
          case DataSetDateTime.Utc:
            dateTime3 = dateTime2.Kind != DateTimeKind.Utc ? (dateTime2.Kind != DateTimeKind.Local ? DateTime.SpecifyKind(dateTime2, DateTimeKind.Utc) : dateTime2.ToUniversalTime()) : dateTime2;
            break;
          default:
            throw ExceptionBuilder.InvalidDateTimeMode(this.DateTimeMode);
        }
        this.values[record] = dateTime3;
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      DateTime[] dateTimeArray = new DateTime[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) dateTimeArray, 0, Math.Min(capacity, this.values.Length));
      this.values = dateTimeArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new DateTime[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      DateTime[] dateTimeArray = (DateTime[]) store;
      bool flag = !this.HasValue(record);
      dateTimeArray[storeIndex] = flag || (this.DateTimeMode & DataSetDateTime.Local) == (DataSetDateTime) 0 ? this.values[record] : this.values[record].ToUniversalTime();
      nullbits.Set(storeIndex, flag);
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (DateTime[]) store;
      this.SetNullStorage(nullbits);
      if (this.DateTimeMode == DataSetDateTime.UnspecifiedLocal)
      {
        for (int recordNo = 0; recordNo < this.values.Length; ++recordNo)
        {
          if (this.HasValue(recordNo))
            this.values[recordNo] = DateTime.SpecifyKind(this.values[recordNo].ToLocalTime(), DateTimeKind.Unspecified);
        }
      }
      else
      {
        if (this.DateTimeMode != DataSetDateTime.Local)
          return;
        for (int recordNo = 0; recordNo < this.values.Length; ++recordNo)
        {
          if (this.HasValue(recordNo))
            this.values[recordNo] = this.values[recordNo].ToLocalTime();
        }
      }
    }
  }
}
