// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(155362443, 7569, 17644, 146, 67, 193, 232, 33, 194, 154, 32)]
  [ExclusiveTo(typeof (TileUpdater))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITileUpdater
  {
    void Update(TileNotification notification);

    void Clear();

    void EnableNotificationQueue(bool enable);

    NotificationSetting Setting { get; }

    void AddToSchedule(ScheduledTileNotification scheduledTile);

    void RemoveFromSchedule(ScheduledTileNotification scheduledTile);

    IVectorView<ScheduledTileNotification> GetScheduledTileNotifications();

    [Overload("StartPeriodicUpdate")]
    void StartPeriodicUpdate(Uri tileContent, PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    void StartPeriodicUpdate(
      Uri tileContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    void StopPeriodicUpdate();

    [Overload("StartPeriodicUpdateBatch")]
    void StartPeriodicUpdateBatch(
      IIterable<Uri> tileContents,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateBatchAtTime")]
    void StartPeriodicUpdateBatch(
      IIterable<Uri> tileContents,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);
  }
}
