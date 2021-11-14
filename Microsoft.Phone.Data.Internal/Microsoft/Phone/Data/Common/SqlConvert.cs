// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.SqlConvert
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Xml;

namespace Microsoft.Phone.Data.Common
{
  internal static class SqlConvert
  {
    public static object ChangeType(object value, Type type, IFormatProvider formatProvider) => SqlConvert.ChangeType2(value, DataStorage.GetStorageType(type), type, formatProvider);

    public static object ChangeType2(
      object value,
      StorageType stype,
      Type type,
      IFormatProvider formatProvider)
    {
      if (DBNull.Value == value || value == null)
        return (object) DBNull.Value;
      StorageType storageType = DataStorage.GetStorageType(value.GetType());
      if (StorageType.String == stype)
      {
        switch (storageType)
        {
          case StorageType.Boolean:
            return (object) ((IConvertible) (bool) value).ToString(formatProvider);
          case StorageType.Char:
            return (object) ((IConvertible) (char) value).ToString(formatProvider);
          case StorageType.SByte:
            return (object) ((IConvertible) (sbyte) value).ToString(formatProvider);
          case StorageType.Byte:
            return (object) ((IConvertible) (byte) value).ToString(formatProvider);
          case StorageType.Int16:
            return (object) ((IConvertible) (short) value).ToString(formatProvider);
          case StorageType.UInt16:
            return (object) ((IConvertible) (ushort) value).ToString(formatProvider);
          case StorageType.Int32:
            return (object) ((IConvertible) (int) value).ToString(formatProvider);
          case StorageType.UInt32:
            return (object) ((IConvertible) (uint) value).ToString(formatProvider);
          case StorageType.Int64:
            return (object) ((IConvertible) (long) value).ToString(formatProvider);
          case StorageType.UInt64:
            return (object) ((IConvertible) (ulong) value).ToString(formatProvider);
          case StorageType.Single:
            return (object) ((IConvertible) (float) value).ToString(formatProvider);
          case StorageType.Double:
            return (object) ((IConvertible) (double) value).ToString(formatProvider);
          case StorageType.Decimal:
            return (object) ((IConvertible) value).ToString(formatProvider);
          case StorageType.DateTime:
            return (object) ((IConvertible) value).ToString(formatProvider);
          case StorageType.TimeSpan:
            return (object) XmlConvert.ToString((TimeSpan) value);
          case StorageType.String:
            return (object) (string) value;
          case StorageType.Guid:
            return (object) XmlConvert.ToString((Guid) value);
          case StorageType.CharArray:
            return (object) new string((char[]) value);
          default:
            switch (value)
            {
              case IConvertible convertible3:
                return (object) convertible3.ToString(formatProvider);
              case IFormattable formattable3:
                return (object) formattable3.ToString((string) null, formatProvider);
              default:
                return (object) value.ToString();
            }
        }
      }
      else if (StorageType.TimeSpan == stype)
      {
        switch (storageType)
        {
          case StorageType.Int32:
            return (object) new TimeSpan((long) (int) value);
          case StorageType.Int64:
            return (object) new TimeSpan((long) value);
          case StorageType.String:
            return (object) XmlConvert.ToTimeSpan((string) value);
          default:
            return (object) (TimeSpan) value;
        }
      }
      else
      {
        if (StorageType.String == storageType)
        {
          switch (stype)
          {
            case StorageType.Boolean:
              if ("1" == (string) value)
                return (object) true;
              if ("0" == (string) value)
                return (object) false;
              break;
            case StorageType.Char:
              return (object) ((IConvertible) (string) value).ToChar(formatProvider);
            case StorageType.SByte:
              return (object) ((IConvertible) (string) value).ToSByte(formatProvider);
            case StorageType.Byte:
              return (object) ((IConvertible) (string) value).ToByte(formatProvider);
            case StorageType.Int16:
              return (object) ((IConvertible) (string) value).ToInt16(formatProvider);
            case StorageType.UInt16:
              return (object) ((IConvertible) (string) value).ToUInt16(formatProvider);
            case StorageType.Int32:
              return (object) ((IConvertible) (string) value).ToInt32(formatProvider);
            case StorageType.UInt32:
              return (object) ((IConvertible) (string) value).ToUInt32(formatProvider);
            case StorageType.Int64:
              return (object) ((IConvertible) (string) value).ToInt64(formatProvider);
            case StorageType.UInt64:
              return (object) ((IConvertible) (string) value).ToUInt64(formatProvider);
            case StorageType.Single:
              return (object) ((IConvertible) (string) value).ToSingle(formatProvider);
            case StorageType.Double:
              return (object) ((IConvertible) (string) value).ToDouble(formatProvider);
            case StorageType.Decimal:
              return (object) ((IConvertible) (string) value).ToDecimal(formatProvider);
            case StorageType.DateTime:
              return (object) ((IConvertible) (string) value).ToDateTime(formatProvider);
            case StorageType.TimeSpan:
              return (object) XmlConvert.ToTimeSpan((string) value);
            case StorageType.String:
              return (object) (string) value;
            case StorageType.Guid:
              return (object) XmlConvert.ToGuid((string) value);
            case StorageType.Uri:
              return (object) new Uri((string) value);
          }
        }
        return Convert.ChangeType(value, type, formatProvider);
      }
    }
  }
}
