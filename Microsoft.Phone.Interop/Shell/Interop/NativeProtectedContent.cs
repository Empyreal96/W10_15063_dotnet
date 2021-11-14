// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeProtectedContent
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell.Interop
{
  [SecuritySafeCritical]
  internal class NativeProtectedContent
  {
    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetIsShowingProtectedContent(
      SafeAppChromeHandle pAppChrome,
      bool fShowingProtectedContent);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetIsShowingProtectedContent(
      SafeAppChromeHandle pAppChrome,
      out bool pResult);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void SetIsMaximized(SafeAppChromeHandle pAppChrome, bool fMaximized);

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetIsMaximized(SafeAppChromeHandle pAppChrome, out bool pResult);
  }
}
