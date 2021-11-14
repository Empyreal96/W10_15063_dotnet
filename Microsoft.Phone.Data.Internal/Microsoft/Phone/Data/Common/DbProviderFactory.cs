// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbProviderFactory
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbProviderFactory
  {
    public virtual bool CanCreateDataSourceEnumerator => false;

    public virtual DbCommand CreateCommand() => (DbCommand) null;

    public virtual DbCommandBuilder CreateCommandBuilder() => (DbCommandBuilder) null;

    public virtual DbConnection CreateConnection() => (DbConnection) null;

    public virtual DbConnectionStringBuilder CreateConnectionStringBuilder() => (DbConnectionStringBuilder) null;

    public virtual DbDataAdapter CreateDataAdapter() => (DbDataAdapter) null;

    public virtual DbParameter CreateParameter() => (DbParameter) null;

    public virtual DbDataSourceEnumerator CreateDataSourceEnumerator() => (DbDataSourceEnumerator) null;
  }
}
