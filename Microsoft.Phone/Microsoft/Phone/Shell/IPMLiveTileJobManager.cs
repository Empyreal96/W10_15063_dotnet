// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IPMLiveTileJobManager
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [Guid("15E673FD-0497-4cb3-97CB-99E698DD3B66")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IPMLiveTileJobManager
  {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int AddLiveTileSubscription(
      Guid productId,
      [MarshalAs((UnmanagedType) 19), In] string TileID,
      [In] PM_LIVETILE_SCHEDULE Schedule,
      [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1), In] byte[] pTileXml,
      [In] uint cbTileXml,
      [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1), In] byte[] pURLXml,
      [In] uint cbURLXml);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int UpdateLiveTileJob([MarshalAs((UnmanagedType) 28), In] IPMLiveTileJobInfo pLiveTileJobInfo);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int RemoveLiveTileSubscription(
      Guid productId,
      [MarshalAs((UnmanagedType) 19), In] string TileID,
      [In] PM_LIVETILE_RECURRENCE_TYPE RecurrenceType);

    void UpdateTileFromXML();
  }
}
