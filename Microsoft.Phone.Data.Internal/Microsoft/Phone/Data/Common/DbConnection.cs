// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbConnection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbConnection : MarshalByValueComponent, IDbConnection, IDisposable
  {
    private StateChangeEventHandler _stateChangeEventHandler;

    public abstract string ConnectionString { get; set; }

    public virtual int ConnectionTimeout => 15;

    public abstract string Database { get; }

    public abstract string DataSource { get; }

    protected virtual DbProviderFactory DbProviderFactory => (DbProviderFactory) null;

    internal DbProviderFactory ProviderFactory => this.DbProviderFactory;

    public abstract string ServerVersion { get; }

    public abstract ConnectionState State { get; }

    public virtual event StateChangeEventHandler StateChange
    {
      add => this._stateChangeEventHandler += value;
      remove => this._stateChangeEventHandler -= value;
    }

    protected abstract DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);

    public DbTransaction BeginTransaction() => this.BeginDbTransaction(IsolationLevel.Unspecified);

    public DbTransaction BeginTransaction(IsolationLevel isolationLevel) => this.BeginDbTransaction(isolationLevel);

    IDbTransaction IDbConnection.BeginTransaction() => (IDbTransaction) this.BeginDbTransaction(IsolationLevel.Unspecified);

    IDbTransaction IDbConnection.BeginTransaction(
      IsolationLevel isolationLevel)
    {
      return (IDbTransaction) this.BeginDbTransaction(isolationLevel);
    }

    public abstract void Close();

    public abstract void ChangeDatabase(string databaseName);

    public DbCommand CreateCommand() => this.CreateDbCommand();

    IDbCommand IDbConnection.CreateCommand() => (IDbCommand) this.CreateDbCommand();

    protected abstract DbCommand CreateDbCommand();

    public virtual DataTable GetSchema() => throw ADP.NotSupported();

    public virtual DataTable GetSchema(string collectionName) => throw ADP.NotSupported();

    public virtual DataTable GetSchema(string collectionName, string[] restrictionValues) => throw ADP.NotSupported();

    protected virtual void OnStateChange(StateChangeEventArgs stateChange)
    {
      StateChangeEventHandler changeEventHandler = this._stateChangeEventHandler;
      if (changeEventHandler == null)
        return;
      changeEventHandler((object) this, stateChange);
    }

    public abstract void Open();
  }
}
