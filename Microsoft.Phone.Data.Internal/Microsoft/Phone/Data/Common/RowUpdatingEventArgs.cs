// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.RowUpdatingEventArgs
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data.Common
{
  public class RowUpdatingEventArgs : EventArgs
  {
    private IDbCommand _command;
    private StatementType _statementType;
    private DataTableMapping _tableMapping;
    private Exception _errors;
    private DataRow _dataRow;
    private UpdateStatus _status;

    public RowUpdatingEventArgs(
      DataRow dataRow,
      IDbCommand command,
      StatementType statementType,
      DataTableMapping tableMapping)
    {
      ADP.CheckArgumentNull((object) dataRow, nameof (dataRow));
      ADP.CheckArgumentNull((object) tableMapping, nameof (tableMapping));
      switch (statementType)
      {
        case StatementType.Select:
        case StatementType.Insert:
        case StatementType.Update:
        case StatementType.Delete:
          this._dataRow = dataRow;
          this._command = command;
          this._statementType = statementType;
          this._tableMapping = tableMapping;
          break;
        case StatementType.Batch:
          throw ADP.NotSupportedStatementType(statementType, nameof (RowUpdatingEventArgs));
        default:
          throw ADP.InvalidStatementType(statementType);
      }
    }

    protected virtual IDbCommand BaseCommand
    {
      get => this._command;
      set => this._command = value;
    }

    public IDbCommand Command
    {
      get => this.BaseCommand;
      set => this.BaseCommand = value;
    }

    public Exception Errors
    {
      get => this._errors;
      set => this._errors = value;
    }

    public DataRow Row => this._dataRow;

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
  }
}
