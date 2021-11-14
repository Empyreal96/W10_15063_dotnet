// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.RowUpdatedEventArgs
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data.Common
{
  public class RowUpdatedEventArgs : EventArgs
  {
    private IDbCommand _command;
    private StatementType _statementType;
    private DataTableMapping _tableMapping;
    private Exception _errors;
    private DataRow _dataRow;
    private DataRow[] _dataRows;
    private UpdateStatus _status;
    private int _recordsAffected;

    public RowUpdatedEventArgs(
      DataRow dataRow,
      IDbCommand command,
      StatementType statementType,
      DataTableMapping tableMapping)
    {
      switch (statementType)
      {
        case StatementType.Select:
        case StatementType.Insert:
        case StatementType.Update:
        case StatementType.Delete:
        case StatementType.Batch:
          this._dataRow = dataRow;
          this._command = command;
          this._statementType = statementType;
          this._tableMapping = tableMapping;
          break;
        default:
          throw ADP.InvalidStatementType(statementType);
      }
    }

    public IDbCommand Command => this._command;

    public Exception Errors
    {
      get => this._errors;
      set => this._errors = value;
    }

    public int RecordsAffected => this._recordsAffected;

    public DataRow Row => this._dataRow;

    internal DataRow[] Rows => this._dataRows;

    public int RowCount
    {
      get
      {
        DataRow[] dataRows = this._dataRows;
        if (dataRows != null)
          return dataRows.Length;
        return this._dataRow == null ? 0 : 1;
      }
    }

    public StatementType StatementType => this._statementType;

    public UpdateStatus Status
    {
      get => this._status;
      set
      {
        switch (value)
        {
          case UpdateStatus.Continue:
          case UpdateStatus.ErrorsOccurred:
          case UpdateStatus.SkipCurrentRow:
          case UpdateStatus.SkipAllRemainingRows:
            this._status = value;
            break;
          default:
            throw ADP.InvalidUpdateStatus(value);
        }
      }
    }

    public DataTableMapping TableMapping => this._tableMapping;

    internal void AdapterInit(DataRow[] dataRows)
    {
      this._statementType = StatementType.Batch;
      this._dataRows = dataRows;
      if (dataRows == null || 1 != dataRows.Length)
        return;
      this._dataRow = dataRows[0];
    }

    internal void AdapterInit(int recordsAffected) => this._recordsAffected = recordsAffected;

    public void CopyToRows(DataRow[] array) => this.CopyToRows(array, 0);

    public void CopyToRows(DataRow[] array, int arrayIndex)
    {
      DataRow[] dataRows = this._dataRows;
      if (dataRows != null)
      {
        dataRows.CopyTo((Array) array, arrayIndex);
      }
      else
      {
        if (array == null)
          throw ADP.ArgumentNull(nameof (array));
        array[arrayIndex] = this.Row;
      }
    }
  }
}
