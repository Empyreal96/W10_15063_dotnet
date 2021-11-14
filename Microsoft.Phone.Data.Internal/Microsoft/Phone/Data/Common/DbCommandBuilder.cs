// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbCommandBuilder
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbCommandBuilder : MarshalByValueComponent
  {
    private const string DeleteFrom = "DELETE FROM ";
    private const string InsertInto = "INSERT INTO ";
    private const string DefaultValues = " DEFAULT VALUES";
    private const string Values = " VALUES ";
    private const string Update = "UPDATE ";
    private const string Set = " SET ";
    private const string Where = " WHERE ";
    private const string SpaceLeftParenthesis = " (";
    private const string Comma = ", ";
    private const string Equal = " = ";
    private const string LeftParenthesis = "(";
    private const string RightParenthesis = ")";
    private const string NameSeparator = ".";
    private const string IsNull = " IS NULL";
    private const string EqualOne = " = 1";
    private const string And = " AND ";
    private const string Or = " OR ";
    private DbDataAdapter _dataAdapter;
    private DbCommand _insertCommand;
    private DbCommand _updateCommand;
    private DbCommand _deleteCommand;
    private MissingMappingAction _missingMappingAction;
    private ConflictOption _conflictDetection = ConflictOption.CompareAllSearchableValues;
    private bool _setAllValues;
    private bool _hasPartialPrimaryKey;
    private DataTable _dbSchemaTable;
    private DbSchemaRow[] _dbSchemaRows;
    private string[] _sourceColumnNames;
    private DbCommandBuilder.ParameterNames _parameterNames;
    private string _quotedBaseTableName;
    private CatalogLocation _catalogLocation = CatalogLocation.Start;
    private string _catalogSeparator = ".";
    private string _schemaSeparator = ".";
    private string _quotePrefix = "";
    private string _quoteSuffix = "";
    private string _parameterNamePattern;
    private string _parameterMarkerFormat;
    private int _parameterNameMaxLength;

    public virtual ConflictOption ConflictOption
    {
      get => this._conflictDetection;
      set
      {
        switch (value)
        {
          case ConflictOption.CompareAllSearchableValues:
          case ConflictOption.CompareRowVersion:
          case ConflictOption.OverwriteChanges:
            this._conflictDetection = value;
            break;
          default:
            throw ADP.InvalidConflictOptions(value);
        }
      }
    }

    public virtual CatalogLocation CatalogLocation
    {
      get => this._catalogLocation;
      set
      {
        if (this._dbSchemaTable != null)
          throw ADP.NoQuoteChange();
        this._catalogLocation = value == CatalogLocation.Start || value == CatalogLocation.End ? value : throw ADP.InvalidCatalogLocation(value);
      }
    }

    public virtual string CatalogSeparator
    {
      get
      {
        string catalogSeparator = this._catalogSeparator;
        return catalogSeparator == null || 0 >= catalogSeparator.Length ? "." : catalogSeparator;
      }
      set
      {
        if (this._dbSchemaTable != null)
          throw ADP.NoQuoteChange();
        this._catalogSeparator = value;
      }
    }

    public DbDataAdapter DataAdapter
    {
      get => this._dataAdapter;
      set
      {
        if (this._dataAdapter == value)
          return;
        this.RefreshSchema();
        if (this._dataAdapter != null)
        {
          this.SetRowUpdatingHandler(this._dataAdapter);
          this._dataAdapter = (DbDataAdapter) null;
        }
        if (value == null)
          return;
        this.SetRowUpdatingHandler(value);
        this._dataAdapter = value;
      }
    }

    internal int ParameterNameMaxLength => this._parameterNameMaxLength;

    internal string ParameterNamePattern => this._parameterNamePattern;

    private string QuotedBaseTableName => this._quotedBaseTableName;

    public virtual string QuotePrefix
    {
      get => this._quotePrefix ?? ADP.StrEmpty;
      set
      {
        if (this._dbSchemaTable != null)
          throw ADP.NoQuoteChange();
        this._quotePrefix = value;
      }
    }

    public virtual string QuoteSuffix
    {
      get => this._quoteSuffix ?? ADP.StrEmpty;
      set
      {
        if (this._dbSchemaTable != null)
          throw ADP.NoQuoteChange();
        this._quoteSuffix = value;
      }
    }

    public virtual string SchemaSeparator
    {
      get
      {
        string schemaSeparator = this._schemaSeparator;
        return schemaSeparator == null || 0 >= schemaSeparator.Length ? "." : schemaSeparator;
      }
      set
      {
        if (this._dbSchemaTable != null)
          throw ADP.NoQuoteChange();
        this._schemaSeparator = value;
      }
    }

    public bool SetAllValues
    {
      get => this._setAllValues;
      set => this._setAllValues = value;
    }

    private DbCommand InsertCommand
    {
      get => this._insertCommand;
      set => this._insertCommand = value;
    }

    private DbCommand UpdateCommand
    {
      get => this._updateCommand;
      set => this._updateCommand = value;
    }

    private DbCommand DeleteCommand
    {
      get => this._deleteCommand;
      set => this._deleteCommand = value;
    }

    private void BuildCache(
      bool closeConnection,
      DataRow dataRow,
      bool useColumnsForParameterNames)
    {
      if (this._dbSchemaTable != null && (!useColumnsForParameterNames || this._parameterNames != null))
        return;
      DataTable schemaTable = (DataTable) null;
      DbCommand selectCommand = this.GetSelectCommand();
      DbConnection connection = selectCommand.Connection;
      if (connection == null)
        throw ADP.MissingSourceCommandConnection();
      try
      {
        if ((ConnectionState.Open & connection.State) == ConnectionState.Closed)
          connection.Open();
        else
          closeConnection = false;
        if (useColumnsForParameterNames)
        {
          DataTable schema = connection.GetSchema(DbMetaDataCollectionNames.DataSourceInformation);
          if (schema.Rows.Count == 1)
          {
            this._parameterNamePattern = schema.Rows[0][DbMetaDataColumnNames.ParameterNamePattern] as string;
            this._parameterMarkerFormat = schema.Rows[0][DbMetaDataColumnNames.ParameterMarkerFormat] as string;
            if (!(schema.Rows[0][DbMetaDataColumnNames.ParameterNameMaxLength] is int num6))
              num6 = 0;
            this._parameterNameMaxLength = num6;
            if (this._parameterNameMaxLength == 0 || this._parameterNamePattern == null || this._parameterMarkerFormat == null)
              useColumnsForParameterNames = false;
          }
          else
          {
            Debug.Assert(false, "Rowcount expected to be 1");
            useColumnsForParameterNames = false;
          }
        }
        schemaTable = this.GetSchemaTable(selectCommand);
      }
      finally
      {
        if (closeConnection)
          connection.Close();
      }
      if (schemaTable == null)
        throw ADP.DynamicSQLNoTableInfo();
      this.BuildInformation(schemaTable);
      this._dbSchemaTable = schemaTable;
      DbSchemaRow[] dbSchemaRows = this._dbSchemaRows;
      string[] columnNameArray = new string[dbSchemaRows.Length];
      for (int index = 0; index < dbSchemaRows.Length; ++index)
      {
        if (dbSchemaRows[index] != null)
          columnNameArray[index] = dbSchemaRows[index].ColumnName;
      }
      this._sourceColumnNames = columnNameArray;
      if (useColumnsForParameterNames)
        this._parameterNames = new DbCommandBuilder.ParameterNames(this, dbSchemaRows);
      ADP.BuildSchemaTableInfoTableNames(columnNameArray);
    }

    protected virtual DataTable GetSchemaTable(DbCommand sourceCommand)
    {
      using (DbDataReader dbDataReader = sourceCommand.ExecuteReader(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo))
        return dbDataReader?.GetSchemaTable();
    }

    private void BuildInformation(DataTable schemaTable)
    {
      DbSchemaRow[] sortedSchemaRows = DbSchemaRow.GetSortedSchemaRows(schemaTable, false);
      if (sortedSchemaRows == null || sortedSchemaRows.Length == 0)
        throw ADP.DynamicSQLNoTableInfo();
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = (string) null;
      for (int index = 0; index < sortedSchemaRows.Length; ++index)
      {
        DbSchemaRow dbSchemaRow = sortedSchemaRows[index];
        string baseTableName = dbSchemaRow.BaseTableName;
        if (baseTableName == null || baseTableName.Length == 0)
        {
          sortedSchemaRows[index] = (DbSchemaRow) null;
        }
        else
        {
          string strB1 = dbSchemaRow.BaseServerName;
          string strB2 = dbSchemaRow.BaseCatalogName;
          string strB3 = dbSchemaRow.BaseSchemaName;
          if (strB1 == null)
            strB1 = "";
          if (strB2 == null)
            strB2 = "";
          if (strB3 == null)
            strB3 = "";
          if (str4 == null)
          {
            str1 = strB1;
            str2 = strB2;
            str3 = strB3;
            str4 = baseTableName;
          }
          else if (ADP.SrcCompare(str4, baseTableName) != 0 || ADP.SrcCompare(str3, strB3) != 0 || (ADP.SrcCompare(str2, strB2) != 0 || ADP.SrcCompare(str1, strB1) != 0))
            throw ADP.DynamicSQLJoinUnsupported();
        }
      }
      if (str1.Length == 0)
        str1 = (string) null;
      if (str2.Length == 0)
      {
        str1 = (string) null;
        str2 = (string) null;
      }
      if (str3.Length == 0)
      {
        str1 = (string) null;
        str2 = (string) null;
        str3 = (string) null;
      }
      if (str4 == null || str4.Length == 0)
        throw ADP.DynamicSQLNoTableInfo();
      CatalogLocation catalogLocation = this.CatalogLocation;
      string catalogSeparator = this.CatalogSeparator;
      string schemaSeparator = this.SchemaSeparator;
      string quotePrefix = this.QuotePrefix;
      string quoteSuffix = this.QuoteSuffix;
      if (!ADP.IsEmpty(quotePrefix) && -1 != str4.IndexOf(quotePrefix, StringComparison.Ordinal))
        throw ADP.DynamicSQLNestedQuote(str4, quotePrefix);
      if (!ADP.IsEmpty(quoteSuffix) && -1 != str4.IndexOf(quoteSuffix, StringComparison.Ordinal))
        throw ADP.DynamicSQLNestedQuote(str4, quoteSuffix);
      StringBuilder stringBuilder = new StringBuilder();
      if (CatalogLocation.Start == catalogLocation)
      {
        if (str1 != null)
        {
          stringBuilder.Append(ADP.BuildQuotedString(quotePrefix, quoteSuffix, str1));
          stringBuilder.Append(catalogSeparator);
        }
        if (str2 != null)
        {
          stringBuilder.Append(ADP.BuildQuotedString(quotePrefix, quoteSuffix, str2));
          stringBuilder.Append(catalogSeparator);
        }
      }
      if (str3 != null)
      {
        stringBuilder.Append(ADP.BuildQuotedString(quotePrefix, quoteSuffix, str3));
        stringBuilder.Append(schemaSeparator);
      }
      stringBuilder.Append(ADP.BuildQuotedString(quotePrefix, quoteSuffix, str4));
      if (CatalogLocation.End == catalogLocation)
      {
        if (str1 != null)
        {
          stringBuilder.Append(catalogSeparator);
          stringBuilder.Append(ADP.BuildQuotedString(quotePrefix, quoteSuffix, str1));
        }
        if (str2 != null)
        {
          stringBuilder.Append(catalogSeparator);
          stringBuilder.Append(ADP.BuildQuotedString(quotePrefix, quoteSuffix, str2));
        }
      }
      this._quotedBaseTableName = stringBuilder.ToString();
      this._hasPartialPrimaryKey = false;
      foreach (DbSchemaRow dbSchemaRow in sortedSchemaRows)
      {
        if (dbSchemaRow != null && (dbSchemaRow.IsKey || dbSchemaRow.IsUnique) && (!dbSchemaRow.IsLong && !dbSchemaRow.IsRowVersion && dbSchemaRow.IsHidden))
        {
          this._hasPartialPrimaryKey = true;
          break;
        }
      }
      this._dbSchemaRows = sortedSchemaRows;
    }

    private DbCommand BuildDeleteCommand(DataTableMapping mappings, DataRow dataRow)
    {
      DbCommand command = this.InitializeCommand(this.DeleteCommand);
      StringBuilder builder = new StringBuilder();
      int parameterCount = 0;
      Debug.Assert(!ADP.IsEmpty(this._quotedBaseTableName), "no table name");
      builder.Append("DELETE FROM ");
      builder.Append(this.QuotedBaseTableName);
      int usedParameterCount = this.BuildWhereClause(mappings, dataRow, builder, command, parameterCount, false);
      command.CommandText = builder.ToString();
      DbCommandBuilder.RemoveExtraParameters(command, usedParameterCount);
      this.DeleteCommand = command;
      return command;
    }

    private DbCommand BuildInsertCommand(DataTableMapping mappings, DataRow dataRow)
    {
      DbCommand command = this.InitializeCommand(this.InsertCommand);
      StringBuilder stringBuilder = new StringBuilder();
      int index1 = 0;
      string str = " (";
      Debug.Assert(!ADP.IsEmpty(this._quotedBaseTableName), "no table name");
      stringBuilder.Append("INSERT INTO ");
      stringBuilder.Append(this.QuotedBaseTableName);
      DbSchemaRow[] dbSchemaRows = this._dbSchemaRows;
      string[] strArray = new string[dbSchemaRows.Length];
      for (int index2 = 0; index2 < dbSchemaRows.Length; ++index2)
      {
        DbSchemaRow row = dbSchemaRows[index2];
        if (row != null && row.BaseColumnName.Length != 0 && this.IncludeInInsertValues(row))
        {
          object obj = (object) null;
          string sourceColumnName = this._sourceColumnNames[index2];
          if (mappings != null && dataRow != null)
          {
            DataColumn dataColumn = this.GetDataColumn(sourceColumnName, mappings, dataRow);
            if (dataColumn != null && (!row.IsReadOnly || !dataColumn.ReadOnly))
            {
              obj = this.GetColumnValue(dataRow, dataColumn, DataRowVersion.Current);
              if (!row.AllowDBNull && (obj == null || Convert.IsDBNull(obj)))
                continue;
            }
            else
              continue;
          }
          stringBuilder.Append(str);
          str = ", ";
          stringBuilder.Append(this.QuotedColumn(row.BaseColumnName));
          strArray[index1] = this.CreateParameterForValue(command, this.GetBaseParameterName(index2), sourceColumnName, DataRowVersion.Current, index1, obj, row, StatementType.Insert, false);
          ++index1;
        }
      }
      if (index1 == 0)
      {
        stringBuilder.Append(" DEFAULT VALUES");
      }
      else
      {
        stringBuilder.Append(")");
        stringBuilder.Append(" VALUES ");
        stringBuilder.Append("(");
        stringBuilder.Append(strArray[0]);
        for (int index2 = 1; index2 < index1; ++index2)
        {
          stringBuilder.Append(", ");
          stringBuilder.Append(strArray[index2]);
        }
        stringBuilder.Append(")");
      }
      command.CommandText = stringBuilder.ToString();
      DbCommandBuilder.RemoveExtraParameters(command, index1);
      this.InsertCommand = command;
      return command;
    }

    private DbCommand BuildUpdateCommand(DataTableMapping mappings, DataRow dataRow)
    {
      DbCommand command = this.InitializeCommand(this.UpdateCommand);
      StringBuilder builder = new StringBuilder();
      string str = " SET ";
      int parameterCount = 0;
      Debug.Assert(!ADP.IsEmpty(this._quotedBaseTableName), "no table name");
      builder.Append("UPDATE ");
      builder.Append(this.QuotedBaseTableName);
      DbSchemaRow[] dbSchemaRows = this._dbSchemaRows;
      for (int index = 0; index < dbSchemaRows.Length; ++index)
      {
        DbSchemaRow row = dbSchemaRows[index];
        if (row != null && row.BaseColumnName.Length != 0 && this.IncludeInUpdateSet(row))
        {
          object obj = (object) null;
          string sourceColumnName = this._sourceColumnNames[index];
          if (mappings != null && dataRow != null)
          {
            DataColumn dataColumn = this.GetDataColumn(sourceColumnName, mappings, dataRow);
            if (dataColumn != null && (!row.IsReadOnly || !dataColumn.ReadOnly))
            {
              obj = this.GetColumnValue(dataRow, dataColumn, DataRowVersion.Current);
              if (!this.SetAllValues)
              {
                object columnValue = this.GetColumnValue(dataRow, dataColumn, DataRowVersion.Original);
                if (columnValue == obj || columnValue != null && columnValue.Equals(obj))
                  continue;
              }
            }
            else
              continue;
          }
          builder.Append(str);
          str = ", ";
          builder.Append(this.QuotedColumn(row.BaseColumnName));
          builder.Append(" = ");
          builder.Append(this.CreateParameterForValue(command, this.GetBaseParameterName(index), sourceColumnName, DataRowVersion.Current, parameterCount, obj, row, StatementType.Update, false));
          ++parameterCount;
        }
      }
      int num = parameterCount == 0 ? 1 : 0;
      int usedParameterCount = this.BuildWhereClause(mappings, dataRow, builder, command, parameterCount, true);
      command.CommandText = builder.ToString();
      DbCommandBuilder.RemoveExtraParameters(command, usedParameterCount);
      this.UpdateCommand = command;
      return num == 0 ? command : (DbCommand) null;
    }

    private int BuildWhereClause(
      DataTableMapping mappings,
      DataRow dataRow,
      StringBuilder builder,
      DbCommand command,
      int parameterCount,
      bool isUpdate)
    {
      string str1 = string.Empty;
      int num = 0;
      builder.Append(" WHERE ");
      builder.Append("(");
      DbSchemaRow[] dbSchemaRows = this._dbSchemaRows;
      for (int index = 0; index < dbSchemaRows.Length; ++index)
      {
        DbSchemaRow row = dbSchemaRows[index];
        if (row != null && row.BaseColumnName.Length != 0 && this.IncludeInWhereClause(row, isUpdate))
        {
          builder.Append(str1);
          str1 = " AND ";
          object obj = (object) null;
          string sourceColumnName = this._sourceColumnNames[index];
          string str2 = this.QuotedColumn(row.BaseColumnName);
          if (mappings != null && dataRow != null)
            obj = this.GetColumnValue(dataRow, sourceColumnName, mappings, DataRowVersion.Original);
          if (!row.AllowDBNull)
          {
            builder.Append("(");
            builder.Append(str2);
            builder.Append(" = ");
            builder.Append(this.CreateParameterForValue(command, this.GetOriginalParameterName(index), sourceColumnName, DataRowVersion.Original, parameterCount, obj, row, isUpdate ? StatementType.Update : StatementType.Delete, true));
            ++parameterCount;
            builder.Append(")");
          }
          else
          {
            builder.Append("(");
            builder.Append("(");
            builder.Append(this.CreateParameterForNullTest(command, this.GetNullParameterName(index), sourceColumnName, DataRowVersion.Original, parameterCount, obj, row, isUpdate ? StatementType.Update : StatementType.Delete, true));
            ++parameterCount;
            builder.Append(" = 1");
            builder.Append(" AND ");
            builder.Append(str2);
            builder.Append(" IS NULL");
            builder.Append(")");
            builder.Append(" OR ");
            builder.Append("(");
            builder.Append(str2);
            builder.Append(" = ");
            builder.Append(this.CreateParameterForValue(command, this.GetOriginalParameterName(index), sourceColumnName, DataRowVersion.Original, parameterCount, obj, row, isUpdate ? StatementType.Update : StatementType.Delete, true));
            ++parameterCount;
            builder.Append(")");
            builder.Append(")");
          }
          if (this.IncrementWhereCount(row))
            ++num;
        }
      }
      builder.Append(")");
      if (num != 0)
        return parameterCount;
      if (isUpdate)
      {
        if (ConflictOption.CompareRowVersion == this.ConflictOption)
          throw ADP.DynamicSQLNoKeyInfoRowVersionUpdate();
        throw ADP.DynamicSQLNoKeyInfoUpdate();
      }
      if (ConflictOption.CompareRowVersion == this.ConflictOption)
        throw ADP.DynamicSQLNoKeyInfoRowVersionDelete();
      throw ADP.DynamicSQLNoKeyInfoDelete();
    }

    private string CreateParameterForNullTest(
      DbCommand command,
      string parameterName,
      string sourceColumn,
      DataRowVersion version,
      int parameterCount,
      object value,
      DbSchemaRow row,
      StatementType statementType,
      bool whereClause)
    {
      DbParameter nextParameter = DbCommandBuilder.GetNextParameter(command, parameterCount);
      Debug.Assert(!ADP.IsEmpty(sourceColumn), "empty source column");
      nextParameter.ParameterName = parameterName != null ? parameterName : this.GetParameterName(1 + parameterCount);
      nextParameter.Direction = ParameterDirection.Input;
      nextParameter.SourceColumn = sourceColumn;
      nextParameter.SourceVersion = version;
      nextParameter.SourceColumnNullMapping = true;
      nextParameter.Value = value;
      nextParameter.Size = 0;
      this.ApplyParameterInfo(nextParameter, row.DataRow, statementType, whereClause);
      nextParameter.DbType = DbType.Int32;
      nextParameter.Value = ADP.IsNull(value) ? DbDataAdapter.ParameterValueNullValue : DbDataAdapter.ParameterValueNonNullValue;
      if (!command.Parameters.Contains((object) nextParameter))
        command.Parameters.Add((object) nextParameter);
      if (parameterName == null)
        return this.GetParameterPlaceholder(1 + parameterCount);
      Debug.Assert(this._parameterNames != null, "How can we have a parameterName without a _parameterNames collection?");
      Debug.Assert(this._parameterMarkerFormat != null, "How can we have a _parameterNames collection but no _parameterMarkerFormat?");
      return string.Format((IFormatProvider) CultureInfo.InvariantCulture, this._parameterMarkerFormat, (object) parameterName);
    }

    private string CreateParameterForValue(
      DbCommand command,
      string parameterName,
      string sourceColumn,
      DataRowVersion version,
      int parameterCount,
      object value,
      DbSchemaRow row,
      StatementType statementType,
      bool whereClause)
    {
      DbParameter nextParameter = DbCommandBuilder.GetNextParameter(command, parameterCount);
      nextParameter.ParameterName = parameterName != null ? parameterName : this.GetParameterName(1 + parameterCount);
      nextParameter.Direction = ParameterDirection.Input;
      nextParameter.SourceColumn = sourceColumn;
      nextParameter.SourceVersion = version;
      nextParameter.SourceColumnNullMapping = false;
      nextParameter.Value = value;
      nextParameter.Size = 0;
      this.ApplyParameterInfo(nextParameter, row.DataRow, statementType, whereClause);
      if (!command.Parameters.Contains((object) nextParameter))
        command.Parameters.Add((object) nextParameter);
      if (parameterName == null)
        return this.GetParameterPlaceholder(1 + parameterCount);
      Debug.Assert(this._parameterNames != null, "How can we have a parameterName without a _parameterNames collection?");
      Debug.Assert(this._parameterMarkerFormat != null, "How can we have a _parameterNames collection but no _parameterMarkerFormat?");
      return string.Format((IFormatProvider) CultureInfo.InvariantCulture, this._parameterMarkerFormat, (object) parameterName);
    }

    protected override void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      this.DataAdapter = (DbDataAdapter) null;
    }

    private DataTableMapping GetTableMapping(DataRow dataRow)
    {
      DataTableMapping dataTableMapping = (DataTableMapping) null;
      if (dataRow != null)
      {
        DataTable table = dataRow.Table;
        if (table != null)
        {
          DbDataAdapter dataAdapter = this.DataAdapter;
          if (dataAdapter != null)
          {
            dataTableMapping = dataAdapter.GetTableMapping(table);
          }
          else
          {
            string tableName = table.TableName;
            dataTableMapping = new DataTableMapping(tableName, tableName);
          }
        }
      }
      return dataTableMapping;
    }

    private string GetBaseParameterName(int index) => this._parameterNames != null ? this._parameterNames.GetBaseParameterName(index) : (string) null;

    private string GetOriginalParameterName(int index) => this._parameterNames != null ? this._parameterNames.GetOriginalParameterName(index) : (string) null;

    private string GetNullParameterName(int index) => this._parameterNames != null ? this._parameterNames.GetNullParameterName(index) : (string) null;

    private DbCommand GetSelectCommand()
    {
      DbCommand dbCommand = (DbCommand) null;
      DbDataAdapter dataAdapter = this.DataAdapter;
      if (dataAdapter != null)
      {
        if (this._missingMappingAction == (MissingMappingAction) 0)
          this._missingMappingAction = dataAdapter.MissingMappingAction;
        dbCommand = dataAdapter.SelectCommand;
      }
      return dbCommand != null ? dbCommand : throw ADP.MissingSourceCommand();
    }

    public DbCommand GetInsertCommand() => this.GetInsertCommand((DataRow) null, false);

    public DbCommand GetInsertCommand(bool useColumnsForParameterNames) => this.GetInsertCommand((DataRow) null, useColumnsForParameterNames);

    internal DbCommand GetInsertCommand(DataRow dataRow, bool useColumnsForParameterNames)
    {
      this.BuildCache(true, dataRow, useColumnsForParameterNames);
      this.BuildInsertCommand(this.GetTableMapping(dataRow), dataRow);
      return this.InsertCommand;
    }

    public DbCommand GetUpdateCommand() => this.GetUpdateCommand((DataRow) null, false);

    public DbCommand GetUpdateCommand(bool useColumnsForParameterNames) => this.GetUpdateCommand((DataRow) null, useColumnsForParameterNames);

    internal DbCommand GetUpdateCommand(DataRow dataRow, bool useColumnsForParameterNames)
    {
      this.BuildCache(true, dataRow, useColumnsForParameterNames);
      this.BuildUpdateCommand(this.GetTableMapping(dataRow), dataRow);
      return this.UpdateCommand;
    }

    public DbCommand GetDeleteCommand() => this.GetDeleteCommand((DataRow) null, false);

    public DbCommand GetDeleteCommand(bool useColumnsForParameterNames) => this.GetDeleteCommand((DataRow) null, useColumnsForParameterNames);

    internal DbCommand GetDeleteCommand(DataRow dataRow, bool useColumnsForParameterNames)
    {
      this.BuildCache(true, dataRow, useColumnsForParameterNames);
      this.BuildDeleteCommand(this.GetTableMapping(dataRow), dataRow);
      return this.DeleteCommand;
    }

    private object GetColumnValue(
      DataRow row,
      string columnName,
      DataTableMapping mappings,
      DataRowVersion version)
    {
      return this.GetColumnValue(row, this.GetDataColumn(columnName, mappings, row), version);
    }

    private object GetColumnValue(DataRow row, DataColumn column, DataRowVersion version)
    {
      object obj = (object) null;
      if (column != null)
        obj = row[column, version];
      return obj;
    }

    private DataColumn GetDataColumn(
      string columnName,
      DataTableMapping tablemapping,
      DataRow row)
    {
      DataColumn dataColumn = (DataColumn) null;
      if (!ADP.IsEmpty(columnName))
        dataColumn = tablemapping.GetDataColumn(columnName, (Type) null, row.Table, this._missingMappingAction, MissingSchemaAction.Error);
      return dataColumn;
    }

    private static DbParameter GetNextParameter(DbCommand command, int pcount)
    {
      DbParameter dbParameter = pcount >= command.Parameters.Count ? command.CreateParameter() : command.Parameters[pcount];
      Debug.Assert(dbParameter != null, "null CreateParameter");
      return dbParameter;
    }

    private bool IncludeInInsertValues(DbSchemaRow row) => !row.IsAutoIncrement && !row.IsHidden && !row.IsExpression && !row.IsRowVersion;

    private bool IncludeInUpdateSet(DbSchemaRow row) => !row.IsAutoIncrement && !row.IsRowVersion && !row.IsHidden;

    private bool IncludeInWhereClause(DbSchemaRow row, bool isUpdate)
    {
      bool flag = this.IncrementWhereCount(row);
      if (flag && row.IsHidden)
      {
        if (ConflictOption.CompareRowVersion == this.ConflictOption)
          throw ADP.DynamicSQLNoKeyInfoRowVersionUpdate();
        throw ADP.DynamicSQLNoKeyInfoUpdate();
      }
      if (!flag && ConflictOption.CompareAllSearchableValues == this.ConflictOption)
        flag = !row.IsLong && !row.IsRowVersion && !row.IsHidden;
      return flag;
    }

    private bool IncrementWhereCount(DbSchemaRow row)
    {
      ConflictOption conflictOption = this.ConflictOption;
      switch (conflictOption)
      {
        case ConflictOption.CompareAllSearchableValues:
        case ConflictOption.OverwriteChanges:
          return (row.IsKey || row.IsUnique) && !row.IsLong && !row.IsRowVersion;
        case ConflictOption.CompareRowVersion:
          return ((row.IsKey || row.IsUnique) && !this._hasPartialPrimaryKey || row.IsRowVersion) && !row.IsLong;
        default:
          throw ADP.InvalidConflictOptions(conflictOption);
      }
    }

    protected virtual DbCommand InitializeCommand(DbCommand command)
    {
      if (command == null)
      {
        DbCommand selectCommand = this.GetSelectCommand();
        command = selectCommand.Connection.CreateCommand();
        command.CommandTimeout = selectCommand.CommandTimeout;
        command.Transaction = selectCommand.Transaction;
      }
      command.CommandType = CommandType.Text;
      command.UpdatedRowSource = UpdateRowSource.None;
      return command;
    }

    private string QuotedColumn(string column) => ADP.BuildQuotedString(this.QuotePrefix, this.QuoteSuffix, column);

    public virtual string QuoteIdentifier(string unquotedIdentifier) => throw ADP.NotSupported();

    public virtual void RefreshSchema()
    {
      this._dbSchemaTable = (DataTable) null;
      this._dbSchemaRows = (DbSchemaRow[]) null;
      this._sourceColumnNames = (string[]) null;
      this._quotedBaseTableName = (string) null;
      DbDataAdapter dataAdapter = this.DataAdapter;
      if (dataAdapter != null)
      {
        if (this.InsertCommand == dataAdapter.InsertCommand)
          dataAdapter.InsertCommand = (DbCommand) null;
        if (this.UpdateCommand == dataAdapter.UpdateCommand)
          dataAdapter.UpdateCommand = (DbCommand) null;
        if (this.DeleteCommand == dataAdapter.DeleteCommand)
          dataAdapter.DeleteCommand = (DbCommand) null;
      }
      DbCommand insertCommand;
      if ((insertCommand = this.InsertCommand) != null)
        insertCommand.Dispose();
      DbCommand updateCommand;
      if ((updateCommand = this.UpdateCommand) != null)
        updateCommand.Dispose();
      DbCommand deleteCommand;
      if ((deleteCommand = this.DeleteCommand) != null)
        deleteCommand.Dispose();
      this.InsertCommand = (DbCommand) null;
      this.UpdateCommand = (DbCommand) null;
      this.DeleteCommand = (DbCommand) null;
    }

    private static void RemoveExtraParameters(DbCommand command, int usedParameterCount)
    {
      for (int index = command.Parameters.Count - 1; index >= usedParameterCount; --index)
        command.Parameters.RemoveAt(index);
    }

    protected void RowUpdatingHandler(RowUpdatingEventArgs rowUpdatingEvent)
    {
      if (rowUpdatingEvent == null)
        throw ADP.ArgumentNull(nameof (rowUpdatingEvent));
      try
      {
        if (rowUpdatingEvent.Status != UpdateStatus.Continue)
          return;
        StatementType statementType = rowUpdatingEvent.StatementType;
        DbCommand dbCommand1 = (DbCommand) rowUpdatingEvent.Command;
        if (dbCommand1 != null)
        {
          DbCommand dbCommand2;
          switch (statementType)
          {
            case StatementType.Select:
              Debug.Assert(false, "how did we get here?");
              return;
            case StatementType.Insert:
              dbCommand2 = this.InsertCommand;
              break;
            case StatementType.Update:
              dbCommand2 = this.UpdateCommand;
              break;
            case StatementType.Delete:
              dbCommand2 = this.DeleteCommand;
              break;
            default:
              throw ADP.InvalidStatementType(statementType);
          }
          if (dbCommand2 != rowUpdatingEvent.Command)
          {
            dbCommand1 = (DbCommand) rowUpdatingEvent.Command;
            if (dbCommand1 != null && dbCommand1.Connection == null)
            {
              DbCommand selectCommand = this.DataAdapter?.SelectCommand;
              if (selectCommand != null)
                dbCommand1.Connection = selectCommand.Connection;
            }
          }
          else
            dbCommand1 = (DbCommand) null;
        }
        if (dbCommand1 != null)
          return;
        this.RowUpdatingHandlerBuilder(rowUpdatingEvent);
      }
      catch (Exception ex)
      {
        if (!ADP.IsCatchableExceptionType(ex))
        {
          throw;
        }
        else
        {
          ADP.TraceExceptionForCapture(ex);
          rowUpdatingEvent.Status = UpdateStatus.ErrorsOccurred;
          rowUpdatingEvent.Errors = ex;
        }
      }
    }

    private void RowUpdatingHandlerBuilder(RowUpdatingEventArgs rowUpdatingEvent)
    {
      DataRow row = rowUpdatingEvent.Row;
      this.BuildCache(false, row, false);
      DbCommand dbCommand;
      switch (rowUpdatingEvent.StatementType)
      {
        case StatementType.Select:
          Debug.Assert(false, "how did we get here?");
          goto default;
        case StatementType.Insert:
          dbCommand = this.BuildInsertCommand(rowUpdatingEvent.TableMapping, row);
          break;
        case StatementType.Update:
          dbCommand = this.BuildUpdateCommand(rowUpdatingEvent.TableMapping, row);
          break;
        case StatementType.Delete:
          dbCommand = this.BuildDeleteCommand(rowUpdatingEvent.TableMapping, row);
          break;
        default:
          throw ADP.InvalidStatementType(rowUpdatingEvent.StatementType);
      }
      if (dbCommand == null)
      {
        row?.AcceptChanges();
        rowUpdatingEvent.Status = UpdateStatus.SkipCurrentRow;
      }
      rowUpdatingEvent.Command = (IDbCommand) dbCommand;
    }

    public virtual string UnquoteIdentifier(string quotedIdentifier) => throw ADP.NotSupported();

    protected abstract void ApplyParameterInfo(
      DbParameter parameter,
      DataRow row,
      StatementType statementType,
      bool whereClause);

    protected abstract string GetParameterName(int parameterOrdinal);

    protected abstract string GetParameterName(string parameterName);

    protected abstract string GetParameterPlaceholder(int parameterOrdinal);

    protected abstract void SetRowUpdatingHandler(DbDataAdapter adapter);

    private class ParameterNames
    {
      private const string DefaultOriginalPrefix = "Original_";
      private const string DefaultIsNullPrefix = "IsNull_";
      private const string AlternativeOriginalPrefix = "original";
      private const string AlternativeIsNullPrefix = "isnull";
      private const string AlternativeOriginalPrefix2 = "ORIGINAL";
      private const string AlternativeIsNullPrefix2 = "ISNULL";
      private string _originalPrefix;
      private string _isNullPrefix;
      private Regex _parameterNameParser;
      private DbCommandBuilder _dbCommandBuilder;
      private string[] _baseParameterNames;
      private string[] _originalParameterNames;
      private string[] _nullParameterNames;
      private bool[] _isMutatedName;
      private int _count;
      private int _genericParameterCount;
      private int _adjustedParameterNameMaxLength;

      internal ParameterNames(DbCommandBuilder dbCommandBuilder, DbSchemaRow[] schemaRows)
      {
        this._dbCommandBuilder = dbCommandBuilder;
        this._baseParameterNames = new string[schemaRows.Length];
        this._originalParameterNames = new string[schemaRows.Length];
        this._nullParameterNames = new string[schemaRows.Length];
        this._isMutatedName = new bool[schemaRows.Length];
        this._count = schemaRows.Length;
        this._parameterNameParser = new Regex(this._dbCommandBuilder.ParameterNamePattern, RegexOptions.ExplicitCapture | RegexOptions.Singleline);
        this.SetAndValidateNamePrefixes();
        this._adjustedParameterNameMaxLength = this.GetAdjustedParameterNameMaxLength();
        for (int index = 0; index < schemaRows.Length; ++index)
        {
          if (schemaRows[index] != null)
          {
            bool flag = false;
            string input = schemaRows[index].ColumnName;
            if ((this._originalPrefix == null || !input.StartsWith(this._originalPrefix, StringComparison.OrdinalIgnoreCase)) && (this._isNullPrefix == null || !input.StartsWith(this._isNullPrefix, StringComparison.OrdinalIgnoreCase)))
            {
              if (input.IndexOf(' ') >= 0)
              {
                input = input.Replace(' ', '_');
                flag = true;
              }
              if (this._parameterNameParser.IsMatch(input) && input.Length <= this._adjustedParameterNameMaxLength)
              {
                this._baseParameterNames[index] = input;
                this._isMutatedName[index] = flag;
              }
            }
          }
        }
        this.EliminateConflictingNames();
        for (int index = 0; index < schemaRows.Length; ++index)
        {
          if (this._baseParameterNames[index] != null)
          {
            if (this._originalPrefix != null)
              this._originalParameterNames[index] = this._originalPrefix + this._baseParameterNames[index];
            if (this._isNullPrefix != null && schemaRows[index].AllowDBNull)
              this._nullParameterNames[index] = this._isNullPrefix + this._baseParameterNames[index];
          }
        }
        this.ApplyProviderSpecificFormat();
        this.GenerateMissingNames(schemaRows);
      }

      private void SetAndValidateNamePrefixes()
      {
        this._isNullPrefix = !this._parameterNameParser.IsMatch("IsNull_") ? (!this._parameterNameParser.IsMatch("isnull") ? (!this._parameterNameParser.IsMatch("ISNULL") ? (string) null : "ISNULL") : "isnull") : "IsNull_";
        if (this._parameterNameParser.IsMatch("Original_"))
          this._originalPrefix = "Original_";
        else if (this._parameterNameParser.IsMatch("original"))
          this._originalPrefix = "original";
        else if (this._parameterNameParser.IsMatch("ORIGINAL"))
          this._originalPrefix = "ORIGINAL";
        else
          this._originalPrefix = (string) null;
      }

      private void ApplyProviderSpecificFormat()
      {
        for (int index = 0; index < this._baseParameterNames.Length; ++index)
        {
          if (this._baseParameterNames[index] != null)
            this._baseParameterNames[index] = this._dbCommandBuilder.GetParameterName(this._baseParameterNames[index]);
          if (this._originalParameterNames[index] != null)
            this._originalParameterNames[index] = this._dbCommandBuilder.GetParameterName(this._originalParameterNames[index]);
          if (this._nullParameterNames[index] != null)
            this._nullParameterNames[index] = this._dbCommandBuilder.GetParameterName(this._nullParameterNames[index]);
        }
      }

      private void EliminateConflictingNames()
      {
        for (int index1 = 0; index1 < this._count - 1; ++index1)
        {
          string baseParameterName = this._baseParameterNames[index1];
          if (baseParameterName != null)
          {
            for (int index2 = index1 + 1; index2 < this._count; ++index2)
            {
              if (ADP.CompareInsensitiveInvariant(baseParameterName, this._baseParameterNames[index2]))
              {
                int index3 = this._isMutatedName[index2] ? index2 : index1;
                Debug.Assert((this._isMutatedName[index3] ? 1 : 0) != 0, string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0} expected to be a mutated name", (object) this._baseParameterNames[index3]));
                this._baseParameterNames[index3] = (string) null;
              }
            }
          }
        }
      }

      internal void GenerateMissingNames(DbSchemaRow[] schemaRows)
      {
        for (int index = 0; index < this._baseParameterNames.Length; ++index)
        {
          if (this._baseParameterNames[index] == null)
          {
            this._baseParameterNames[index] = this.GetNextGenericParameterName();
            this._originalParameterNames[index] = this.GetNextGenericParameterName();
            if (schemaRows[index] != null && schemaRows[index].AllowDBNull)
              this._nullParameterNames[index] = this.GetNextGenericParameterName();
          }
        }
      }

      private int GetAdjustedParameterNameMaxLength() => this._dbCommandBuilder.ParameterNameMaxLength - (Math.Max(this._isNullPrefix != null ? this._isNullPrefix.Length : 0, this._originalPrefix != null ? this._originalPrefix.Length : 0) + this._dbCommandBuilder.GetParameterName("").Length);

      private string GetNextGenericParameterName()
      {
        bool flag;
        string parameterName;
        do
        {
          flag = false;
          ++this._genericParameterCount;
          parameterName = this._dbCommandBuilder.GetParameterName(this._genericParameterCount);
          for (int index = 0; index < this._baseParameterNames.Length; ++index)
          {
            if (ADP.CompareInsensitiveInvariant(this._baseParameterNames[index], parameterName))
            {
              flag = true;
              break;
            }
          }
        }
        while (flag);
        return parameterName;
      }

      internal string GetBaseParameterName(int index) => this._baseParameterNames[index];

      internal string GetOriginalParameterName(int index) => this._originalParameterNames[index];

      internal string GetNullParameterName(int index) => this._nullParameterNames[index];
    }
  }
}
