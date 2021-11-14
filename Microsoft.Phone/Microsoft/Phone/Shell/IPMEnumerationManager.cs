// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IPMEnumerationManager
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [Guid("698D57C2-292D-4CF3-B73C-D95A6922ED9A")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IPMEnumerationManager
  {
    void get_AllApplications();

    [DispId(2)]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_AllTiles([MarshalAs((UnmanagedType) 28)] out IPMTileInfoEnumerator ppTileEnum, [In] PM_ENUM_TILE_FILTER_APP_ALL Filter);

    void get_AllTasks();

    void get_AllExtensions();

    void get_AllBackgroundServiceAgents();

    void get_AllBackgroundWorkers();

    void get_ApplicationInfo();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_TileInfo([In] Guid ProductID, [MarshalAs((UnmanagedType) 19), In] string TileID, [MarshalAs((UnmanagedType) 28)] out IPMTileInfo ppTileInfo);

    void get_TaskInfo();

    void get_TaskInfoEx();

    void get_BackgroundServiceAgentInfo();

    void get_AllLiveTileJobs();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_LiveTileJob(
      [In] Guid ProductID,
      [MarshalAs((UnmanagedType) 19), In] string TileID,
      ref PM_LIVETILE_RECURRENCE_TYPE RecurrenceType,
      [MarshalAs((UnmanagedType) 28)] out IPMLiveTileJobInfo ppLiveTileJobInfo);
  }
}
