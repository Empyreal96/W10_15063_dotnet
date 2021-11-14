// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeTransaction
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using Microsoft.Phone.Data.Common;
using System.Diagnostics;
using System.Security;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeTransaction : DbTransaction
  {
    private object thisLock = new object();
    private bool isZombied;
    private bool isDisposed;
    private bool isFinalized;
    internal SqlCeConnection connection;
    private IsolationLevel isolationLevel;
    private IntPtr pQpSession;
    private IntPtr pTx;
    private IntPtr pError;
    private long ullTransactionBsn;

    static SqlCeTransaction() => KillBitHelper.ThrowIfKillBitIsSet();

    protected override DbConnection DbConnection => (DbConnection) this.connection;

    internal SeTransactionFlags EngineFlags
    {
      [SecuritySafeCritical] get
      {
        this.EnterPublicAPI();
        SeTransactionFlags seTxFlags = SeTransactionFlags.NOFLAGS;
        this.ProcessResults(NativeMethods.GetTransactionFlags(this.ITransact, ref seTxFlags));
        return seTxFlags;
      }
      [SecuritySafeCritical] set
      {
        this.EnterPublicAPI();
        SeTransactionFlags seTxFlags = SeTransactionFlags.NOFLAGS;
        this.ProcessResults(NativeMethods.GetTransactionFlags(this.ITransact, ref seTxFlags));
        this.ProcessResults(NativeMethods.SetTransactionFlag(this.ITransact, seTxFlags, false, this.pError));
        this.ProcessResults(NativeMethods.SetTransactionFlag(this.ITransact, value, true, this.pError));
      }
    }

    private SqlCeConnection Connection => this.connection;

    public override IsolationLevel IsolationLevel
    {
      get
      {
        if (IntPtr.Zero == this.Connection.ITransact)
          throw new InvalidOperationException(Res.GetString("ADP_TransactionZombied", (object) this.GetType().Name));
        return this.isolationLevel;
      }
    }

    public long CurrentTransactionBsn => this.ullTransactionBsn;

    internal bool IsZombied => this.isZombied;

    [SecurityCritical]
    internal SqlCeTransaction(
      SqlCeConnection connection,
      IsolationLevel isolationLevel,
      IntPtr pTx,
      IntPtr pQpSession)
    {
      Debug.Assert(IntPtr.Zero != pTx);
      Debug.Assert(IntPtr.Zero != pQpSession);
      this.pTx = pTx;
      this.pQpSession = pQpSession;
      this.isZombied = false;
      this.isDisposed = false;
      this.isFinalized = false;
      this.isolationLevel = isolationLevel;
      this.connection = connection;
      this.ullTransactionBsn = 0L;
      int errorInstance = NativeMethods.CreateErrorInstance(ref this.pError);
      if (errorInstance != 0)
        this.ProcessResults(errorInstance);
      int transactionBsn = NativeMethods.GetTransactionBsn(pTx, ref this.ullTransactionBsn, this.pError);
      if (transactionBsn == 0)
        return;
      this.ProcessResults(transactionBsn);
    }

    ~SqlCeTransaction() => this.Dispose(false);

    [SecurityCritical]
    private void ReleaseNativeInterfaces()
    {
      if (IntPtr.Zero != this.pQpSession)
        NativeMethods.SafeRelease(ref this.pQpSession);
      if (IntPtr.Zero != this.pTx)
        NativeMethods.SafeRelease(ref this.pTx);
      if (!(IntPtr.Zero != this.pError))
        return;
      NativeMethods.SafeDelete(ref this.pError);
    }

    private void EnterPublicAPI()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeTransaction));
      if (this.Connection == null || IntPtr.Zero == this.Connection.ITransact)
        this.isZombied = true;
      if (this.isZombied)
        throw new InvalidOperationException(Res.GetString("ADP_TransactionZombied", (object) this.GetType().Name));
    }

    public new void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SecuritySafeCritical]
    protected override void Dispose(bool disposing)
    {
      lock (this.thisLock)
      {
        if (this.isFinalized)
          return;
        if (disposing)
        {
          if (IntPtr.Zero != this.pTx)
            this.Rollback();
          if (this.connection != null)
            this.connection.RemoveWeakReference((object) this);
          this.isDisposed = true;
        }
        this.ReleaseNativeInterfaces();
        if (disposing)
          return;
        this.isFinalized = true;
      }
    }

    internal IntPtr ITransact => this.pTx;

    internal IntPtr IQPSession => this.pQpSession;

    public override void Commit() => this.Commit(CommitMode.Deferred);

    [SecuritySafeCritical]
    public void Commit(CommitMode mode)
    {
      this.EnterPublicAPI();
      if (this.connection.HasOpenedCursors(this))
        throw new InvalidOperationException(Res.GetString("SQLCE_OpenedCursorsOnTxCommit"));
      try
      {
        int hr = NativeMethods.CommitTransaction(this.pTx, mode, this.pError);
        this.isZombied = true;
        if (hr != 0)
          this.ProcessResults(hr);
        if (this.connection == null)
          return;
        this.connection.Zombie(this);
        this.connection.RemoveWeakReference((object) this);
      }
      finally
      {
        this.Dispose(false);
        GC.SuppressFinalize((object) this);
      }
    }

    [SecuritySafeCritical]
    public override void Rollback()
    {
      this.EnterPublicAPI();
      if (this.connection.HasOpenedCursors(this))
        throw new InvalidOperationException(Res.GetString("SQLCE_OpenedCursorsOnTxAbort"));
      try
      {
        int hr = NativeMethods.AbortTransaction(this.pTx, this.pError);
        if (hr != 0)
          this.ProcessResults(hr);
        this.isZombied = true;
        this.connection.Zombie(this);
        this.connection.RemoveWeakReference((object) this);
      }
      finally
      {
        this.Dispose(false);
        GC.SuppressFinalize((object) this);
      }
    }

    private void ProcessResults(int hr)
    {
      Exception exception = (Exception) this.connection.ProcessResults(hr, this.pError, (object) this);
      if (exception != null)
        throw exception;
    }
  }
}
