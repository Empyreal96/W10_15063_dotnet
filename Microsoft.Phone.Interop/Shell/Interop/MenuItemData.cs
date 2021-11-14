// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.MenuItemData
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Shell.Interop
{
  [SecuritySafeCritical]
  [StructLayout(LayoutKind.Explicit)]
  internal struct MenuItemData
  {
    [FieldOffset(0)]
    public MenuBarItemType uType;
    [MarshalAs(UnmanagedType.Bool)]
    [FieldOffset(4)]
    public bool fEnabled;
    [MarshalAs(UnmanagedType.Bool)]
    [FieldOffset(5)]
    public bool fChecked;
    [FieldOffset(8)]
    public uint dwId;
    [MarshalAs(UnmanagedType.LPWStr)]
    [FieldOffset(12)]
    public string pszChecked;
    [MarshalAs(UnmanagedType.LPWStr)]
    [FieldOffset(16)]
    public string pszUnchecked;
    [MarshalAs(UnmanagedType.LPWStr)]
    [FieldOffset(20)]
    public string pszText;
    [FieldOffset(24)]
    public IntPtr pUnCheckedImageBuffer;
    [FieldOffset(28)]
    public uint cbUnCheckedImageBuffer;
    [FieldOffset(32)]
    public ImageBufferData ibdUnCheckedImageBufferData;
  }
}
