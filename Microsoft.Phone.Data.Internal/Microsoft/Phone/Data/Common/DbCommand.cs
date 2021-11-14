// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbCommand
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Workaround;
using System;

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbCommand : MarshalByValueComponent, IDbCommand, IDisposable
  {
    public abstract string CommandText { get; set; }

    public abstract int CommandTimeout { get; set; }

    public abstract CommandType CommandType { get; set; }

    public DbConnection Connection
    {
      get => this.DbConnection;
      set => this.DbConnection = value;
    }

    IDbConnection IDbCommand.Connection
    {
      get => (IDbConnection) this.DbConnection;
      set => this.DbConnection = (DbConnection) value;
    }

    protected abstract DbConnection DbConnection { get; set; }

    protected abstract DbParameterCollection DbParameterCollection { get; }

    protected abstract DbTransaction DbTransaction { get; set; }

    public abstract bool DesignTimeVisible { get; set; }

    public DbParameterCollection Parameters => this.DbParameterCollection;

    IDataParameterCollection IDbCommand.Parameters => (IDataParameterCollection) this.DbParameterCollection;

    public DbTransaction Transaction
    {
      get => this.DbTransaction;
      set => this.DbTransaction = value;
    }

    IDbTransaction IDbCommand.Transaction
    {
      get => (IDbTransaction) this.DbTransaction;
      set => this.DbTransaction = (DbTransaction) value;
    }

    public abstract UpdateRowSource UpdatedRowSource { get; set; }

    public abstract void Cancel();

    public DbParameter CreateParameter() => this.CreateDbParameter();

    IDbDataParameter IDbCommand.CreateParameter() => (IDbDataParameter) this.CreateDbParameter();

    protected abstract DbParameter CreateDbParameter();

    protected abstract DbDataReader ExecuteDbDataReader(CommandBehavior behavior);

    public abstract int ExecuteNonQuery();

    public DbDataReader ExecuteReader() => this.ExecuteDbDataReader(CommandBehavior.Default);

    IDataReader IDbCommand.ExecuteReader() => (IDataReader) this.ExecuteDbDataReader(CommandBehavior.Default);

    public DbDataReader ExecuteReader(CommandBehavior behavior) => this.ExecuteDbDataReader(behavior);

    IDataReader IDbCommand.ExecuteReader(CommandBehavior behavior) => (IDataReader) this.ExecuteDbDataReader(behavior);

    public abstract object ExecuteScalar();

    public abstract void Prepare();
  }
}
