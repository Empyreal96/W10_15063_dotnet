// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.ObjectStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class ObjectStorage : DataStorage
  {
    private static readonly object defaultValue;
    private object[] values;

    internal ObjectStorage(DataColumn column, Type type)
      : base(column, type, ObjectStorage.defaultValue, (object) DBNull.Value, typeof (Microsoft.Phone.Data.Workaround.ICloneable).IsAssignableFrom(type))
    {
    }

    public override object Aggregate(int[] records, AggregateType kind) => throw ExceptionBuilder.AggregateException(kind, this.DataType);

    public override int Compare(int recordNo1, int recordNo2)
    {
      object valueNo1 = this.values[recordNo1];
      object valueNo2 = this.values[recordNo2];
      if (valueNo1 == valueNo2)
        return 0;
      if (valueNo1 == null)
        return -1;
      if (valueNo2 == null)
        return 1;
      if (valueNo1 is IComparable comparable)
      {
        try
        {
          return comparable.CompareTo(valueNo2);
        }
        catch (ArgumentException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
      }
      return this.CompareWithFamilies(valueNo1, valueNo2);
    }

    public override int CompareValueTo(int recordNo1, object value)
    {
      object valueNo1 = this.Get(recordNo1);
      if (valueNo1 is IComparable && value.GetType() == valueNo1.GetType())
        return ((IComparable) valueNo1).CompareTo(value);
      if (valueNo1 == value)
        return 0;
      return valueNo1 == null ? (this.NullValue == value ? 0 : -1) : (this.NullValue == value || value == null ? 1 : this.CompareWithFamilies(valueNo1, value));
    }

    private int CompareTo(object valueNo1, object valueNo2)
    {
      if (valueNo1 == null)
        return -1;
      if (valueNo2 == null)
        return 1;
      if (valueNo1 == valueNo2)
        return 0;
      if (valueNo1 == this.NullValue)
        return -1;
      if (valueNo2 == this.NullValue)
        return 1;
      if (valueNo1 is IComparable)
      {
        try
        {
          return ((IComparable) valueNo1).CompareTo(valueNo2);
        }
        catch (ArgumentException ex)
        {
          ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        }
      }
      return this.CompareWithFamilies(valueNo1, valueNo2);
    }

    private int CompareWithFamilies(object valueNo1, object valueNo2)
    {
      ObjectStorage.Families family1 = this.GetFamily(valueNo1.GetType());
      ObjectStorage.Families family2 = this.GetFamily(valueNo2.GetType());
      if (family1 < family2)
        return -1;
      if (family1 > family2)
        return 1;
      switch (family1)
      {
        case ObjectStorage.Families.DATETIME:
          valueNo1 = (object) Convert.ToDateTime(valueNo1, this.FormatProvider);
          valueNo2 = (object) Convert.ToDateTime(valueNo1, this.FormatProvider);
          break;
        case ObjectStorage.Families.NUMBER:
          valueNo1 = (object) Convert.ToDouble(valueNo1, this.FormatProvider);
          valueNo2 = (object) Convert.ToDouble(valueNo2, this.FormatProvider);
          break;
        case ObjectStorage.Families.BOOLEAN:
          valueNo1 = (object) Convert.ToBoolean(valueNo1, this.FormatProvider);
          valueNo2 = (object) Convert.ToBoolean(valueNo2, this.FormatProvider);
          break;
        case ObjectStorage.Families.ARRAY:
          Array array1 = (Array) valueNo1;
          Array array2 = (Array) valueNo2;
          if (array1.Length > array2.Length)
            return 1;
          if (array1.Length < array2.Length)
            return -1;
          for (int index = 0; index < array1.Length; ++index)
          {
            int num = this.CompareTo(array1.GetValue(index), array2.GetValue(index));
            if (num != 0)
              return num;
          }
          return 0;
        default:
          valueNo1 = (object) valueNo1.ToString();
          valueNo2 = (object) valueNo2.ToString();
          break;
      }
      return ((IComparable) valueNo1).CompareTo(valueNo2);
    }

    public override void Copy(int recordNo1, int recordNo2) => this.values[recordNo2] = this.values[recordNo1];

    public override object Get(int recordNo) => this.values[recordNo] ?? this.NullValue;

    private ObjectStorage.Families GetFamily(Type dataType)
    {
      switch (Type.GetTypeCode(dataType))
      {
        case TypeCode.Boolean:
          return ObjectStorage.Families.BOOLEAN;
        case TypeCode.Char:
          return ObjectStorage.Families.STRING;
        case TypeCode.SByte:
          return ObjectStorage.Families.STRING;
        case TypeCode.Byte:
          return ObjectStorage.Families.STRING;
        case TypeCode.Int16:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.UInt16:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.Int32:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.UInt32:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.Int64:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.UInt64:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.Single:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.Double:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.Decimal:
          return ObjectStorage.Families.NUMBER;
        case TypeCode.DateTime:
          return ObjectStorage.Families.DATETIME;
        case TypeCode.String:
          return ObjectStorage.Families.STRING;
        default:
          if (typeof (TimeSpan) == dataType)
            return ObjectStorage.Families.DATETIME;
          return dataType.IsArray ? ObjectStorage.Families.ARRAY : ObjectStorage.Families.STRING;
      }
    }

    public override bool IsNull(int record) => this.values[record] == null;

    public override void Set(int recordNo, object value)
    {
      Debug.Assert(value != null, "null value");
      if (this.NullValue == value)
        this.values[recordNo] = (object) null;
      else if (this.DataType == typeof (object) || this.DataType.IsInstanceOfType(value))
      {
        this.values[recordNo] = value;
      }
      else
      {
        Type type = value.GetType();
        if (this.DataType == typeof (Guid) && type == typeof (string))
        {
          this.values[recordNo] = (object) new Guid((string) value);
        }
        else
        {
          if (this.DataType != typeof (byte[]))
            throw ExceptionBuilder.StorageSetFailed();
          if (type == typeof (bool))
            this.values[recordNo] = (object) BitConverter.GetBytes((bool) value);
          else if (type == typeof (char))
            this.values[recordNo] = (object) BitConverter.GetBytes((char) value);
          else if (type == typeof (short))
            this.values[recordNo] = (object) BitConverter.GetBytes((short) value);
          else if (type == typeof (int))
            this.values[recordNo] = (object) BitConverter.GetBytes((int) value);
          else if (type == typeof (long))
            this.values[recordNo] = (object) BitConverter.GetBytes((long) value);
          else if (type == typeof (ushort))
            this.values[recordNo] = (object) BitConverter.GetBytes((ushort) value);
          else if (type == typeof (uint))
            this.values[recordNo] = (object) BitConverter.GetBytes((uint) value);
          else if (type == typeof (ulong))
            this.values[recordNo] = (object) BitConverter.GetBytes((ulong) value);
          else if (type == typeof (float))
          {
            this.values[recordNo] = (object) BitConverter.GetBytes((float) value);
          }
          else
          {
            if (type != typeof (double))
              throw ExceptionBuilder.StorageSetFailed();
            this.values[recordNo] = (object) BitConverter.GetBytes((double) value);
          }
        }
      }
    }

    public override void SetCapacity(int capacity)
    {
      object[] objArray = new object[capacity];
      if (this.values != null)
        Array.Copy((Array) this.values, 0, (Array) objArray, 0, Math.Min(capacity, this.values.Length));
      this.values = objArray;
    }

    protected override object GetEmptyStorage(int recordCount) => (object) new object[recordCount];

    protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
    {
      object[] objArray = (object[]) store;
      objArray[storeIndex] = this.values[record];
      bool flag = this.IsNull(record);
      nullbits.Set(storeIndex, flag);
      if (flag || !(objArray[storeIndex] is DateTime))
        return;
      DateTime dateTime = (DateTime) objArray[storeIndex];
      if (dateTime.Kind != DateTimeKind.Local)
        return;
      objArray[storeIndex] = (object) DateTime.SpecifyKind(dateTime.ToUniversalTime(), DateTimeKind.Local);
    }

    protected override void SetStorage(object store, BitArray nullbits)
    {
      this.values = (object[]) store;
      for (int index = 0; index < this.values.Length; ++index)
      {
        if (this.values[index] is DateTime)
        {
          DateTime dateTime = (DateTime) this.values[index];
          if (dateTime.Kind == DateTimeKind.Local)
            this.values[index] = (object) DateTime.SpecifyKind(dateTime, DateTimeKind.Utc).ToLocalTime();
        }
      }
    }

    private enum Families
    {
      DATETIME,
      NUMBER,
      STRING,
      BOOLEAN,
      ARRAY,
    }
  }
}
