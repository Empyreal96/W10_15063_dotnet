// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Marketplace.LicenseInformation
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Marketplace
{
  [SecuritySafeCritical]
  public sealed class LicenseInformation
  {
    private bool m_fIsTrial;

    public bool IsTrial()
    {
      if (LicenseInformation.NativeMethods.IsTrial(ref this.m_fIsTrial) != 0)
        this.m_fIsTrial = true;
      return this.m_fIsTrial;
    }

    internal static class NativeMethods
    {
      internal const int S_OK = 0;
      internal const int S_FALSE = 1;

      [DllImport("LicenseInterop.dll")]
      internal static extern int IsTrial([MarshalAs(UnmanagedType.Bool)] ref bool pfIsTrial);
    }
  }
}
