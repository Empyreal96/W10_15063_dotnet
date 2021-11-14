// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataTableReader
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Collections;
using System.Globalization;

namespace Microsoft.Phone.Data
{
  public sealed class DataTableReader : DbDataReader
  {
    private readonly DataTable[] tables;
    private bool isOpen = true;
    private DataTable schemaTable;
    private int tableCounter = -1;
    private int rowCounter = -1;
    private DataTable currentDataTable;
    private DataRow currentDataRow;
    private bool hasRows = true;
    private bool reachEORows;
    private bool currentRowRemoved;
    private bool schemaIsChanged;
    private bool started;
    private bool readerIsInvalid;
    private DataTableReaderListener listener;
    private bool tableCleared;

    public DataTableReader(DataTable dataTable)
    {
      this.tables = dataTable != null ? new DataTable[1]
      {
        dataTable
      } : throw ExceptionBuilder.ArgumentNull("DataTable");
      this.init();
    }

    public DataTableReader(DataTable[] dataTables)
    {
      if (dataTables == null)
        throw ExceptionBuilder.ArgumentNull("DataTable");
      this.tables = dataTables.Length != 0 ? new DataTable[dataTables.Length] : throw ExceptionBuilder.DataTableReaderArgumentIsEmpty();
      for (int index = 0; index < dataTables.Length; ++index)
        this.tables[index] = dataTables[index] != null ? dataTables[index] : throw ExceptionBuilder.ArgumentNull("DataTable");
      this.init();
    }

    private bool ReaderIsInvalid
    {
      get => this.readerIsInvalid;
      set
      {
        if (this.readerIsInvalid == value)
          return;
        this.readerIsInvalid = value;
        if (!this.readerIsInvalid || this.listener == null)
          return;
        this.listener.CleanUp();
      }
    }

    private bool IsSchemaChanged
    {
      get => this.schemaIsChanged;
      set
      {
        if (!value || this.schemaIsChanged == value)
          return;
        this.schemaIsChanged = value;
        if (this.listener == null)
          return;
        this.listener.CleanUp();
      }
    }

    internal DataTable CurrentDataTable => this.currentDataTable;

    private void init()
    {
      this.tableCounter = 0;
      this.reachEORows = false;
      this.schemaIsChanged = false;
      this.currentDataTable = this.tables[this.tableCounter];
      this.hasRows = this.currentDataTable.Rows.Count > 0;
      this.ReaderIsInvalid = false;
      this.listener = new DataTableReaderListener(this);
    }

    public override void Close()
    {
      if (!this.isOpen)
        return;
      if (this.listener != null)
        this.listener.CleanUp();
      this.listener = (DataTableReaderListener) null;
      this.schemaTable = (DataTable) null;
      this.isOpen = false;
    }

    public override DataTable GetSchemaTable()
    {
      this.ValidateOpen(nameof (GetSchemaTable));
      this.ValidateReader();
      if (this.schemaTable == null)
        this.schemaTable = DataTableReader.GetSchemaTableFromDataTable(this.currentDataTable);
      return this.schemaTable;
    }

    public override bool NextResult()
    {
      this.ValidateOpen(nameof (NextResult));
      if (this.tableCounter == this.tables.Length - 1)
        return false;
      this.currentDataTable = this.tables[++this.tableCounter];
      if (this.listener != null)
        this.listener.UpdataTable(this.currentDataTable);
      this.schemaTable = (DataTable) null;
      this.rowCounter = -1;
      this.currentRowRemoved = false;
      this.reachEORows = false;
      this.schemaIsChanged = false;
      this.started = false;
      this.ReaderIsInvalid = false;
      this.tableCleared = false;
      this.hasRows = this.currentDataTable.Rows.Count > 0;
      return true;
    }

    public override bool Read()
    {
      if (!this.started)
        this.started = true;
      this.ValidateOpen(nameof (Read));
      this.ValidateReader();
      if (this.reachEORows)
        return false;
      if (this.rowCounter >= this.currentDataTable.Rows.Count - 1)
      {
        this.reachEORows = true;
        if (this.listener != null)
          this.listener.CleanUp();
        return false;
      }
      ++this.rowCounter;
      this.ValidateRow(this.rowCounter);
      for (this.currentDataRow = this.currentDataTable.Rows[this.rowCounter]; this.currentDataRow.RowState == DataRowState.Deleted; this.currentDataRow = this.currentDataTable.Rows[this.rowCounter])
      {
        ++this.rowCounter;
        if (this.rowCounter == this.currentDataTable.Rows.Count)
        {
          this.reachEORows = true;
          if (this.listener != null)
            this.listener.CleanUp();
          return false;
        }
        this.ValidateRow(this.rowCounter);
      }
      if (this.currentRowRemoved)
        this.currentRowRemoved = false;
      return true;
    }

