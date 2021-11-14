// Decompiled with JetBrains decompiler
// Type: Windows.Internal.LegacyLiveTile.IWinRTLegacyLiveTileJobManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Internal.LegacyLiveTile
{
  [Guid(2052925576, 50702, 17967, 129, 25, 78, 95, 26, 241, 227, 235)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (WinRTLegacyLiveTileJobManager))]
  internal interface IWinRTLegacyLiveTileJobManager
  {
    void AddLiveTileRequest(
      Guid productId,
      string TileID,
      LegacyLiveTileRecurrenceType Recurrence,
      bool userNoneIdle,
      byte[] pTileXml,
      byte[] pUrlXml);

    void AddLiveTileSchedule(
      Guid productId,
      string TileID,
      LegacyLiveTileRecurrenceType Recurrence,
      LegacyLiveTileIntervalKind Interval,
      uint maximumRunCount,
      bool runForever,
      global::Windows.Foundation.DateTime startTime,
      byte[] pTileXml,
      byte[] pUrlXml);

    void RemoveLegacyLiveTileSubscription(
      Guid productId,
      string TileID,
      LegacyLiveTileRecurrenceType RecurrenceType);

    void PushUpdateTile(Guid productId, string TileID);
  }
}
