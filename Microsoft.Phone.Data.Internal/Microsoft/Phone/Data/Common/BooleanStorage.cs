// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.BooleanStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class BooleanStorage : DataStorage
  {
    private const bool defaultValue = false;
    private bool[] values;

    internal BooleanStorage(DataColumn column)
      : base(column, typeof (bool), (object) false)
    {
    }

    public override object Aggregate(int[] records, AggregateType kind)
    {
      bool flag1 = false;
      try
      {
        switch (kind)
        {
          case AggregateType.Min:
            bool flag2 = true;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (!this.IsNull(record))
              {
                flag2 = this.values[record] & flag2;
                flag1 = true;
              }
            }
            return flag1 ? (object) flag2 : this.NullValue;
          case AggregateType.Max:
            bool flag3 = false;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (!this.IsNull(record))
              {
                flag3 = this.values[record] | flag3;
                flag1 = true;
              }
            }
            return flag1 ? (object) flag3 : this.NullValue;
          case AggregateType.First:
            return records.Length != 0 ? (object) this.values[records[0]] : (object) null;
          case AggregateType.Count:
            return base.Aggregate(records, kind);
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (bool));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      bool flag1 = this.values[recordNo1];
      bool flag2 = this.values[recordNo2];
      if (!flag1 || !flag2)
      {
        int num = this.CompareBits(recordNo1, recordNo2);
        if (num != 0)
          return num;
      }
      return flag1.CompareTo(flag2);
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(0 <= recordNo, "Invalid record");
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        return this.IsNull(recordNo) ? 0 : 1;
      bool flag = this.values[recordNo];
      return !flag && this.IsNull(recordNo) ? -1 : flag.CompareTo((bool) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
        value = value == null ? this.NullValue : (object) (bool) (value is bool flag2 ? (flag2 ? 1 : 0) : (((IConvertible) value).ToBoolean(this.FormatProvider) ? 1 : 0));
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2)
    {
      this.CopyBits(recordNo1, recordNo2);
      this.values[recordNo2] = this.values[recordNo1];
    }

    public override object Get(int record)
    {
      bool flag = this.values[record];
      return flag ? (object) flag : this.GetBits(record);
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = false;
        this.SetNullBit(record, true);
      }
      else
      {
        this.values[record] = value is bool flag2 ? flag2 : ((IConvertible) value).ToBoolean(this.FormatProvider);
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      bool[] flagArray = new bool[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) flagArray, 0, Math.Min(capacity, this.values.Length));
      this.values = flagArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new bool[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((bool[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, this.IsNull(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (bool[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
