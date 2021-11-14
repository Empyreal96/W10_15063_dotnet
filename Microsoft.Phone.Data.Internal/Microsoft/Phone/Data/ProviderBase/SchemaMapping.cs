// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ProviderBase.SchemaMapping
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data.ProviderBase
{
  internal sealed class SchemaMapping
  {
    private const int MapExactMatch = 0;
    private const int MapDifferentSize = 1;
    private const int MapReorderedValues = 2;
    private const int MapChapters = 3;
    private const int MapChaptersReordered = 4;
    private readonly DataSet _dataSet;
    private DataTable _dataTable;
    private readonly DataAdapter _adapter;
    private readonly DataReaderContainer _dataReader;
    private readonly DataTable _schemaTable;
    private readonly DataTableMapping _tableMapping;
    private readonly string[] _fieldNames;
    private readonly object[] _readerDataValues;
    private object[] _mappedDataValues;
    private int[] _indexMap;
    private bool[] _chapterMap;
    private int _mappedMode;
    private int _mappedLength;
    private readonly LoadOption _loadOption;

    internal SchemaMapping(
      DataAdapter adapter,
      DataSet dataset,
      DataTable datatable,
      DataReaderContainer dataReader,
      bool keyInfo,
      SchemaType schemaType,
      string sourceTableName,
      bool gettingData,
      DataColumn parentChapterColumn,
      object parentChapterValue)
    {
      Debug.Assert(adapter != null, nameof (adapter));
      Debug.Assert(dataReader != null, nameof (dataReader));
      Debug.Assert(0 < dataReader.FieldCount, "FieldCount");
      Debug.Assert(dataset != null || datatable != null, "SchemaMapping - null dataSet");
      Debug.Assert(SchemaType.Mapped == schemaType || SchemaType.Source == schemaType, "SetupSchema - invalid schemaType");
      this._dataSet = dataset;
      this._dataTable = datatable;
      this._adapter = adapter;
      this._dataReader = dataReader;
      if (keyInfo)
        this._schemaTable = dataReader.GetSchemaTable();
      this._loadOption = !adapter.ShouldSerializeFillLoadOption() ? (!adapter.AcceptChangesDuringFill ? (LoadOption) 5 : (LoadOption) 4) : adapter.FillLoadOption;
      MissingMappingAction mappingAction;
      MissingSchemaAction schemaAction;
      if (SchemaType.Mapped == schemaType)
      {
        mappingAction = this._adapter.MissingMappingAction;
        schemaAction = this._adapter.MissingSchemaAction;
        if (!ADP.IsEmpty(sourceTableName))
        {
          DataAdapter adapter1 = this._adapter;
          string str = sourceTableName;
          int num = (int) mappingAction;
          this._tableMapping = adapter1.GetTableMappingBySchemaAction(str, str, (MissingMappingAction) num);
        }
        else if (this._dataTable != null)
        {
          int index = this._adapter.IndexOfDataSetTable(this._dataTable.TableName);
          if (-1 != index)
          {
            this._tableMapping = this._adapter.TableMappings[index];
          }
          else
          {
            switch (mappingAction)
            {
              case MissingMappingAction.Passthrough:
                this._tableMapping = new DataTableMapping(this._dataTable.TableName, this._dataTable.TableName);
                break;
              case MissingMappingAction.Ignore:
                this._tableMapping = (DataTableMapping) null;
                break;
              case MissingMappingAction.Error:
                throw ADP.MissingTableMappingDestination(this._dataTable.TableName);
              default:
                throw ADP.InvalidMissingMappingAction(mappingAction);
            }
          }
        }
      }
      else
      {
        if (SchemaType.Source != schemaType)
          throw ADP.InvalidSchemaType(schemaType);
        mappingAction = MissingMappingAction.Passthrough;
        schemaAction = MissingSchemaAction.Add;
        if (!ADP.IsEmpty(sourceTableName))
        {
          string str = sourceTableName;
          this._tableMapping = DataTableMappingCollection.GetTableMappingBySchemaAction((DataTableMappingCollection) null, str, str, mappingAction);
        }
        else if (this._dataTable != null)
        {
          int index = this._adapter.IndexOfDataSetTable(this._dataTable.TableName);
          this._tableMapping = -1 == index ? new DataTableMapping(this._dataTable.TableName, this._dataTable.TableName) : this._adapter.TableMappings[index];
        }
      }
      if (this._tableMapping == null)
        return;
      if (this._dataTable == null)
        this._dataTable = this._tableMapping.GetDataTableBySchemaAction(this._dataSet, schemaAction);
      if (this._dataTable == null)
        return;
      this._fieldNames = SchemaMapping.GenerateFieldNames(dataReader);
      if (this._schemaTable == null)
        this._readerDataValues = this.SetupSchemaWithoutKeyInfo(mappingAction, schemaAction, gettingData, parentChapterColumn, parentChapterValue);
      else
        this._readerDataValues = this.SetupSchemaWithKeyInfo(mappingAction, schemaAction, gettingData, parentChapterColumn, parentChapterValue);
    }

    internal DataReaderContainer DataReader => this._dataReader;

    internal DataTable DataTable => this._dataTable;

    internal object[] DataValues => this._readerDataValues;

    internal void ApplyToDataRow(DataRow dataRow)
    {
      DataColumnCollection columns = dataRow.Table.Columns;
      this._dataReader.GetValues(this._readerDataValues);
      object[] mappedValues = this.GetMappedValues();
      bool[] flagArray = new bool[mappedValues.Length];
      for (int index = 0; index < flagArray.Length; ++index)
        flagArray[index] = columns[index].ReadOnly;
      try
      {
        try
        {
          for (int index = 0; index < flagArray.Length; ++index)
          {
            if (columns[index].Expression.Length == 0)
              columns[index].ReadOnly = false;
          }
          for (int columnIndex = 0; columnIndex < mappedValues.Length; ++columnIndex)
          {
            if (mappedValues[columnIndex] != null)
              dataRow[columnIndex] = mappedValues[columnIndex];
          }
        }
        finally
        {
          for (int index = 0; index < flagArray.Length; ++index)
          {
            if (columns[index].Expression.Length == 0)
              columns[index].ReadOnly = flagArray[index];
          }
        }
      }
      finally
      {
        if (this._chapterMap != null)
          this.FreeDataRowChapters();
      }
    }

    private void MappedChapterIndex()
    {
      int mappedLength = this._mappedLength;
      for (int index1 = 0; index1 < mappedLength; ++index1)
      {
        int index2 = this._indexMap[index1];
        if (0 <= index2)
        {
          this._mappedDataValues[index2] = this._readerDataValues[index1];
          if (this._chapterMap[index1])
            this._mappedDataValues[index2] = (object) null;
        }
      }
    }

    private void MappedChapter()
    {
      int mappedLength = this._mappedLength;
      for (int index = 0; index < mappedLength; ++index)
      {
        this._mappedDataValues[index] = this._readerDataValues[index];
        if (this._chapterMap[index])
          this._mappedDataValues[index] = (object) null;
      }
    }

    private void MappedIndex()
    {
      Debug.Assert(this._mappedLength == this._indexMap.Length, "incorrect precomputed length");
      int mappedLength = this._mappedLength;
      for (int index1 = 0; index1 < mappedLength; ++index1)
      {
        int index2 = this._indexMap[index1];
        if (0 <= index2)
          this._mappedDataValues[index2] = this._readerDataValues[index1];
      }
    }

    private void MappedValues()
    {
      Debug.Assert(this._mappedLength == Math.Min(this._readerDataValues.Length, this._mappedDataValues.Length), "incorrect precomputed length");
      int mappedLength = this._mappedLength;
      for (int index = 0; index < mappedLength; ++index)
        this._mappedDataValues[index] = this._readerDataValues[index];
    }

    private object[] GetMappedValues()
    {
      switch (this._mappedMode)
      {
        case 1:
          Debug.Assert(this._chapterMap == null && this._indexMap == null && this._mappedDataValues != null, "incorrect MappedValues");
          this.MappedValues();
          break;
        case 2:
          Debug.Assert(this._chapterMap == null && this._indexMap != null && this._mappedDataValues != null, "incorrect MappedValues");
          this.MappedIndex();
          break;
        case 3:
          Debug.Assert(this._chapterMap != null && this._indexMap == null && this._mappedDataValues != null, "incorrect MappedValues");
          this.MappedChapter();
          break;
        case 4:
          Debug.Assert(this._chapterMap != null && this._indexMap != null && this._mappedDataValues != null, "incorrect MappedValues");
          this.MappedChapterIndex();
          break;
        default:
          Debug.Assert(this._mappedMode == 0, "incorrect mappedMode");
          Debug.Assert(this._chapterMap == null && this._indexMap == null && this._mappedDataValues == null, "incorrect MappedValues");
          return this._readerDataValues;
      }
      return this._mappedDataValues;
    }

    internal void LoadDataRowWithClear()
    {
      for (int index = 0; index < this._readerDataValues.Length; ++index)
        this._readerDataValues[index] = (object) null;
      this.LoadDataRow();
    }

    internal void LoadDataRow()
    {
      try
      {
        this._dataReader.GetValues(this._readerDataValues);
        object[] mappedValues = this.GetMappedValues();
        DataRow dataRow;
        switch (this._loadOption)
        {
          case LoadOption.OverwriteChanges:
          case LoadOption.PreserveChanges:
          case LoadOption.Upsert:
            dataRow = this._dataTable.LoadDataRow(mappedValues, this._loadOption);
            break;
          case (LoadOption) 4:
            dataRow = this._dataTable.LoadDataRow(mappedValues, true);
            break;
          case (LoadOption) 5:
            dataRow = this._dataTable.LoadDataRow(mappedValues, false);
            break;
          default:
            Debug.Assert(false, "unexpected LoadOption");
            throw ADP.InvalidLoadOption(this._loadOption);
        }
        if (this._chapterMap == null || this._dataSet == null)
          return;
        this.LoadDataRowChapters(dataRow);
      }
      finally
      {
        if (this._chapterMap != null)
          this.FreeDataRowChapters();
      }
    }

    private void FreeDataRowChapters()
    {
      for (int index = 0; index < this._chapterMap.Length; ++index)
      {
        if (this._chapterMap[index] && this._readerDataValues[index] is IDisposable readerDataValue1)
        {
          this._readerDataValues[index] = (object) null;
          readerDataValue1.Dispose();
        }
      }
    }

    internal int LoadDataRowChapters(DataRow dataRow)
    {
      int num = 0;
      int length = this._chapterMap.Length;
      for (int index = 0; index < length; ++index)
      {
        if (this._chapterMap[index])
        {
          object readerDataValue = this._readerDataValues[index];
          if (readerDataValue != null && !Convert.IsDBNull(readerDataValue))
          {
            this._readerDataValues[index] = (object) null;
            using (IDataReader dataReader1 = (IDataReader) readerDataValue)
            {
              if (!dataReader1.IsClosed)
              {
                Debug.Assert(this._dataSet != null, "if chapters, then Fill(DataSet,...) not Fill(DataTable,...)");
                DataColumn column;
                object parentChapterValue;
                if (this._indexMap == null)
                {
                  column = this._dataTable.Columns[index];
                  parentChapterValue = dataRow[column];
                }
                else
                {
                  column = this._dataTable.Columns[this._indexMap[index]];
                  parentChapterValue = dataRow[column];
                }
                string srcTable = this._tableMapping.SourceTable + this._fieldNames[index];
                DataReaderContainer dataReader2 = DataReaderContainer.Create(dataReader1, this._dataReader.ReturnProviderSpecificTypes);
                num += this._adapter.FillFromReader(this._dataSet, (DataTable) null, srcTable, dataReader2, 0, 0, column, parentChapterValue);
              }
            }
          }
        }
      }
      return num;
    }

    private int[] CreateIndexMap(int count, int index)
    {
      int[] numArray = new int[count];
      for (int index1 = 0; index1 < index; ++index1)
        numArray[index1] = index1;
      return numArray;
    }

    private static string[] GenerateFieldNames(DataReaderContainer dataReader)
    {
      string[] columnNameArray = new string[dataReader.FieldCount];
      for (int ordinal = 0; ordinal < columnNameArray.Length; ++ordinal)
        columnNameArray[ordinal] = dataReader.GetName(ordinal);
      ADP.BuildSchemaTableInfoTableNames(columnNameArray);
      return columnNameArray;
    }

    private DataColumn[] ResizeColumnArray(DataColumn[] rgcol, int len)
    {
      Debug.Assert(rgcol != null, "invalid call to ResizeArray");
      Debug.Assert(len <= rgcol.Length, "invalid len passed to ResizeArray");
      DataColumn[] dataColumnArray = new DataColumn[len];
      Array.Copy((Array) rgcol, (Array) dataColumnArray, len);
      return dataColumnArray;
    }

    private void AddItemToAllowRollback(ref List<object> items, object value)
    {
      if (items == null)
        items = new List<object>();
      items.Add(value);
    }

    private void RollbackAddedItems(List<object> items)
    {
      if (items == null)
        return;
      for (int index = items.Count - 1; 0 <= index; --index)
      {
        if (items[index] != null)
        {
          if (items[index] is DataColumn column)
          {
            if (column.Table != null)
              column.Table.Columns.Remove(column);
          }
          else if (items[index] is DataTable table && table.DataSet != null)
            table.DataSet.Tables.Remove(table);
        }
      }
    }

    private object[] SetupSchemaWithoutKeyInfo(
      MissingMappingAction mappingAction,
      MissingSchemaAction schemaAction,
      bool gettingData,
      DataColumn parentChapterColumn,
      object chapterValue)
    {
      int[] numArray = (int[]) null;
      bool[] flagArray = (bool[]) null;
      int num = 0;
      int fieldCount = this._dataReader.FieldCount;
      object[] objArray = (object[]) null;
      List<object> items = (List<object>) null;
      try
      {
        DataColumnCollection columns = this._dataTable.Columns;
        for (int index = 0; index < fieldCount; ++index)
        {
          bool flag = false;
          Type type = this._dataReader.GetFieldType(index);
          if (type == null)
            throw ADP.MissingDataReaderFieldType(index);
          if (typeof (IDataReader).IsAssignableFrom(type))
          {
            if (flagArray == null)
              flagArray = new bool[fieldCount];
            flagArray[index] = flag = true;
            type = typeof (int);
          }
          DataColumn dataColumn = this._tableMapping.GetDataColumn(this._fieldNames[index], type, this._dataTable, mappingAction, schemaAction);
          if (dataColumn == null)
          {
            if (numArray == null)
              numArray = this.CreateIndexMap(fieldCount, index);
            numArray[index] = -1;
          }
          else
          {
            if (dataColumn.Table == null)
            {
              if (flag)
              {
                dataColumn.AllowDBNull = false;
                dataColumn.AutoIncrement = true;
                dataColumn.ReadOnly = true;
              }
              this.AddItemToAllowRollback(ref items, (object) dataColumn);
              columns.Add(dataColumn);
            }
            else if (flag && !dataColumn.AutoIncrement)
              throw ADP.FillChapterAutoIncrement();
            if (numArray != null)
              numArray[index] = dataColumn.Ordinal;
            else if (index != dataColumn.Ordinal)
            {
              numArray = this.CreateIndexMap(fieldCount, index);
              numArray[index] = dataColumn.Ordinal;
            }
            ++num;
          }
        }
        bool flag1 = false;
        DataColumn dataColumn1 = (DataColumn) null;
        if (chapterValue != null)
        {
          dataColumn1 = this._tableMapping.GetDataColumn(this._tableMapping.SourceTable, chapterValue.GetType(), this._dataTable, mappingAction, schemaAction);
          if (dataColumn1 != null)
          {
            if (dataColumn1.Table == null)
            {
              this.AddItemToAllowRollback(ref items, (object) dataColumn1);
              columns.Add(dataColumn1);
              flag1 = parentChapterColumn != null;
            }
            ++num;
          }
        }
        if (0 < num)
        {
          if (this._dataSet != null && this._dataTable.DataSet == null)
          {
            this.AddItemToAllowRollback(ref items, (object) this._dataTable);
            this._dataSet.Tables.Add(this._dataTable);
          }
          if (gettingData)
          {
            if (columns == null)
              columns = this._dataTable.Columns;
            this._indexMap = numArray;
            this._chapterMap = flagArray;
            objArray = this.SetupMapping(fieldCount, columns, dataColumn1, chapterValue);
          }
          else
            this._mappedMode = -1;
        }
        else
          this._dataTable = (DataTable) null;
        if (flag1)
          this.AddRelation(parentChapterColumn, dataColumn1);
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableOrSecurityExceptionType(ex))
          this.RollbackAddedItems(items);
        throw;
      }
      return objArray;
    }

    private object[] SetupSchemaWithKeyInfo(
      MissingMappingAction mappingAction,
      MissingSchemaAction schemaAction,
      bool gettingData,
      DataColumn parentChapterColumn,
      object chapterValue)
    {
      DbSchemaRow[] sortedSchemaRows = DbSchemaRow.GetSortedSchemaRows(this._schemaTable, this._dataReader.ReturnProviderSpecificTypes);
      Debug.Assert(sortedSchemaRows != null, "SchemaSetup - null DbSchemaRow[]");
      Debug.Assert(this._dataReader.FieldCount <= sortedSchemaRows.Length, "unexpected fewer rows in Schema than FieldCount");
      if (sortedSchemaRows.Length == 0)
      {
        this._dataTable = (DataTable) null;
        return (object[]) null;
      }
      bool flag1 = this._dataTable.PrimaryKey.Length == 0 && ((LoadOption) 4 <= this._loadOption || this._dataTable.Rows.Count == 0) || this._dataTable.Columns.Count == 0;
      DataColumn[] dataColumnArray = (DataColumn[]) null;
      int len = 0;
      bool flag2 = true;
      string str1 = (string) null;
      string str2 = (string) null;
      bool flag3 = false;
      bool flag4 = false;
      int[] numArray = (int[]) null;
      bool[] flagArray = (bool[]) null;
      int num = 0;
      object[] objArray = (object[]) null;
      List<object> items = (List<object>) null;
      DataColumnCollection columns = this._dataTable.Columns;
      try
      {
        for (int index = 0; index < sortedSchemaRows.Length; ++index)
        {
          DbSchemaRow dbSchemaRow = sortedSchemaRows[index];
          int unsortedIndex = dbSchemaRow.UnsortedIndex;
          bool flag5 = false;
          Type type = dbSchemaRow.DataType ?? this._dataReader.GetFieldType(index);
          if (type == null)
            throw ADP.MissingDataReaderFieldType(index);
          if (typeof (IDataReader).IsAssignableFrom(type))
          {
            if (flagArray == null)
              flagArray = new bool[sortedSchemaRows.Length];
            flagArray[unsortedIndex] = flag5 = true;
            type = typeof (int);
          }
          DataColumn dataColumn = (DataColumn) null;
          if (!dbSchemaRow.IsHidden)
            dataColumn = this._tableMapping.GetDataColumn(this._fieldNames[index], type, this._dataTable, mappingAction, schemaAction);
          string baseTableName = dbSchemaRow.BaseTableName;
          if (dataColumn == null)
          {
            if (numArray == null)
              numArray = this.CreateIndexMap(sortedSchemaRows.Length, unsortedIndex);
            numArray[unsortedIndex] = -1;
            if (dbSchemaRow.IsKey && (flag3 || dbSchemaRow.BaseTableName == str1))
            {
              flag1 = false;
              dataColumnArray = (DataColumn[]) null;
            }
          }
          else
          {
            if (dbSchemaRow.IsKey && baseTableName != str1)
            {
              if (str1 == null)
                str1 = baseTableName;
              else
                flag3 = true;
            }
            if (flag5)
            {
              if (dataColumn.Table == null)
              {
                dataColumn.AllowDBNull = false;
                dataColumn.AutoIncrement = true;
                dataColumn.ReadOnly = true;
              }
              else if (!dataColumn.AutoIncrement)
                throw ADP.FillChapterAutoIncrement();
            }
            else
            {
              if (!flag4 && baseTableName != str2 && !ADP.IsEmpty(baseTableName))
              {
                if (str2 == null)
                  str2 = baseTableName;
                else
                  flag4 = true;
              }
              if ((LoadOption) 4 <= this._loadOption)
              {
                if (dbSchemaRow.IsAutoIncrement && DataColumn.IsAutoIncrementType(type))
                {
                  dataColumn.AutoIncrement = true;
                  if (!dbSchemaRow.AllowDBNull)
                    dataColumn.AllowDBNull = false;
                }
                if (type == typeof (string))
                  dataColumn.MaxLength = dbSchemaRow.Size > 0 ? dbSchemaRow.Size : -1;
                if (dbSchemaRow.IsReadOnly)
                  dataColumn.ReadOnly = true;
                if (!dbSchemaRow.AllowDBNull && (!dbSchemaRow.IsReadOnly || dbSchemaRow.IsKey))
                  dataColumn.AllowDBNull = false;
                if (dbSchemaRow.IsUnique && !dbSchemaRow.IsKey && !type.IsArray)
                {
                  dataColumn.Unique = true;
                  if (!dbSchemaRow.AllowDBNull)
                    dataColumn.AllowDBNull = false;
                }
              }
              else if (dataColumn.Table == null)
              {
                dataColumn.AutoIncrement = dbSchemaRow.IsAutoIncrement;
                dataColumn.AllowDBNull = dbSchemaRow.AllowDBNull;
                dataColumn.ReadOnly = dbSchemaRow.IsReadOnly;
                dataColumn.Unique = dbSchemaRow.IsUnique;
                if (type == typeof (string))
                  dataColumn.MaxLength = dbSchemaRow.Size;
              }
            }
            if (dataColumn.Table == null)
            {
              if ((LoadOption) 4 > this._loadOption)
                this.AddAdditionalProperties(dataColumn, dbSchemaRow.DataRow);
              this.AddItemToAllowRollback(ref items, (object) dataColumn);
              columns.Add(dataColumn);
            }
            if (flag1 && dbSchemaRow.IsKey)
            {
              if (dataColumnArray == null)
                dataColumnArray = new DataColumn[sortedSchemaRows.Length];
              dataColumnArray[len++] = dataColumn;
              if (flag2 && dataColumn.AllowDBNull)
                flag2 = false;
            }
            if (numArray != null)
              numArray[unsortedIndex] = dataColumn.Ordinal;
            else if (unsortedIndex != dataColumn.Ordinal)
            {
              numArray = this.CreateIndexMap(sortedSchemaRows.Length, unsortedIndex);
              numArray[unsortedIndex] = dataColumn.Ordinal;
            }
            ++num;
          }
        }
        bool flag6 = false;
        DataColumn dataColumn1 = (DataColumn) null;
        if (chapterValue != null)
        {
          dataColumn1 = this._tableMapping.GetDataColumn(this._tableMapping.SourceTable, chapterValue.GetType(), this._dataTable, mappingAction, schemaAction);
          if (dataColumn1 != null)
          {
            if (dataColumn1.Table == null)
            {
              dataColumn1.ReadOnly = true;
              dataColumn1.AllowDBNull = false;
              this.AddItemToAllowRollback(ref items, (object) dataColumn1);
              columns.Add(dataColumn1);
              flag6 = parentChapterColumn != null;
            }
            ++num;
          }
        }
        if (0 < num)
        {
          if (this._dataSet != null && this._dataTable.DataSet == null)
          {
            this.AddItemToAllowRollback(ref items, (object) this._dataTable);
            this._dataSet.Tables.Add(this._dataTable);
          }
          if (flag1 && dataColumnArray != null)
          {
            if (len < dataColumnArray.Length)
              dataColumnArray = this.ResizeColumnArray(dataColumnArray, len);
            if (flag2)
            {
              this._dataTable.PrimaryKey = dataColumnArray;
            }
            else
            {
              UniqueConstraint uniqueConstraint = new UniqueConstraint("", dataColumnArray);
              ConstraintCollection constraints = this._dataTable.Constraints;
              int count = constraints.Count;
              for (int index = 0; index < count; ++index)
              {
                if (uniqueConstraint.Equals((object) constraints[index]))
                {
                  uniqueConstraint = (UniqueConstraint) null;
                  break;
                }
              }
              if (uniqueConstraint != null)
                constraints.Add((Constraint) uniqueConstraint);
            }
          }
          if (!flag4 && !ADP.IsEmpty(str2) && ADP.IsEmpty(this._dataTable.TableName))
            this._dataTable.TableName = str2;
          if (gettingData)
          {
            this._indexMap = numArray;
            this._chapterMap = flagArray;
            objArray = this.SetupMapping(sortedSchemaRows.Length, columns, dataColumn1, chapterValue);
          }
          else
            this._mappedMode = -1;
        }
        else
          this._dataTable = (DataTable) null;
        if (flag6)
          this.AddRelation(parentChapterColumn, dataColumn1);
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableOrSecurityExceptionType(ex))
          this.RollbackAddedItems(items);
        throw;
      }
      return objArray;
    }

    private void AddAdditionalProperties(DataColumn targetColumn, DataRow schemaRow)
    {
      DataColumnCollection columns = schemaRow.Table.Columns;
      DataColumn column1 = columns[SchemaTableOptionalColumn.DefaultValue];
      if (column1 != null)
        targetColumn.DefaultValue = schemaRow[column1];
      DataColumn column2 = columns[SchemaTableOptionalColumn.AutoIncrementSeed];
      if (column2 != null)
      {
        object obj = schemaRow[column2];
        if (DBNull.Value != obj)
          targetColumn.AutoIncrementSeed = ((IConvertible) obj).ToInt64((IFormatProvider) CultureInfo.InvariantCulture);
      }
      DataColumn column3 = columns[SchemaTableOptionalColumn.AutoIncrementStep];
      if (column3 != null)
      {
        object obj = schemaRow[column3];
        if (DBNull.Value != obj)
          targetColumn.AutoIncrementStep = ((IConvertible) obj).ToInt64((IFormatProvider) CultureInfo.InvariantCulture);
      }
      DataColumn column4 = columns[SchemaTableOptionalColumn.ColumnMapping];
      if (column4 != null)
      {
        object obj = schemaRow[column4];
        if (DBNull.Value != obj)
          targetColumn.ColumnMapping = (MappingType) ((IConvertible) obj).ToInt32((IFormatProvider) CultureInfo.InvariantCulture);
      }
      DataColumn column5 = columns[SchemaTableOptionalColumn.BaseColumnNamespace];
      if (column5 != null)
      {
        object obj = schemaRow[column5];
        if (DBNull.Value != obj)
          targetColumn.Namespace = ((IConvertible) obj).ToString((IFormatProvider) CultureInfo.InvariantCulture);
      }
      DataColumn column6 = columns[SchemaTableOptionalColumn.Expression];
      if (column6 == null)
        return;
      object obj1 = schemaRow[column6];
      if (DBNull.Value == obj1)
        return;
      targetColumn.Expression = ((IConvertible) obj1).ToString((IFormatProvider) CultureInfo.InvariantCulture);
    }

    private void AddRelation(DataColumn parentChapterColumn, DataColumn chapterColumn)
    {
      if (this._dataSet == null)
        return;
      string columnName = chapterColumn.ColumnName;
      DataRelation relation = new DataRelation(columnName, new DataColumn[1]
      {
        parentChapterColumn
      }, new DataColumn[1]{ chapterColumn }, false);
      int num = 1;
      string relationName = columnName;
      DataRelationCollection relations = this._dataSet.Relations;
      while (-1 != relations.IndexOf(relationName))
      {
        relationName = columnName + (object) num;
        ++num;
      }
      relation.RelationName = relationName;
      relations.Add(relation);
    }

    private object[] SetupMapping(
      int count,
      DataColumnCollection columnCollection,
      DataColumn chapterColumn,
      object chapterValue)
    {
      object[] objArray = new object[count];
      if (this._indexMap == null)
      {
        int count1 = columnCollection.Count;
        bool flag = this._chapterMap != null;
        if (count != count1 | flag)
        {
          this._mappedDataValues = new object[count1];
          if (flag)
          {
            this._mappedMode = 3;
            this._mappedLength = count;
          }
          else
          {
            this._mappedMode = 1;
            this._mappedLength = Math.Min(count, count1);
          }
        }
        else
          this._mappedMode = 0;
      }
      else
      {
        this._mappedDataValues = new object[columnCollection.Count];
        this._mappedMode = this._chapterMap == null ? 2 : 4;
        this._mappedLength = count;
      }
      if (chapterColumn == null)
        return objArray;
      this._mappedDataValues[chapterColumn.Ordinal] = chapterValue;
      return objArray;
    }
  }
}
