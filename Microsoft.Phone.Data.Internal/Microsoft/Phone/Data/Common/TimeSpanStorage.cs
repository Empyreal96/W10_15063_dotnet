// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.TimeSpanStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class TimeSpanStorage : DataStorage
  {
    private static readonly TimeSpan defaultValue = TimeSpan.Zero;
    private TimeSpan[] values;

    public TimeSpanStorage(DataColumn column)
      : base(column, typeof (TimeSpan), (object) TimeSpanStorage.defaultValue)
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
            TimeSpan t2_1 = TimeSpan.MaxValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (!this.IsNull(record))
              {
                t2_1 = TimeSpan.Compare(this.values[record], t2_1) < 0 ? this.values[record] : t2_1;
                flag = true;
              }
            }
            return flag ? (object) t2_1 : this.NullValue;
          case AggregateType.Max:
            TimeSpan t2_2 = TimeSpan.MinValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (!this.IsNull(record))
              {
                t2_2 = TimeSpan.Compare(this.values[record], t2_2) >= 0 ? this.values[record] : t2_2;
                flag = true;
              }
            }
            return flag ? (object) t2_2 : this.NullValue;
          case AggregateType.First:
            return records.Length != 0 ? (object) this.values[records[0]] : (object) null;
          case AggregateType.Count:
            return base.Aggregate(records, kind);
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (TimeSpan));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      TimeSpan t1 = this.values[recordNo1];
      TimeSpan t2 = this.values[recordNo2];
      if (t1 == TimeSpanStorage.defaultValue || t2 == TimeSpanStorage.defaultValue)
      {
        int num = this.CompareBits(recordNo1, recordNo2);
        if (num != 0)
          return num;
      }
      return TimeSpan.Compare(t1, t2);
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(0 <= recordNo, "Invalid record");
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        return this.IsNull(recordNo) ? 0 : 1;
      TimeSpan timeSpan = this.values[recordNo];
      return TimeSpanStorage.defaultValue == timeSpan && this.IsNull(recordNo) ? -1 : timeSpan.CompareTo((TimeSpan) value);
    }

    private static TimeSpan ConvertToTimeSpan(object value)
    {
      Type type = value.GetType();
      if (type == typeof (string))
        return TimeSpan.Parse((string) value);
      if (type == typeof (int))
        return new TimeSpan((long) (int) value);
      return type == typeof (long) ? new TimeSpan((long) value) : (TimeSpan) value;
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
        value = value == null ? this.NullValue : (object) TimeSpanStorage.ConvertToTimeSpan(value);
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2)
    {
      this.CopyBits(recordNo1, recordNo2);
      this.values[recordNo2] = this.values[recordNo1];
    }

    public override object Get(int record)
    {
      TimeSpan timeSpan = this.values[record];
      return timeSpan != TimeSpanStorage.defaultValue ? (object) timeSpan : this.GetBits(record);
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = TimeSpanStorage.defaultValue;
        this.SetNullBit(record, true);
      }
      else
      {
        this.values[record] = TimeSpanStorage.ConvertToTimeSpan(value);
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      TimeSpan[] timeSpanArray = new TimeSpan[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) timeSpanArray, 0, Math.Min(capacity, this.values.Length));
      this.values = timeSpanArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new TimeSpan[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((TimeSpan[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, this.IsNull(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (TimeSpan[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
