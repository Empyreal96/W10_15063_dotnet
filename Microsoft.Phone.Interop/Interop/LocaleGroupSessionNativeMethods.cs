// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.LocaleGroupSessionNativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Interop
{
  internal class LocaleGroupSessionNativeMethods
  {
    internal const int E_INVALIDARG = -2147024809;
    private const string PlatformInteropDllName = "PlatformInterop.dll";

    [SecurityCritical]
    [DllImport("PlatformInterop.dll", EntryPoint = "LocaleGroupSession_Create", CharSet = CharSet.Unicode)]
    internal static extern int Create(string localeName, out int groupCount, out IntPtr session);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll", EntryPoint = "LocaleGroupSession_Destroy", CharSet = CharSet.Unicode)]
    internal static extern int Destroy(IntPtr session);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll", EntryPoint = "LocaleGroupSession_GetGroupDisplayString", CharSet = CharSet.Unicode)]
    internal static extern int GetGroupDisplayString(
      IntPtr session,
      int groupIndex,
      out string groupName);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll", EntryPoint = "LocaleGroupSession_GetGroupIndexForString", CharSet = CharSet.Unicode)]
    internal static extern int GetGroupIndexForString(
      IntPtr session,
      string lookup,
      out int groupIndex);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll", EntryPoint = "LocaleGroupSession_GetActualCulture", CharSet = CharSet.Unicode)]
    internal static extern int GetActualCulture(IntPtr session, out string culture);

    [SecurityCritical]
    [DllImport("PlatformInterop.dll", EntryPoint = "LocaleGroupSession_IsPhoneticsSupported", CharSet = CharSet.Unicode)]
    internal static extern bool IsPhoneticsSupported(IntPtr session);
  }
}
