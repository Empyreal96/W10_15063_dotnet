// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.StringStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class StringStorage : DataStorage
  {
    private string[] values;

    public StringStorage(DataColumn column)
      : base(column, typeof (string), (object) string.Empty)
    {
    }

    public override object Aggregate(int[] recordNos, AggregateType kind)
    {
      switch (kind)
      {
        case AggregateType.Min:
          int num1 = -1;
          int index1;
          for (index1 = 0; index1 < recordNos.Length; ++index1)
          {
            if (!this.IsNull(recordNos[index1]))
            {
              num1 = recordNos[index1];
              break;
            }
          }
          if (num1 < 0)
            return this.NullValue;
          for (int index2 = index1 + 1; index2 < recordNos.Length; ++index2)
          {
            if (!this.IsNull(recordNos[index2]) && this.Compare(num1, recordNos[index2]) > 0)
              num1 = recordNos[index2];
          }
          return this.Get(num1);
        case AggregateType.Max:
          int num2 = -1;
          int index3;
          for (index3 = 0; index3 < recordNos.Length; ++index3)
          {
            if (!this.IsNull(recordNos[index3]))
            {
              num2 = recordNos[index3];
              break;
            }
          }
          if (num2 < 0)
            return this.NullValue;
          for (int index2 = index3 + 1; index2 < recordNos.Length; ++index2)
          {
            if (this.Compare(num2, recordNos[index2]) < 0)
              num2 = recordNos[index2];
          }
          return this.Get(num2);
        case AggregateType.Count:
          int num3 = 0;
          for (int index2 = 0; index2 < recordNos.Length; ++index2)
          {
            if (this.values[recordNos[index2]] != null)
              ++num3;
          }
          return (object) num3;
        default:
          throw ExceptionBuilder.AggregateException(kind, this.DataType);
      }
    }

    public override int Compare(int recordNo1, int recordNo2)
    {
      string s1 = this.values[recordNo1];
      string s2 = this.values[recordNo2];
      if ((object) s1 == (object) s2)
        return 0;
      if (s1 == null)
        return -1;
      return s2 == null ? 1 : this.Table.Compare(s1, s2);
    }

    public override int CompareValueTo(int recordNo, object value)
    {
      Debug.Assert(recordNo != -1, "Invalid (-1) parameter: 'recordNo'");
      Debug.Assert(value != null, "null value");
      string s1 = this.values[recordNo];
      return s1 == null ? (this.NullValue == value ? 0 : -1) : (this.NullValue == value ? 1 : this.Table.Compare(s1, (string) value));
    }

    public override object ConvertValue(object value)
    {
      if (this.NullValue != value)
        value = value == null ? this.NullValue : (object) value.ToString();
      return value;
    }

    public override void Copy(int recordNo1, int recordNo2) => this.values[recordNo2] = this.values[recordNo1];

    public override object Get(int recordNo) => (object) this.values[recordNo] ?? this.NullValue;

    public override int GetStringLength(int record)
    {
      string str = this.values[record];
      return str == null ? 0 : str.Length;
    }

    public override bool IsNull(int record) => this.values[record] == null;

    public override void Set(int record, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        this.values[record] = (string) null;
      else
        this.values[record] = value.ToString();
    }

    public override void SetCapacity(int capacity)
    {
      string[] strArray = new string[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) strArray, 0, Math.Min(capacity, this.values.Length));
      this.values = strArray;
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new string[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      ((string[]) store)[storeIndex] = this.values[record];
      nullbits.Set(storeIndex, this.IsNull(record));
    }

    protected override void SetStorage(object store, BitArray nullbits) => this.values = (string[]) store;
  }
}
