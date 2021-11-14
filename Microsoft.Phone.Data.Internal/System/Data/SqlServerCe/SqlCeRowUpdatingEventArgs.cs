// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeRowUpdatingEventArgs
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using Microsoft.Phone.Data.Common;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeRowUpdatingEventArgs : RowUpdatingEventArgs
  {
    static SqlCeRowUpdatingEventArgs() => KillBitHelper.ThrowIfKillBitIsSet();

    public SqlCeRowUpdatingEventArgs(
      DataRow dataRow,
      IDbCommand command,
      StatementType statementType,
      DataTableMapping tableMapping)
      : base(dataRow, command, statementType, tableMapping)
    {
    }

    public SqlCeCommand Command
    {
      get => (SqlCeCommand) base.Command;
      set => this.Command = (IDbCommand) value;
    }
  }
}
