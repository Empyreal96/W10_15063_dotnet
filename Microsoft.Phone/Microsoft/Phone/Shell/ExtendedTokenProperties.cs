// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ExtendedTokenProperties
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  internal struct ExtendedTokenProperties
  {
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearImg;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrImg;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearTitle;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrTitle;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearBackgroundContent;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrBackContent;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearWideImg;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrWideImg;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearWideBackgroundContent;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrWideBackContent;
  }
}
