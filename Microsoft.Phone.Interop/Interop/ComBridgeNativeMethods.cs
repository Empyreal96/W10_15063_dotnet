﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.ComBridgeNativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Interop
{
  [SecurityCritical]
  internal static class ComBridgeNativeMethods
  {
    [DllImport("PlatformInterop.dll", CharSet = CharSet.Unicode)]
    internal static extern uint RegisterComDllInproc(string dllFileName, string clsid);
  }
}
