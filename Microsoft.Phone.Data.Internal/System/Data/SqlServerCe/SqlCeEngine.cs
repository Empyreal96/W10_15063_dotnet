// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeEngine
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeEngine : IDisposable
  {
    private SqlCeConnectionStringBuilder connTokens;
    private string connStr;
    private bool isDisposed;

    static SqlCeEngine() => KillBitHelper.ThrowIfKillBitIsSet();

    [SecuritySafeCritical]
    public SqlCeEngine()
    {
      NativeMethods.LoadNativeBinaries();
      this.isDisposed = false;
      NativeMethods.DllAddRef();
      this.LocalConnectionString = string.Empty;
    }

    [SecuritySafeCritical]
    public SqlCeEngine(string connectionString)
      : this()
    {
      this.LocalConnectionString = connectionString;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    ~SqlCeEngine() => this.Dispose(false);

    [SecuritySafeCritical]
    private void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      this.connStr = (string) null;
      this.connTokens = (SqlCeConnectionStringBuilder) null;
      NativeMethods.DllRelease();
      this.isDisposed = true;
    }

    public string LocalConnectionString
    {
      get
      {
        if (string.IsNullOrEmpty(this.connStr) || string.IsNullOrEmpty(this.connStr.Trim()))
          this.connStr = string.Empty;
        return this.connStr;
      }
      set
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(nameof (SqlCeEngine));
        if (this.connTokens == null)
          this.connTokens = new SqlCeConnectionStringBuilder();
        this.connTokens.ConnectionString = value;
        this.connStr = value;
      }
    }

    public void Compact(string connectionString) => this.Repair(SEFIXOPTION.SEFIX_OPTION_COMPACT, connectionString, RepairOption.DeleteCorruptedRows);

    public void Shrink() => this.Repair(SEFIXOPTION.SEFIX_OPTION_SHRINK, (string) null, RepairOption.DeleteCorruptedRows);

    public void Repair(string connectionString, RepairOption options) => this.Repair(SEFIXOPTION.SEFIX_OPTION_REPAIR, connectionString, options);

    public bool Verify() => this.Verify(VerifyOption.Default);

    public bool Verify(VerifyOption option)
    {
      try
      {
        switch (option)
        {
          case VerifyOption.Default:
            this.Repair(SEFIXOPTION.SEFIX_OPTION_VERIFY, (string) null, RepairOption.DeleteCorruptedRows);
            break;
          case VerifyOption.Enhanced:
            this.Repair(SEFIXOPTION.SEFIX_OPTION_VERIFYEX, (string) null, RepairOption.DeleteCorruptedRows);
            break;
          default:
            Debug.Assert(false, "Wrong value for option in Verify");
            break;
        }
        return true;
      }
      catch (SqlCeException ex)
      {
        return false;
      }
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    [SecuritySafeCritical]
    private void Repair(SEFIXOPTION option, string dstConnStr, RepairOption repairOption)
    {
      int lcid = 0;
      string str1 = (string) null;
      IntPtr zero = IntPtr.Zero;
      IntPtr num1 = IntPtr.Zero;
      IntPtr num2 = IntPtr.Zero;
      IntPtr num3 = IntPtr.Zero;
      IntPtr num4 = IntPtr.Zero;
      IntPtr num5 = IntPtr.Zero;
      string source1 = (string) null;
      string source2 = (string) null;
      string source3 = (string) null;
      string source4 = (string) null;
      string source5 = (string) null;
      int fEncrypt = 0;
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeEngine));
      if (this.connTokens != null)
      {
        if (!string.IsNullOrEmpty(this.LocalConnectionString))
        {
          try
          {
            object connToken1 = this.connTokens["Password"];
            if (connToken1 != null)
            {
              string str2 = ((string) connToken1).Trim();
              if (str2.Length > 0)
                source4 = str2;
            }
            string lower = (dstConnStr != null ? dstConnStr : this.LocalConnectionString).ToLower(CultureInfo.InvariantCulture);
            int num6 = lower.Contains("Case Sensitive".ToLower(CultureInfo.InvariantCulture)) || lower.Contains("ssce:case sensitive".ToLower(CultureInfo.InvariantCulture)) ? 1 : (lower.Contains("casesensitive".ToLower(CultureInfo.InvariantCulture)) ? 1 : 0);
            bool connToken2;
            if (dstConnStr != null)
            {
              SqlCeConnectionStringBuilder connectionStringBuilder = new SqlCeConnectionStringBuilder(dstConnStr);
              object obj1 = connectionStringBuilder["Data Source"];
              if (obj1 != null)
              {
                string inputString = ((string) obj1).Trim();
                if (inputString.Length > 0)
                  source2 = ConStringUtil.ReplaceDataDirectory(inputString);
              }
              object obj2 = connectionStringBuilder["Password"];
              if (obj2 != null)
              {
                string str2 = ((string) obj2).Trim();
                if (str2.Length > 0)
                  source5 = str2;
              }
              object obj3 = connectionStringBuilder["Temp File Directory"];
              if (obj3 != null)
                source3 = (string) obj3;
              object obj4 = connectionStringBuilder["Locale Identifier"];
              if (obj4 != null)
                lcid = (int) obj4;
              object obj5 = connectionStringBuilder["Encryption Mode"];
              if (obj5 != null)
                str1 = (string) obj5;
              object obj6 = connectionStringBuilder["Encrypt Database"];
              if (obj6 != null)
                fEncrypt = (bool) obj6 ? 1 : 0;
              connToken2 = (bool) connectionStringBuilder["Case Sensitive"];
            }
            else
            {
              source2 = (string) null;
              object connToken3 = this.connTokens["Password"];
              if (connToken3 != null)
              {
                string str2 = ((string) connToken3).Trim();
                if (str2.Length > 0)
                  source5 = str2;
              }
              object connToken4 = this.connTokens["Temp File Directory"];
              if (connToken4 != null)
                source3 = (string) connToken4;
              object connToken5 = this.connTokens["Locale Identifier"];
              if (connToken5 != null)
                lcid = (int) connToken5;
              object connToken6 = this.connTokens["Encrypt Database"];
              if (connToken6 != null)
                fEncrypt = (bool) connToken6 ? 1 : 0;
              connToken2 = (bool) this.connTokens["Case Sensitive"];
            }
            num2 = NativeMethods.MarshalStringToLPWSTR(source2);
            num3 = NativeMethods.MarshalStringToLPWSTR(source3);
            num4 = NativeMethods.MarshalStringToLPWSTR(source4);
            num5 = NativeMethods.MarshalStringToLPWSTR(source5);
            object connToken7 = this.connTokens["Data Source"];
            if (connToken7 != null)
              source1 = ConStringUtil.ReplaceDataDirectory((string) connToken7);
            num1 = NativeMethods.MarshalStringToLPWSTR(source1);
            int fSafeRepair = (int) repairOption;
            int dstEncryptionMode = ConStringUtil.MapEncryptionMode(str1);
            int localeFlags = 0;
            if (num6 == 0)
              localeFlags = -1;
            else if (connToken2)
              localeFlags |= 1;
            int hr = NativeMethods.Rebuild(num1, num2, num3, num4, num5, fEncrypt, option, fSafeRepair, lcid, dstEncryptionMode, localeFlags, ref zero);
            if (hr == 0)
              return;
            SqlCeEngine.ProcessResults(zero, hr);
            return;
          }
          finally
          {
            NativeMethods.CoTaskMemFree(num1);
            NativeMethods.CoTaskMemFree(num2);
            NativeMethods.CoTaskMemFree(num3);
            NativeMethods.CoTaskMemFree(num4);
            NativeMethods.CoTaskMemFree(num5);
            NativeMethods.SafeDelete(ref zero);
          }
        }
      }
      throw new InvalidOperationException(Res.GetString("SQLCE_ConnectionStringNotInitialized"));
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    [SecuritySafeCritical]
    public void CreateDatabase()
    {
      int num1 = -1;
      string str1 = (string) null;
      bool flag1 = false;
      IntPtr zero = IntPtr.Zero;
      bool flag2 = false;
      string source1 = (string) null;
      string source2 = (string) null;
      if (this.isDisposed)
        throw new ObjectDisposedException(nameof (SqlCeEngine));
      if (this.connTokens == null || string.IsNullOrEmpty(this.LocalConnectionString))
        throw new InvalidOperationException(Res.GetString("SQLCE_ConnectionStringNotInitialized"));
      IntPtr num2 = IntPtr.Zero;
      MEOPENINFO meopeninfo = new MEOPENINFO();
      try
      {
        num2 = NativeMethods.CoTaskMemAlloc(sizeof (MEOPENINFO));
        if (IntPtr.Zero == num2)
          throw new OutOfMemoryException();
        object connToken1 = this.connTokens["Locale Identifier"];
        if (connToken1 != null)
          num1 = (int) connToken1;
        object connToken2 = this.connTokens["Encryption Mode"];
        if (connToken2 != null)
          str1 = (string) connToken2;
        object connToken3 = this.connTokens["Data Source"];
        if (connToken3 != null)
          source1 = ConStringUtil.ReplaceDataDirectory((string) connToken3);
        object connToken4 = this.connTokens["Password"];
        if (connToken4 != null)
        {
          string str2 = ((string) connToken4).Trim();
          if (str2.Length > 0)
            source2 = str2;
        }
        object connToken5 = this.connTokens["Encrypt Database"];
        if (connToken5 != null)
          flag1 = (bool) connToken5;
        object connToken6 = this.connTokens["Case Sensitive"];
        if (connToken6 != null)
          flag2 = (bool) connToken6;
        meopeninfo.pwszFileName = NativeMethods.MarshalStringToLPWSTR(source1);
        meopeninfo.pwszPassword = NativeMethods.MarshalStringToLPWSTR(source2);
        meopeninfo.lcidLocale = num1;
        meopeninfo.fEncrypt = flag1 ? 1 : 0;
        meopeninfo.dwEncryptionMode = ConStringUtil.MapEncryptionMode(str1);
        meopeninfo.dwLocaleFlags = 0;
        if (flag2)
          meopeninfo.dwLocaleFlags |= 1;
        Marshal.StructureToPtr((object) meopeninfo, num2, false);
        int database = NativeMethods.CreateDatabase(num2, ref zero);
        if (database == 0)
          return;
        SqlCeEngine.ProcessResults(zero, database);
      }
      finally
      {
        NativeMethods.CoTaskMemFree(meopeninfo.pwszFileName);
        NativeMethods.CoTaskMemFree(meopeninfo.pwszPassword);
        NativeMethods.CoTaskMemFree(num2);
        NativeMethods.SafeDelete(ref zero);
      }
    }

    internal static void ProcessResults(IntPtr pError, int hr)
    {
      if (NativeMethods.Failed(hr))
        throw SqlCeException.FillErrorInformation(hr, pError);
    }

    public void Upgrade() => this.Repair(SEFIXOPTION.SEFIX_OPTION_UPGRADE, (string) null, RepairOption.DeleteCorruptedRows);

    public void Upgrade(string destConnectionString) => this.Repair(SEFIXOPTION.SEFIX_OPTION_UPGRADE, destConnectionString, RepairOption.DeleteCorruptedRows);
  }
}
