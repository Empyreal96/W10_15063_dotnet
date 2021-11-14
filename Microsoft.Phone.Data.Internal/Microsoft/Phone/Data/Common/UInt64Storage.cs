// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.UInt64Storage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class UInt64Storage : DataStorage
  {
    private static readonly ulong defaultValue;
    private ulong[] values;

    public UInt64Storage(DataColumn column)
      : base(column, typeof (ulong), (object) UInt64Storage.defaultValue)
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
            ulong defaultValue1 = UInt64Storage.defaultValue;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                checked { defaultValue1 += this.values[record]; }
                flag = true;
              }
            }
            return flag ? (object) defaultValue1 : this.NullValue;
          case AggregateType.Mean:
            Decimal defaultValue2 = (Decimal) UInt64Storage.defaultValue;
            int num1 = 0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                defaultValue2 += (Decimal) this.values[record];
                ++num1;
                flag = true;
              }
            }
            return flag ? (object) (ulong) (defaultValue2 / (Decimal) num1) : this.NullValue;
          case AggregateType.Min:
            ulong val2_1 = ulong.MaxValue;
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
            ulong val2_2 = 0;
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
            return base.Aggregate(records, kind);
          case AggregateType.Var:
          case AggregateType.StDev:
            int num2 = 0;
            double num3 = 0.0;
            double num4 = 0.0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                num3 += (double) this.values[record];
                num4 += (double) this.values[record] * (double) this.values[record];
                ++num2;
              }
            }
            if (num2 <= 1)
              return this.NullValue;
            double num5 = (double) num2 * num4;
            double num6 = num3;
            double num7 = num6 * num6;
            double num8 = num5 - num7;
            double num9 = num8;
            double num10 = num3;
            double num11 = num10 * num10;
            double d;
            if (num9 / num11 < 1E-15 || num8 < 0.0)
            {
              d = 0.0;
            }
            else
            {
              double num12 = num8;
              int num13 = num2;
              double num14 = (double) (num13 * (num13 - 1));
              d = num12 / num14;
            }
            return kind == AggregateType.StDev ? (object) Math.Sqrt(d) : (object) d;
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (ulong));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      ulong num1 = this.values[recordNo1];
      ulong num2 = this.values[recordNo2];
      if (num1.Equals(UInt64Storage.defaultValue) || num2.Equals(UInt64Storage.defaultValue))
      {
        int num3 = this.CompareBits(recordNo1, recordNo2);
        if (num3 != 0)
          return num3;
      }
      if (num1 < num2)
        return -1;
      return num1 <= num2 ? 0 : 1;
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(0 <= recordNo, "Invalid record");
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        return !this.HasValue(recordNo) ? 0 : 1;
      ulong num = this.values[recordNo];
      return (long) UInt64Storage.defaultValue == (long) num && !this.HasValue(recordNo) ? -1 : num.CompareTo((ulong) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
        value = value == null ? this.NullValue : (object) (ulong) (value is ulong num2 ? (long) num2 : (long) ((IConvertible) value).ToUInt64(this.FormatProvider));
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2)
    {
      this.CopyBits(recordNo1, recordNo2);
      this.values[recordNo2] = this.values[recordNo1];
    }

    public override object Get(int record)
    {
      ulong num = this.values[record];
      return !num.Equals(UInt64Storage.defaultValue) ? (object) num : this.GetBits(record);
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = UInt64Storage.defaultValue;
        this.SetNullBit(record, true);
      }
      else
      {
        this.values[record] = value is ulong num2 ? num2 : ((IConvertible) value).ToUInt64(this.FormatProvider);
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      ulong[] numArray = new ulong[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) numArray, 0, Math.Min(capacity, this.values.Length));
      this.values = numArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new ulong[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((ulong[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, !this.HasValue(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (ulong[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
