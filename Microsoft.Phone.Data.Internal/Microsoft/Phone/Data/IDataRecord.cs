// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.IDataRecord
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data
{
  public interface IDataRecord
  {
    int FieldCount { get; }

    object this[int i] { get; }

    object this[string name] { get; }

    string GetName(int i);

    string GetDataTypeName(int i);

    Type GetFieldType(int i);

    object GetValue(int i);

    int GetValues(object[] values);

    int GetOrdinal(string name);

    bool GetBoolean(int i);

    byte GetByte(int i);

    long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length);

    char GetChar(int i);

    long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length);

    Guid GetGuid(int i);

    short GetInt16(int i);

    int GetInt32(int i);

    long GetInt64(int i);

    float GetFloat(int i);

    double GetDouble(int i);

    string GetString(int i);

    Decimal GetDecimal(int i);

    DateTime GetDateTime(int i);

    IDataReader GetData(int i);

    bool IsDBNull(int i);
  }
}
