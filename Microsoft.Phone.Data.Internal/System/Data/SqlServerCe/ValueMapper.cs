// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.ValueMapper
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using System.Globalization;

namespace System.Data.SqlServerCe
{
  internal class ValueMapper
  {
    private static ValueMapper.ValueMapperDelegate _typeMapperInternal = Type.GetType("System.DateTimeOffset") == null ? new ValueMapper.ValueMapperDelegate(ValueMapper.GetMappedValueNET20RTM) : new ValueMapper.ValueMapperDelegate(ValueMapper.GetMappedValueNET20SP1);

    static ValueMapper() => KillBitHelper.ThrowIfKillBitIsSet();

    public static object GetMappedValue(SqlDbType paramType, object value) => ValueMapper._typeMapperInternal(paramType, value);

    private static object GetMappedValueNET20RTM(SqlDbType paramType, object value)
    {
      switch (value)
      {
        case null:
          return (object) null;
        case DateTime _:
          return ValueMapper.DateTimeMapper(paramType, value);
        case TimeSpan _:
          return ValueMapper.TimeSpanMapper(paramType, value);
        default:
          return value;
      }
    }

    private static object GetMappedValueNET20SP1(SqlDbType paramType, object value)
    {
      switch (value)
      {
        case null:
          return (object) null;
        case DateTime _:
          return ValueMapper.DateTimeMapper(paramType, value);
        case TimeSpan _:
          return ValueMapper.TimeSpanMapper(paramType, value);
        default:
          return value;
      }
    }

    private static object DateTimeMapper(SqlDbType paramType, object value) => paramType == SqlDbType.NChar || paramType == SqlDbType.NVarChar ? (object) ((DateTime) value).ToString("yyyy-MM-dd HH:mm:ss.fffffff", (IFormatProvider) CultureInfo.InvariantCulture) : value;

    private static object TimeSpanMapper(SqlDbType paramType, object value)
    {
      if (paramType != SqlDbType.NChar && paramType != SqlDbType.NVarChar)
        return value;
      TimeSpan timeSpan = (TimeSpan) value;
      DateTime dateTime = DateTime.MinValue;
      dateTime = dateTime.Add(timeSpan);
      return (object) dateTime.ToString("HH:mm:ss.fffffff");
    }

    private static object DateTimeOffsetMapper(SqlDbType paramType, object value) => value;

    private delegate object ValueMapperDelegate(SqlDbType paramType, object value);
  }
}
