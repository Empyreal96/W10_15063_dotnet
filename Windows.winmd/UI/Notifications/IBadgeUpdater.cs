// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (BadgeUpdater))]
  [Guid(3053068244, 30050, 20332, 191, 163, 27, 110, 210, 229, 127, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBadgeUpdater
  {
    void Update(BadgeNotification notification);

    void Clear();

    [Overload("StartPeriodicUpdate")]
    void StartPeriodicUpdate(Uri badgeContent, PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    void StartPeriodicUpdate(
      Uri badgeContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    void StopPeriodicUpdate();
  }
}
