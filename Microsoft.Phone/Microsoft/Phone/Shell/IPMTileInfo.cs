// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IPMTileInfo
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("D1604833-2B08-4001-82CD-183AD734F752")]
  [ComImport]
  internal interface IPMTileInfo
  {
    void get_ProductID(out Guid pProductID);

    void get_TileID([MarshalAs((UnmanagedType) 19)] out string pTileID);

    void get_TemplateType(out TILE_TEMPLATE_TYPE pTemplateType);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_HubPinnedState(PM_TILE_HUBTYPE HubType, out bool pIsVisible);

    void get_Position();

    void get_IsNotified(out bool pIsNotified);

    void get_IsDefault(out bool pIsDefault);

    void get_TaskID([MarshalAs((UnmanagedType) 19)] out string pTaskID);

    void get_TileType(out PM_STARTTILE_TYPE pStartTileType);

    void get_IsThemable(out bool pIsThemable);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_PropertyById(uint PropID, [MarshalAs((UnmanagedType) 28)] out IPMTilePropertyInfo ppPropInfo);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_InvocationInfo([MarshalAs((UnmanagedType) 19)] out string pImageUrn, [MarshalAs((UnmanagedType) 19)] out string pParameters);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_PropertyEnum([MarshalAs((UnmanagedType) 28)] out object ppTilePropEnum);

    void get_HubTileSize();

    void set_Position();

    void set_NotifiedState();

    void set_HubPinnedState();

    void set_HubTileSize();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int set_InvocationInfo([MarshalAs((UnmanagedType) 19), In] string TaskName, [MarshalAs((UnmanagedType) 19), In] string TaskParameters);
  }
}
