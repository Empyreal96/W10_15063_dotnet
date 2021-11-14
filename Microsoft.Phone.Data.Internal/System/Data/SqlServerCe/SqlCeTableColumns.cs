// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeTableColumns
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections;
using System.Collections.Generic;

namespace System.Data.SqlServerCe
{
  internal class SqlCeTableColumns : IEnumerable
  {
    public string TableName;
    private readonly Dictionary<string, SqlCeInfoSchemaColumn> columns;
    private readonly Dictionary<string, SqlCeInfoSchemaColumn> parameters;
    private readonly StringComparer _comparer = StringComparer.OrdinalIgnoreCase;

    static SqlCeTableColumns() => KillBitHelper.ThrowIfKillBitIsSet();

    private SqlCeTableColumns()
    {
    }

    public SqlCeTableColumns(string tableName)
    {
      this.TableName = tableName;
      this.columns = new Dictionary<string, SqlCeInfoSchemaColumn>((IEqualityComparer<string>) this._comparer);
      this.parameters = new Dictionary<string, SqlCeInfoSchemaColumn>((IEqualityComparer<string>) this._comparer);
    }

    public void Add(SqlCeInfoSchemaColumn column)
    {
      this.columns.Add(column.ColumnName, column);
      this.parameters.Add(column.ParamName, column);
    }

    public void Clear(string newTableName)
    {
      this.columns.Clear();
      this.parameters.Clear();
      this.TableName = newTableName;
    }

    public int Count => this.columns != null ? this.columns.Count : 0;

    public SqlCeInfoSchemaColumn GetValueByParameterName(string paramName)
    {
      SqlCeInfoSchemaColumn infoSchemaColumn = (SqlCeInfoSchemaColumn) null;
      if (!this.parameters.TryGetValue(paramName, out infoSchemaColumn))
        throw new InvalidOperationException("SqlCeTableColumns.GetValueByParameterName");
      return infoSchemaColumn;
    }

    public SqlCeInfoSchemaColumn GetValueByColumnName(string columnName)
    {
      SqlCeInfoSchemaColumn infoSchemaColumn = (SqlCeInfoSchemaColumn) null;
      if (!this.columns.TryGetValue(columnName, out infoSchemaColumn))
        throw new InvalidOperationException("SqlCeTableColumns.GetValueByColumnName");
      return infoSchemaColumn;
    }

    public string ParameterNameOf(string columnName)
    {
      SqlCeInfoSchemaColumn infoSchemaColumn = (SqlCeInfoSchemaColumn) null;
      this.columns.TryGetValue(columnName, out infoSchemaColumn);
      return infoSchemaColumn?.ParamName;
    }

    public IEnumerator GetEnumerator() => (IEnumerator) new KeyValuePairsEnumerator<string, SqlCeInfoSchemaColumn>((IEnumerator<KeyValuePair<string, SqlCeInfoSchemaColumn>>) this.columns.GetEnumerator());
  }
}
