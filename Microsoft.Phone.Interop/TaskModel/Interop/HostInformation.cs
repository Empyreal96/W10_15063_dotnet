// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.HostInformation
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.TaskModel.Interop
{
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  internal struct HostInformation
  {
    public uint ullLastInstanceId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szProductId;
    public IntPtr hHostWnd;
    public IntPtr hTouchWnd;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAppInstallFolder;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAppDataFolder;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAppIsolatedStorePath;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2084)]
    public string szUri;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2084)]
    public string szTaskPage;
    public uint fRehydrated;
    public uint fDehydrating;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGuidInstanceId;
    public uint uAppTargetMajorVersion;
    public uint uAppTargetMinorVersion;
    public ApplicationType appType;
    public uint fIsHeadlessHost;
    public uint fIsExecutingInBackground;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAppVersion;
  }
}
