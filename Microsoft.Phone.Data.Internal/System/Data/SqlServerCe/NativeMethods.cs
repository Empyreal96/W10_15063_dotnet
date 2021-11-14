// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.NativeMethods
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Data.SqlServerCe
{
  internal static class NativeMethods
  {
    private static bool m_fTryLoadingNativeLibraries = true;
    private const int VersionMismatchKB = 974247;

    internal static bool Failed(int hr) => hr < 0;

    public static void CheckHRESULT(IntPtr pISSCEErrors, int hr)
    {
      if ((2147483648L & (long) hr) == 0L)
        return;
      SqlCeException sqlCeException = SqlCeException.FillErrorCollection(hr, pISSCEErrors);
      if (sqlCeException != null)
        throw sqlCeException;
    }

    [SecurityCritical]
    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    internal static IntPtr MarshalStringToLPWSTR(string source)
    {
      if (source == null)
        return IntPtr.Zero;
      int length = source.Length;
      int num1 = (length + 1) * 2;
      IntPtr num2 = NativeMethods.CoTaskMemAlloc(num1);
      if (IntPtr.Zero == num2)
        throw new OutOfMemoryException();
      NativeMethods.uwutil_ZeroMemory(num2, num1);
      Marshal.Copy(source.ToCharArray(), 0, num2, length);
      return num2;
    }

    [SecurityCritical]
    internal static unsafe string GetMinorErrorMessage(int minorError)
    {
      IntPtr num = new IntPtr(0);
      string str = (string) null;
      if (NativeMethods.GetContextErrorMessage(minorError, ref num) == 0)
        str = new string((char*) (void*) num);
      NativeMethods.SafeDelete(ref num);
      return str;
    }

    [SecuritySafeCritical]
    internal static void LoadNativeBinaries()
    {
      try
      {
        if (!NativeMethods.m_fTryLoadingNativeLibraries)
          return;
        lock (typeof (NativeMethods))
        {
          if (!NativeMethods.m_fTryLoadingNativeLibraries)
            return;
          try
          {
            NativeMethods.LoadValidLibrary("\\Windows\\sqlceme35.dll");
          }
          catch (DllNotFoundException ex)
          {
            throw SqlCeException.CreateException(string.Format(Res.GetString("ADP_LoadNativeBinaryFail"), (object) 5722, (object) 974247), (Exception) ex);
          }
          if (NativeMethods.m_fTryLoadingNativeLibraries)
            throw SqlCeException.CreateException(string.Format(Res.GetString("ADP_LoadNativeBinaryFail"), (object) 5722, (object) 974247));
        }
      }
      catch (SqlCeException ex)
      {
        throw;
      }
    }

    [DllImport("api-ms-win-core-libraryloader-l1-1-1.dll")]
    private static extern IntPtr LoadLibraryExA(
      string lpFileName,
      IntPtr hFile,
      uint dwFlags);

    [SecurityCritical]
    [DllImport("rmclient.dll")]
    internal static extern int SHGetResourceManagementValue(uint rmv, ref ulong cbValue);

    [SecuritySafeCritical]
    internal static unsafe bool LoadValidLibrary(string modulePath)
    {
      modulePath = modulePath.Trim();
      if (string.IsNullOrEmpty(modulePath))
        return false;
      IntPtr zero1 = IntPtr.Zero;
      IntPtr num = NativeMethods.LoadLibraryExA(modulePath, new IntPtr(0), 0U);
      IntPtr zero2 = IntPtr.Zero;
      NativeMethods.GetSqlCeVersionInfo(ref zero2);
      string version = new string((char*) (void*) zero2);
      NativeMethods.SafeDelete(ref zero2);
      int build = new Version(version).Build;
      if (build != 5722)
      {
        if (num != IntPtr.Zero)
          NativeMethods.DllRelease();
        throw SqlCeException.CreateException(string.Format(Res.GetString("ADP_FileVersionMismatch"), (object) build, (object) 5722, (object) 974247));
      }
      NativeMethods.m_fTryLoadingNativeLibraries = false;
      return true;
    }

    [DllImport("api-ms-win-core-com-l1-1-0.dll", CharSet = CharSet.Unicode)]
    internal static extern IntPtr CoTaskMemAlloc(int cb);

    [DllImport("api-ms-win-core-com-l1-1-0.dll", CharSet = CharSet.Unicode)]
    internal static extern void CoTaskMemFree(IntPtr ptr);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_AbortTransaction", CharSet = CharSet.Unicode)]
    internal static extern int AbortTransaction(IntPtr pTx, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CommitTransaction", CharSet = CharSet.Unicode)]
    internal static extern int CommitTransaction(IntPtr pTx, CommitMode mode, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SetTransactionFlag", CharSet = CharSet.Unicode)]
    internal static extern int SetTransactionFlag(
      IntPtr pITransact,
      SeTransactionFlags seTxFlag,
      bool fEnable,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetTransactionFlags", CharSet = CharSet.Unicode)]
    internal static extern int GetTransactionFlags(
      IntPtr pITransact,
      ref SeTransactionFlags seTxFlags);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetTrackingContext", CharSet = CharSet.Unicode)]
    internal static extern int GetTrackingContext(
      IntPtr pITransact,
      out IntPtr pGuidTrackingContext,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SetTrackingContext", CharSet = CharSet.Unicode)]
    internal static extern int SetTrackingContext(
      IntPtr pITransact,
      IntPtr pGuidTrackingContext,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetTransactionBsn", CharSet = CharSet.Unicode)]
    internal static extern int GetTransactionBsn(
      IntPtr pITransact,
      ref long pTransactionBsn,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_InitChangeTracking", CharSet = CharSet.Unicode)]
    internal static extern int InitChangeTracking(
      IntPtr pITransact,
      ref IntPtr pTracking,
      ref IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_ExitChangeTracking", CharSet = CharSet.Unicode)]
    internal static extern int ExitChangeTracking(ref IntPtr pTracking, ref IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_EnableChangeTracking", CharSet = CharSet.Unicode)]
    internal static extern int EnableChangeTracking(
      IntPtr pTracking,
      string TableName,
      SETRACKINGTYPE seTrackingType,
      SEOCSTRACKOPTIONS seTrackOpts,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetTrackingOptions", CharSet = CharSet.Unicode)]
    internal static extern int GetTrackingOptions(
      IntPtr pTracking,
      string TableName,
      ref SEOCSTRACKOPTIONSV2 iTrackingOptions,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_DisableChangeTracking", CharSet = CharSet.Unicode)]
    internal static extern int DisableChangeTracking(
      IntPtr pTracking,
      string TableName,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_IsTableChangeTracked", CharSet = CharSet.Unicode)]
    internal static extern int IsTableChangeTracked(
      IntPtr pTracking,
      string TableName,
      ref bool fTableTracked,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetChangeTrackingInfo", CharSet = CharSet.Unicode)]
    internal static extern int GetChangeTrackingInfo(
      IntPtr pTracking,
      string TableName,
      ref SEOCSTRACKOPTIONS trackOptions,
      ref SETRACKINGTYPE trackType,
      ref long trackOrdinal,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CleanupTrackingMetadata", CharSet = CharSet.Unicode)]
    internal static extern int CleanupTrackingMetadata(
      IntPtr pTracking,
      string TableName,
      int retentionPeriodInDays,
      long cutoffTxCsn,
      long leastTxCsn,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CleanupTransactionData", CharSet = CharSet.Unicode)]
    internal static extern int CleanupTransactionData(
      IntPtr pTracking,
      int iRetentionPeriodInDays,
      long ullCutoffTransactionCsn,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CleanupTombstoneData", CharSet = CharSet.Unicode)]
    internal static extern int CleanupTombstoneData(
      IntPtr pTracking,
      string TableName,
      int iRetentionPeriodInDays,
      long ullCutoffTransactionCsn,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetCurrentTrackingTxCsn", CharSet = CharSet.Unicode)]
    internal static extern int GetCurrentTrackingTxCsn(
      IntPtr pTracking,
      ref long txCsn,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetCurrentTrackingTxBsn", CharSet = CharSet.Unicode)]
    internal static extern int GetCurrentTrackingTxBsn(
      IntPtr pTracking,
      ref long txBsn,
      IntPtr pError);

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    internal static extern int DllAddRef();

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    internal static extern int DllRelease();

    [DllImport("sqlceme35.dll", EntryPoint = "ME_ClearErrorInfo", CharSet = CharSet.Unicode)]
    internal static extern int ClearErrorInfo(IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_ExecuteQueryPlan", CharSet = CharSet.Unicode)]
    internal static extern int ExecuteQueryPlan(
      IntPtr pTx,
      IntPtr pQpServices,
      IntPtr pQpCommand,
      IntPtr pQpPlan,
      IntPtr prgBinding,
      int cDbBinding,
      IntPtr pData,
      ref int recordsAffected,
      ref ResultSetOptions cursorCapabilities,
      ref IntPtr pSeCursor,
      ref int fIsBaseTableCursor,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SetValues", CharSet = CharSet.Unicode)]
    internal static extern int SetValues(
      IntPtr pQpServices,
      IntPtr pSeCursor,
      IntPtr prgBinding,
      int cDbBinding,
      IntPtr pData,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SetValue", CharSet = CharSet.Unicode)]
    internal static extern unsafe int SetValue(
      IntPtr pSeCursor,
      int seSetColumn,
      void* pBuffer,
      int ordinal,
      int size,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_Prepare", CharSet = CharSet.Unicode)]
    internal static extern int Prepare(IntPtr pSeCursor, SEPREPAREMODE mode, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_InsertRecord", CharSet = CharSet.Unicode)]
    internal static extern int InsertRecord(
      int fMoveTo,
      IntPtr pSeCursor,
      ref int hBookmark,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_UpdateRecord", CharSet = CharSet.Unicode)]
    internal static extern int UpdateRecord(IntPtr pSeCursor, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_DeleteRecord", CharSet = CharSet.Unicode)]
    internal static extern int DeleteRecord(IntPtr pSeCursor, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GotoBookmark", CharSet = CharSet.Unicode)]
    internal static extern int GotoBookmark(IntPtr pSeCursor, int hBookmark, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetContextErrorInfo", CharSet = CharSet.Unicode)]
    internal static extern int GetContextErrorInfo(
      IntPtr pError,
      ref int lNumber,
      ref int lNativeError,
      ref IntPtr pwszMessage,
      ref IntPtr pwszSource,
      ref int numPar1,
      ref int numPar2,
      ref int numPar3,
      ref IntPtr pwszErr1,
      ref IntPtr pwszErr2,
      ref IntPtr pwszErr3);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetContextErrorMessage", CharSet = CharSet.Unicode)]
    internal static extern int GetContextErrorMessage(int dminorError, ref IntPtr pwszMessage);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetMinorError", CharSet = CharSet.Unicode)]
    internal static extern int GetMinorError(IntPtr pError, ref int lMinor);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetBookmark", CharSet = CharSet.Unicode)]
    internal static extern int GetBookmark(IntPtr pSeCursor, ref int hBookmark, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetColumnInfo", CharSet = CharSet.Unicode)]
    internal static extern int GetColumnInfo(
      IntPtr pIUnknown,
      ref int columnCount,
      ref IntPtr prgColumnInfo,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SetColumnInfo", CharSet = CharSet.Unicode)]
    internal static extern int SetColumnInfo(
      IntPtr pITransact,
      string TableName,
      string ColumnName,
      SECOLUMNINFO seColumnInfo,
      SECOLUMNATTRIB seColAttrib,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SetTableInfoAsSystem", CharSet = CharSet.Unicode)]
    internal static extern int SetTableInfoAsSystem(
      IntPtr pITransact,
      string TableName,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetParameterInfo", CharSet = CharSet.Unicode)]
    internal static extern int GetParameterInfo(
      IntPtr pQpCommand,
      ref uint columnCount,
      ref IntPtr prgParamInfo,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetIndexColumnOrdinals", CharSet = CharSet.Unicode)]
    internal static extern int GetIndexColumnOrdinals(
      IntPtr pSeCursor,
      IntPtr pwszIndex,
      ref uint cColumns,
      ref IntPtr priOrdinals,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetKeyInfo", CharSet = CharSet.Unicode)]
    internal static extern int GetKeyInfo(
      IntPtr pIUnknown,
      IntPtr pTx,
      string pwszBaseTable,
      IntPtr prgDbKeyInfo,
      int cDbKeyInfo,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CreateCommand", CharSet = CharSet.Unicode)]
    internal static extern int CreateCommand(
      IntPtr pQpSession,
      ref IntPtr pQpCommand,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CompileQueryPlan", CharSet = CharSet.Unicode)]
    internal static extern int CompileQueryPlan(
      IntPtr pQpCommand,
      string pwszCommandText,
      ResultSetOptions options,
      IntPtr[] pParamNames,
      IntPtr prgBinding,
      int cDbBinding,
      ref IntPtr pQpPlan,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_Move", CharSet = CharSet.Unicode)]
    internal static extern int Move(IntPtr pSeCursor, DIRECTION direction, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_OpenCursor", CharSet = CharSet.Unicode)]
    internal static extern int OpenCursor(
      IntPtr pITransact,
      IntPtr pwszTableName,
      IntPtr pwszIndexName,
      ref IntPtr pSeCursor,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetValues", CharSet = CharSet.Unicode)]
    internal static extern int GetValues(
      IntPtr pSeCursor,
      int seGetColumn,
      IntPtr prgBinding,
      int cDbBinding,
      IntPtr pData,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_Read", CharSet = CharSet.Unicode)]
    internal static extern unsafe int Read(
      IntPtr pSeqStream,
      void* pBuffer,
      int bufferIndex,
      int byteCount,
      out int bytesRead,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_ReadAt", CharSet = CharSet.Unicode)]
    internal static extern unsafe int ReadAt(
      IntPtr pLockBytes,
      int srcIndex,
      void* pBuffer,
      int bufferIndex,
      int byteCount,
      out int bytesRead,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_Seek", CharSet = CharSet.Unicode)]
    internal static extern int Seek(
      IntPtr pSeCursor,
      IntPtr pQpServices,
      IntPtr prgBinding,
      int cBinding,
      IntPtr pData,
      int cKeyValues,
      int dbSeekOptions,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SetRange", CharSet = CharSet.Unicode)]
    internal static extern int SetRange(
      IntPtr pSeCursor,
      IntPtr pQpServices,
      IntPtr prgBinding,
      int cBinding,
      IntPtr pStartData,
      int cStartKeyValues,
      IntPtr pEndData,
      int cEndKeyValues,
      int dbRangeOptions,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SafeRelease", CharSet = CharSet.Unicode)]
    internal static extern int SafeRelease(ref IntPtr ppUnknown);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_SafeDelete", CharSet = CharSet.Unicode)]
    internal static extern int SafeDelete(ref IntPtr ppInstance);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_DeleteArray", CharSet = CharSet.Unicode)]
    internal static extern int DeleteArray(ref IntPtr ppInstance);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_OpenStore", CharSet = CharSet.Unicode)]
    internal static extern int OpenStore(
      IntPtr pOpenInfo,
      IntPtr pfnOnFlushFailure,
      ref IntPtr pStoreService,
      ref IntPtr pStoreServer,
      ref IntPtr pQpServices,
      ref IntPtr pSeStore,
      ref IntPtr pTx,
      ref IntPtr pQpDatabase,
      ref IntPtr pQpSession,
      ref IntPtr pStoreEvents,
      ref IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CloseStore", CharSet = CharSet.Unicode)]
    internal static extern int CloseStore(IntPtr pSeStore);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CloseAndReleaseStore", CharSet = CharSet.Unicode)]
    internal static extern int CloseAndReleaseStore(ref IntPtr pSeStore);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_OpenTransaction", CharSet = CharSet.Unicode)]
    internal static extern int OpenTransaction(
      IntPtr pSeStore,
      IntPtr pQpDatabase,
      SEISOLATION isoLevel,
      IntPtr pQPConnSession,
      ref IntPtr pTx,
      ref IntPtr pQpSession,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CreateDatabase", CharSet = CharSet.Unicode)]
    internal static extern int CreateDatabase(IntPtr pOpenInfo, ref IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_Rebuild", CharSet = CharSet.Unicode)]
    internal static extern int Rebuild(
      IntPtr pwszSrc,
      IntPtr pwszDst,
      IntPtr pwszTemp,
      IntPtr pwszPwd,
      IntPtr pwszPwdNew,
      int fEncrypt,
      SEFIXOPTION tyOption,
      int fSafeRepair,
      int lcid,
      int dstEncryptionMode,
      int localeFlags,
      ref IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_CreateErrorInstance", CharSet = CharSet.Unicode)]
    internal static extern int CreateErrorInstance(ref IntPtr pError);

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    public static extern int uwutil_ConvertToDBTIMESTAMP(
      ref DBTIMESTAMP pDbTimestamp,
      uint dtTime,
      int dtDay);

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    public static extern int uwutil_ConvertFromDBTIMESTAMP(
      DBTIMESTAMP pDbTimestamp,
      ref uint dtTime,
      ref int dtDay);

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    public static extern void uwutil_SysFreeString(IntPtr p);

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    public static extern uint uwutil_ReleaseCOMPtr(IntPtr p);

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    internal static extern int uwutil_get_ErrorCount(IntPtr pIRDA);

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    internal static extern int uwutil_get_Error(
      IntPtr pIError,
      int errno,
      out int hResult,
      out IntPtr message,
      out int nativeError,
      out IntPtr source,
      out int numericParameter1,
      out int numericParameter2,
      out int numericParameter3,
      out IntPtr errorParameter1,
      out IntPtr errorParameter2,
      out IntPtr errorParameter3);

    [DllImport("sqlceme35.dll", CharSet = CharSet.Unicode)]
    internal static extern void uwutil_ZeroMemory(IntPtr dest, int length);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetSqlCeVersionInfo", CharSet = CharSet.Unicode)]
    internal static extern int GetSqlCeVersionInfo(ref IntPtr pwszVersion);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetNativeVersionInfo", CharSet = CharSet.Unicode)]
    internal static extern int GetNativeVersionInfo(ref int bldMajor, ref int bldMinor);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetDatabaseInstanceID", CharSet = CharSet.Unicode)]
    internal static extern int GetDatabaseInstanceID(
      IntPtr pStore,
      out IntPtr pwszGuidString,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetEncryptionMode", CharSet = CharSet.Unicode)]
    internal static extern int GetEncryptionMode(
      IntPtr pStore,
      ref int encryptionMode,
      IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetLocale", CharSet = CharSet.Unicode)]
    internal static extern int GetLocale(IntPtr pStore, ref int locale, IntPtr pError);

    [DllImport("sqlceme35.dll", EntryPoint = "ME_GetLocaleFlags", CharSet = CharSet.Unicode)]
    internal static extern int GetLocaleFlags(IntPtr pStore, ref int sortFlags, IntPtr pError);
  }
}
