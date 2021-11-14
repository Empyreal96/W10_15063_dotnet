// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbSchemaTable
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace Microsoft.Phone.Data.Common
{
  internal sealed class DbSchemaTable
  {
    private static readonly string[] DBCOLUMN_NAME = new string[21]
    {
      SchemaTableColumn.ColumnName,
      SchemaTableColumn.ColumnOrdinal,
      SchemaTableColumn.ColumnSize,
      SchemaTableOptionalColumn.BaseServerName,
      SchemaTableOptionalColumn.BaseCatalogName,
      SchemaTableColumn.BaseColumnName,
      SchemaTableColumn.BaseSchemaName,
      SchemaTableColumn.BaseTableName,
      SchemaTableOptionalColumn.IsAutoIncrement,
      SchemaTableColumn.IsUnique,
      SchemaTableColumn.IsKey,
      SchemaTableOptionalColumn.IsRowVersion,
      SchemaTableColumn.DataType,
      SchemaTableOptionalColumn.ProviderSpecificDataType,
      SchemaTableColumn.AllowDBNull,
      SchemaTableColumn.ProviderType,
      SchemaTableColumn.IsExpression,
      SchemaTableOptionalColumn.IsHidden,
      SchemaTableColumn.IsLong,
      SchemaTableOptionalColumn.IsReadOnly,
      "SchemaMapping Unsorted Index"
    };
    internal DataTable dataTable;
    private DataColumnCollection columns;
    private DataColumn[] columnCache = new DataColumn[DbSchemaTable.DBCOLUMN_NAME.Length];
    private bool _returnProviderSpecificTypes;

    internal DbSchemaTable(DataTable dataTable, bool returnProviderSpecificTypes)
    {
      this.dataTable = dataTable;
      this.columns = dataTable.Columns;
      this._returnProviderSpecificTypes = returnProviderSpecificTypes;
    }

    internal DataColumn ColumnName => this.CachedDataColumn(DbSchemaTable.ColumnEnum.ColumnName);

    internal DataColumn Size => this.CachedDataColumn(DbSchemaTable.ColumnEnum.ColumnSize);

    internal DataColumn BaseServerName => this.CachedDataColumn(DbSchemaTable.ColumnEnum.BaseServerName);

    internal DataColumn BaseColumnName => this.CachedDataColumn(DbSchemaTable.ColumnEnum.BaseColumnName);

    internal DataColumn BaseTableName => this.CachedDataColumn(DbSchemaTable.ColumnEnum.BaseTableName);

    internal DataColumn BaseCatalogName => this.CachedDataColumn(DbSchemaTable.ColumnEnum.BaseCatalogName);

    internal DataColumn BaseSchemaName => this.CachedDataColumn(DbSchemaTable.ColumnEnum.BaseSchemaName);

    internal DataColumn IsAutoIncrement => this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsAutoIncrement);

    internal DataColumn IsUnique => this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsUnique);

    internal DataColumn IsKey => this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsKey);

    internal DataColumn IsRowVersion => this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsRowVersion);

    internal DataColumn AllowDBNull => this.CachedDataColumn(DbSchemaTable.ColumnEnum.AllowDBNull);

    internal DataColumn IsExpression => this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsExpression);

    internal DataColumn IsHidden => this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsHidden);

    internal DataColumn IsLong => this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsLong);

    internal DataColumn IsReadOnly => this.CachedDataColumn(DbSchemaTable.ColumnEnum.IsReadOnly);

    internal DataColumn UnsortedIndex => this.CachedDataColumn(DbSchemaTable.ColumnEnum.SchemaMappingUnsortedIndex);

    internal DataColumn DataType => this._returnProviderSpecificTypes ? this.CachedDataColumn(DbSchemaTable.ColumnEnum.ProviderSpecificDataType, DbSchemaTable.ColumnEnum.DataType) : this.CachedDataColumn(DbSchemaTable.ColumnEnum.DataType);

    private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column)
    {
      int num = (int) column;
      return this.CachedDataColumn((DbSchemaTable.ColumnEnum) num, (DbSchemaTable.ColumnEnum) num);
    }

    private DataColumn CachedDataColumn(
      DbSchemaTable.ColumnEnum column,
      DbSchemaTable.ColumnEnum column2)
    {
      DataColumn column1 = this.columnCache[(int) column];
      if (column1 == null)
      {
        int index = this.columns.IndexOf(DbSchemaTable.DBCOLUMN_NAME[(int) column]);
        if (-1 == index && column != column2)
          index = this.columns.IndexOf(DbSchemaTable.DBCOLUMN_NAME[(int) column2]);
        if (-1 != index)
        {
          column1 = this.columns[index];
          this.columnCache[(int) column] = column1;
        }
      }
      return column1;
    }

    private enum ColumnEnum
    {
      ColumnName,
      ColumnOrdinal,
      ColumnSize,
      BaseServerName,
      BaseCatalogName,
      BaseColumnName,
      BaseSchemaName,
      BaseTableName,
      IsAutoIncrement,
      IsUnique,
      IsKey,
      IsRowVersion,
      DataType,
      ProviderSpecificDataType,
      AllowDBNull,
      ProviderType,
      IsExpression,
      IsHidden,
      IsLong,
      IsReadOnly,
      SchemaMappingUnsortedIndex,
    }
  }
}
