// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeErrorCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections;
using System.Security;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeErrorCollection : ICollection, IEnumerable
  {
    private Microsoft.Phone.Data.Workaround.ArrayList items = new Microsoft.Phone.Data.Workaround.ArrayList();

    static SqlCeErrorCollection() => KillBitHelper.ThrowIfKillBitIsSet();

    internal SqlCeErrorCollection()
    {
    }

    [SecuritySafeCritical]
    internal unsafe void FillErrorInformation(int hr, IntPtr pIError)
    {
      int lNativeError = 0;
      int numPar1 = 0;
      int numPar2 = 0;
      int numPar3 = 0;
      IntPtr num1 = new IntPtr(0);
      IntPtr num2 = new IntPtr(0);
      IntPtr num3 = new IntPtr(0);
      IntPtr num4 = new IntPtr(0);
      IntPtr num5 = new IntPtr(0);
      if (IntPtr.Zero == pIError)
      {
        this.Add(SqlCeError.GetDefaultError(hr));
      }
      else
      {
        try
        {
          NativeMethods.GetContextErrorInfo(pIError, ref hr, ref lNativeError, ref num1, ref num2, ref numPar1, ref numPar2, ref numPar3, ref num3, ref num4, ref num5);
          string message = new string((char*) (void*) num1);
          string source = new string((char*) (void*) num2);
          string errorParameter1 = new string((char*) (void*) num3);
          string errorParameter2 = new string((char*) (void*) num4);
          string errorParameter3 = new string((char*) (void*) num5);
          this.Add(new SqlCeError(hr, message, lNativeError, source, numPar1, numPar2, numPar3, errorParameter1, errorParameter2, errorParameter3));
        }
        finally
        {
          NativeMethods.SafeDelete(ref num2);
          NativeMethods.SafeDelete(ref num1);
          NativeMethods.SafeDelete(ref num3);
          NativeMethods.SafeDelete(ref num4);
          NativeMethods.SafeDelete(ref num5);
        }
      }
    }

    [SecuritySafeCritical]
    internal unsafe void FillErrorCollection(int hr, IntPtr pISSCEErrors)
    {
      if (pISSCEErrors == IntPtr.Zero)
      {
        this.Add(SqlCeError.GetDefaultError(hr));
      }
      else
      {
        int hResult = 0;
        int nativeError = 0;
        int numericParameter1 = 0;
        int numericParameter2 = 0;
        int numericParameter3 = 0;
        IntPtr message1 = new IntPtr(0);
        IntPtr source1 = new IntPtr(0);
        IntPtr errorParameter1_1 = new IntPtr(0);
        IntPtr errorParameter2_1 = new IntPtr(0);
        IntPtr errorParameter3_1 = new IntPtr(0);
        int errorCount = NativeMethods.uwutil_get_ErrorCount(pISSCEErrors);
        for (int errno = 0; errno < errorCount; ++errno)
        {
          hr = NativeMethods.uwutil_get_Error(pISSCEErrors, errno, out hResult, out message1, out nativeError, out source1, out numericParameter1, out numericParameter2, out numericParameter3, out errorParameter1_1, out errorParameter2_1, out errorParameter3_1);
          if (hr == 0)
          {
            string message2 = new string((char*) (void*) message1);
            string source2 = new string((char*) (void*) source1);
            string errorParameter1_2 = new string((char*) (void*) errorParameter1_1);
            string errorParameter2_2 = new string((char*) (void*) errorParameter2_1);
            string errorParameter3_2 = new string((char*) (void*) errorParameter3_1);
            if (message2 != null && message2.Equals("Run"))
              message2 = "SqlCeReplication.Synchronize()";
            this.Add(new SqlCeError(hResult, message2, nativeError, source2, numericParameter1, numericParameter2, numericParameter3, errorParameter1_2, errorParameter2_2, errorParameter3_2));
          }
          NativeMethods.uwutil_SysFreeString(source1);
          NativeMethods.uwutil_SysFreeString(message1);
          NativeMethods.uwutil_SysFreeString(errorParameter1_1);
          NativeMethods.uwutil_SysFreeString(errorParameter2_1);
          NativeMethods.uwutil_SysFreeString(errorParameter3_1);
        }
      }
    }

    bool ICollection.IsSynchronized => false;

    object ICollection.SyncRoot => (object) this;

    public int Count => this.items == null ? 0 : this.items.Count;

    public SqlCeError this[int index] => this.items == null || this.items.Count <= index ? SqlCeError.GetDefaultError(-2147467259) : (SqlCeError) this.items[index];

    internal void Add(SqlCeError error) => this.items.Add((object) error);

    public void CopyTo(Array array, int index) => this.items.CopyTo(array, index);

    public IEnumerator GetEnumerator() => this.items.GetEnumerator();
  }
}
