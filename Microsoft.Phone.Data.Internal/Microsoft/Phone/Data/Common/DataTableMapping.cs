// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DataTableMapping
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;

namespace Microsoft.Phone.Data.Common
{
  public sealed class DataTableMapping : MarshalByValueComponent, ITableMapping, Microsoft.Phone.Data.Workaround.ICloneable
  {
    private DataTableMappingCollection parent;
    private DataColumnMappingCollection _columnMappings;
    private string _dataSetTableName;
    private string _sourceTableName;

    public DataTableMapping()
    {
    }

    public DataTableMapping(string sourceTable, string dataSetTable)
    {
      this.SourceTable = sourceTable;
      this.DataSetTable = dataSetTable;
    }

    public DataTableMapping(
      string sourceTable,
      string dataSetTable,
      DataColumnMapping[] columnMappings)
    {
      this.SourceTable = sourceTable;
      this.DataSetTable = dataSetTable;
      if (columnMappings == null || columnMappings.Length == 0)
        return;
      this.ColumnMappings.AddRange(columnMappings);
    }

    IColumnMappingCollection ITableMapping.ColumnMappings => (IColumnMappingCollection) this.ColumnMappings;

    public DataColumnMappingCollection ColumnMappings
    {
      get
      {
        DataColumnMappingCollection mappingCollection = this._columnMappings;
        if (mappingCollection == null)
        {
          mappingCollection = new DataColumnMappingCollection();
          this._columnMappings = mappingCollection;
        }
        return mappingCollection;
      }
    }

    public string DataSetTable
    {
      get => this._dataSetTableName ?? ADP.StrEmpty;
      set => this._dataSetTableName = value;
    }

    internal DataTableMappingCollection Parent
    {
      get => this.parent;
      set => this.parent = value;
    }

    public string SourceTable
    {
      get => this._sourceTableName ?? ADP.StrEmpty;
      set
      {
        if (this.Parent != null && ADP.SrcCompare(this._sourceTableName, value) != 0)
          this.Parent.ValidateSourceTable(-1, value);
        this._sourceTableName = value;
      }
    }

    object Microsoft.Phone.Data.Workaround.ICloneable.Clone()
    {
      DataTableMapping dataTableMapping = new DataTableMapping();
      dataTableMapping._dataSetTableName = this._dataSetTableName;
      dataTableMapping._sourceTableName = this._sourceTableName;
      if (this._columnMappings != null && 0 < this.ColumnMappings.Count)
      {
        DataColumnMappingCollection columnMappings = dataTableMapping.ColumnMappings;
        foreach (Microsoft.Phone.Data.Workaround.ICloneable columnMapping in this.ColumnMappings)
          columnMappings.Add(columnMapping.Clone());
      }
      return (object) dataTableMapping;
    }

    public DataColumn GetDataColumn(
      string sourceColumn,
      Type dataType,
      DataTable dataTable,
      MissingMappingAction mappingAction,
      MissingSchemaAction schemaAction)
    {
      return DataColumnMappingCollection.GetDataColumn(this._columnMappings, sourceColumn, dataType, dataTable, mappingAction, schemaAction);
    }

    public DataColumnMapping GetColumnMappingBySchemaAction(
      string sourceColumn,
      MissingMappingAction mappingAction)
    {
      return DataColumnMappingCollection.GetColumnMappingBySchemaAction(this._columnMappings, sourceColumn, mappingAction);
    }

    public DataTable GetDataTableBySchemaAction(
      DataSet dataSet,
      MissingSchemaAction schemaAction)
    {
      if (dataSet == null)
        throw ADP.ArgumentNull(nameof (dataSet));
      string dataSetTable = this.DataSetTable;
      if (ADP.IsEmpty(dataSetTable))
        return (DataTable) null;
      DataTableCollection tables = dataSet.Tables;
      int index = tables.IndexOf(dataSetTable);
      if (0 <= index && index < tables.Count)
        return tables[index];
      switch (schemaAction)
      {
        case MissingSchemaAction.Add:
        case MissingSchemaAction.AddWithKey:
          return new DataTable(dataSetTable);
        case MissingSchemaAction.Ignore:
          return (DataTable) null;
        case MissingSchemaAction.Error:
          throw ADP.MissingTableSchema(dataSetTable, this.SourceTable);
        default:
          throw ADP.InvalidMissingSchemaAction(schemaAction);
      }
    }

    public override string ToString() => this.SourceTable;
  }
}