    public override int Depth
    {
      get
      {
        this.ValidateOpen(nameof (Depth));
        this.ValidateReader();
        return 0;
      }
    }

    public override bool IsClosed => !this.isOpen;

    public override int RecordsAffected
    {
      get
      {
        this.ValidateReader();
        return 0;
      }
    }

    public override bool HasRows
    {
      get
      {
        this.ValidateOpen(nameof (HasRows));
        this.ValidateReader();
        return this.hasRows;
      }
    }

    public override object this[int ordinal]
    {
      get
      {
        this.ValidateOpen(nameof (Item));
        this.ValidateReader();
        if (this.currentDataRow != null)
        {
          if (this.currentDataRow.RowState != DataRowState.Deleted)
          {
            try
            {
              return this.currentDataRow[ordinal];
            }
            catch (IndexOutOfRangeException ex)
            {
              ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
              throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
            }
          }
        }
        this.ReaderIsInvalid = true;
        throw ExceptionBuilder.InvalidDataTableReader(this.currentDataTable.TableName);
      }
    }

    public override object this[string name]
    {
      get
      {
        this.ValidateOpen(nameof (Item));
        this.ValidateReader();
        if (this.currentDataRow == null || this.currentDataRow.RowState == DataRowState.Deleted)
        {
          this.ReaderIsInvalid = true;
          throw ExceptionBuilder.InvalidDataTableReader(this.currentDataTable.TableName);
        }
        return this.currentDataRow[name];
      }
    }

    public override int FieldCount
    {
      get
      {
        this.ValidateOpen(nameof (FieldCount));
        this.ValidateReader();
        return this.currentDataTable.Columns.Count;
      }
    }

    public override Type GetProviderSpecificFieldType(int ordinal)
    {
      this.ValidateOpen(nameof (GetProviderSpecificFieldType));
      this.ValidateReader();
      return this.GetFieldType(ordinal);
    }

    public override object GetProviderSpecificValue(int ordinal)
    {
      this.ValidateOpen(nameof (GetProviderSpecificValue));
      this.ValidateReader();
      return this.GetValue(ordinal);
    }

    public override int GetProviderSpecificValues(object[] values)
    {
      this.ValidateOpen(nameof (GetProviderSpecificValues));
      this.ValidateReader();
      return this.GetValues(values);
    }

