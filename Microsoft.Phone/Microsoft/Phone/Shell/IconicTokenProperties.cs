﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IconicTokenProperties
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  internal struct IconicTokenProperties
  {
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearSmallImg;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrSmallImg;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearImg;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrImg;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearCount;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrCount;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearTitle;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrTitle;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearContent1;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrContent1;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearContent2;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrContent2;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearContent3;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrContent3;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fClearColor;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string wstrColor;
  }
}
