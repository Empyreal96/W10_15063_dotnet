// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.PhoneCallTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using Windows.ApplicationModel.Calls;

namespace Microsoft.Phone.Tasks
{
  public sealed class PhoneCallTask
  {
    public string DisplayName { get; set; }

    public string PhoneNumber { get; set; }

    [SecuritySafeCritical]
    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      if (QuirksMode.ShouldEnforceId_Cap_PhoneDialer())
      {
        bool isCapabilityPresent = false;
        PhoneCallTask.NativeMethods.CapabilityCheck(IntPtr.Zero, "ID_CAP_PHONEDIALER", out isCapabilityPresent);
        if (!isCapabilityPresent)
          throw new UnauthorizedAccessException("The PhoneCallTask can only be launched if the app has ID_CAP_PHONEDIALER capability specified in its manifest.");
      }
      if (string.IsNullOrEmpty(this.PhoneNumber))
        return;
      if (this.DisplayName == null)
        this.DisplayName = string.Empty;
      PhoneCallManager.ShowPhoneCallUI(this.PhoneNumber, this.DisplayName);
    }

    private class NativeMethods
    {
      [DllImport("SecRuntime.dll", CharSet = CharSet.Unicode)]
      public static extern int CapabilityCheck(
        IntPtr clientToken,
        string capabilityID,
        [MarshalAs(UnmanagedType.Bool)] out bool isCapabilityPresent);
    }
  }
}
