// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DataRecordInternal
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.ProviderBase;
using System;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class DataRecordInternal : DbDataRecord
  {
    private SchemaInfo[] _schemaInfo;
    private object[] _values;
    private FieldNameLookup _fieldNameLookup;

    internal DataRecordInternal(
      SchemaInfo[] schemaInfo,
      object[] values,
      FieldNameLookup fieldNameLookup)
    {
      Debug.Assert(schemaInfo != null, "invalid attempt to instantiate DataRecordInternal with null schema information");
      Debug.Assert(values != null, "invalid attempt to instantiate DataRecordInternal with null value[]");
      this._schemaInfo = schemaInfo;
      this._values = values;
      this._fieldNameLookup = fieldNameLookup;
    }

    internal DataRecordInternal(object[] values, FieldNameLookup fieldNameLookup)
    {
      Debug.Assert(values != null, "invalid attempt to instantiate DataRecordInternal with null value[]");
      this._values = values;
      this._fieldNameLookup = fieldNameLookup;
    }

    internal void SetSchemaInfo(SchemaInfo[] schemaInfo)
    {
      Debug.Assert(this._schemaInfo == null, "invalid attempt to override DataRecordInternal schema information");
      this._schemaInfo = schemaInfo;
    }

    public override int FieldCount => this._schemaInfo.Length;

    public override int GetValues(object[] values)
    {
      if (values == null)
        throw ADP.ArgumentNull(nameof (values));
      int num = values.Length < this._schemaInfo.Length ? values.Length : this._schemaInfo.Length;
      for (int index = 0; index < num; ++index)
        values[index] = this._values[index];
      return num;
    }

    public override string GetName(int i) => this._schemaInfo[i].name;

    public override object GetValue(int i) => this._values[i];

    public override string GetDataTypeName(int i) => this._schemaInfo[i].typeName;

    public override Type GetFieldType(int i) => this._schemaInfo[i].type;

    public override int GetOrdinal(string name) => this._fieldNameLookup.GetOrdinal(name);

    public override object this[int i] => this.GetValue(i);

    public override object this[string name] => this.GetValue(this.GetOrdinal(name));

    public override bool GetBoolean(int i) => (bool) this._values[i];

    public override byte GetByte(int i) => (byte) this._values[i];

    public override long GetBytes(
      int i,
      long dataIndex,
      byte[] buffer,
      int bufferIndex,
      int length)
    {
      byte[] numArray = (byte[]) this._values[i];
      int num = numArray.Length;
      int sourceIndex = dataIndex <= (long) int.MaxValue ? (int) dataIndex : throw ADP.InvalidSourceBufferIndex(num, dataIndex, nameof (dataIndex));
      if (buffer == null)
        return (long) num;
      try
      {
        if (sourceIndex < num)
        {
          if (sourceIndex + length > num)
            num -= sourceIndex;
          else
            num = length;
        }
        Array.Copy((Array) numArray, sourceIndex, (Array) buffer, bufferIndex, num);
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableExceptionType(ex))
        {
          int length1 = numArray.Length;
          if (length < 0)
            throw ADP.InvalidDataLength((long) length);
          if (bufferIndex < 0 || bufferIndex >= buffer.Length)
            throw ADP.InvalidDestinationBufferIndex(length, bufferIndex, nameof (bufferIndex));
          if (dataIndex < 0L || dataIndex >= (long) length1)
            throw ADP.InvalidSourceBufferIndex(length, dataIndex, nameof (dataIndex));
          if (length1 + bufferIndex > buffer.Length)
            throw ADP.InvalidBufferSizeOrIndex(length1, bufferIndex);
        }
        throw;
      }
      return (long) num;
    }

    public override char GetChar(int i) => ((string) this._values[i]).ToCharArray()[0];

    public override long GetChars(
      int i,
      long dataIndex,
      char[] buffer,
      int bufferIndex,
      int length)
    {
      char[] charArray = ((string) this._values[i]).ToCharArray();
      int num = charArray.Length;
      int sourceIndex = dataIndex <= (long) int.MaxValue ? (int) dataIndex : throw ADP.InvalidSourceBufferIndex(num, dataIndex, nameof (dataIndex));
      if (buffer == null)
        return (long) num;
      try
      {
        if (sourceIndex < num)
        {
          if (sourceIndex + length > num)
            num -= sourceIndex;
          else
            num = length;
        }
        Array.Copy((Array) charArray, sourceIndex, (Array) buffer, bufferIndex, num);
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableExceptionType(ex))
        {
          int length1 = charArray.Length;
          if (length < 0)
            throw ADP.InvalidDataLength((long) length);
          if (bufferIndex < 0 || bufferIndex >= buffer.Length)
            throw ADP.InvalidDestinationBufferIndex(buffer.Length, bufferIndex, nameof (bufferIndex));
          if (sourceIndex < 0 || sourceIndex >= length1)
            throw ADP.InvalidSourceBufferIndex(length1, dataIndex, nameof (dataIndex));
          if (length1 + bufferIndex > buffer.Length)
            throw ADP.InvalidBufferSizeOrIndex(length1, bufferIndex);
        }
        throw;
      }
      return (long) num;
    }

    public override Guid GetGuid(int i) => (Guid) this._values[i];

    public override short GetInt16(int i) => (short) this._values[i];

    public override int GetInt32(int i) => (int) this._values[i];

    public override long GetInt64(int i) => (long) this._values[i];

    public override float GetFloat(int i) => (float) this._values[i];

    public override double GetDouble(int i) => (double) this._values[i];

    public override string GetString(int i) => (string) this._values[i];

    public override Decimal GetDecimal(int i) => (Decimal) this._values[i];

    public override DateTime GetDateTime(int i) => (DateTime) this._values[i];

    public override bool IsDBNull(int i)
    {
      object obj = this._values[i];
      return obj == null || Convert.IsDBNull(obj);
    }
  }
}
