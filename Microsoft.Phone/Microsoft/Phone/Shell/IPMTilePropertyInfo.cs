// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IPMTilePropertyInfo
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [Guid("6C2B8017-1EFA-42a7-86C0-6D4B640BF528")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IPMTilePropertyInfo
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_PropertyID(out uint pPropID);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_PropertyValue([MarshalAs((UnmanagedType) 19)] out string pPropValue);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int set_Property([MarshalAs((UnmanagedType) 19), In] string PropValue);
  }
}
