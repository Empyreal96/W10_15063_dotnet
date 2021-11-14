// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ProviderBase.DataReaderContainer
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Diagnostics;

namespace Microsoft.Phone.Data.ProviderBase
{
  internal abstract class DataReaderContainer
  {
    protected readonly IDataReader _dataReader;
    protected int _fieldCount;

    internal static DataReaderContainer Create(
      IDataReader dataReader,
      bool returnProviderSpecificTypes)
    {
      return returnProviderSpecificTypes && dataReader is DbDataReader dbDataReader ? (DataReaderContainer) new DataReaderContainer.ProviderSpecificDataReader(dataReader, dbDataReader) : (DataReaderContainer) new DataReaderContainer.CommonLanguageSubsetDataReader(dataReader);
    }

    protected DataReaderContainer(IDataReader dataReader)
    {
      Debug.Assert(dataReader != null, "null dataReader");
      this._dataReader = dataReader;
    }

    internal int FieldCount => this._fieldCount;

    internal abstract bool ReturnProviderSpecificTypes { get; }

    protected abstract int VisibleFieldCount { get; }

    internal abstract Type GetFieldType(int ordinal);

    internal abstract object GetValue(int ordinal);

    internal abstract int GetValues(object[] values);

    internal string GetName(int ordinal)
    {
      string name = this._dataReader.GetName(ordinal);
      Debug.Assert(name != null, "null GetName");
      return name ?? "";
    }

    internal DataTable GetSchemaTable() => this._dataReader is DbDataReader dataReader ? dataReader.GetSchemaTable() : (DataTable) null;

    internal bool NextResult()
    {
      this._fieldCount = 0;
      if (!this._dataReader.NextResult())
        return false;
      this._fieldCount = this.VisibleFieldCount;
      return true;
    }

    internal bool Read() => this._dataReader.Read();

    private sealed class ProviderSpecificDataReader : DataReaderContainer
    {
      private DbDataReader _providerSpecificDataReader;

      internal ProviderSpecificDataReader(IDataReader dataReader, DbDataReader dbDataReader)
        : base(dataReader)
      {
        Debug.Assert(dataReader != null, "null dbDataReader");
        this._providerSpecificDataReader = dbDataReader;
        this._fieldCount = this.VisibleFieldCount;
      }

      internal override bool ReturnProviderSpecificTypes => true;

      protected override int VisibleFieldCount
      {
        get
        {
          int visibleFieldCount = this._providerSpecificDataReader.VisibleFieldCount;
          return 0 > visibleFieldCount ? 0 : visibleFieldCount;
        }
      }

      internal override Type GetFieldType(int ordinal)
      {
        Type specificFieldType = this._providerSpecificDataReader.GetProviderSpecificFieldType(ordinal);
        Debug.Assert(specificFieldType != null, "null FieldType");
        return specificFieldType;
      }

      internal override object GetValue(int ordinal) => this._providerSpecificDataReader.GetProviderSpecificValue(ordinal);

      internal override int GetValues(object[] values) => this._providerSpecificDataReader.GetProviderSpecificValues(values);
    }

    private sealed class CommonLanguageSubsetDataReader : DataReaderContainer
    {
      internal CommonLanguageSubsetDataReader(IDataReader dataReader)
        : base(dataReader)
      {
        this._fieldCount = this.VisibleFieldCount;
      }

      internal override bool ReturnProviderSpecificTypes => false;

      protected override int VisibleFieldCount
      {
        get
        {
          int fieldCount = this._dataReader.FieldCount;
          return 0 > fieldCount ? 0 : fieldCount;
        }
      }

      internal override Type GetFieldType(int ordinal) => this._dataReader.GetFieldType(ordinal);

      internal override object GetValue(int ordinal) => this._dataReader.GetValue(ordinal);

      internal override int GetValues(object[] values) => this._dataReader.GetValues(values);
    }
  }
}
