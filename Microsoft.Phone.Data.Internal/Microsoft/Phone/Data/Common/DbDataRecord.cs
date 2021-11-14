// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbDataRecord
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbDataRecord : IDataRecord
  {
    public abstract int FieldCount { get; }

    public abstract object this[int i] { get; }

    public abstract object this[string name] { get; }

    public abstract bool GetBoolean(int i);

    public abstract byte GetByte(int i);

    public abstract long GetBytes(
      int i,
      long dataIndex,
      byte[] buffer,
      int bufferIndex,
      int length);

    public abstract char GetChar(int i);

    public abstract long GetChars(
      int i,
      long dataIndex,
      char[] buffer,
      int bufferIndex,
      int length);

    public IDataReader GetData(int i) => (IDataReader) this.GetDbDataReader(i);

    protected virtual DbDataReader GetDbDataReader(int i) => throw ADP.NotSupported();

    public abstract string GetDataTypeName(int i);

    public abstract DateTime GetDateTime(int i);

    public abstract Decimal GetDecimal(int i);

    public abstract double GetDouble(int i);

    public abstract Type GetFieldType(int i);

    public abstract float GetFloat(int i);

    public abstract Guid GetGuid(int i);

    public abstract short GetInt16(int i);

    public abstract int GetInt32(int i);

    public abstract long GetInt64(int i);

    public abstract string GetName(int i);

    public abstract int GetOrdinal(string name);

    public abstract string GetString(int i);

    public abstract object GetValue(int i);

    public abstract int GetValues(object[] values);

    public abstract bool IsDBNull(int i);
  }
}
