// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.BadgeUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  public sealed class BadgeUpdater : IBadgeUpdater
  {
    [MethodImpl]
    public extern void Update(BadgeNotification notification);

    [MethodImpl]
    public extern void Clear();

    [Overload("StartPeriodicUpdate")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri badgeContent,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri badgeContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    [MethodImpl]
    public extern void StopPeriodicUpdate();
  }
}
