// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeConnection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeConnection : DbConnection
  {
    private const uint RMV_DATABASESHAREDMEMORYBYTESSUGGESTION = 2;
    private static Hashtable connStrCache;
    private static uint memoryCap = 0;
    private static readonly object memoryCachelock = new object();
    private static Dictionary<string, SqlCeConnection.MemoryInfo> connMemoryUsageCache;
    private SqlCeConnectionStringBuilder connTokens;
    private bool isOpened;
    private bool isHostControlled;
    private bool removePwd;
    private IntPtr pStoreService;
    private IntPtr pStoreServer;
    private IntPtr pSeStore;
    private IntPtr pQpServices;
    private IntPtr pQpDatabase;
    private IntPtr pQpSession;
    private IntPtr pTx;
    private IntPtr pStoreEvents;
    private IntPtr pError;
    private string connStr;
    private string dataSource;
    private string modifiedConnStr;
    private ConnectionState state;
    private bool isDisposed;
    private SqlCeConnection.ObjectLifeTimeTracker weakReferenceCache;
    private bool isClosing;
    private FlushFailureEventHandler flushFailureEventHandler;
    private EventHandlerList eventHandlerList;
    private const int CbPageSize = 4096;
    private const int CbPageFrame = 4096;
    private const int CbPageInfo = 4;
    private const int SystemPageCount = 1026;
    private const int SharedMemoryOverhead = 241676;
    private const int TempDbBufferPoolSize = 262144;

    static SqlCeConnection() => KillBitHelper.ThrowIfKillBitIsSet();

    private new EventHandlerList Events
    {
      get => this.eventHandlerList != null ? this.eventHandlerList : throw new ObjectDisposedException(nameof (SqlCeConnection));
      set => this.eventHandlerList = value;
    }

    [AllowReversePInvokeCalls]
    internal void OnFlushFailure(int hr, IntPtr pError)
    {
      SqlCeFlushFailureEventHandler failureEventHandler = (SqlCeFlushFailureEventHandler) this.Events[ADP.EventFlushFailure];
      if (failureEventHandler == null)
        return;
      try
      {
        failureEventHandler((object) this, new SqlCeFlushFailureEventArgs(hr, pError, (object) this));
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableExceptionType(ex))
          return;
        throw;
      }
    }

    public override string ConnectionString
    {
      get
      {
        if (this.connStr == null || this.connStr.Trim().Length == 0)
          return this.connStr = string.Empty;
        if (this.removePwd)
        {
          if (this.connTokens == null)
            return string.Empty;
          if (!(bool) this.connTokens["Persist Security Info"])
            this.connStr = ConStringUtil.RemoveKeyValuesFromString(this.connStr, "Password");
          this.removePwd = false;
        }
        return this.connStr;
      }
      set
      {
        if (this.state != ConnectionState.Closed)
          throw new InvalidOperationException(Res.GetString("ADP_OpenConnectionPropertySet", (object) nameof (ConnectionString), (object) this.state));
        Hashtable connStrCache = SqlCeConnection.connStrCache;
        if (connStrCache != null && value != null && connStrCache.Contains((object) value))
        {
          object[] objArray = (object[]) connStrCache[(object) value];
          this.modifiedConnStr = (string) objArray[0];
          if (this.state != ConnectionState.Closed)
            throw new InvalidOperationException(Res.GetString("ADP_OpenConnectionPropertySet", (object) nameof (ConnectionString), (object) this.state));
          this.connTokens = (SqlCeConnectionStringBuilder) objArray[1];
        }
        else if (value != null && value.Length > 0)
        {
          this.connTokens = new SqlCeConnectionStringBuilder(value);
          this.modifiedConnStr = value;
          if (this.connTokens != null)
            SqlCeConnection.CachedConnectionStringAdd(value, this.modifiedConnStr, this.connTokens);
          else
            this.modifiedConnStr = (string) null;
        }
        else
        {
          this.modifiedConnStr = (string) null;
          this.connTokens = (SqlCeConnectionStringBuilder) null;
        }
        this.connStr = value;
        this.removePwd = false;
        if (this.connTokens == null)
          return;
        this.dataSource = (string) this.connTokens["Data Source"];
      }
    }

    public override int ConnectionTimeout => 0;

    public override string Database => this.dataSource;

    public override string DataSource => this.dataSource;

    public override ConnectionState State => this.state;

    public override string ServerVersion => "3.5.5722.1";

    public event SqlCeInfoMessageEventHandler InfoMessage
    {
      add => this.Events.AddHandler(ADP.EventInfoMessage, (Delegate) value);
      remove => this.Events.RemoveHandler(ADP.EventInfoMessage, (Delegate) value);
    }

    public event SqlCeFlushFailureEventHandler FlushFailure
    {
      add => this.Events.AddHandler(ADP.EventFlushFailure, (Delegate) value);
      remove => this.Events.RemoveHandler(ADP.EventFlushFailure, (Delegate) value);
    }

    public override event StateChangeEventHandler StateChange
    {
      add => this.Events.AddHandler(ADP.EventStateChange, (Delegate) value);
      remove => this.Events.RemoveHandler(ADP.EventStateChange, (Delegate) value);
    }

    internal IntPtr ITransact => this.pTx;

    internal IntPtr IQPSession => this.pQpSession;

    internal IntPtr IQPServices => this.pQpServices;

    internal bool IsEnlisted => (bool) this.connTokens["Enlist"];

    [SecuritySafeCritical]
    public SqlCeConnection()
    {
      NativeMethods.LoadNativeBinaries();
      this.dataSource = string.Empty;
      this.isHostControlled = false;
      this.Events = new EventHandlerList();
      this.weakReferenceCache = new SqlCeConnection.ObjectLifeTimeTracker(true);
      NativeMethods.DllAddRef();
    }

    public SqlCeConnection(string connectionString)
      : this()
    {
      this.ConnectionString = connectionString;
    }

    ~SqlCeConnection() => this.Dispose(false);

    [SecurityCritical]
    private void ReleaseNativeInterfaces()
    {
      if (IntPtr.Zero != this.pQpSession)
        NativeMethods.SafeRelease(ref this.pQpSession);
      if (IntPtr.Zero != this.pQpDatabase)
        NativeMethods.SafeRelease(ref this.pQpDatabase);
      if (IntPtr.Zero != this.pTx)
        NativeMethods.SafeRelease(ref this.pTx);
      if (IntPtr.Zero != this.pStoreService)
        NativeMethods.SafeRelease(ref this.pStoreService);
      if (IntPtr.Zero != this.pQpServices)
        NativeMethods.SafeRelease(ref this.pQpServices);
      if (IntPtr.Zero != this.pStoreServer)
        NativeMethods.SafeRelease(ref this.pStoreServer);
      if (IntPtr.Zero != this.pStoreEvents)
        NativeMethods.SafeRelease(ref this.pStoreEvents);
      if (IntPtr.Zero != this.pError)
        NativeMethods.SafeDelete(ref this.pError);
      if (!(IntPtr.Zero != this.pSeStore))
        return;
      NativeMethods.CloseAndReleaseStore(ref this.pSeStore);
      SqlCeConnection.RemoveCachedMemoryUsage(this.dataSource);
    }

    internal void DisposeSqlCeDataRdr(SqlCeTransaction tx)
    {
      if (this.weakReferenceCache == null)
        return;
      this.weakReferenceCache.CloseDataRdr(tx);
    }

    public new void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SecuritySafeCritical]
    protected override void Dispose(bool disposing)
    {
      if (this.isDisposed)
        return;
      if (disposing)
      {
        if (this.isOpened)
        {
          try
          {
            this.OnStateChange(ConnectionState.Open, ConnectionState.Closed);
          }
          catch (Exception ex)
          {
            if (!ADP.IsCatchableExceptionType(ex))
              throw;
          }
        }
        if (this.weakReferenceCache != null)
        {
          this.weakReferenceCache.Close(true);
          this.weakReferenceCache = (SqlCeConnection.ObjectLifeTimeTracker) null;
        }
        if (this.eventHandlerList != null)
        {
          this.eventHandlerList.Dispose();
          this.eventHandlerList = (EventHandlerList) null;
        }
        this.connStr = (string) null;
        this.modifiedConnStr = (string) null;
        NativeMethods.DllRelease();
        this.isOpened = false;
        this.isDisposed = true;
        this.state = ConnectionState.Closed;
      }
      if (!this.isHostControlled)
      {
        this.ReleaseNativeInterfaces();
        if (IntPtr.Zero == this.pSeStore)
          this.dataSource = (string) null;
      }
      base.Dispose(disposing);
    }

    public override void Close()
    {
      this.Close(false);
      GC.KeepAlive((object) this);
    }

    internal void Zombie(SqlCeTransaction tx)
    {
      if (this.weakReferenceCache == null)
        return;
      this.weakReferenceCache.Zombie(tx);
    }

    [SecuritySafeCritical]
    private void Close(bool silent)
    {
      if (!this.isOpened || this.isClosing)
        return;
      this.isClosing = true;
      try
      {
        if (!silent)
          this.OnStateChange(ConnectionState.Open, ConnectionState.Closed);
        if (this.weakReferenceCache != null)
          this.weakReferenceCache.Close(false);
        this.ReleaseNativeInterfaces();
        this.isOpened = false;
        this.state = ConnectionState.Closed;
      }
      finally
      {
        this.isClosing = false;
      }
    }

    [SecuritySafeCritical]
    public List<KeyValuePair<string, string>> GetDatabaseInfo()
    {
      List<KeyValuePair<string, string>> keyValuePairList = new List<KeyValuePair<string, string>>();
      int locale1 = 0;
      this.CheckStateOpen(nameof (GetDatabaseInfo));
      int locale2 = NativeMethods.GetLocale(this.pSeStore, ref locale1, this.pError);
      if (locale2 != 0)
        this.ProcessResults(locale2);
      keyValuePairList.Add(new KeyValuePair<string, string>("Locale Identifier", locale1.ToString()));
      int encryptionMode1 = 0;
      int encryptionMode2 = NativeMethods.GetEncryptionMode(this.pSeStore, ref encryptionMode1, this.pError);
      if (encryptionMode2 != 0)
        this.ProcessResults(encryptionMode2);
      string str1 = (string) null;
      switch (encryptionMode1)
      {
        case 0:
          str1 = string.Empty;
          break;
        case 1:
          str1 = "Platform Default";
          break;
        case 2:
          str1 = "Engine Default";
          break;
      }
      keyValuePairList.Add(new KeyValuePair<string, string>("Encryption Mode", str1));
      int sortFlags = 0;
      int localeFlags = NativeMethods.GetLocaleFlags(this.pSeStore, ref sortFlags, this.pError);
      if (localeFlags != 0)
        this.ProcessResults(localeFlags);
      string str2 = 1 != (sortFlags & 1) ? bool.TrueString : bool.FalseString;
      keyValuePairList.Add(new KeyValuePair<string, string>("Case Sensitive", str2));
      return keyValuePairList;
    }

    [SecuritySafeCritical]
    public SqlCeTransaction BeginTransaction(IsolationLevel isolationLevel)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeConnection));
      this.CheckStateOpen(nameof (BeginTransaction));
      SEISOLATION isoLevel;
      switch (isolationLevel)
      {
        case IsolationLevel.Unspecified:
        case IsolationLevel.ReadCommitted:
          isoLevel = SEISOLATION.ISO_READ_COMMITTED;
          break;
        case IsolationLevel.RepeatableRead:
          isoLevel = SEISOLATION.ISO_REPEATABLE_READ;
          break;
        case IsolationLevel.Serializable:
          isoLevel = SEISOLATION.ISO_SERIALIZABLE;
          break;
        default:
          throw new ArgumentException(Res.GetString("ADP_InvalidIsolationLevel", (object) isolationLevel.ToString()));
      }
      IntPtr zero1 = IntPtr.Zero;
      IntPtr zero2 = IntPtr.Zero;
      SqlCeTransaction sqlCeTransaction;
      try
      {
        int hr = NativeMethods.OpenTransaction(this.pSeStore, this.pQpDatabase, isoLevel, this.IQPSession, ref zero1, ref zero2, this.pError);
        if (hr != 0)
          this.ProcessResults(hr);
        sqlCeTransaction = new SqlCeTransaction(this, isolationLevel, zero1, zero2);
        this.AddWeakReference((object) sqlCeTransaction);
      }
      catch (Exception ex)
      {
        if (IntPtr.Zero != zero2)
          NativeMethods.SafeRelease(ref zero2);
        if (IntPtr.Zero != zero1)
          NativeMethods.SafeRelease(ref zero1);
        throw;
      }
      return sqlCeTransaction;
    }

    protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel) => (DbTransaction) this.BeginTransaction(isolationLevel);

    public SqlCeTransaction BeginTransaction() => this.BeginTransaction(IsolationLevel.ReadCommitted);

    public override void ChangeDatabase(string value)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeConnection));
      this.CheckStateOpen(nameof (ChangeDatabase));
      if (value == null || value.Trim().Length == 0)
        throw new ArgumentException(Res.GetString("ADP_EmptyDatabaseName"));
      string dataSource = this.dataSource;
      try
      {
        this.Close(true);
        this.dataSource = value;
        this.Open(true);
      }
      catch (Exception ex)
      {
        this.dataSource = dataSource;
        throw;
      }
    }

    internal void CheckStateOpen(string method)
    {
      if (ConnectionState.Open != this.State)
      {
        string name = (string) null;
        if (!(method == "BeginTransaction"))
        {
          if (!(method == "ChangeDatabase"))
          {
            if (!(method == "CommitTransaction"))
            {
              if (!(method == "RollbackTransaction"))
              {
                if (!(method == "set_Connection"))
                {
                  if (method == "GetDatabaseInfo")
                    name = "ADP_OpenConnectionRequired_GetDatabaseInfo";
                }
                else
                  name = "ADP_OpenConnectionRequired_SetConnection";
              }
              else
                name = "ADP_OpenConnectionRequired_RollbackTransaction";
            }
            else
              name = "ADP_OpenConnectionRequired_CommitTransaction";
          }
          else
            name = "ADP_OpenConnectionRequired_ChangeDatabase";
        }
        else
          name = "ADP_OpenConnectionRequired_BeginTransaction";
        throw new InvalidOperationException(Res.GetString(name, (object) method, (object) this.State));
      }
    }

    internal void AddWeakReference(object value)
    {
      int num;
      switch (value)
      {
        case SqlCeCommand _:
        case SqlCeDataReader _:
          num = 1;
          break;
        default:
          num = value is SqlCeTransaction ? 1 : 0;
          break;
      }
      Debug.Assert(num != 0, "Attempt to add invalid type into ObjectLifeTimeTracker");
      if (this.isDisposed || this.weakReferenceCache == null)
        throw new ObjectDisposedException(nameof (SqlCeConnection));
      this.weakReferenceCache.Add(value);
    }

    internal void RemoveWeakReference(object value)
    {
      if (this.weakReferenceCache == null)
        throw new ObjectDisposedException(nameof (SqlCeConnection));
      this.weakReferenceCache.Remove(value);
    }

    public override DataTable GetSchema() => throw new NotSupportedException();

    public override DataTable GetSchema(string collectionName) => throw new NotSupportedException();

    public override DataTable GetSchema(string collectionName, string[] restrictionValues) => throw new NotSupportedException();

    internal bool HasOpenedCursors(SqlCeTransaction tx) => this.weakReferenceCache != null && this.weakReferenceCache.HasOpenedCursors(tx);

    protected override DbCommand CreateDbCommand() => (DbCommand) this.CreateCommand();

    public SqlCeCommand CreateCommand()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeConnection));
      return new SqlCeCommand("", this);
    }

    private void OnStateChange(ConnectionState original, ConnectionState state)
    {
      StateChangeEventHandler changeEventHandler = (StateChangeEventHandler) this.Events[ADP.EventStateChange];
      if (changeEventHandler == null)
        return;
      try
      {
        changeEventHandler((object) this, new StateChangeEventArgs(original, state));
      }
      catch (Exception ex)
      {
        if (ADP.IsCatchableExceptionType(ex))
          return;
        throw;
      }
    }

    [SecuritySafeCritical]
    public override void Open() => this.Open(false);

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    internal void Open(bool silent)
    {
      int num1 = -1;
      int num2 = -1;
      int num3 = -1;
      int num4 = -1;
      int num5 = -1;
      int num6 = -1;
      int num7 = -1;
      int num8 = -1;
      string source1 = (string) null;
      string source2 = (string) null;
      string str1 = (string) null;
      SEOPENFLAGS seopenflags = SEOPENFLAGS.MODE_READ | SEOPENFLAGS.MODE_WRITE;
      bool flag = false;
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeConnection));
      if (this.ConnectionString == null || this.ConnectionString.Length == 0)
        throw new InvalidOperationException(Res.GetString("ADP_NoConnectionString"));
      if (this.dataSource == null || this.dataSource.Trim().Length == 0)
        throw new ArgumentException(Res.GetString("ADP_EmptyDatabaseName"));
      if (this.isOpened)
        throw new InvalidOperationException(Res.GetString("ADP_ConnectionAlreadyOpen", (object) ConnectionState.Open.ToString()));
      MEOPENINFO openInfo = new MEOPENINFO();
      IntPtr num9 = NativeMethods.CoTaskMemAlloc(sizeof (MEOPENINFO));
      if (IntPtr.Zero == num9)
        throw new OutOfMemoryException();
      try
      {
        if (ADP.IsEmpty(this.modifiedConnStr))
          throw new InvalidOperationException(Res.GetString("ADP_NoConnectionString"));
        string source3 = ConStringUtil.ReplaceDataDirectory(this.dataSource);
        object connToken1 = this.connTokens["Locale Identifier"];
        if (connToken1 != null)
          num1 = (int) connToken1;
        object connToken2 = this.connTokens["Max Buffer Size"];
        if (connToken2 != null)
          num2 = (int) connToken2 * 1024;
        object connToken3 = this.connTokens["Autoshrink Threshold"];
        if (connToken3 != null)
          num3 = (int) connToken3;
        object connToken4 = this.connTokens["Max Database Size"];
        if (connToken4 != null)
          num4 = (int) connToken4 * 256;
        object connToken5 = this.connTokens["Temp File Max Size"];
        if (connToken5 != null)
          num5 = (int) connToken5 * 256;
        object connToken6 = this.connTokens["Flush Interval"];
        if (connToken6 != null)
          num8 = (int) connToken6;
        object connToken7 = this.connTokens["Default Lock Escalation"];
        if (connToken7 != null)
          num6 = (int) connToken7;
        object connToken8 = this.connTokens["Default Lock Timeout"];
        if (connToken8 != null)
          num7 = (int) connToken8;
        object connToken9 = this.connTokens["Temp File Directory"];
        if (connToken9 != null)
          source2 = (string) connToken9;
        object connToken10 = this.connTokens["Encryption Mode"];
        if (connToken10 != null)
          str1 = (string) connToken10;
        object connToken11 = this.connTokens["Password"];
        if (connToken11 != null)
        {
          string str2 = (string) connToken11;
          if (str2.Length > 0)
            source1 = str2;
        }
        object connToken12 = this.connTokens["Case Sensitive"];
        if (connToken12 != null)
          flag = (bool) connToken12;
        string str3 = (string) null;
        object connToken13 = this.connTokens["Mode"];
        if (connToken13 != null)
          str3 = (string) connToken13;
        if (str3 != null)
        {
          if (!(str3 == "Read Only"))
          {
            if (!(str3 == "Read Write"))
            {
              if (!(str3 == "Exclusive"))
              {
                if (str3 == "Shared Read")
                  seopenflags = SEOPENFLAGS.MODE_READ | SEOPENFLAGS.MODE_WRITE | SEOPENFLAGS.MODE_SHARE_DENY_WRITE;
                else
                  Debug.Assert(false, "Invalid File Open Mode");
              }
              else
                seopenflags = SEOPENFLAGS.MODE_READ | SEOPENFLAGS.MODE_WRITE | SEOPENFLAGS.MODE_SHARE_DENY_READ | SEOPENFLAGS.MODE_SHARE_DENY_WRITE;
            }
            else
              seopenflags = SEOPENFLAGS.MODE_READ | SEOPENFLAGS.MODE_WRITE;
          }
          else
            seopenflags = SEOPENFLAGS.MODE_READ;
        }
        openInfo.pwszFileName = NativeMethods.MarshalStringToLPWSTR(source3);
        openInfo.pwszPassword = NativeMethods.MarshalStringToLPWSTR(source1);
        openInfo.pwszTempPath = NativeMethods.MarshalStringToLPWSTR(source2);
        openInfo.lcidLocale = num1;
        openInfo.cbBufferPool = num2;
        openInfo.dwAutoShrinkPercent = num3;
        openInfo.dwFlushInterval = num8;
        openInfo.cMaxPages = num4;
        openInfo.cMaxTmpPages = num5;
        openInfo.dwDefaultTimeout = num7;
        openInfo.dwDefaultEscalation = num6;
        openInfo.dwFlags = seopenflags;
        openInfo.dwEncryptionMode = ConStringUtil.MapEncryptionMode(str1);
        openInfo.dwLocaleFlags = 0;
        if (flag)
          openInfo.dwLocaleFlags &= 1;
        this.flushFailureEventHandler = new FlushFailureEventHandler(this.OnFlushFailure);
        if (!SqlCeConnection.ValidateAndAddMemoryUsage(this.DataSource, openInfo))
          throw new InvalidOperationException(Res.GetString(CultureInfo.CurrentCulture, "ADP_ExceedsSharedMemoryCap"));
        Marshal.StructureToPtr((object) openInfo, num9, false);
        int hr = NativeMethods.OpenStore(num9, Marshal.GetFunctionPointerForDelegate((Delegate) this.flushFailureEventHandler), ref this.pStoreService, ref this.pStoreServer, ref this.pQpServices, ref this.pSeStore, ref this.pTx, ref this.pQpDatabase, ref this.pQpSession, ref this.pStoreEvents, ref this.pError);
        if (hr != 0)
        {
          Exception exception = (Exception) this.ProcessResults(hr, this.pError, (object) this);
          if (exception != null)
          {
            SqlCeConnection.RemoveCachedMemoryUsage(this.dataSource);
            throw exception;
          }
        }
        Debug.Assert(IntPtr.Zero != this.pStoreService);
        Debug.Assert(IntPtr.Zero != this.pStoreServer);
        Debug.Assert(IntPtr.Zero != this.pQpServices);
        Debug.Assert(IntPtr.Zero != this.pSeStore);
        Debug.Assert(IntPtr.Zero != this.pTx);
        Debug.Assert(IntPtr.Zero != this.pQpDatabase);
        Debug.Assert(IntPtr.Zero != this.pQpSession);
        Debug.Assert(IntPtr.Zero != this.pStoreEvents);
        Debug.Assert(IntPtr.Zero != this.pError);
        this.removePwd = true;
        this.state = ConnectionState.Open;
        this.isOpened = true;
      }
      finally
      {
        NativeMethods.CoTaskMemFree(openInfo.pwszFileName);
        NativeMethods.CoTaskMemFree(openInfo.pwszPassword);
        NativeMethods.CoTaskMemFree(openInfo.pwszTempPath);
        NativeMethods.CoTaskMemFree(num9);
        if (ConnectionState.Open != this.state)
        {
          this.Close();
          this.removePwd = false;
          this.state = ConnectionState.Closed;
        }
      }
      if (silent)
        return;
      this.OnStateChange(ConnectionState.Closed, ConnectionState.Open);
    }

    private static void CachedConnectionStringAdd(
      string connStr,
      string modifiedConnStr,
      SqlCeConnectionStringBuilder connTokens)
    {
      Debug.Assert(!ADP.IsEmpty(connStr), "null connection string");
      Debug.Assert(connTokens != null, "null httable");
      Hashtable hashtable = SqlCeConnection.connStrCache;
      lock (typeof (SqlCeConnection))
      {
        if (hashtable == null)
        {
          hashtable = new Hashtable();
          hashtable[(object) connStr] = (object) new object[2]
          {
            (object) modifiedConnStr,
            (object) connTokens
          };
          SqlCeConnection.connStrCache = hashtable;
          return;
        }
      }
      lock (hashtable.SyncRoot)
      {
        if (hashtable.Contains((object) connStr))
          return;
        if (hashtable.Count < 250)
          hashtable[(object) connStr] = (object) new object[2]
          {
            (object) modifiedConnStr,
            (object) connTokens
          };
        else
          SqlCeConnection.connStrCache = (Hashtable) null;
      }
    }

    private static int CalculateSharedMemoryUsage(MEOPENINFO openInfo)
    {
      int num1 = 241676;
      int num2 = openInfo.cbBufferPool / 4096;
      if (openInfo.cbBufferPool % 4096 > 0)
        ++num2;
      int num3 = num1 + num2 * 4096 + openInfo.cMaxPages * 4;
      if (openInfo.pwszTempPath != IntPtr.Zero)
        num3 = num3 + 241676 + 262144 + openInfo.cMaxTmpPages * 4;
      return num3;
    }

    [SecuritySafeCritical]
    private static bool ValidateAndAddMemoryUsage(string dataSource, MEOPENINFO openInfo)
    {
      ulong cbValue = 0;
      bool flag = false;
      string key = ConStringUtil.ReplaceDataDirectory(dataSource);
      lock (SqlCeConnection.memoryCachelock)
      {
        if (SqlCeConnection.connMemoryUsageCache == null)
        {
          SqlCeConnection.connMemoryUsageCache = new Dictionary<string, SqlCeConnection.MemoryInfo>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
          if (NativeMethods.SHGetResourceManagementValue(2U, ref cbValue) != 0)
          {
            Debug.WriteLine("----------------SqlCeConnection Shared Memory Usage------------------");
            foreach (KeyValuePair<string, SqlCeConnection.MemoryInfo> keyValuePair in SqlCeConnection.connMemoryUsageCache)
              Debug.WriteLine(string.Format("Database: {0};   Size: {1} bytes;    No of Connection Open: {2}", (object) keyValuePair.Key, (object) keyValuePair.Value.Size, (object) keyValuePair.Value.ConnectionCount));
            throw new InvalidOperationException(Res.GetString(CultureInfo.CurrentCulture, "ADP_CannotGetMemoryCap"));
          }
          SqlCeConnection.memoryCap = cbValue <= (ulong) uint.MaxValue ? (uint) cbValue : throw new OverflowException("MemoryCap exceeded max allowed value.");
        }
        int sharedMemoryUsage = SqlCeConnection.CalculateSharedMemoryUsage(openInfo);
        int num = 0;
        foreach (SqlCeConnection.MemoryInfo memoryInfo in SqlCeConnection.connMemoryUsageCache.Values)
          num += memoryInfo.Size;
        SqlCeConnection.MemoryInfo memoryInfo1;
        if (SqlCeConnection.connMemoryUsageCache.TryGetValue(key, out memoryInfo1))
        {
          if (memoryInfo1.Size < sharedMemoryUsage)
            num = num - memoryInfo1.Size + sharedMemoryUsage;
          if ((long) num <= (long) SqlCeConnection.memoryCap)
          {
            ++memoryInfo1.ConnectionCount;
            if (memoryInfo1.Size < sharedMemoryUsage)
              memoryInfo1.Size = sharedMemoryUsage;
            flag = true;
          }
        }
        else if ((long) (num + sharedMemoryUsage) <= (long) SqlCeConnection.memoryCap)
        {
          SqlCeConnection.connMemoryUsageCache.Add(key, new SqlCeConnection.MemoryInfo()
          {
            Size = sharedMemoryUsage,
            ConnectionCount = 1
          });
          flag = true;
        }
      }
      return flag;
    }

    private static void RemoveCachedMemoryUsage(string dataSource)
    {
      string key = ConStringUtil.ReplaceDataDirectory(dataSource);
      lock (SqlCeConnection.memoryCachelock)
      {
        SqlCeConnection.MemoryInfo memoryInfo;
        if (SqlCeConnection.connMemoryUsageCache.TryGetValue(key, out memoryInfo))
        {
          --memoryInfo.ConnectionCount;
          if (memoryInfo.ConnectionCount != 0)
            return;
          SqlCeConnection.connMemoryUsageCache.Remove(key);
        }
        else
          Debug.Assert(false, "When close an connection, there should always be an entry for this db in the shared memory cache.");
      }
    }

    private void ProcessResults(int hr)
    {
      Exception exception = (Exception) this.ProcessResults(hr, this.pError, (object) this);
      if (exception != null)
        throw exception;
    }

    [SecuritySafeCritical]
    internal SqlCeException ProcessResults(int hr, IntPtr pError, object src)
    {
      if (hr == 0)
        return (SqlCeException) null;
      if (NativeMethods.Failed(hr))
      {
        SqlCeException sqlCeException = SqlCeException.FillErrorInformation(hr, pError);
        Debug.Assert((uint) sqlCeException.Errors[0].HResult > 0U, "IError is missing HRESULT");
        return sqlCeException;
      }
      if ((object) this.Events[ADP.EventInfoMessage] != null)
      {
        SqlCeInfoMessageEventHandler messageEventHandler = (SqlCeInfoMessageEventHandler) this.Events[ADP.EventInfoMessage];
        if (messageEventHandler != null)
        {
          try
          {
            messageEventHandler((object) this, new SqlCeInfoMessageEventArgs(hr, pError, src));
          }
          catch (Exception ex)
          {
            if (!ADP.IsCatchableExceptionType(ex))
              throw;
          }
        }
      }
      else
      {
        SqlCeException sqlCeException = SqlCeException.FillErrorInformation(hr, pError);
        Debug.Assert(sqlCeException.Errors[0].HResult != 0 || (uint) sqlCeException.Errors[0].NativeError > 0U, "IError is missing return status and/or minor code");
        NativeMethods.ClearErrorInfo(pError);
      }
      return (SqlCeException) null;
    }

    private class MemoryInfo
    {
      public int Size { get; set; }

      public int ConnectionCount { get; set; }
    }

    private class ObjectLifeTimeTracker : WeakReferenceCache
    {
      static ObjectLifeTimeTracker() => KillBitHelper.ThrowIfKillBitIsSet();

      internal ObjectLifeTimeTracker(bool trackResurrection)
        : base(trackResurrection)
      {
      }

      internal bool HasOpenedCursors(SqlCeTransaction tx)
      {
        lock (this)
        {
          int length = this.items.Length;
          for (int index = 0; index < length; ++index)
          {
            WeakReference weakReference = this.items[index];
            if (ADP.IsAlive(weakReference))
            {
              object target = weakReference.Target;
              if (target != null && target is SqlCeDataReader)
              {
                SqlCeDataReader sqlCeDataReader = (SqlCeDataReader) target;
                if (tx == sqlCeDataReader.transaction && !sqlCeDataReader.IsClosed)
                  return true;
              }
            }
          }
          return false;
        }
      }

      internal void CloseDataRdr(SqlCeTransaction tx)
      {
        ArrayList arrayList = new ArrayList();
        int length = this.items.Length;
        for (int index = 0; index < length; ++index)
        {
          WeakReference weakReference = this.items[index];
          if (ADP.IsAlive(weakReference))
          {
            object target = weakReference.Target;
            if (target != null && target is SqlCeDataReader)
            {
              SqlCeDataReader sqlCeDataReader = (SqlCeDataReader) target;
              if ((tx == null || tx == sqlCeDataReader.transaction) && !sqlCeDataReader.IsClosed)
              {
                arrayList.Add(target);
                this.items[index] = (WeakReference) null;
              }
            }
          }
        }
        foreach (SqlCeDataReader sqlCeDataReader in arrayList)
          sqlCeDataReader.Dispose();
      }

      internal void Close(bool isDisposing)
      {
        ArrayList arrayList1 = new ArrayList();
        ArrayList arrayList2 = new ArrayList();
        ArrayList arrayList3 = new ArrayList();
        ArrayList arrayList4 = new ArrayList();
        int length = this.items.Length;
        for (int index = 0; index < length; ++index)
        {
          WeakReference weakReference = this.items[index];
          if (ADP.IsAlive(weakReference))
          {
            object target = weakReference.Target;
            switch (target)
            {
              case null:
                continue;
              case SqlCeDataReader _:
                arrayList3.Add(target);
                this.items[index] = (WeakReference) null;
                continue;
              case SqlCeCommand _:
                arrayList2.Add(target);
                continue;
              case SqlCeTransaction _:
                arrayList1.Add(target);
                this.items[index] = (WeakReference) null;
                continue;
              default:
                Debug.Assert(false, "Invalid object type");
                continue;
            }
          }
        }
        foreach (SqlCeDataReader sqlCeDataReader in arrayList3)
          sqlCeDataReader.Dispose();
        foreach (SqlCeCommand sqlCeCommand in arrayList2)
        {
          sqlCeCommand.CloseFromConnection();
          if (isDisposing)
            sqlCeCommand.Connection = (SqlCeConnection) null;
        }
        foreach (SqlCeTransaction sqlCeTransaction in arrayList1)
          sqlCeTransaction.Dispose();
      }

      internal void Zombie(SqlCeTransaction tx)
      {
        lock (this)
        {
          int length = this.items.Length;
          for (int index = 0; index < length; ++index)
          {
            WeakReference weakReference = this.items[index];
            if (ADP.IsAlive(weakReference))
            {
              object target = weakReference.Target;
              if (target != null && target is SqlCeCommand)
              {
                if (tx == ((SqlCeCommand) target).Transaction)
                  ((SqlCeCommand) target).Transaction = (SqlCeTransaction) null;
                else if (tx == ((SqlCeCommand) target).InternalTransaction)
                  ((SqlCeCommand) target).InternalTransaction = (SqlCeTransaction) null;
              }
            }
          }
        }
      }
    }
  }
}
