// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IPMTileManager
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [Guid("D622EEDE-5363-41fc-91C3-88E321191A34")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IPMTileManager
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int ConstructTile(
      Guid ProductID,
      string TileID,
      TILE_TEMPLATE_TYPE templateType,
      PM_TILE_HUBTYPE HubType,
      [MarshalAs((UnmanagedType) 28)] out IPMTileInfo ppTile);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int CommitTile([MarshalAs((UnmanagedType) 28), In] IPMTileInfo pTile);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int DeleteTile(Guid ProductID, [MarshalAs((UnmanagedType) 19), In] string TileID);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int CommitTileExternal([MarshalAs((UnmanagedType) 28), In] IPMTileInfo pTile);
  }
}
