// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IPMTileInfoEnumerator
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [Guid("DED83065-E462-4b2c-ACB5-E39CEA61C874")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IPMTileInfoEnumerator
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_Next([MarshalAs((UnmanagedType) 28)] out IPMTileInfo ppTileInfo);
  }
}
