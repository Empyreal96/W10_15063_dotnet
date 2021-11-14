// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeProviderFactory
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System.Diagnostics.CodeAnalysis;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeProviderFactory : DbProviderFactory
  {
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly SqlCeProviderFactory Instance = new SqlCeProviderFactory();

    static SqlCeProviderFactory() => KillBitHelper.ThrowIfKillBitIsSet();

    public override DbCommand CreateCommand() => (DbCommand) new SqlCeCommand();

    public override DbCommandBuilder CreateCommandBuilder() => (DbCommandBuilder) new SqlCeCommandBuilder();

    public override DbConnection CreateConnection() => (DbConnection) new SqlCeConnection();

    public override DbDataAdapter CreateDataAdapter() => (DbDataAdapter) new SqlCeDataAdapter();

    public override DbParameter CreateParameter() => (DbParameter) new SqlCeParameter();

    public override DbConnectionStringBuilder CreateConnectionStringBuilder() => (DbConnectionStringBuilder) new SqlCeConnectionStringBuilder();
  }
}
