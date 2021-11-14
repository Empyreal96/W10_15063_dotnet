// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.Int64Storage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class Int64Storage : DataStorage
  {
    private const long defaultValue = 0;
    private long[] values;

    internal Int64Storage(DataColumn column)
      : base(column, typeof (long), (object) 0L)
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
            long num1 = 0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                checked { num1 += this.values[record]; }
                flag = true;
              }
            }
            return flag ? (object) num1 : this.NullValue;
          case AggregateType.Mean:
            Decimal num2 = 0M;
            int num3 = 0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                num2 += (Decimal) this.values[record];
                ++num3;
                flag = true;
              }
            }
            return flag ? (object) (long) (num2 / (Decimal) num3) : this.NullValue;
          case AggregateType.Min:
            long val2_1 = long.MaxValue;
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
            long val2_2 = long.MinValue;
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
            int num4 = 0;
            double num5 = 0.0;
            double num6 = 0.0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                num5 += (double) this.values[record];
                num6 += (double) this.values[record] * (double) this.values[record];
                ++num4;
              }
            }
            if (num4 <= 1)
              return this.NullValue;
            double num7 = (double) num4 * num6;
            double num8 = num5;
            double num9 = num8 * num8;
            double num10 = num7 - num9;
            double num11 = num10;
            double num12 = num5;
            double num13 = num12 * num12;
            double d;
            if (num11 / num13 < 1E-15 || num10 < 0.0)
            {
              d = 0.0;
            }
            else
            {
              double num14 = num10;
              int num15 = num4;
              double num16 = (double) (num15 * (num15 - 1));
              d = num14 / num16;
            }
            return kind == AggregateType.StDev ? (object) Math.Sqrt(d) : (object) d;
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (long));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      long num1 = this.values[recordNo1];
      long num2 = this.values[recordNo2];
      if (num1 == 0L || num2 == 0L)
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
      long num = this.values[recordNo];
      return num == 0L && !this.HasValue(recordNo) ? -1 : num.CompareTo((long) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
      {
        if (value != null)
        {
          if (!(value is long num3))
            num3 = ((IConvertible) value).ToInt64(this.FormatProvider);
          value = (object) num3;
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
      long num = this.values[record];
      return num != 0L ? (object) num : this.GetBits(record);
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = 0L;
        this.SetNullBit(record, true);
      }
      else
      {
        long[] values = this.values;
        int index = record;
        if (!(value is long num2))
          num2 = ((IConvertible) value).ToInt64(this.FormatProvider);
        values[index] = num2;
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      long[] numArray = new long[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) numArray, 0, Math.Min(capacity, this.values.Length));
      this.values = numArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new long[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((long[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, !this.HasValue(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (long[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
