// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbEnumerator
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.ProviderBase;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  public class DbEnumerator : IEnumerator
  {
    internal IDataReader _reader;
    internal IDataRecord _current;
    internal SchemaInfo[] _schemaInfo;
    private FieldNameLookup _fieldNameLookup;
    private bool closeReader;

    public DbEnumerator(IDataReader reader) => this._reader = reader != null ? reader : throw ADP.ArgumentNull(nameof (reader));

    public DbEnumerator(IDataReader reader, bool closeReader)
    {
      this._reader = reader != null ? reader : throw ADP.ArgumentNull(nameof (reader));
      this.closeReader = closeReader;
    }

    public object Current => (object) this._current;

    public bool MoveNext()
    {
      if (this._schemaInfo == null)
        this.BuildSchemaInfo();
      Debug.Assert(this._schemaInfo != null, "unable to build schema information!");
      this._current = (IDataRecord) null;
      if (this._reader.Read())
      {
        object[] values = new object[this._schemaInfo.Length];
        this._reader.GetValues(values);
        this._current = (IDataRecord) new DataRecordInternal(this._schemaInfo, values, this._fieldNameLookup);
        return true;
      }
      if (this.closeReader)
        this._reader.Close();
      return false;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Reset() => throw ADP.NotSupported();

    private void BuildSchemaInfo()
    {
      int fieldCount = this._reader.FieldCount;
      string[] columnNameArray = new string[fieldCount];
      for (int i = 0; i < fieldCount; ++i)
        columnNameArray[i] = this._reader.GetName(i);
      ADP.BuildSchemaTableInfoTableNames(columnNameArray);
      SchemaInfo[] schemaInfoArray = new SchemaInfo[fieldCount];
      for (int i = 0; i < schemaInfoArray.Length; ++i)
        schemaInfoArray[i] = new SchemaInfo()
        {
          name = this._reader.GetName(i),
          type = this._reader.GetFieldType(i),
          typeName = this._reader.GetDataTypeName(i)
        };
      this._schemaInfo = schemaInfoArray;
      this._fieldNameLookup = new FieldNameLookup(this._reader, -1);
    }
  }
}
