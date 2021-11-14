// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.CharStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class CharStorage : DataStorage
  {
    private const char defaultValue = '\0';
    private char[] values;

    internal CharStorage(DataColumn column)
      : base(column, typeof (char), (object) char.MinValue)
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
            char ch1 = char.MaxValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (!this.IsNull(record))
              {
                ch1 = (int) this.values[record] < (int) ch1 ? this.values[record] : ch1;
                flag = true;
              }
            }
            return flag ? (object) ch1 : this.NullValue;
          case AggregateType.Max:
            char ch2 = char.MinValue;
            for (int index = 0; index < records.Length; ++index)
            {
              int record = records[index];
              if (!this.IsNull(record))
              {
                ch2 = (int) this.values[record] > (int) ch2 ? this.values[record] : ch2;
                flag = true;
              }
            }
            return flag ? (object) ch2 : this.NullValue;
          case AggregateType.First:
            return records.Length != 0 ? (object) this.values[records[0]] : (object) null;
          case AggregateType.Count:
            return base.Aggregate(records, kind);
        }
      }
      catch (OverflowException ex)
      {
        throw ExprException.Overflow(typeof (char));
      }
      throw ExceptionBuilder.AggregateException(kind, this.DataType);
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      char ch1 = this.values[recordNo1];
      char ch2 = this.values[recordNo2];
      if (ch1 == char.MinValue || ch2 == char.MinValue)
      {
        int num = this.CompareBits(recordNo1, recordNo2);
        if (num != 0)
          return num;
      }
      return ch1.CompareTo(ch2);
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(0 <= recordNo, "Invalid record");
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        return this.IsNull(recordNo) ? 0 : 1;
      char ch = this.values[recordNo];
      return ch == char.MinValue && this.IsNull(recordNo) ? -1 : ch.CompareTo((char) value);
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
        value = value == null ? this.NullValue : (object) (char) (value is char ch2 ? (int) ch2 : (int) ((IConvertible) value).ToChar(this.FormatProvider));
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2)
    {
      this.CopyBits(recordNo1, recordNo2);
      this.values[recordNo2] = this.values[recordNo1];
    }

    public override object Get(int record)
    {
      char ch = this.values[record];
      return ch != char.MinValue ? (object) ch : this.GetBits(record);
    }

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
      {
        this.values[record] = char.MinValue;
        this.SetNullBit(record, true);
      }
      else
      {
        char charValue = value is char ch2 ? ch2 : ((IConvertible) value).ToChar(this.FormatProvider);
        this.values[record] = (charValue < '\uD800' || charValue > '\uDFFF') && (charValue >= '!' || charValue != '\t' && charValue != '\n' && charValue != '\r') ? charValue : throw ExceptionBuilder.ProblematicChars(charValue);
        this.SetNullBit(record, false);
      }
    }

    public override void SetCapacity(int capacity)
    {
      char[] chArray = new char[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) chArray, 0, Math.Min(capacity, this.values.Length));
      this.values = chArray;
      base.SetCapacity(capacity);
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new char[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((char[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, this.IsNull(record));
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (char[]) store;
      this.SetNullStorage(nullbits);
    }
  }
}
