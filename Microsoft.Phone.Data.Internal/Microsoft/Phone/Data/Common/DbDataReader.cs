// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbDataReader
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbDataReader : IDisposable, IDataReader, IDataRecord, IEnumerable
  {
    public abstract int Depth { get; }

    public abstract int FieldCount { get; }

    public abstract bool HasRows { get; }

    public abstract bool IsClosed { get; }

    public abstract int RecordsAffected { get; }

    public virtual int VisibleFieldCount => this.FieldCount;

    public abstract object this[int ordinal] { get; }

    public abstract object this[string name] { get; }

    public abstract void Close();

    public void Dispose() => this.Dispose(true);

    protected virtual void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      this.Close();
    }

    public abstract string GetDataTypeName(int ordinal);

    public abstract IEnumerator GetEnumerator();

    public abstract Type GetFieldType(int ordinal);

    public abstract string GetName(int ordinal);

    public abstract int GetOrdinal(string name);

    public abstract DataTable GetSchemaTable();

    public abstract bool GetBoolean(int ordinal);

    public abstract byte GetByte(int ordinal);

    public abstract long GetBytes(
      int ordinal,
      long dataOffset,
      byte[] buffer,
      int bufferOffset,
      int length);

    public abstract char GetChar(int ordinal);

    public abstract long GetChars(
      int ordinal,
      long dataOffset,
      char[] buffer,
      int bufferOffset,
      int length);

    public DbDataReader GetData(int ordinal) => this.GetDbDataReader(ordinal);

    IDataReader IDataRecord.GetData(int ordinal) => (IDataReader) this.GetDbDataReader(ordinal);

    protected virtual DbDataReader GetDbDataReader(int ordinal) => throw ADP.NotSupported();

    public abstract DateTime GetDateTime(int ordinal);

    public abstract Decimal GetDecimal(int ordinal);

    public abstract double GetDouble(int ordinal);

    public abstract float GetFloat(int ordinal);

    public abstract Guid GetGuid(int ordinal);

    public abstract short GetInt16(int ordinal);

    public abstract int GetInt32(int ordinal);

    public abstract long GetInt64(int ordinal);

    public virtual Type GetProviderSpecificFieldType(int ordinal) => this.GetFieldType(ordinal);

    public virtual object GetProviderSpecificValue(int ordinal) => this.GetValue(ordinal);

    public virtual int GetProviderSpecificValues(object[] values) => this.GetValues(values);

    public abstract string GetString(int ordinal);

    public abstract object GetValue(int ordinal);

    public abstract int GetValues(object[] values);

    public abstract bool IsDBNull(int ordinal);

    public abstract bool NextResult();

    public abstract bool Read();
  }
}
