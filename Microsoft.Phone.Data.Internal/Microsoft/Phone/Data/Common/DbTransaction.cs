// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.DbTransaction
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data.Common
{
  public abstract class DbTransaction : IDbTransaction, IDisposable
  {
    public DbConnection Connection => this.DbConnection;

    IDbConnection IDbTransaction.Connection => (IDbConnection) this.DbConnection;

    protected abstract DbConnection DbConnection { get; }

    public abstract IsolationLevel IsolationLevel { get; }

    public abstract void Commit();

    public void Dispose() => this.Dispose(true);

    protected virtual void Dispose(bool disposing)
    {
    }

    public abstract void Rollback();
  }
}
