﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeCallbackMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell.Interop
{
  [SecurityCritical]
  internal class NativeCallbackMethods
  {
    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    internal static extern void CreateMenuListener(
      out SafeMenuListenerHandle ppListenerInterface,
      ref AppBarCallbackFunctionPointers callbackStruct);

    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    internal static extern void ReleaseMenuListener(ref IntPtr ppListenerInterface);

    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    internal static extern void DetachMenuListener(IntPtr pListenerInterface);
  }
}
