// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.CEVALUNION
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.UserData
{
  [SecurityCritical]
  [StructLayout(LayoutKind.Explicit)]
  internal struct CEVALUNION
  {
    [FieldOffset(0)]
    public short iVal;
    [FieldOffset(0)]
    public ushort uiVal;
    [FieldOffset(0)]
    public int lVal;
    [FieldOffset(0)]
    public uint ulVal;
    [FieldOffset(0)]
    public FILETIME filetime;
    [FieldOffset(0)]
    public IntPtr lpwstr;
    [FieldOffset(0)]
    public bool boolVal;
    [FieldOffset(0)]
    public double dblVal;
  }
}
