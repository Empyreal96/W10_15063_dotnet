// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbDataAdapter
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.ProviderBase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbDataAdapter : DataAdapter, IDbDataAdapter, IDataAdapter, Microsoft.Phone.Data.Workaround.ICloneable
  {
    public const string DefaultSourceTableName = "Table";
    internal static readonly object ParameterValueNonNullValue = (object) 0;
    internal static readonly object ParameterValueNullValue = (object) 1;
    private IDbCommand _deleteCommand;
    private IDbCommand _insertCommand;
    private IDbCommand _selectCommand;
    private IDbCommand _updateCommand;
    private CommandBehavior _fillCommandBehavior;

    protected DbDataAdapter()
    {
    }

    protected DbDataAdapter(DbDataAdapter adapter)
      : base((DataAdapter) adapter)
    {
      this.CloneFrom(adapter);
    }

    private IDbDataAdapter _IDbDataAdapter => (IDbDataAdapter) this;

    public DbCommand DeleteCommand
    {
      get => (DbCommand) this._IDbDataAdapter.DeleteCommand;
      set => this._IDbDataAdapter.DeleteCommand = (IDbCommand) value;
    }

    IDbCommand IDbDataAdapter.DeleteCommand
    {
      get => this._deleteCommand;
      set => this._deleteCommand = value;
    }

    protected internal CommandBehavior FillCommandBehavior
    {
      get => this._fillCommandBehavior | CommandBehavior.SequentialAccess;
      set => this._fillCommandBehavior = value | CommandBehavior.SequentialAccess;
    }

    public DbCommand InsertCommand
    {
      get => (DbCommand) this._IDbDataAdapter.InsertCommand;
      set => this._IDbDataAdapter.InsertCommand = (IDbCommand) value;
    }

    IDbCommand IDbDataAdapter.InsertCommand
    {
      get => this._insertCommand;
      set => this._insertCommand = value;
    }

    public DbCommand SelectCommand
    {
      get => (DbCommand) this._IDbDataAdapter.SelectCommand;
      set => this._IDbDataAdapter.SelectCommand = (IDbCommand) value;
    }

    IDbCommand IDbDataAdapter.SelectCommand
    {
      get => this._selectCommand;
      set => this._selectCommand = value;
    }

    public virtual int UpdateBatchSize
    {
      get => 1;
      set
      {
        if (1 != value)
          throw ADP.NotSupported();
      }
    }

    public DbCommand UpdateCommand
    {
      get => (DbCommand) this._IDbDataAdapter.UpdateCommand;
      set => this._IDbDataAdapter.UpdateCommand = (IDbCommand) value;
    }

    IDbCommand IDbDataAdapter.UpdateCommand
    {
      get => this._updateCommand;
      set => this._updateCommand = value;
    }

    private MissingMappingAction UpdateMappingAction => MissingMappingAction.Passthrough == this.MissingMappingAction ? MissingMappingAction.Passthrough : MissingMappingAction.Error;

    private MissingSchemaAction UpdateSchemaAction
    {
      get
      {
        MissingSchemaAction missingSchemaAction = this.MissingSchemaAction;
        return MissingSchemaAction.Add == missingSchemaAction || MissingSchemaAction.AddWithKey == missingSchemaAction ? MissingSchemaAction.Ignore : MissingSchemaAction.Error;
      }
    }

    protected virtual int AddToBatch(IDbCommand command) => throw ADP.NotSupported();

    protected virtual void ClearBatch() => throw ADP.NotSupported();

    object Microsoft.Phone.Data.Workaround.ICloneable.Clone()
    {
      DbDataAdapter dbDataAdapter = (DbDataAdapter) this.CloneInternals();
      dbDataAdapter.CloneFrom(this);
      return (object) dbDataAdapter;
    }

    private void CloneFrom(DbDataAdapter from)
    {
      IDbDataAdapter idbDataAdapter = from._IDbDataAdapter;
      this._IDbDataAdapter.SelectCommand = this.CloneCommand(idbDataAdapter.SelectCommand);
      this._IDbDataAdapter.InsertCommand = this.CloneCommand(idbDataAdapter.InsertCommand);
      this._IDbDataAdapter.UpdateCommand = this.CloneCommand(idbDataAdapter.UpdateCommand);
      this._IDbDataAdapter.DeleteCommand = this.CloneCommand(idbDataAdapter.DeleteCommand);
    }

    private IDbCommand CloneCommand(IDbCommand command) => command is Microsoft.Phone.Data.Workaround.ICloneable ? (IDbCommand) ((Microsoft.Phone.Data.Workaround.ICloneable) command).Clone() : (IDbCommand) (object) null;

    protected virtual RowUpdatedEventArgs CreateRowUpdatedEvent(
      DataRow dataRow,
      IDbCommand command,
      StatementType statementType,
      DataTableMapping tableMapping)
    {
      return new RowUpdatedEventArgs(dataRow, command, statementType, tableMapping);
    }

    protected virtual RowUpdatingEventArgs CreateRowUpdatingEvent(
      DataRow dataRow,
      IDbCommand command,
      StatementType statementType,
      DataTableMapping tableMapping)
    {
      return new RowUpdatingEventArgs(dataRow, command, statementType, tableMapping);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        DbDataAdapter dbDataAdapter = this;
        ((IDbDataAdapter) dbDataAdapter).SelectCommand = (IDbCommand) null;
        ((IDbDataAdapter) dbDataAdapter).InsertCommand = (IDbCommand) null;
        ((IDbDataAdapter) dbDataAdapter).UpdateCommand = (IDbCommand) null;
        ((IDbDataAdapter) dbDataAdapter).DeleteCommand = (IDbCommand) null;
      }
      base.Dispose(disposing);
    }

    protected virtual int ExecuteBatch() => throw ADP.NotSupported();

    public DataTable FillSchema(DataTable dataTable, SchemaType schemaType)
    {
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
      return this.FillSchema(dataTable, schemaType, selectCommand, fillCommandBehavior);
    }

    public override DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
    {
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
      return this.FillSchema(dataSet, schemaType, selectCommand, "Table", fillCommandBehavior);
    }

    public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType, string srcTable)
    {
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
      return this.FillSchema(dataSet, schemaType, selectCommand, srcTable, fillCommandBehavior);
    }

    protected virtual DataTable[] FillSchema(
      DataSet dataSet,
      SchemaType schemaType,
      IDbCommand command,
      string srcTable,
      CommandBehavior behavior)
    {
      if (dataSet == null)
        throw ADP.ArgumentNull(nameof (dataSet));
      if (SchemaType.Source != schemaType && SchemaType.Mapped != schemaType)
        throw ADP.InvalidSchemaType(schemaType);
      if (ADP.IsEmpty(srcTable))
        throw ADP.FillSchemaRequiresSourceTableName(nameof (srcTable));
      if (command == null)
        throw ADP.MissingSelectCommand(nameof (FillSchema));
      return (DataTable[]) this.FillSchemaInternal(dataSet, (DataTable) null, schemaType, command, srcTable, behavior);
    }

    protected virtual DataTable FillSchema(
      DataTable dataTable,
      SchemaType schemaType,
      IDbCommand command,
      CommandBehavior behavior)
    {
      if (dataTable == null)
        throw ADP.ArgumentNull(nameof (dataTable));
      if (SchemaType.Source != schemaType && SchemaType.Mapped != schemaType)
        throw ADP.InvalidSchemaType(schemaType);
      if (command == null)
        throw ADP.MissingSelectCommand(nameof (FillSchema));
      string str = dataTable.TableName;
      int index = this.IndexOfDataSetTable(str);
      if (-1 != index)
        str = this.TableMappings[index].SourceTable;
      return (DataTable) this.FillSchemaInternal((DataSet) null, dataTable, schemaType, command, str, behavior | CommandBehavior.SingleResult);
    }

    private object FillSchemaInternal(
      DataSet dataset,
      DataTable datatable,
      SchemaType schemaType,
      IDbCommand command,
      string srcTable,
      CommandBehavior behavior)
    {
      bool flag = command.Connection == null;
      try
      {
        IDbConnection connection3 = DbDataAdapter.GetConnection3(this, command, "FillSchema");
        ConnectionState originalState = ConnectionState.Open;
        try
        {
          DbDataAdapter.QuietOpen(connection3, out originalState);
          using (IDataReader dataReader = command.ExecuteReader(behavior | CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo))
            return datatable != null ? (object) this.FillSchema(datatable, schemaType, dataReader) : (object) this.FillSchema(dataset, schemaType, srcTable, dataReader);
        }
        finally
        {
          DbDataAdapter.QuietClose(connection3, originalState);
        }
      }
      finally
      {
        if (flag)
        {
          command.Transaction = (IDbTransaction) null;
          command.Connection = (IDbConnection) null;
        }
      }
    }

    public override int Fill(DataSet dataSet)
    {
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
      return this.Fill(dataSet, 0, 0, "Table", selectCommand, fillCommandBehavior);
    }

    public int Fill(DataSet dataSet, string srcTable)
    {
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
      return this.Fill(dataSet, 0, 0, srcTable, selectCommand, fillCommandBehavior);
    }

    public int Fill(DataSet dataSet, int startRecord, int maxRecords, string srcTable)
    {
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
      return this.Fill(dataSet, startRecord, maxRecords, srcTable, selectCommand, fillCommandBehavior);
    }

    protected virtual int Fill(
      DataSet dataSet,
      int startRecord,
      int maxRecords,
      string srcTable,
      IDbCommand command,
      CommandBehavior behavior)
    {
      if (dataSet == null)
        throw ADP.FillRequires(nameof (dataSet));
      if (startRecord < 0)
        throw ADP.InvalidStartRecord(nameof (startRecord), startRecord);
      if (maxRecords < 0)
        throw ADP.InvalidMaxRecords(nameof (maxRecords), maxRecords);
      if (ADP.IsEmpty(srcTable))
        throw ADP.FillRequiresSourceTableName(nameof (srcTable));
      if (command == null)
        throw ADP.MissingSelectCommand(nameof (Fill));
      return this.FillInternal(dataSet, (DataTable[]) null, startRecord, maxRecords, srcTable, command, behavior);
    }

    public int Fill(DataTable dataTable) => this.Fill(new DataTable[1]
    {
      dataTable
    }, 0, 0, this._IDbDataAdapter.SelectCommand, this.FillCommandBehavior);

    public int Fill(int startRecord, int maxRecords, params DataTable[] dataTables)
    {
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
      return this.Fill(dataTables, startRecord, maxRecords, selectCommand, fillCommandBehavior);
    }

    protected virtual int Fill(DataTable dataTable, IDbCommand command, CommandBehavior behavior) => this.Fill(new DataTable[1]
    {
      dataTable
    }, 0, 0, command, behavior);

    protected virtual int Fill(
      DataTable[] dataTables,
      int startRecord,
      int maxRecords,
      IDbCommand command,
      CommandBehavior behavior)
    {
      if (dataTables == null || dataTables.Length == 0 || dataTables[0] == null)
        throw ADP.FillRequires("dataTable");
      if (startRecord < 0)
        throw ADP.InvalidStartRecord(nameof (startRecord), startRecord);
      if (maxRecords < 0)
        throw ADP.InvalidMaxRecords(nameof (maxRecords), maxRecords);
      if (1 < dataTables.Length && (startRecord != 0 || maxRecords != 0))
        throw ADP.OnlyOneTableForStartRecordOrMaxRecords();
      if (command == null)
        throw ADP.MissingSelectCommand(nameof (Fill));
      if (1 == dataTables.Length)
        behavior |= CommandBehavior.SingleResult;
      return this.FillInternal((DataSet) null, dataTables, startRecord, maxRecords, (string) null, command, behavior);
    }

    private int FillInternal(
      DataSet dataset,
      DataTable[] datatables,
      int startRecord,
      int maxRecords,
      string srcTable,
      IDbCommand command,
      CommandBehavior behavior)
    {
      bool flag = command.Connection == null;
      try
      {
        IDbConnection connection3 = DbDataAdapter.GetConnection3(this, command, "Fill");
        ConnectionState originalState = ConnectionState.Open;
        if (MissingSchemaAction.AddWithKey == this.MissingSchemaAction)
          behavior |= CommandBehavior.KeyInfo;
        try
        {
          DbDataAdapter.QuietOpen(connection3, out originalState);
          behavior |= CommandBehavior.SequentialAccess;
          IDataReader dataReader = (IDataReader) null;
          try
          {
            dataReader = command.ExecuteReader(behavior);
            return datatables != null ? this.Fill(datatables, dataReader, startRecord, maxRecords) : this.Fill(dataset, srcTable, dataReader, startRecord, maxRecords);
          }
          finally
          {
            dataReader?.Dispose();
          }
        }
        finally
        {
          DbDataAdapter.QuietClose(connection3, originalState);
        }
      }
      finally
      {
        if (flag)
        {
          command.Transaction = (IDbTransaction) null;
          command.Connection = (IDbConnection) null;
        }
      }
    }

    protected virtual IDataParameter GetBatchedParameter(
      int commandIdentifier,
      int parameterIndex)
    {
      throw ADP.NotSupported();
    }

    protected virtual bool GetBatchedRecordsAffected(
      int commandIdentifier,
      out int recordsAffected,
      out Exception error)
    {
      recordsAffected = 1;
      error = (Exception) null;
      return true;
    }

    public override IDataParameter[] GetFillParameters()
    {
      IDataParameter[] dataParameterArray = (IDataParameter[]) null;
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      if (selectCommand != null)
      {
        IDataParameterCollection parameters = selectCommand.Parameters;
        if (parameters != null)
        {
          dataParameterArray = new IDataParameter[parameters.Count];
          parameters.CopyTo((Array) dataParameterArray, 0);
        }
      }
      if (dataParameterArray == null)
        dataParameterArray = new IDataParameter[0];
      return dataParameterArray;
    }

    internal DataTableMapping GetTableMapping(DataTable dataTable)
    {
      DataTableMapping dataTableMapping = (DataTableMapping) null;
      int index = this.IndexOfDataSetTable(dataTable.TableName);
      if (-1 != index)
        dataTableMapping = this.TableMappings[index];
      if (dataTableMapping == null)
      {
        if (MissingMappingAction.Error == this.MissingMappingAction)
          throw ADP.MissingTableMappingDestination(dataTable.TableName);
        dataTableMapping = new DataTableMapping(dataTable.TableName, dataTable.TableName);
      }
      return dataTableMapping;
    }

    protected virtual void InitializeBatching() => throw ADP.NotSupported();

    protected virtual void OnRowUpdated(RowUpdatedEventArgs value)
    {
    }

    protected virtual void OnRowUpdating(RowUpdatingEventArgs value)
    {
    }

    private void ParameterInput(
      IDataParameterCollection parameters,
      StatementType typeIndex,
      DataRow row,
      DataTableMapping mappings)
    {
      MissingMappingAction updateMappingAction = this.UpdateMappingAction;
      MissingSchemaAction updateSchemaAction = this.UpdateSchemaAction;
      foreach (IDataParameter parameter in (IEnumerable) parameters)
      {
        if (parameter != null && (ParameterDirection.Input & parameter.Direction) != (ParameterDirection) 0)
        {
          string sourceColumn = parameter.SourceColumn;
          if (!ADP.IsEmpty(sourceColumn))
          {
            DataColumn dataColumn = mappings.GetDataColumn(sourceColumn, (Type) null, row.Table, updateMappingAction, updateSchemaAction);
            if (dataColumn != null)
            {
              DataRowVersion parameterSourceVersion = DbDataAdapter.GetParameterSourceVersion(typeIndex, parameter);
              parameter.Value = row[dataColumn, parameterSourceVersion];
            }
            else
              parameter.Value = (object) null;
            if (parameter is DbParameter dbParameter5 && dbParameter5.SourceColumnNullMapping)
            {
              Debug.Assert(DbType.Int32 == parameter.DbType, "unexpected DbType");
              parameter.Value = ADP.IsNull(parameter.Value) ? DbDataAdapter.ParameterValueNullValue : DbDataAdapter.ParameterValueNonNullValue;
            }
          }
        }
      }
    }

    private void ParameterOutput(
      IDataParameter parameter,
      DataRow row,
      DataTableMapping mappings,
      MissingMappingAction missingMapping,
      MissingSchemaAction missingSchema)
    {
      if ((ParameterDirection.Output & parameter.Direction) == (ParameterDirection) 0)
        return;
      object obj = parameter.Value;
      if (obj == null)
        return;
      string sourceColumn = parameter.SourceColumn;
      if (ADP.IsEmpty(sourceColumn))
        return;
      DataColumn dataColumn = mappings.GetDataColumn(sourceColumn, (Type) null, row.Table, missingMapping, missingSchema);
      if (dataColumn == null)
        return;
      if (dataColumn.ReadOnly)
      {
        try
        {
          dataColumn.ReadOnly = false;
          row[dataColumn] = obj;
        }
        finally
        {
          dataColumn.ReadOnly = true;
        }
      }
      else
        row[dataColumn] = obj;
    }

    private void ParameterOutput(
      IDataParameterCollection parameters,
      DataRow row,
      DataTableMapping mappings)
    {
      MissingMappingAction updateMappingAction = this.UpdateMappingAction;
      MissingSchemaAction updateSchemaAction = this.UpdateSchemaAction;
      foreach (IDataParameter parameter in (IEnumerable) parameters)
      {
        if (parameter != null)
          this.ParameterOutput(parameter, row, mappings, updateMappingAction, updateSchemaAction);
      }
    }

    protected virtual void TerminateBatching() => throw ADP.NotSupported();

    public override int Update(DataSet dataSet) => this.Update(dataSet, "Table");

    public int Update(DataRow[] dataRows)
    {
      if (dataRows == null)
        throw ADP.ArgumentNull(nameof (dataRows));
      int num = 0;
      if (dataRows != null || dataRows.Length != 0)
      {
        DataTable dataTable = (DataTable) null;
        for (int i = 0; i < dataRows.Length; ++i)
        {
          if (dataRows[i] != null && dataTable != dataRows[i].Table)
          {
            if (dataTable != null)
              throw ADP.UpdateMismatchRowTable(i);
            dataTable = dataRows[i].Table;
          }
        }
        if (dataTable != null)
        {
          DataTableMapping tableMapping = this.GetTableMapping(dataTable);
          num = this.Update(dataRows, tableMapping);
        }
      }
      return num;
    }

    public int Update(DataTable dataTable)
    {
      if (dataTable == null)
        throw ADP.UpdateRequiresDataTable(nameof (dataTable));
      DataTableMapping tableMapping = (DataTableMapping) null;
      int index = this.IndexOfDataSetTable(dataTable.TableName);
      if (-1 != index)
        tableMapping = this.TableMappings[index];
      if (tableMapping == null)
      {
        if (MissingMappingAction.Error == this.MissingMappingAction)
          throw ADP.MissingTableMappingDestination(dataTable.TableName);
        tableMapping = new DataTableMapping("Table", dataTable.TableName);
      }
      return this.UpdateFromDataTable(dataTable, tableMapping);
    }

    public int Update(DataSet dataSet, string srcTable)
    {
      if (dataSet == null)
        throw ADP.UpdateRequiresNonNullDataSet(nameof (dataSet));
      if (ADP.IsEmpty(srcTable))
        throw ADP.UpdateRequiresSourceTableName(nameof (srcTable));
      int num = 0;
      int updateMappingAction = (int) this.UpdateMappingAction;
      string str = srcTable;
      DataTableMapping mappingBySchemaAction = this.GetTableMappingBySchemaAction(str, str, this.UpdateMappingAction);
      Debug.Assert(mappingBySchemaAction != null, "null TableMapping when MissingMappingAction.Error");
      MissingSchemaAction updateSchemaAction = this.UpdateSchemaAction;
      DataTable tableBySchemaAction = mappingBySchemaAction.GetDataTableBySchemaAction(dataSet, updateSchemaAction);
      if (tableBySchemaAction != null)
        num = this.UpdateFromDataTable(tableBySchemaAction, mappingBySchemaAction);
      else if (!this.HasTableMappings() || -1 == this.TableMappings.IndexOf((object) mappingBySchemaAction))
        throw ADP.UpdateRequiresSourceTable(srcTable);
      return num;
    }

    protected virtual int Update(DataRow[] dataRows, DataTableMapping tableMapping)
    {
      Debug.Assert(dataRows != null && (uint) dataRows.Length > 0U, "Update: bad dataRows");
      Debug.Assert(tableMapping != null, "Update: bad DataTableMapping");
      int num = 0;
      IDbConnection[] connections = new IDbConnection[5];
      ConnectionState[] connectionStates = new ConnectionState[5];
      bool useSelectConnectionState = false;
      IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
      if (selectCommand != null)
      {
        connections[0] = selectCommand.Connection;
        if (connections[0] != null)
        {
          connectionStates[0] = connections[0].State;
          useSelectConnectionState = true;
        }
      }
      int length1 = Math.Min(this.UpdateBatchSize, dataRows.Length);
      if (length1 < 1)
        length1 = dataRows.Length;
      DbDataAdapter.BatchCommandInfo[] batchCommands = new DbDataAdapter.BatchCommandInfo[length1];
      DataRow[] dataRows1 = new DataRow[length1];
      int length2 = 0;
      try
      {
        try
        {
          if (1 != length1)
            this.InitializeBatching();
          StatementType statementType = StatementType.Select;
          IDbCommand dbCommand = (IDbCommand) null;
          foreach (DataRow dataRow in dataRows)
          {
            if (dataRow != null)
            {
              IDbCommand command1;
              switch (dataRow.RowState)
              {
                case DataRowState.Detached:
                case DataRowState.Unchanged:
                  continue;
                case DataRowState.Added:
                  statementType = StatementType.Insert;
                  command1 = this._IDbDataAdapter.InsertCommand;
                  break;
                case DataRowState.Deleted:
                  statementType = StatementType.Delete;
                  command1 = this._IDbDataAdapter.DeleteCommand;
                  break;
                case DataRowState.Modified:
                  statementType = StatementType.Update;
                  command1 = this._IDbDataAdapter.UpdateCommand;
                  break;
                default:
                  Debug.Assert(false, "InvalidDataRowState");
                  throw ADP.InvalidDataRowState(dataRow.RowState);
              }
              RowUpdatingEventArgs rowUpdatingEvent = this.CreateRowUpdatingEvent(dataRow, command1, statementType, tableMapping);
              try
              {
                dataRow.RowError = (string) null;
                if (command1 != null)
                  this.ParameterInput(command1.Parameters, statementType, dataRow, tableMapping);
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
                  rowUpdatingEvent.Errors = ex;
                  rowUpdatingEvent.Status = UpdateStatus.ErrorsOccurred;
                }
              }
              this.OnRowUpdating(rowUpdatingEvent);
              IDbCommand command2 = rowUpdatingEvent.Command;
              bool flag1 = command1 != command2;
              dbCommand = command2;
              UpdateStatus status = rowUpdatingEvent.Status;
              if (status != UpdateStatus.Continue)
              {
                if (UpdateStatus.ErrorsOccurred == status)
                  this.UpdatingRowStatusErrors(rowUpdatingEvent, dataRow);
                else if (UpdateStatus.SkipCurrentRow == status)
                {
                  if (DataRowState.Unchanged == dataRow.RowState)
                    ++num;
                }
                else
                {
                  if (UpdateStatus.SkipAllRemainingRows != status)
                    throw ADP.InvalidUpdateStatus(status);
                  if (DataRowState.Unchanged == dataRow.RowState)
                  {
                    ++num;
                    break;
                  }
                  break;
                }
              }
              else
              {
                if (1 == length1)
                {
                  if (dbCommand != null)
                  {
                    batchCommands[0].CommandIdentifier = 0;
                    batchCommands[0].ParameterCount = dbCommand.Parameters.Count;
                    batchCommands[0].StatementType = statementType;
                    batchCommands[0].UpdatedRowSource = dbCommand.UpdatedRowSource;
                  }
                  batchCommands[0].Row = dataRow;
                  dataRows1[0] = dataRow;
                  length2 = 1;
                }
                else
                {
                  Exception exception = (Exception) null;
                  try
                  {
                    if (dbCommand != null)
                    {
                      if ((UpdateRowSource.FirstReturnedRecord & dbCommand.UpdatedRowSource) == UpdateRowSource.None)
                      {
                        batchCommands[length2].CommandIdentifier = this.AddToBatch(dbCommand);
                        batchCommands[length2].ParameterCount = dbCommand.Parameters.Count;
                        batchCommands[length2].Row = dataRow;
                        batchCommands[length2].StatementType = statementType;
                        batchCommands[length2].UpdatedRowSource = dbCommand.UpdatedRowSource;
                        dataRows1[length2] = dataRow;
                        ++length2;
                        if (length2 < length1)
                          continue;
                      }
                      else
                        exception = (Exception) ADP.ResultsNotAllowedDuringBatch();
                    }
                    else
                      exception = (Exception) ADP.UpdateRequiresCommand(statementType, flag1);
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
                      exception = ex;
                    }
                  }
                  if (exception != null)
                  {
                    RowUpdatedEventArgs rowUpdatedEvent = this.CreateRowUpdatedEvent(dataRow, dbCommand, StatementType.Batch, tableMapping);
                    rowUpdatedEvent.Errors = exception;
                    rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
                    this.OnRowUpdated(rowUpdatedEvent);
                    if (exception != rowUpdatedEvent.Errors)
                    {
                      for (int index = 0; index < batchCommands.Length; ++index)
                        batchCommands[index].Errors = (Exception) null;
                    }
                    num += this.UpdatedRowStatus(rowUpdatedEvent, batchCommands, length2);
                    if (UpdateStatus.SkipAllRemainingRows != rowUpdatedEvent.Status)
                      continue;
                    break;
                  }
                }
                RowUpdatedEventArgs rowUpdatedEvent1 = this.CreateRowUpdatedEvent(dataRow, dbCommand, statementType, tableMapping);
                try
                {
                  if (1 != length1)
                  {
                    ConnectionState state = this.UpdateConnectionOpen(DbDataAdapter.GetConnection1(this), StatementType.Batch, connections, connectionStates, useSelectConnectionState);
                    rowUpdatedEvent1.AdapterInit(dataRows1);
                    if (ConnectionState.Open == state)
                    {
                      this.UpdateBatchExecute(batchCommands, length2, rowUpdatedEvent1);
                    }
                    else
                    {
                      rowUpdatedEvent1.Errors = (Exception) ADP.UpdateOpenConnectionRequired(StatementType.Batch, false, state);
                      rowUpdatedEvent1.Status = UpdateStatus.ErrorsOccurred;
                    }
                  }
                  else if (dbCommand != null)
                  {
                    ConnectionState state = this.UpdateConnectionOpen(DbDataAdapter.GetConnection4(this, dbCommand, statementType, flag1), statementType, connections, connectionStates, useSelectConnectionState);
                    if (ConnectionState.Open == state)
                    {
                      this.UpdateRowExecute(rowUpdatedEvent1, dbCommand, statementType);
                      batchCommands[0].RecordsAffected = new int?(rowUpdatedEvent1.RecordsAffected);
                      batchCommands[0].Errors = (Exception) null;
                    }
                    else
                    {
                      rowUpdatedEvent1.Errors = (Exception) ADP.UpdateOpenConnectionRequired(statementType, flag1, state);
                      rowUpdatedEvent1.Status = UpdateStatus.ErrorsOccurred;
                    }
                  }
                  else
                  {
                    rowUpdatedEvent1.Errors = (Exception) ADP.UpdateRequiresCommand(statementType, flag1);
                    rowUpdatedEvent1.Status = UpdateStatus.ErrorsOccurred;
                  }
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
                    rowUpdatedEvent1.Errors = ex;
                    rowUpdatedEvent1.Status = UpdateStatus.ErrorsOccurred;
                  }
                }
                bool flag2 = UpdateStatus.ErrorsOccurred == rowUpdatedEvent1.Status;
                Exception errors1 = rowUpdatedEvent1.Errors;
                this.OnRowUpdated(rowUpdatedEvent1);
                Exception errors2 = rowUpdatedEvent1.Errors;
                if (errors1 != errors2)
                {
                  for (int index = 0; index < batchCommands.Length; ++index)
                    batchCommands[index].Errors = (Exception) null;
                }
                num += this.UpdatedRowStatus(rowUpdatedEvent1, batchCommands, length2);
                if (UpdateStatus.SkipAllRemainingRows == rowUpdatedEvent1.Status)
                {
                  if (flag2 && 1 != length1)
                  {
                    this.ClearBatch();
                    length2 = 0;
                    break;
                  }
                  break;
                }
                if (1 != length1)
                  this.ClearBatch();
                for (int index = 0; index < batchCommands.Length; ++index)
                  batchCommands[index] = new DbDataAdapter.BatchCommandInfo();
                length2 = 0;
              }
            }
          }
          if (1 != length1)
          {
            if (0 < length2)
            {
              RowUpdatedEventArgs rowUpdatedEvent = this.CreateRowUpdatedEvent((DataRow) null, dbCommand, statementType, tableMapping);
              try
              {
                ConnectionState state = this.UpdateConnectionOpen(DbDataAdapter.GetConnection1(this), StatementType.Batch, connections, connectionStates, useSelectConnectionState);
                DataRow[] dataRows2 = dataRows1;
                if (length2 < dataRows1.Length)
                {
                  dataRows2 = new DataRow[length2];
                  Array.Copy((Array) dataRows1, (Array) dataRows2, length2);
                }
                rowUpdatedEvent.AdapterInit(dataRows2);
                if (ConnectionState.Open == state)
                {
                  this.UpdateBatchExecute(batchCommands, length2, rowUpdatedEvent);
                }
                else
                {
                  rowUpdatedEvent.Errors = (Exception) ADP.UpdateOpenConnectionRequired(StatementType.Batch, false, state);
                  rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
                }
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
                  rowUpdatedEvent.Errors = ex;
                  rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
                }
              }
              Exception errors1 = rowUpdatedEvent.Errors;
              this.OnRowUpdated(rowUpdatedEvent);
              Exception errors2 = rowUpdatedEvent.Errors;
              if (errors1 != errors2)
              {
                for (int index = 0; index < batchCommands.Length; ++index)
                  batchCommands[index].Errors = (Exception) null;
              }
              num += this.UpdatedRowStatus(rowUpdatedEvent, batchCommands, length2);
            }
          }
        }
        finally
        {
          if (1 != length1)
            this.TerminateBatching();
        }
      }
      finally
      {
        for (int index = 0; index < connections.Length; ++index)
          DbDataAdapter.QuietClose(connections[index], connectionStates[index]);
      }
      return num;
    }

    private void UpdateBatchExecute(
      DbDataAdapter.BatchCommandInfo[] batchCommands,
      int commandCount,
      RowUpdatedEventArgs rowUpdatedEvent)
    {
      try
      {
        int recordsAffected = this.ExecuteBatch();
        rowUpdatedEvent.AdapterInit(recordsAffected);
      }
      catch (DbException ex)
      {
        ADP.TraceExceptionForCapture((Exception) ex);
        rowUpdatedEvent.Errors = (Exception) ex;
        rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
      }
      MissingMappingAction updateMappingAction = this.UpdateMappingAction;
      MissingSchemaAction updateSchemaAction = this.UpdateSchemaAction;
      int num = 0;
      bool flag = false;
      List<DataRow> dataRowList = (List<DataRow>) null;
      for (int index = 0; index < commandCount; ++index)
      {
        DbDataAdapter.BatchCommandInfo batchCommand = batchCommands[index];
        StatementType statementType = batchCommand.StatementType;
        int recordsAffected;
        if (this.GetBatchedRecordsAffected(batchCommand.CommandIdentifier, out recordsAffected, out batchCommands[index].Errors))
          batchCommands[index].RecordsAffected = new int?(recordsAffected);
        if (batchCommands[index].Errors == null && batchCommands[index].RecordsAffected.HasValue)
        {
          if (StatementType.Update == statementType || StatementType.Delete == statementType)
          {
            ++num;
            if (recordsAffected == 0)
            {
              if (dataRowList == null)
                dataRowList = new List<DataRow>();
              batchCommands[index].Errors = ADP.UpdateConcurrencyViolation(batchCommands[index].StatementType, 0, 1, new DataRow[1]
              {
                rowUpdatedEvent.Rows[index]
              });
              flag = true;
              dataRowList.Add(rowUpdatedEvent.Rows[index]);
            }
          }
          if ((StatementType.Insert == statementType || StatementType.Update == statementType) && ((UpdateRowSource.OutputParameters & batchCommand.UpdatedRowSource) != UpdateRowSource.None && recordsAffected != 0))
          {
            if (StatementType.Insert == statementType)
              rowUpdatedEvent.Rows[index].AcceptChanges();
            for (int parameterIndex = 0; parameterIndex < batchCommand.ParameterCount; ++parameterIndex)
              this.ParameterOutput(this.GetBatchedParameter(batchCommand.CommandIdentifier, parameterIndex), batchCommand.Row, rowUpdatedEvent.TableMapping, updateMappingAction, updateSchemaAction);
          }
        }
      }
      if (rowUpdatedEvent.Errors != null || rowUpdatedEvent.Status != UpdateStatus.Continue || (0 >= num || !(rowUpdatedEvent.RecordsAffected == 0 | flag)))
        return;
      Debug.Assert(rowUpdatedEvent.Errors == null, "Continue - but contains an exception");
      DataRow[] dataRows = dataRowList != null ? dataRowList.ToArray() : rowUpdatedEvent.Rows;
      rowUpdatedEvent.Errors = ADP.UpdateConcurrencyViolation(StatementType.Batch, commandCount - dataRows.Length, commandCount, dataRows);
      rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
    }

    private ConnectionState UpdateConnectionOpen(
      IDbConnection connection,
      StatementType statementType,
      IDbConnection[] connections,
      ConnectionState[] connectionStates,
      bool useSelectConnectionState)
    {
      Debug.Assert(connection != null, "unexpected null connection");
      Debug.Assert(connection != null, "unexpected null connection");
      int index = (int) statementType;
      if (connection != connections[index])
      {
        DbDataAdapter.QuietClose(connections[index], connectionStates[index]);
        connections[index] = connection;
        connectionStates[index] = ConnectionState.Closed;
        DbDataAdapter.QuietOpen(connection, out connectionStates[index]);
        if (useSelectConnectionState && connections[0] == connection)
          connectionStates[index] = connections[0].State;
      }
      return connection.State;
    }

    private int UpdateFromDataTable(DataTable dataTable, DataTableMapping tableMapping)
    {
      int num = 0;
      DataRow[] dataRows = ADP.SelectAdapterRows(dataTable, false);
      if (dataRows != null && dataRows.Length != 0)
        num = this.Update(dataRows, tableMapping);
      return num;
    }

    private void UpdateRowExecute(
      RowUpdatedEventArgs rowUpdatedEvent,
      IDbCommand dataCommand,
      StatementType cmdIndex)
    {
      Debug.Assert(rowUpdatedEvent != null, "null rowUpdatedEvent");
      Debug.Assert(dataCommand != null, "null dataCommand");
      Debug.Assert(rowUpdatedEvent.Command == dataCommand, "dataCommand differs from rowUpdatedEvent");
      bool flag1 = true;
      UpdateRowSource updatedRowSource = dataCommand.UpdatedRowSource;
      if (StatementType.Delete == cmdIndex || (UpdateRowSource.FirstReturnedRecord & updatedRowSource) == UpdateRowSource.None)
      {
        int recordsAffected = dataCommand.ExecuteNonQuery();
        rowUpdatedEvent.AdapterInit(recordsAffected);
      }
      else if (StatementType.Insert == cmdIndex || StatementType.Update == cmdIndex)
      {
        using (IDataReader dataReader1 = dataCommand.ExecuteReader(CommandBehavior.SequentialAccess))
        {
          DataReaderContainer dataReader2 = DataReaderContainer.Create(dataReader1, this.ReturnProviderSpecificTypes);
          try
          {
            bool flag2 = false;
            while (0 >= dataReader2.FieldCount)
            {
              if (!dataReader1.NextResult())
                goto label_9;
            }
            flag2 = true;
label_9:
            if (flag2)
            {
              if (dataReader1.RecordsAffected != 0)
              {
                SchemaMapping schemaMapping = new SchemaMapping((DataAdapter) this, (DataSet) null, rowUpdatedEvent.Row.Table, dataReader2, false, SchemaType.Mapped, rowUpdatedEvent.TableMapping.SourceTable, true, (DataColumn) null, (object) null);
                if (schemaMapping.DataTable != null)
                {
                  if (schemaMapping.DataValues != null)
                  {
                    if (dataReader1.Read())
                    {
                      if (StatementType.Insert == cmdIndex & flag1)
                      {
                        rowUpdatedEvent.Row.AcceptChanges();
                        flag1 = false;
                      }
                      schemaMapping.ApplyToDataRow(rowUpdatedEvent.Row);
                    }
                  }
                }
              }
            }
          }
          finally
          {
            dataReader1.Close();
            int recordsAffected = dataReader1.RecordsAffected;
            rowUpdatedEvent.AdapterInit(recordsAffected);
          }
        }
      }
      else
        Debug.Assert(false, "unexpected StatementType");
      if ((StatementType.Insert == cmdIndex || StatementType.Update == cmdIndex) && ((UpdateRowSource.OutputParameters & updatedRowSource) != UpdateRowSource.None && rowUpdatedEvent.RecordsAffected != 0))
      {
        if (StatementType.Insert == cmdIndex & flag1)
          rowUpdatedEvent.Row.AcceptChanges();
        this.ParameterOutput(dataCommand.Parameters, rowUpdatedEvent.Row, rowUpdatedEvent.TableMapping);
      }
      if (rowUpdatedEvent.Status != UpdateStatus.Continue || cmdIndex != StatementType.Update && cmdIndex != StatementType.Delete || rowUpdatedEvent.RecordsAffected != 0)
        return;
      Debug.Assert(rowUpdatedEvent.Errors == null, "Continue - but contains an exception");
      rowUpdatedEvent.Errors = ADP.UpdateConcurrencyViolation(cmdIndex, rowUpdatedEvent.RecordsAffected, 1, new DataRow[1]
      {
        rowUpdatedEvent.Row
      });
      rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
    }

    private int UpdatedRowStatus(
      RowUpdatedEventArgs rowUpdatedEvent,
      DbDataAdapter.BatchCommandInfo[] batchCommands,
      int commandCount)
    {
      Debug.Assert(rowUpdatedEvent != null, "null rowUpdatedEvent");
      switch (rowUpdatedEvent.Status)
      {
        case UpdateStatus.Continue:
          return this.UpdatedRowStatusContinue(rowUpdatedEvent, batchCommands, commandCount);
        case UpdateStatus.ErrorsOccurred:
          return this.UpdatedRowStatusErrors(rowUpdatedEvent, batchCommands, commandCount);
        case UpdateStatus.SkipCurrentRow:
        case UpdateStatus.SkipAllRemainingRows:
          return this.UpdatedRowStatusSkip(batchCommands, commandCount);
        default:
          throw ADP.InvalidUpdateStatus(rowUpdatedEvent.Status);
      }
    }

    private int UpdatedRowStatusContinue(
      RowUpdatedEventArgs rowUpdatedEvent,
      DbDataAdapter.BatchCommandInfo[] batchCommands,
      int commandCount)
    {
      Debug.Assert(batchCommands != null, "null batchCommands?");
      int num = 0;
      bool changesDuringUpdate = this.AcceptChangesDuringUpdate;
      for (int index = 0; index < commandCount; ++index)
      {
        DataRow row = batchCommands[index].Row;
        if (batchCommands[index].Errors == null && batchCommands[index].RecordsAffected.HasValue && batchCommands[index].RecordsAffected.Value != 0)
        {
          Debug.Assert(row != null, "null dataRow?");
          if (changesDuringUpdate && ((DataRowState.Added | DataRowState.Deleted | DataRowState.Modified) & row.RowState) != (DataRowState) 0)
            row.AcceptChanges();
          ++num;
        }
      }
      return num;
    }

    private int UpdatedRowStatusErrors(
      RowUpdatedEventArgs rowUpdatedEvent,
      DbDataAdapter.BatchCommandInfo[] batchCommands,
      int commandCount)
    {
      Debug.Assert(batchCommands != null, "null batchCommands?");
      Exception exception = rowUpdatedEvent.Errors;
      if (exception == null)
      {
        exception = (Exception) ADP.RowUpdatedErrors();
        rowUpdatedEvent.Errors = exception;
      }
      int num = 0;
      bool flag = false;
      string message = exception.Message;
      for (int index = 0; index < commandCount; ++index)
      {
        DataRow row = batchCommands[index].Row;
        Debug.Assert(row != null, "null dataRow?");
        if (batchCommands[index].Errors != null)
        {
          string str = batchCommands[index].Errors.Message;
          if (string.IsNullOrEmpty(str))
            str = message;
          row.RowError += str;
          flag = true;
        }
      }
      if (!flag)
      {
        for (int index = 0; index < commandCount; ++index)
          batchCommands[index].Row.RowError += message;
      }
      else
        num = this.UpdatedRowStatusContinue(rowUpdatedEvent, batchCommands, commandCount);
      if (!this.ContinueUpdateOnError)
        throw exception;
      return num;
    }

    private int UpdatedRowStatusSkip(
      DbDataAdapter.BatchCommandInfo[] batchCommands,
      int commandCount)
    {
      Debug.Assert(batchCommands != null, "null batchCommands?");
      int num = 0;
      for (int index = 0; index < commandCount; ++index)
      {
        DataRow row = batchCommands[index].Row;
        Debug.Assert(row != null, "null dataRow?");
        if (((DataRowState.Detached | DataRowState.Unchanged) & row.RowState) != (DataRowState) 0)
          ++num;
      }
      return num;
    }

    private void UpdatingRowStatusErrors(RowUpdatingEventArgs rowUpdatedEvent, DataRow dataRow)
    {
      Debug.Assert(dataRow != null, "null dataRow");
      Exception exception = rowUpdatedEvent.Errors;
      if (exception == null)
      {
        exception = (Exception) ADP.RowUpdatingErrors();
        rowUpdatedEvent.Errors = exception;
      }
      string message = exception.Message;
      dataRow.RowError += message;
      if (!this.ContinueUpdateOnError)
        throw exception;
    }

    private static IDbConnection GetConnection1(DbDataAdapter adapter)
    {
      IDbCommand dbCommand = adapter._IDbDataAdapter.SelectCommand ?? adapter._IDbDataAdapter.InsertCommand ?? adapter._IDbDataAdapter.UpdateCommand ?? adapter._IDbDataAdapter.DeleteCommand;
      IDbConnection dbConnection = (IDbConnection) null;
      if (dbCommand != null)
        dbConnection = dbCommand.Connection;
      return dbConnection != null ? dbConnection : throw ADP.UpdateConnectionRequired(StatementType.Batch, false);
    }

    private static IDbConnection GetConnection3(
      DbDataAdapter adapter,
      IDbCommand command,
      string method)
    {
      Debug.Assert(command != null, "GetConnection3: null command");
      Debug.Assert(!ADP.IsEmpty(method), "missing method name");
      return command.Connection ?? throw ADP.ConnectionRequired_Res(method);
    }

    private static IDbConnection GetConnection4(
      DbDataAdapter adapter,
      IDbCommand command,
      StatementType statementType,
      bool isCommandFromRowUpdating)
    {
      Debug.Assert(command != null, "GetConnection4: null command");
      return command.Connection ?? throw ADP.UpdateConnectionRequired(statementType, isCommandFromRowUpdating);
    }

    private static DataRowVersion GetParameterSourceVersion(
      StatementType statementType,
      IDataParameter parameter)
    {
      switch (statementType)
      {
        case StatementType.Select:
        case StatementType.Batch:
          throw ADP.UnwantedStatementType(statementType);
        case StatementType.Insert:
          return DataRowVersion.Current;
        case StatementType.Update:
          return parameter.SourceVersion;
        case StatementType.Delete:
          return DataRowVersion.Original;
        default:
          throw ADP.InvalidStatementType(statementType);
      }
    }

    private static void QuietClose(IDbConnection connection, ConnectionState originalState)
    {
      if (connection == null || originalState != ConnectionState.Closed)
        return;
      connection.Close();
    }

    private static void QuietOpen(IDbConnection connection, out ConnectionState originalState)
    {
      Debug.Assert(connection != null, "QuiteClose: null connection");
      originalState = connection.State;
      if (originalState != ConnectionState.Closed)
        return;
      connection.Open();
    }

    private struct BatchCommandInfo
    {
      internal int CommandIdentifier;
      internal int ParameterCount;
      internal DataRow Row;
      internal StatementType StatementType;
      internal UpdateRowSource UpdatedRowSource;
      internal int? RecordsAffected;
      internal Exception Errors;
    }
  }
}
