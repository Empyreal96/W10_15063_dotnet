// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DataAdapter
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.ProviderBase;
using Microsoft.Phone.Data.Workaround;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace Microsoft.Phone.Data.Common
{
  public class DataAdapter : MarshalByValueComponent, IDataAdapter
  {
    private static readonly object EventFillError = new object();
    private bool _acceptChangesDuringUpdate = true;
    private bool _acceptChangesDuringUpdateAfterInsert = true;
    private bool _continueUpdateOnError;
    private bool _hasFillErrorHandler;
    private bool _returnProviderSpecificTypes;
    private bool _acceptChangesDuringFill = true;
    private LoadOption _fillLoadOption;
    private MissingMappingAction _missingMappingAction = MissingMappingAction.Passthrough;
    private MissingSchemaAction _missingSchemaAction = MissingSchemaAction.Add;
    private DataTableMappingCollection _tableMappings;

    protected DataAdapter() => GC.SuppressFinalize((object) this);

    protected DataAdapter(DataAdapter from) => this.CloneFrom(from);

    public bool AcceptChangesDuringFill
    {
      get => this._acceptChangesDuringFill;
      set => this._acceptChangesDuringFill = value;
    }

    public virtual bool ShouldSerializeAcceptChangesDuringFill() => this._fillLoadOption == (LoadOption) 0;

    public bool AcceptChangesDuringUpdate
    {
      get => this._acceptChangesDuringUpdate;
      set => this._acceptChangesDuringUpdate = value;
    }

    public bool ContinueUpdateOnError
    {
      get => this._continueUpdateOnError;
      set => this._continueUpdateOnError = value;
    }

    public LoadOption FillLoadOption
    {
      get => this._fillLoadOption == (LoadOption) 0 ? LoadOption.OverwriteChanges : this._fillLoadOption;
      set
      {
        switch (value)
        {
          case (LoadOption) 0:
          case LoadOption.OverwriteChanges:
          case LoadOption.PreserveChanges:
          case LoadOption.Upsert:
            this._fillLoadOption = value;
            break;
          default:
            throw ADP.InvalidLoadOption(value);
        }
      }
    }

    public void ResetFillLoadOption() => this._fillLoadOption = (LoadOption) 0;

    public virtual bool ShouldSerializeFillLoadOption() => (uint) this._fillLoadOption > 0U;

    public MissingMappingAction MissingMappingAction
    {
      get => this._missingMappingAction;
      set
      {
        switch (value)
        {
          case MissingMappingAction.Passthrough:
          case MissingMappingAction.Ignore:
          case MissingMappingAction.Error:
            this._missingMappingAction = value;
            break;
          default:
            throw ADP.InvalidMissingMappingAction(value);
        }
      }
    }

    public MissingSchemaAction MissingSchemaAction
    {
      get => this._missingSchemaAction;
      set
      {
        switch (value)
        {
          case MissingSchemaAction.Add:
          case MissingSchemaAction.Ignore:
          case MissingSchemaAction.Error:
          case MissingSchemaAction.AddWithKey:
            this._missingSchemaAction = value;
            break;
          default:
            throw ADP.InvalidMissingSchemaAction(value);
        }
      }
    }

    public virtual bool ReturnProviderSpecificTypes
    {
      get => this._returnProviderSpecificTypes;
      set => this._returnProviderSpecificTypes = value;
    }

    public DataTableMappingCollection TableMappings
    {
      get
      {
        DataTableMappingCollection mappingCollection = this._tableMappings;
        if (mappingCollection == null)
        {
          mappingCollection = this.CreateTableMappings() ?? new DataTableMappingCollection();
          this._tableMappings = mappingCollection;
        }
        return mappingCollection;
      }
    }

    ITableMappingCollection IDataAdapter.TableMappings => (ITableMappingCollection) this.TableMappings;

    protected virtual bool ShouldSerializeTableMappings() => true;

    protected bool HasTableMappings() => this._tableMappings != null && 0 < this.TableMappings.Count;

    public event FillErrorEventHandler FillError
    {
      add
      {
        this._hasFillErrorHandler = true;
        this.Events.AddHandler(DataAdapter.EventFillError, (Delegate) value);
      }
      remove => this.Events.RemoveHandler(DataAdapter.EventFillError, (Delegate) value);
    }

    protected virtual DataAdapter CloneInternals()
    {
      DataAdapter instance = (DataAdapter) Activator.CreateInstance(this.GetType(), (object) (BindingFlags.Instance | BindingFlags.Public), null, null, (object) CultureInfo.InvariantCulture, null);
      instance.CloneFrom(this);
      return instance;
    }

    private void CloneFrom(DataAdapter from)
    {
      this._acceptChangesDuringUpdate = from._acceptChangesDuringUpdate;
      this._acceptChangesDuringUpdateAfterInsert = from._acceptChangesDuringUpdateAfterInsert;
      this._continueUpdateOnError = from._continueUpdateOnError;
      this._returnProviderSpecificTypes = from._returnProviderSpecificTypes;
      this._acceptChangesDuringFill = from._acceptChangesDuringFill;
      this._fillLoadOption = from._fillLoadOption;
      this._missingMappingAction = from._missingMappingAction;
      this._missingSchemaAction = from._missingSchemaAction;
      if (from._tableMappings == null || 0 >= from.TableMappings.Count)
        return;
      DataTableMappingCollection tableMappings = this.TableMappings;
      foreach (object tableMapping in from.TableMappings)
        tableMappings.Add(tableMapping is Microsoft.Phone.Data.Workaround.ICloneable ? ((Microsoft.Phone.Data.Workaround.ICloneable) tableMapping).Clone() : tableMapping);
    }

    protected virtual DataTableMappingCollection CreateTableMappings() => new DataTableMappingCollection();

    protected override void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      this._tableMappings = (DataTableMappingCollection) null;
    }

    public virtual DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType) => throw ADP.NotSupported();

    protected virtual DataTable[] FillSchema(
      DataSet dataSet,
      SchemaType schemaType,
      string srcTable,
      IDataReader dataReader)
    {
      if (dataSet == null)
        throw ADP.ArgumentNull(nameof (dataSet));
      if (SchemaType.Source != schemaType && SchemaType.Mapped != schemaType)
        throw ADP.InvalidSchemaType(schemaType);
      if (ADP.IsEmpty(srcTable))
        throw ADP.FillSchemaRequiresSourceTableName(nameof (srcTable));
      if (dataReader == null || dataReader.IsClosed)
        throw ADP.FillRequires(nameof (dataReader));
      return (DataTable[]) this.FillSchemaFromReader(dataSet, (DataTable) null, schemaType, srcTable, dataReader);
    }

    protected virtual DataTable FillSchema(
      DataTable dataTable,
      SchemaType schemaType,
      IDataReader dataReader)
    {
      if (dataTable == null)
        throw ADP.ArgumentNull(nameof (dataTable));
      if (SchemaType.Source != schemaType && SchemaType.Mapped != schemaType)
        throw ADP.InvalidSchemaType(schemaType);
      if (dataReader == null || dataReader.IsClosed)
        throw ADP.FillRequires(nameof (dataReader));
      return (DataTable) this.FillSchemaFromReader((DataSet) null, dataTable, schemaType, (string) null, dataReader);
    }

    internal object FillSchemaFromReader(
      DataSet dataset,
      DataTable datatable,
      SchemaType schemaType,
      string srcTable,
      IDataReader dataReader)
    {
      DataTable[] tables = (DataTable[]) null;
      int index = 0;
      do
      {
        DataReaderContainer dataReader1 = DataReaderContainer.Create(dataReader, this.ReturnProviderSpecificTypes);
        if (0 < dataReader1.FieldCount)
        {
          string sourceTableName = (string) null;
          if (dataset != null)
          {
            sourceTableName = DataAdapter.GetSourceTableName(srcTable, index);
            ++index;
          }
          SchemaMapping schemaMapping = new SchemaMapping(this, dataset, datatable, dataReader1, true, schemaType, sourceTableName, false, (DataColumn) null, (object) null);
          if (datatable != null)
            return (object) schemaMapping.DataTable;
          if (schemaMapping.DataTable != null)
          {
            if (tables == null)
              tables = new DataTable[1]
              {
                schemaMapping.DataTable
              };
            else
              tables = DataAdapter.AddDataTableToArray(tables, schemaMapping.DataTable);
          }
        }
      }
      while (dataReader.NextResult());
      object obj = (object) tables;
      if (obj == null && datatable == null)
        obj = (object) new DataTable[0];
      return obj;
    }

    public virtual int Fill(DataSet dataSet) => throw ADP.NotSupported();

    protected virtual int Fill(
      DataSet dataSet,
      string srcTable,
      IDataReader dataReader,
      int startRecord,
      int maxRecords)
    {
      if (dataSet == null)
        throw ADP.FillRequires(nameof (dataSet));
      if (ADP.IsEmpty(srcTable))
        throw ADP.FillRequiresSourceTableName(nameof (srcTable));
      if (dataReader == null)
        throw ADP.FillRequires(nameof (dataReader));
      if (startRecord < 0)
        throw ADP.InvalidStartRecord(nameof (startRecord), startRecord);
      if (maxRecords < 0)
        throw ADP.InvalidMaxRecords(nameof (maxRecords), maxRecords);
      if (dataReader.IsClosed)
        return 0;
      DataReaderContainer dataReader1 = DataReaderContainer.Create(dataReader, this.ReturnProviderSpecificTypes);
      return this.FillFromReader(dataSet, (DataTable) null, srcTable, dataReader1, startRecord, maxRecords, (DataColumn) null, (object) null);
    }

    protected virtual int Fill(DataTable dataTable, IDataReader dataReader) => this.Fill(new DataTable[1]
    {
      dataTable
    }, dataReader, 0, 0);

    protected virtual int Fill(
      DataTable[] dataTables,
      IDataReader dataReader,
      int startRecord,
      int maxRecords)
    {
      ADP.CheckArgumentLength((Array) dataTables, "tables");
      if (dataTables == null || dataTables.Length == 0 || dataTables[0] == null)
        throw ADP.FillRequires("dataTable");
      if (dataReader == null)
        throw ADP.FillRequires(nameof (dataReader));
      if (1 < dataTables.Length && (startRecord != 0 || maxRecords != 0))
        throw ADP.NotSupported();
      int num1 = 0;
      bool flag = false;
      DataSet dataSet = dataTables[0].DataSet;
      try
      {
        if (dataSet != null)
        {
          flag = dataSet.EnforceConstraints;
          dataSet.EnforceConstraints = false;
        }
        for (int index = 0; index < dataTables.Length; ++index)
        {
          Debug.Assert(dataTables[index] != null, "null DataTable Fill");
          if (!dataReader.IsClosed)
          {
            DataReaderContainer dataReader1 = DataReaderContainer.Create(dataReader, this.ReturnProviderSpecificTypes);
            if (dataReader1.FieldCount > 0)
            {
              if (0 < index)
              {
                if (!this.FillNextResult(dataReader1))
                  break;
              }
              int num2 = this.FillFromReader((DataSet) null, dataTables[index], (string) null, dataReader1, startRecord, maxRecords, (DataColumn) null, (object) null);
              if (index == 0)
                num1 = num2;
            }
          }
          else
            break;
        }
      }
      catch (ConstraintException ex)
      {
        flag = false;
        throw;
      }
      finally
      {
        if (flag)
          dataSet.EnforceConstraints = true;
      }
      return num1;
    }

    internal int FillFromReader(
      DataSet dataset,
      DataTable datatable,
      string srcTable,
      DataReaderContainer dataReader,
      int startRecord,
      int maxRecords,
      DataColumn parentChapterColumn,
      object parentChapterValue)
    {
      int num1 = 0;
      int schemaCount = 0;
      do
      {
        if (0 < dataReader.FieldCount)
        {
          SchemaMapping mapping = this.FillMapping(dataset, datatable, srcTable, dataReader, schemaCount, parentChapterColumn, parentChapterValue);
          ++schemaCount;
          if (mapping != null && mapping.DataValues != null && mapping.DataTable != null)
          {
            mapping.DataTable.BeginLoadData();
            try
            {
              if (1 == schemaCount && (0 < startRecord || 0 < maxRecords))
              {
                num1 = this.FillLoadDataRowChunk(mapping, startRecord, maxRecords);
              }
              else
              {
                int num2 = this.FillLoadDataRow(mapping);
                if (1 == schemaCount)
                  num1 = num2;
              }
            }
            finally
            {
              mapping.DataTable.EndLoadData();
            }
            if (datatable != null)
              break;
          }
        }
      }
      while (this.FillNextResult(dataReader));
      return num1;
    }

    private int FillLoadDataRowChunk(SchemaMapping mapping, int startRecord, int maxRecords)
    {
      DataReaderContainer dataReader = mapping.DataReader;
      for (; 0 < startRecord; --startRecord)
      {
        if (!dataReader.Read())
          return 0;
      }
      int num = 0;
      if (0 < maxRecords)
      {
        while (num < maxRecords && dataReader.Read())
        {
          if (this._hasFillErrorHandler)
          {
            try
            {
              mapping.LoadDataRowWithClear();
              ++num;
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
                this.OnFillErrorHandler(ex, mapping.DataTable, mapping.DataValues);
              }
            }
          }
          else
          {
            mapping.LoadDataRow();
            ++num;
          }
        }
      }
      else
        num = this.FillLoadDataRow(mapping);
      return num;
    }

    private int FillLoadDataRow(SchemaMapping mapping)
    {
      int num = 0;
      DataReaderContainer dataReader = mapping.DataReader;
      if (this._hasFillErrorHandler)
      {
        while (dataReader.Read())
        {
          try
          {
            mapping.LoadDataRowWithClear();
            ++num;
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
              this.OnFillErrorHandler(ex, mapping.DataTable, mapping.DataValues);
            }
          }
        }
      }
      else
      {
        while (dataReader.Read())
        {
          mapping.LoadDataRow();
          ++num;
        }
      }
      return num;
    }

    private SchemaMapping FillMappingInternal(
      DataSet dataset,
      DataTable datatable,
      string srcTable,
      DataReaderContainer dataReader,
      int schemaCount,
      DataColumn parentChapterColumn,
      object parentChapterValue)
    {
      bool keyInfo = MissingSchemaAction.AddWithKey == this.MissingSchemaAction;
      string sourceTableName = (string) null;
      if (dataset != null)
        sourceTableName = DataAdapter.GetSourceTableName(srcTable, schemaCount);
      return new SchemaMapping(this, dataset, datatable, dataReader, keyInfo, SchemaType.Mapped, sourceTableName, true, parentChapterColumn, parentChapterValue);
    }

    private SchemaMapping FillMapping(
      DataSet dataset,
      DataTable datatable,
      string srcTable,
      DataReaderContainer dataReader,
      int schemaCount,
      DataColumn parentChapterColumn,
      object parentChapterValue)
    {
      SchemaMapping schemaMapping = (SchemaMapping) null;
      if (this._hasFillErrorHandler)
      {
        try
        {
          schemaMapping = this.FillMappingInternal(dataset, datatable, srcTable, dataReader, schemaCount, parentChapterColumn, parentChapterValue);
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
            this.OnFillErrorHandler(ex, (DataTable) null, (object[]) null);
          }
        }
      }
      else
        schemaMapping = this.FillMappingInternal(dataset, datatable, srcTable, dataReader, schemaCount, parentChapterColumn, parentChapterValue);
      return schemaMapping;
    }

    private bool FillNextResult(DataReaderContainer dataReader)
    {
      bool flag = true;
      if (this._hasFillErrorHandler)
      {
        try
        {
          flag = dataReader.NextResult();
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
            this.OnFillErrorHandler(ex, (DataTable) null, (object[]) null);
          }
        }
      }
      else
        flag = dataReader.NextResult();
      return flag;
    }

    public virtual IDataParameter[] GetFillParameters() => new IDataParameter[0];

    internal DataTableMapping GetTableMappingBySchemaAction(
      string sourceTableName,
      string dataSetTableName,
      MissingMappingAction mappingAction)
    {
      return DataTableMappingCollection.GetTableMappingBySchemaAction(this._tableMappings, sourceTableName, dataSetTableName, mappingAction);
    }

    internal int IndexOfDataSetTable(string dataSetTable) => this._tableMappings != null ? this.TableMappings.IndexOfDataSetTable(dataSetTable) : -1;

    protected virtual void OnFillError(FillErrorEventArgs value)
    {
      FillErrorEventHandler errorEventHandler = (FillErrorEventHandler) this.Events[DataAdapter.EventFillError];
      if (errorEventHandler == null)
        return;
      errorEventHandler((object) this, value);
    }

    private void OnFillErrorHandler(Exception e, DataTable dataTable, object[] dataValues)
    {
      FillErrorEventArgs fillErrorEventArgs = new FillErrorEventArgs(dataTable, dataValues);
      fillErrorEventArgs.Errors = e;
      this.OnFillError(fillErrorEventArgs);
      if (fillErrorEventArgs.Continue)
        return;
      if (fillErrorEventArgs.Errors != null)
        throw fillErrorEventArgs.Errors;
      throw e;
    }

    public virtual int Update(DataSet dataSet) => throw ADP.NotSupported();

    private static DataTable[] AddDataTableToArray(DataTable[] tables, DataTable newTable)
    {
      for (int index = 0; index < tables.Length; ++index)
      {
        if (tables[index] == newTable)
          return tables;
      }
      DataTable[] dataTableArray = new DataTable[tables.Length + 1];
      for (int index = 0; index < tables.Length; ++index)
        dataTableArray[index] = tables[index];
      dataTableArray[tables.Length] = newTable;
      return dataTableArray;
    }

    private static string GetSourceTableName(string srcTable, int index) => index == 0 ? srcTable : srcTable + index.ToString((IFormatProvider) CultureInfo.InvariantCulture);
  }
}
