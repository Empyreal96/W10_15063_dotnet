// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DataColumnMapping
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;
using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  public sealed class DataColumnMapping : MarshalByValueComponent, IColumnMapping, Microsoft.Phone.Data.Workaround.ICloneable
  {
    private DataColumnMappingCollection parent;
    private string _dataSetColumnName;
    private string _sourceColumnName;

    public DataColumnMapping()
    {
    }

    public DataColumnMapping(string sourceColumn, string dataSetColumn)
    {
      this.SourceColumn = sourceColumn;
      this.DataSetColumn = dataSetColumn;
    }

    public string DataSetColumn
    {
      get => this._dataSetColumnName ?? ADP.StrEmpty;
      set => this._dataSetColumnName = value;
    }

    internal DataColumnMappingCollection Parent
    {
      get => this.parent;
      set => this.parent = value;
    }

    public string SourceColumn
    {
      get => this._sourceColumnName ?? ADP.StrEmpty;
      set
      {
        if (this.Parent != null && ADP.SrcCompare(this._sourceColumnName, value) != 0)
          this.Parent.ValidateSourceColumn(-1, value);
        this._sourceColumnName = value;
      }
    }

    object Microsoft.Phone.Data.Workaround.ICloneable.Clone() => (object) new DataColumnMapping()
    {
      _sourceColumnName = this._sourceColumnName,
      _dataSetColumnName = this._dataSetColumnName
    };

    public DataColumn GetDataColumnBySchemaAction(
      DataTable dataTable,
      Type dataType,
      MissingSchemaAction schemaAction)
    {
      return DataColumnMapping.GetDataColumnBySchemaAction(this.SourceColumn, this.DataSetColumn, dataTable, dataType, schemaAction);
    }

    public static DataColumn GetDataColumnBySchemaAction(
      string sourceColumn,
      string dataSetColumn,
      DataTable dataTable,
      Type dataType,
      MissingSchemaAction schemaAction)
    {
      if (dataTable == null)
        throw ADP.ArgumentNull(nameof (dataTable));
      if (ADP.IsEmpty(dataSetColumn))
        return (DataColumn) null;
      DataColumnCollection columns = dataTable.Columns;
      Debug.Assert(columns != null, "GetDataColumnBySchemaAction: unexpected null DataColumnCollection");
      int index = columns.IndexOf(dataSetColumn);
      if (0 <= index && index < columns.Count)
      {
        DataColumn column = columns[index];
        Debug.Assert(column != null, "GetDataColumnBySchemaAction: unexpected null dataColumn");
        if (!ADP.IsEmpty(column.Expression))
          throw ADP.ColumnSchemaExpression(sourceColumn, dataSetColumn);
        if (dataType == null || dataType.IsArray == column.DataType.IsArray)
          return column;
        throw ADP.ColumnSchemaMismatch(sourceColumn, dataType, column);
      }
      switch (schemaAction)
      {
        case MissingSchemaAction.Add:
        case MissingSchemaAction.AddWithKey:
          return new DataColumn(dataSetColumn, dataType);
        case MissingSchemaAction.Ignore:
          return (DataColumn) null;
        case MissingSchemaAction.Error:
          throw ADP.ColumnSchemaMissing(dataSetColumn, dataTable.TableName, sourceColumn);
        default:
          throw ADP.InvalidMissingSchemaAction(schemaAction);
      }
    }

    public override string ToString() => this.SourceColumn;
  }
}
