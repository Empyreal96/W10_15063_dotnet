// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.UInt16Storage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class UInt16Storage : DataStorage
  {
    private static readonly ushort defaultValue;
    private ushort[] values;

    public UInt16Storage(DataColumn column)
      : base(column, typeof (ushort), (object) UInt16Storage.defaultValue)
    {
    }

    public override object Aggregate(int[] records, AggregateType kind)
    {
      bool flag = false;
      try
      {
        switch (kind)
        {
          case AggregateType.Sum:
            ulong defaultValue1 = (ulong) UInt16Storage.defaultValue;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                checked { defaultValue1 += (ulong) this.values[record]; }
                flag = true;
              }
            }
            return flag ? (object) defaultValue1 : this.NullValue;
          case AggregateType.Mean:
            long defaultValue2 = (long) UInt16Storage.defaultValue;
            int num1 = 0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                checked { defaultValue2 += (long) this.values[record]; }
                ++num1;
                flag = true;
              }
            }
            return flag ? (object) checked ((ushort) unchecked (defaultValue2 / (long) num1)) : this.NullValue;
          case AggregateType.Min:
            ushort val2_1 = ushort.MaxValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (this.HasValue(record))
              {
                val2_1 = Math.Min(this.values[record], val2_1);
                flag = true;
              }
            }
            return flag ? (object) val2_1 : this.NullValue;
          case AggregateType.Max:
            ushort val2_2 = 0;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (this.HasValue(record))
              {
                val2_2 = Math.Max(this.values[record], val2_2);
                flag = true;
              }
            }
            return flag ? (object) val2_2 : this.NullValue;
          case AggregateType.First:
            return records.Length != 0 ? (object) this.values[records[0]] : (object) null;
          case AggregateType.Count:
            int num2 = 0;
            for (int index = 0; index < records.Length; ++index)
            {
              if (this.HasValue(records[index]))
                ++num2;
            }
            return (object) num2;
          case AggregateType.Var:
          case AggregateType.StDev:
            int num3 = 0;
            double num4 = 0.0;
            double num5 = 0.0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                num4 += (double) this.values[record];
                num5 += (double) this.values[record] * (double) this.values[record];
                ++num3;
              }
            }
            if (num3 <= 1)
              return this.NullValue;
            double num6 = (double) num3 * num5;
            double num7 = num4;
            double num8 = num7 * num7;
            double num9 = num6 - num8;
            double num10 = num9;
            double num11 = num4;
            double num12 = num11 * num11;
            double d;
            if (num10 / num12 < 1E-15 || num9 < 0.0)
            {
              d = 0.0;
            }
            else
            {
              double num13 = num9;
              int num14 = num3;
              double num15 = (double) (num14 * (num14 - 1));
              d = num13 / num15;
            }
            return kind == AggregateType.StDev ? (object) Math.Sqrt(d) : (object) d;
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (ushort));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      ushort num1 = this.values[recordNo1];
      ushort num2 = this.values[recordNo2];
      if ((int) num1 == (int) UInt16Storage.defaultValue || (int) num2 == (int) UInt16Storage.defaultValue)
      {
        int num3 = this.CompareBits(recordNo1, recordNo2);
        if (num3 != 0)
          return num3;
      }
      return (int) num1 - (int) num2;
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(0 <= recordNo, "Invalid record");
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        return !this.HasValue(recordNo) ? 0 : 1;
      ushort num = this.values[recordNo];
      return (int) UInt16Storage.defaultValue == (int) num && !this.HasValue(recordNo) ? -1 : num.CompareTo((ushort) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
        value = value == null ? this.NullValue : (object) (ushort) (value is ushort num2 ? (int) num2 : (int) ((IConvertible) value).ToUInt16(this.FormatProvider));
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2)
    {
      this.CopyBits(recordNo1, recordNo2);
      this.values[recordNo2] = this.values[recordNo1];
    }

    public override object Get(int record)
    {
      ushort num = this.values[record];
      return !num.Equals(UInt16Storage.defaultValue) ? (object) num : this.GetBits(record);
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = UInt16Storage.defaultValue;
        this.SetNullBit(record, true);
      }
      else
      {
        this.values[record] = value is ushort num2 ? num2 : ((IConvertible) value).ToUInt16(this.FormatProvider);
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      ushort[] numArray = new ushort[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) numArray, 0, Math.Min(capacity, this.values.Length));
      this.values = numArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new ushort[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((ushort[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, !this.HasValue(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (ushort[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
