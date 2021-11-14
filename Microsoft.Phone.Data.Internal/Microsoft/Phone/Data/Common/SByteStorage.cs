// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.SByteStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class SByteStorage : DataStorage
  {
    private const sbyte defaultValue = 0;
    private sbyte[] values;

    public SByteStorage(DataColumn column)
      : base(column, typeof (sbyte), (object) (sbyte) 0)
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
              if (!this.IsNull(record))
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
              if (!this.IsNull(record))
              {
                checked { num2 += (long) this.values[record]; }
                ++num3;
                flag = true;
              }
            }
            return flag ? (object) checked ((sbyte) unchecked (num2 / (long) num3)) : this.NullValue;
          case AggregateType.Min:
            sbyte val2_1 = sbyte.MaxValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (!this.IsNull(record))
              {
                val2_1 = Math.Min(this.values[record], val2_1);
                flag = true;
              }
            }
            return flag ? (object) val2_1 : this.NullValue;
          case AggregateType.Max:
            sbyte val2_2 = sbyte.MinValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (!this.IsNull(record))
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
              if (!this.IsNull(record))
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
        throw ExprException.Overflow(typeof (sbyte));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      sbyte num1 = this.values[recordNo1];
      sbyte num2 = this.values[recordNo2];
      if (num1.Equals((sbyte) 0) || num2.Equals((sbyte) 0))
      {
        int num3 = this.CompareBits(recordNo1, recordNo2);
        if (num3 != 0)
          return num3;
      }
      return num1.CompareTo(num2);
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(0 <= recordNo, "Invalid record");
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        return this.IsNull(recordNo) ? 0 : 1;
      sbyte num = this.values[recordNo];
      return num == (sbyte) 0 && this.IsNull(recordNo) ? -1 : num.CompareTo((sbyte) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
        value = value == null ? this.NullValue : (object) (sbyte) (value is sbyte num2 ? (int) num2 : (int) ((IConvertible) value).ToSByte(this.FormatProvider));
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2)
    {
      this.CopyBits(recordNo1, recordNo2);
      this.values[recordNo2] = this.values[recordNo1];
    }

    public override object Get(int record)
    {
      sbyte num = this.values[record];
      return !num.Equals((sbyte) 0) ? (object) num : this.GetBits(record);
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = (sbyte) 0;
        this.SetNullBit(record, true);
      }
      else
      {
        this.values[record] = value is sbyte num2 ? num2 : ((IConvertible) value).ToSByte(this.FormatProvider);
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      sbyte[] numArray = new sbyte[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) numArray, 0, Math.Min(capacity, this.values.Length));
      this.values = numArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new sbyte[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((sbyte[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, this.IsNull(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (sbyte[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
