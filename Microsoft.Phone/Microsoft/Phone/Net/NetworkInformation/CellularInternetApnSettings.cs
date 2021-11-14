// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.CellularInternetApnSettings
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  internal struct CellularInternetApnSettings
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    internal string szApn;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    internal string szUserName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    internal string szPassword;
    internal CellularAuthType authType;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    internal string szProxyServer;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    internal string szPort;
    internal CellularIpType ipType;
  }
}
