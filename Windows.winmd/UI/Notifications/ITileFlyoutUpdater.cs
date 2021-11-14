// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileFlyoutUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TileFlyoutUpdater))]
  [Guid(2369832810, 50277, 16466, 167, 64, 92, 38, 84, 193, 160, 137)]
  internal interface ITileFlyoutUpdater
  {
    void Update(TileFlyoutNotification notification);

    void Clear();

    [Overload("StartPeriodicUpdate")]
    void StartPeriodicUpdate(Uri tileFlyoutContent, PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    void StartPeriodicUpdate(
      Uri tileFlyoutContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    void StopPeriodicUpdate();

    NotificationSetting Setting { get; }
  }
}
