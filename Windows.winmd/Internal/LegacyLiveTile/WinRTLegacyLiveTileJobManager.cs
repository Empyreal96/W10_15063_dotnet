// Decompiled with JetBrains decompiler
// Type: Windows.Internal.LegacyLiveTile.WinRTLegacyLiveTileJobManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Internal.LegacyLiveTile
{
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class WinRTLegacyLiveTileJobManager : IWinRTLegacyLiveTileJobManager
  {
    [MethodImpl]
    public extern WinRTLegacyLiveTileJobManager();

    [MethodImpl]
    public extern void AddLiveTileRequest(
      Guid productId,
      string TileID,
      LegacyLiveTileRecurrenceType Recurrence,
      bool userNoneIdle,
      byte[] pTileXml,
      byte[] pUrlXml);

    [MethodImpl]
    public extern void AddLiveTileSchedule(
      Guid productId,
      string TileID,
      LegacyLiveTileRecurrenceType Recurrence,
      LegacyLiveTileIntervalKind Interval,
      uint maximumRunCount,
      bool runForever,
      global::Windows.Foundation.DateTime startTime,
      byte[] pTileXml,
      byte[] pUrlXml);

    [MethodImpl]
    public extern void RemoveLegacyLiveTileSubscription(
      Guid productId,
      string TileID,
      LegacyLiveTileRecurrenceType RecurrenceType);

    [MethodImpl]
    public extern void PushUpdateTile(Guid productId, string TileID);
  }
}
