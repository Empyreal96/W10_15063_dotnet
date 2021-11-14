// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  public sealed class TileUpdater : ITileUpdater, ITileUpdater2
  {
    [MethodImpl]
    public extern void Update(TileNotification notification);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern void EnableNotificationQueue(bool enable);

    public extern NotificationSetting Setting { [MethodImpl] get; }

    [MethodImpl]
    public extern void AddToSchedule(ScheduledTileNotification scheduledTile);

    [MethodImpl]
    public extern void RemoveFromSchedule(ScheduledTileNotification scheduledTile);

    [MethodImpl]
    public extern IVectorView<ScheduledTileNotification> GetScheduledTileNotifications();

    [Overload("StartPeriodicUpdate")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri tileContent,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri tileContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    [MethodImpl]
    public extern void StopPeriodicUpdate();

    [Overload("StartPeriodicUpdateBatch")]
    [MethodImpl]
    public extern void StartPeriodicUpdateBatch(
      IIterable<Uri> tileContents,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateBatchAtTime")]
    [MethodImpl]
    public extern void StartPeriodicUpdateBatch(
      IIterable<Uri> tileContents,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    [MethodImpl]
    public extern void EnableNotificationQueueForSquare150x150(bool enable);

    [MethodImpl]
    public extern void EnableNotificationQueueForWide310x150(bool enable);

    [MethodImpl]
    public extern void EnableNotificationQueueForSquare310x310(bool enable);
  }
}
