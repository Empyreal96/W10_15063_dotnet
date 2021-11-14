// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.Int16Storage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class Int16Storage : DataStorage
  {
    private const short defaultValue = 0;
    private short[] values;

    internal Int16Storage(DataColumn column)
      : base(column, typeof (short), (object) (short) 0)
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
                checked { num1 += (long) this.values[record]; }
                flag = true;
              }
            }
            return flag ? (object) num1 : this.NullValue;
          case AggregateType.Mean:
            long num2 = 0;
            int num3 = 0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                checked { num2 += (long) this.values[record]; }
                ++num3;
                flag = true;
              }
            }
            return flag ? (object) checked ((short) unchecked (num2 / (long) num3)) : this.NullValue;
          case AggregateType.Min:
            short val2_1 = short.MaxValue;
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
            short val2_2 = short.MinValue;
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
            int num4 = 0;
            for (int index = 0; index < records.Length; ++index)
            {
              if (this.HasValue(records[index]))
                ++num4;
            }
            return (object) num4;
          case AggregateType.Var:
          case AggregateType.StDev:
            int num5 = 0;
            double num6 = 0.0;
            double num7 = 0.0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                num6 += (double) this.values[record];
                num7 += (double) this.values[record] * (double) this.values[record];
                ++num5;
              }
            }
            if (num5 <= 1)
              return this.NullValue;
            double num8 = (double) num5 * num7;
            double num9 = num6;
            double num10 = num9 * num9;
            double num11 = num8 - num10;
            double num12 = num11;
            double num13 = num6;
            double num14 = num13 * num13;
            double d;
            if (num12 / num14 < 1E-15 || num11 < 0.0)
            {
              d = 0.0;
            }
            else
            {
              double num15 = num11;
              int num16 = num5;
              double num17 = (double) (num16 * (num16 - 1));
              d = num15 / num17;
            }
            return kind == AggregateType.StDev ? (object) Math.Sqrt(d) : (object) d;
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (short));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      short num1 = this.values[recordNo1];
      short num2 = this.values[recordNo2];
      if (num1 == (short) 0 || num2 == (short) 0)
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
      short num = this.values[recordNo];
      return num == (short) 0 && !this.HasValue(recordNo) ? -1 : num.CompareTo((short) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
        value = value == null ? this.NullValue : (object) (short) (value is short num2 ? (int) num2 : (int) ((IConvertible) value).ToInt16(this.FormatProvider));
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2)
    {
      this.CopyBits(recordNo1, recordNo2);
      this.values[recordNo2] = this.values[recordNo1];
    }

    public override object Get(int record)
    {
      short num = this.values[record];
      return num != (short) 0 ? (object) num : this.GetBits(record);
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = (short) 0;
        this.SetNullBit(record, true);
      }
      else
      {
        this.values[record] = value is short num2 ? num2 : ((IConvertible) value).ToInt16(this.FormatProvider);
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      short[] numArray = new short[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) numArray, 0, Math.Min(capacity, this.values.Length));
      this.values = numArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new short[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((short[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, !this.HasValue(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (short[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