    public override bool GetBoolean(int ordinal)
    {
      this.ValidateState(nameof (GetBoolean));
      this.ValidateReader();
      try
      {
        return (bool) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override byte GetByte(int ordinal)
    {
      this.ValidateState(nameof (GetByte));
      this.ValidateReader();
      try
      {
        return (byte) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override long GetBytes(
      int ordinal,
      long dataIndex,
      byte[] buffer,
      int bufferIndex,
      int length)
    {
      this.ValidateState(nameof (GetBytes));
      this.ValidateReader();
      byte[] numArray;
      try
      {
        numArray = (byte[]) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
      if (buffer == null)
        return (long) numArray.Length;
      int num = (int) dataIndex;
      int length1 = Math.Min(numArray.Length - num, length);
      if (num < 0)
        throw ADP.InvalidSourceBufferIndex(numArray.Length, (long) num, nameof (dataIndex));
      if (bufferIndex < 0 || bufferIndex > 0 && bufferIndex >= buffer.Length)
        throw ADP.InvalidDestinationBufferIndex(buffer.Length, bufferIndex, nameof (bufferIndex));
      if (0 < length1)
      {
        Array.Copy((Array) numArray, (int) dataIndex, (Array) buffer, bufferIndex, length1);
      }
      else
      {
        if (length < 0)
          throw ADP.InvalidDataLength((long) length);
        length1 = 0;
      }
      return (long) length1;
    }

    public override char GetChar(int ordinal)
    {
      this.ValidateState(nameof (GetChar));
      this.ValidateReader();
      try
      {
        return (char) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override long GetChars(
      int ordinal,
      long dataIndex,
      char[] buffer,
      int bufferIndex,
      int length)
    {
      this.ValidateState(nameof (GetChars));
      this.ValidateReader();
      char[] chArray;
      try
      {
        chArray = (char[]) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
      if (buffer == null)
        return (long) chArray.Length;
      int num = (int) dataIndex;
      int length1 = Math.Min(chArray.Length - num, length);
      if (num < 0)
        throw ADP.InvalidSourceBufferIndex(chArray.Length, (long) num, nameof (dataIndex));
      if (bufferIndex < 0 || bufferIndex > 0 && bufferIndex >= buffer.Length)
        throw ADP.InvalidDestinationBufferIndex(buffer.Length, bufferIndex, nameof (bufferIndex));
      if (0 < length1)
      {
        Array.Copy((Array) chArray, (int) dataIndex, (Array) buffer, bufferIndex, length1);
      }
      else
      {
        if (length < 0)
          throw ADP.InvalidDataLength((long) length);
        length1 = 0;
      }
      return (long) length1;
    }

    public override string GetDataTypeName(int ordinal)
    {
      this.ValidateOpen(nameof (GetDataTypeName));
      this.ValidateReader();
      return this.GetFieldType(ordinal).Name;
    }

    public override DateTime GetDateTime(int ordinal)
    {
      this.ValidateState(nameof (GetDateTime));
      this.ValidateReader();
      try
      {
        return (DateTime) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override Decimal GetDecimal(int ordinal)
    {
      this.ValidateState(nameof (GetDecimal));
      this.ValidateReader();
      try
      {
        return (Decimal) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override double GetDouble(int ordinal)
    {
      this.ValidateState(nameof (GetDouble));
      this.ValidateReader();
      try
      {
        return (double) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override Type GetFieldType(int ordinal)
    {
      this.ValidateOpen(nameof (GetFieldType));
      this.ValidateReader();
      try
      {
        return this.currentDataTable.Columns[ordinal].DataType;
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override float GetFloat(int ordinal)
    {
      this.ValidateState(nameof (GetFloat));
      this.ValidateReader();
      try
      {
        return (float) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override Guid GetGuid(int ordinal)
    {
      this.ValidateState(nameof (GetGuid));
      this.ValidateReader();
      try
      {
        return (Guid) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override short GetInt16(int ordinal)
    {
      this.ValidateState(nameof (GetInt16));
      this.ValidateReader();
      try
      {
        return (short) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override int GetInt32(int ordinal)
    {
      this.ValidateState(nameof (GetInt32));
      this.ValidateReader();
      try
      {
        return (int) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override long GetInt64(int ordinal)
    {
      this.ValidateState(nameof (GetInt64));
      this.ValidateReader();
      try
      {
        return (long) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override string GetName(int ordinal)
    {
      this.ValidateOpen(nameof (GetName));
      this.ValidateReader();
      try
      {
        return this.currentDataTable.Columns[ordinal].ColumnName;
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override int GetOrdinal(string name)
    {
      this.ValidateOpen(nameof (GetOrdinal));
      this.ValidateReader();
      return (this.currentDataTable.Columns[name] ?? throw ExceptionBuilder.ColumnNotInTheTable(name, this.currentDataTable.TableName)).Ordinal;
    }

    public override string GetString(int ordinal)
    {
      this.ValidateState(nameof (GetString));
      this.ValidateReader();
      try
      {
        return (string) this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override object GetValue(int ordinal)
    {
      this.ValidateState(nameof (GetValue));
      this.ValidateReader();
      try
      {
        return this.currentDataRow[ordinal];
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override int GetValues(object[] values)
    {
      this.ValidateState(nameof (GetValues));
      this.ValidateReader();
      if (values == null)
        throw ExceptionBuilder.ArgumentNull(nameof (values));
      Array.Copy((Array) this.currentDataRow.ItemArray, (Array) values, this.currentDataRow.ItemArray.Length > values.Length ? values.Length : this.currentDataRow.ItemArray.Length);
      return this.currentDataRow.ItemArray.Length <= values.Length ? this.currentDataRow.ItemArray.Length : values.Length;
    }

    public override bool IsDBNull(int ordinal)
    {
      this.ValidateState(nameof (IsDBNull));
      this.ValidateReader();
      try
      {
        return this.currentDataRow.IsNull(ordinal);
      }
      catch (IndexOutOfRangeException ex)
      {
        ExceptionBuilder.TraceExceptionWithoutRethrow((Exception) ex);
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (ordinal));
      }
    }

    public override IEnumerator GetEnumerator()
    {
      this.ValidateOpen(nameof (GetEnumerator));
      return (IEnumerator) new DbEnumerator((IDataReader) this);
    }

    internal static DataTable GetSchemaTableFromDataTable(DataTable table)
    {
      if (table == null)
        throw ExceptionBuilder.ArgumentNull("DataTable");
      DataTable dataTable = new DataTable("SchemaTable");
      dataTable.Locale = CultureInfo.InvariantCulture;
      DataColumn column1 = new DataColumn(SchemaTableColumn.ColumnName, typeof (string));
      DataColumn column2 = new DataColumn(SchemaTableColumn.ColumnOrdinal, typeof (int));
      DataColumn column3 = new DataColumn(SchemaTableColumn.ColumnSize, typeof (int));
      DataColumn column4 = new DataColumn(SchemaTableColumn.NumericPrecision, typeof (short));
      DataColumn column5 = new DataColumn(SchemaTableColumn.NumericScale, typeof (short));
      DataColumn column6 = new DataColumn(SchemaTableColumn.DataType, typeof (Type));
      DataColumn column7 = new DataColumn(SchemaTableColumn.ProviderType, typeof (int));
      DataColumn column8 = new DataColumn(SchemaTableColumn.IsLong, typeof (bool));
      DataColumn column9 = new DataColumn(SchemaTableColumn.AllowDBNull, typeof (bool));
      DataColumn column10 = new DataColumn(SchemaTableOptionalColumn.IsReadOnly, typeof (bool));
      DataColumn column11 = new DataColumn(SchemaTableOptionalColumn.IsRowVersion, typeof (bool));
      DataColumn column12 = new DataColumn(SchemaTableColumn.IsUnique, typeof (bool));
      DataColumn column13 = new DataColumn(SchemaTableColumn.IsKey, typeof (bool));
      DataColumn column14 = new DataColumn(SchemaTableOptionalColumn.IsAutoIncrement, typeof (bool));
      DataColumn column15 = new DataColumn(SchemaTableColumn.BaseSchemaName, typeof (string));
      DataColumn column16 = new DataColumn(SchemaTableOptionalColumn.BaseCatalogName, typeof (string));
      DataColumn column17 = new DataColumn(SchemaTableColumn.BaseTableName, typeof (string));
      DataColumn column18 = new DataColumn(SchemaTableColumn.BaseColumnName, typeof (string));
      DataColumn column19 = new DataColumn(SchemaTableOptionalColumn.AutoIncrementSeed, typeof (long));
      DataColumn column20 = new DataColumn(SchemaTableOptionalColumn.AutoIncrementStep, typeof (long));
      DataColumn column21 = new DataColumn(SchemaTableOptionalColumn.DefaultValue, typeof (object));
      DataColumn column22 = new DataColumn(SchemaTableOptionalColumn.Expression, typeof (string));
      DataColumn column23 = new DataColumn(SchemaTableOptionalColumn.ColumnMapping, typeof (MappingType));
      DataColumn column24 = new DataColumn(SchemaTableOptionalColumn.BaseTableNamespace, typeof (string));
      DataColumn column25 = new DataColumn(SchemaTableOptionalColumn.BaseColumnNamespace, typeof (string));
      column3.DefaultValue = (object) -1;
      if (table.DataSet != null)
        column16.DefaultValue = (object) table.DataSet.DataSetName;
      column17.DefaultValue = (object) table.TableName;
      column24.DefaultValue = (object) table.Namespace;
      column11.DefaultValue = (object) false;
      column8.DefaultValue = (object) false;
      column10.DefaultValue = (object) false;
      column13.DefaultValue = (object) false;
      column14.DefaultValue = (object) false;
      column19.DefaultValue = (object) 0;
      column20.DefaultValue = (object) 1;
      dataTable.Columns.Add(column1);
      dataTable.Columns.Add(column2);
      dataTable.Columns.Add(column3);
      dataTable.Columns.Add(column4);
      dataTable.Columns.Add(column5);
      dataTable.Columns.Add(column6);
      dataTable.Columns.Add(column7);
      dataTable.Columns.Add(column8);
      dataTable.Columns.Add(column9);
      dataTable.Columns.Add(column10);
      dataTable.Columns.Add(column11);
      dataTable.Columns.Add(column12);
      dataTable.Columns.Add(column13);
      dataTable.Columns.Add(column14);
      dataTable.Columns.Add(column16);
      dataTable.Columns.Add(column15);
      dataTable.Columns.Add(column17);
      dataTable.Columns.Add(column18);
      dataTable.Columns.Add(column19);
      dataTable.Columns.Add(column20);
      dataTable.Columns.Add(column21);
      dataTable.Columns.Add(column22);
      dataTable.Columns.Add(column23);
      dataTable.Columns.Add(column24);
      dataTable.Columns.Add(column25);
      foreach (DataColumn column26 in (InternalDataCollectionBase) table.Columns)
      {
        DataRow row = dataTable.NewRow();
        row[column1] = (object) column26.ColumnName;
        row[column2] = (object) column26.Ordinal;
        row[column6] = (object) column26.DataType;
        if (column26.DataType == typeof (string))
          row[column3] = (object) column26.MaxLength;
        row[column9] = (object) column26.AllowDBNull;
        row[column10] = (object) column26.ReadOnly;
        row[column12] = (object) column26.Unique;
        if (column26.AutoIncrement)
        {
          row[column14] = (object) true;
          row[column19] = (object) column26.AutoIncrementSeed;
          row[column20] = (object) column26.AutoIncrementStep;
        }
        if (column26.DefaultValue != DBNull.Value)
          row[column21] = column26.DefaultValue;
        if (column26.Expression.Length != 0)
        {
          bool flag = false;
          foreach (DataColumn dataColumn in column26.DataExpression.GetDependency())
          {
            if (dataColumn.Table != table)
            {
              flag = true;
              break;
            }
          }
          if (!flag)
            row[column22] = (object) column26.Expression;
        }
        row[column23] = (object) column26.ColumnMapping;
        row[column18] = (object) column26.ColumnName;
        row[column25] = (object) column26.Namespace;
        dataTable.Rows.Add(row);
      }
      foreach (DataColumn dataColumn in table.PrimaryKey)
        dataTable.Rows[dataColumn.Ordinal][column13] = (object) true;
      dataTable.AcceptChanges();
      return dataTable;
    }

    private void ValidateOpen(string caller)
    {
      if (!this.isOpen)
        throw ADP.DataReaderClosed(caller);
    }

    private void ValidateReader()
    {
      if (this.ReaderIsInvalid)
        throw ExceptionBuilder.InvalidDataTableReader(this.currentDataTable.TableName);
      if (this.IsSchemaChanged)
        throw ExceptionBuilder.DataTableReaderSchemaIsInvalid(this.currentDataTable.TableName);
    }

    private void ValidateState(string caller)
    {
      this.ValidateOpen(caller);
      if (this.tableCleared)
        throw ExceptionBuilder.EmptyDataTableReader(this.currentDataTable.TableName);
      if (this.currentDataRow == null || this.currentDataTable == null)
      {
        this.ReaderIsInvalid = true;
        throw ExceptionBuilder.InvalidDataTableReader(this.currentDataTable.TableName);
      }
      if (this.currentDataRow.RowState == DataRowState.Deleted || this.currentDataRow.RowState == DataRowState.Detached || this.currentRowRemoved)
        throw ExceptionBuilder.InvalidCurrentRowInDataTableReader();
      if (0 > this.rowCounter || this.currentDataTable.Rows.Count <= this.rowCounter)
      {
        this.ReaderIsInvalid = true;
        throw ExceptionBuilder.InvalidDataTableReader(this.currentDataTable.TableName);
      }
    }

    private void ValidateRow(int rowPosition)
    {
      if (this.ReaderIsInvalid)
        throw ExceptionBuilder.InvalidDataTableReader(this.currentDataTable.TableName);
      if (0 > rowPosition || this.currentDataTable.Rows.Count <= rowPosition)
      {
        this.ReaderIsInvalid = true;
        throw ExceptionBuilder.InvalidDataTableReader(this.currentDataTable.TableName);
      }
    }

    internal void SchemaChanged() => this.IsSchemaChanged = true;

    internal void DataTableCleared()
    {
      if (!this.started)
        return;
      this.rowCounter = -1;
      if (this.reachEORows)
        return;
      this.currentRowRemoved = true;
    }

    internal void DataChanged(DataRowChangeEventArgs args)
    {
      if (!this.started || this.rowCounter == -1 && !this.tableCleared)
        return;
      switch (args.Action)
      {
        case DataRowAction.Delete:
        case DataRowAction.Rollback:
        case DataRowAction.Commit:
          if (args.Row.RowState != DataRowState.Detached)
            break;
          if (args.Row != this.currentDataRow)
          {
            if (this.rowCounter == 0)
              break;
            this.ValidateRow(this.rowCounter - 1);
            if (this.currentDataRow != this.currentDataTable.Rows[this.rowCounter - 1])
              break;
            --this.rowCounter;
            break;
          }
          this.currentRowRemoved = true;
          if (this.rowCounter > 0)
          {
            --this.rowCounter;
            this.currentDataRow = this.currentDataTable.Rows[this.rowCounter];
            break;
          }
          this.rowCounter = -1;
          this.currentDataRow = (DataRow) null;
          break;
        case DataRowAction.Add:
          this.ValidateRow(this.rowCounter + 1);
          if (this.currentDataRow != this.currentDataTable.Rows[this.rowCounter + 1])
            break;
          ++this.rowCounter;
          break;
      }
    }
  }
}
