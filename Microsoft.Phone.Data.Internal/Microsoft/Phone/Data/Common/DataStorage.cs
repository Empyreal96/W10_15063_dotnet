// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DataStorage
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Microsoft.Phone.Data.Common
{
  internal abstract class DataStorage
  {
    private static readonly Type[] StorageClassType = new Type[24]
    {
      null,
      typeof (object),
      typeof (DBNull),
      typeof (bool),
      typeof (char),
      typeof (sbyte),
      typeof (byte),
      typeof (short),
      typeof (ushort),
      typeof (int),
      typeof (uint),
      typeof (long),
      typeof (ulong),
      typeof (float),
      typeof (double),
      typeof (Decimal),
      typeof (DateTime),
      typeof (TimeSpan),
      typeof (string),
      typeof (Guid),
      typeof (byte[]),
      typeof (char[]),
      typeof (Type),
      typeof (Uri)
    };
    internal readonly DataColumn Column;
    internal readonly DataTable Table;
    internal readonly Type DataType;
    internal readonly StorageType StorageTypeCode;
    private BitArray dbNullBits;
    private readonly object DefaultValue;
    internal readonly object NullValue;
    internal readonly bool IsCloneable;
    internal readonly bool IsCustomDefinedType;
    internal readonly bool IsStringType;
    internal readonly bool IsValueType;

    protected DataStorage(DataColumn column, Type type, object defaultValue)
      : this(column, type, defaultValue, (object) DBNull.Value, false)
    {
    }

    protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue)
      : this(column, type, defaultValue, nullValue, false)
    {
    }

    protected DataStorage(
      DataColumn column,
      Type type,
      object defaultValue,
      object nullValue,
      bool isICloneable)
    {
      this.Column = column;
      this.Table = column.Table;
      this.DataType = type;
      this.StorageTypeCode = DataStorage.GetStorageType(type);
      this.DefaultValue = defaultValue;
      this.NullValue = nullValue;
      this.IsCloneable = isICloneable;
      this.IsCustomDefinedType = DataStorage.IsTypeCustomType(this.StorageTypeCode);
      this.IsStringType = StorageType.String == this.StorageTypeCode || StorageType.SqlString == this.StorageTypeCode;
      this.IsValueType = DataStorage.DetermineIfValueType(this.StorageTypeCode, type);
    }

    internal DataSetDateTime DateTimeMode => this.Column.DateTimeMode;

    internal IFormatProvider FormatProvider => this.Table.FormatProvider;

    public virtual object Aggregate(int[] recordNos, AggregateType kind)
    {
      if (AggregateType.Count != kind)
        return (object) null;
      int num = 0;
      for (int index = 0; index < recordNos.Length; ++index)
      {
        if (!this.dbNullBits.Get(recordNos[index]))
          ++num;
      }
      return (object) num;
    }

    protected int CompareBits(int recordNo1, int recordNo2)
    {
      bool flag1 = this.dbNullBits.Get(recordNo1);
      bool flag2 = this.dbNullBits.Get(recordNo2);
      if (!(flag1 ^ flag2))
        return 0;
      return flag1 ? -1 : 1;
    }

    public virtual int Compare(int recordNo1, int recordNo2)
    {
      object obj1 = this.Get(recordNo1);
      if (obj1 is IComparable)
      {
        object obj2 = this.Get(recordNo2);
        if (obj2.GetType() == obj1.GetType())
          return ((IComparable) obj1).CompareTo(obj2);
        this.CompareBits(recordNo1, recordNo2);
      }
      return 0;
    }

    public abstract int CompareValueTo(int recordNo1, object value);

    public virtual object ConvertValue(object value) => value;

    protected void CopyBits(int srcRecordNo, int dstRecordNo) => this.dbNullBits.Set(dstRecordNo, this.dbNullBits.Get(srcRecordNo));

    public abstract void Copy(int recordNo1, int recordNo2);

    public abstract object Get(int recordNo);

    protected object GetBits(int recordNo) => this.dbNullBits.Get(recordNo) ? this.NullValue : this.DefaultValue;

    public virtual int GetStringLength(int record)
    {
      Debug.Assert(false, "not a String or SqlString column");
      return int.MaxValue;
    }

    protected bool HasValue(int recordNo) => !this.dbNullBits.Get(recordNo);

    public virtual bool IsNull(int recordNo) => this.dbNullBits.Get(recordNo);

    public abstract void Set(int recordNo, object value);

    protected void SetNullBit(int recordNo, bool flag) => this.dbNullBits.Set(recordNo, flag);

    public virtual void SetCapacity(int capacity)
    {
      if (this.dbNullBits == null)
        this.dbNullBits = new BitArray(capacity);
      else
        this.dbNullBits.Length = capacity;
    }

    public static DataStorage CreateStorage(DataColumn column, Type dataType)
    {
      StorageType storageType = DataStorage.GetStorageType(dataType);
      if (storageType == StorageType.Empty && dataType != null)
        return (DataStorage) new ObjectStorage(column, dataType);
      switch (storageType)
      {
        case StorageType.Empty:
          throw ExceptionBuilder.InvalidStorageType(TypeCode.Empty);
        case StorageType.Object:
          return (DataStorage) new ObjectStorage(column, dataType);
        case StorageType.DBNull:
          throw ExceptionBuilder.InvalidStorageType(TypeCode.DBNull);
        case StorageType.Boolean:
          return (DataStorage) new BooleanStorage(column);
        case StorageType.Char:
          return (DataStorage) new CharStorage(column);
        case StorageType.SByte:
          return (DataStorage) new SByteStorage(column);
        case StorageType.Byte:
          return (DataStorage) new ByteStorage(column);
        case StorageType.Int16:
          return (DataStorage) new Int16Storage(column);
        case StorageType.UInt16:
          return (DataStorage) new UInt16Storage(column);
        case StorageType.Int32:
          return (DataStorage) new Int32Storage(column);
        case StorageType.UInt32:
          return (DataStorage) new UInt32Storage(column);
        case StorageType.Int64:
          return (DataStorage) new Int64Storage(column);
        case StorageType.UInt64:
          return (DataStorage) new UInt64Storage(column);
        case StorageType.Single:
          return (DataStorage) new SingleStorage(column);
        case StorageType.Double:
          return (DataStorage) new DoubleStorage(column);
        case StorageType.Decimal:
          return (DataStorage) new DecimalStorage(column);
        case StorageType.DateTime:
          return (DataStorage) new DateTimeStorage(column);
        case StorageType.TimeSpan:
          return (DataStorage) new TimeSpanStorage(column);
        case StorageType.String:
          return (DataStorage) new StringStorage(column);
        case StorageType.Guid:
          return (DataStorage) new ObjectStorage(column, dataType);
        case StorageType.ByteArray:
          return (DataStorage) new ObjectStorage(column, dataType);
        case StorageType.CharArray:
          return (DataStorage) new ObjectStorage(column, dataType);
        case StorageType.Type:
          return (DataStorage) new ObjectStorage(column, dataType);
        case StorageType.Uri:
          return (DataStorage) new ObjectStorage(column, dataType);
        default:
          Debug.Assert(false, "shouldn't be here");
          goto case StorageType.Object;
      }
    }

    internal static StorageType GetStorageType(Type dataType)
    {
      for (int index = 0; index < DataStorage.StorageClassType.Length; ++index)
      {
        if (dataType == DataStorage.StorageClassType[index])
          return (StorageType) index;
      }
      TypeCode typeCode = Type.GetTypeCode(dataType);
      return TypeCode.Object != typeCode ? (StorageType) typeCode : StorageType.Empty;
    }

    internal static Type GetTypeStorage(StorageType storageType) => DataStorage.StorageClassType[(int) storageType];

    internal static bool IsTypeCustomType(Type type) => DataStorage.IsTypeCustomType(DataStorage.GetStorageType(type));

    internal static bool IsTypeCustomType(StorageType typeCode) => StorageType.Object == typeCode || typeCode == StorageType.Empty || StorageType.CharArray == typeCode;

    internal static bool IsSqlType(StorageType storageType) => StorageType.SqlBinary <= storageType;

    public static bool IsSqlType(Type dataType)
    {
      for (int index = 24; index < DataStorage.StorageClassType.Length; ++index)
      {
        if (dataType == DataStorage.StorageClassType[index])
          return true;
      }
      return false;
    }

    private static bool DetermineIfValueType(StorageType typeCode, Type dataType)
    {
      bool flag;
      switch (typeCode)
      {
        case StorageType.Boolean:
        case StorageType.Char:
        case StorageType.SByte:
        case StorageType.Byte:
        case StorageType.Int16:
        case StorageType.UInt16:
        case StorageType.Int32:
        case StorageType.UInt32:
        case StorageType.Int64:
        case StorageType.UInt64:
        case StorageType.Single:
        case StorageType.Double:
        case StorageType.Decimal:
        case StorageType.DateTime:
        case StorageType.TimeSpan:
        case StorageType.Guid:
        case StorageType.SqlBinary:
        case StorageType.SqlBoolean:
        case StorageType.SqlByte:
        case StorageType.SqlDateTime:
        case StorageType.SqlDecimal:
        case StorageType.SqlDouble:
        case StorageType.SqlGuid:
        case StorageType.SqlInt16:
        case StorageType.SqlInt32:
        case StorageType.SqlInt64:
        case StorageType.SqlMoney:
        case StorageType.SqlSingle:
        case StorageType.SqlString:
          flag = true;
          break;
        case StorageType.String:
        case StorageType.ByteArray:
        case StorageType.CharArray:
        case StorageType.Type:
        case StorageType.Uri:
        case StorageType.SqlBytes:
        case StorageType.SqlChars:
          flag = false;
          break;
        default:
          flag = dataType.IsValueType;
          break;
      }
      Debug.Assert(flag == dataType.IsValueType, "typeCode mismatches dataType");
      return flag;
    }

    internal static void ImplementsInterfaces(
      StorageType typeCode,
      Type dataType,
      out bool sqlType,
      out bool nullable,
      out bool xmlSerializable,
      out bool changeTracking,
      out bool revertibleChangeTracking)
    {
      Debug.Assert(typeCode == DataStorage.GetStorageType(dataType), "typeCode mismatches dataType");
      if (DataStorage.IsSqlType(typeCode))
      {
        sqlType = true;
        nullable = true;
        changeTracking = false;
        revertibleChangeTracking = false;
        xmlSerializable = true;
      }
      else if (typeCode != StorageType.Empty)
      {
        sqlType = false;
        nullable = false;
        changeTracking = false;
        revertibleChangeTracking = false;
        xmlSerializable = false;
      }
      else
      {
        sqlType = false;
        nullable = false;
        changeTracking = typeof (IChangeTracking).IsAssignableFrom(dataType);
        revertibleChangeTracking = typeof (IRevertibleChangeTracking).IsAssignableFrom(dataType);
        xmlSerializable = typeof (IXmlSerializable).IsAssignableFrom(dataType);
      }
      Debug.Assert(changeTracking == typeof (IChangeTracking).IsAssignableFrom(dataType), "IChangeTracking");
      Debug.Assert(revertibleChangeTracking == typeof (IRevertibleChangeTracking).IsAssignableFrom(dataType), "IRevertibleChangeTracking");
      Debug.Assert(xmlSerializable == typeof (IXmlSerializable).IsAssignableFrom(dataType), "IXmlSerializable");
    }

    internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType)
    {
      Debug.Assert(typeCode == DataStorage.GetStorageType(dataType), "typeCode mismatches dataType");
      return typeCode == StorageType.Empty && dataType.IsGenericType && dataType.GetGenericTypeDefinition() == typeof (Nullable<>);
    }

    public static bool IsObjectNull(object value) => value == null || DBNull.Value == value || DataStorage.IsObjectSqlNull(value);

    public static bool IsObjectSqlNull(object value) => false;

    protected abstract object GetEmptyStorage(int recordCount);

    protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

    protected abstract void SetStorage(object store, BitArray nullbits);

    protected void SetNullStorage(BitArray nullbits) => this.dbNullBits = nullbits;
  }
}
