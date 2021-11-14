// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DecimalStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class DecimalStorage : DataStorage
  {
    private static readonly Decimal defaultValue;
    private Decimal[] values;

    internal DecimalStorage(DataColumn column)
      : base(column, typeof (Decimal), (object) DecimalStorage.defaultValue)
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
            Decimal defaultValue1 = DecimalStorage.defaultValue;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                defaultValue1 += this.values[record];
                flag = true;
              }
            }
            return flag ? (object) defaultValue1 : this.NullValue;
          case AggregateType.Mean:
            Decimal defaultValue2 = DecimalStorage.defaultValue;
            int num1 = 0;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                defaultValue2 += this.values[record];
                ++num1;
                flag = true;
              }
            }
            return flag ? (object) (defaultValue2 / (Decimal) num1) : this.NullValue;
          case AggregateType.Min:
            Decimal val2_1 = Decimal.MaxValue;
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
            Decimal val2_2 = Decimal.MinValue;
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
            double defaultValue3 = (double) DecimalStorage.defaultValue;
            double defaultValue4 = (double) DecimalStorage.defaultValue;
            double defaultValue5 = (double) DecimalStorage.defaultValue;
            double defaultValue6 = (double) DecimalStorage.defaultValue;
            foreach (int record in records)
            {
              if (this.HasValue(record))
              {
                defaultValue5 += (double) this.values[record];
                defaultValue6 += (double) this.values[record] * (double) this.values[record];
                ++num2;
              }
            }
            if (num2 <= 1)
              return this.NullValue;
            double num3 = (double) num2 * defaultValue6;
            double num4 = defaultValue5;
            double num5 = num4 * num4;
            double num6 = num3 - num5;
            double num7 = num6;
            double num8 = defaultValue5;
            double num9 = num8 * num8;
            double d;
            if (num7 / num9 < 1E-15 || num6 < 0.0)
            {
              d = 0.0;
            }
            else
            {
              double num10 = num6;
              int num11 = num2;
              double num12 = (double) (num11 * (num11 - 1));
              d = num10 / num12;
            }
            return kind == AggregateType.StDev ? (object) Math.Sqrt(d) : (object) d;
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (Decimal));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      Decimal d1 = this.values[recordNo1];
      Decimal d2 = this.values[recordNo2];
      if (d1 == DecimalStorage.defaultValue || d2 == DecimalStorage.defaultValue)
      {
        int num = this.CompareBits(recordNo1, recordNo2);
        if (num != 0)
          return num;
      }
      return Decimal.Compare(d1, d2);
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(0 <= recordNo, "Invalid record");
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        return !this.HasValue(recordNo) ? 0 : 1;
      Decimal d1 = this.values[recordNo];
      return DecimalStorage.defaultValue == d1 && !this.HasValue(recordNo) ? -1 : Decimal.Compare(d1, (Decimal) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
      {
        if (value != null)
        {
          if (!(value is Decimal num3))
            num3 = ((IConvertible) value).ToDecimal(this.FormatProvider);
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

    public override object Get(int record) => !this.HasValue(record) ? this.NullValue : (object) this.values[record];

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = DecimalStorage.defaultValue;
        this.SetNullBit(record, true);
      }
      else
      {
        Decimal[] values = this.values;
        int index = record;
        if (!(value is Decimal num2))
          num2 = ((IConvertible) value).ToDecimal(this.FormatProvider);
        values[index] = num2;
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      Decimal[] numArray = new Decimal[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) numArray, 0, Math.Min(capacity, this.values.Length));
      this.values = numArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new Decimal[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((Decimal[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, !this.HasValue(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (Decimal[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
