// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.BadgeUpdateManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class BadgeUpdateManagerForUser : IBadgeUpdateManagerForUser
  {
    [Overload("CreateBadgeUpdaterForApplication")]
    [MethodImpl]
    public extern BadgeUpdater CreateBadgeUpdaterForApplication();

    [Overload("CreateBadgeUpdaterForApplicationWithId")]
    [MethodImpl]
    public extern BadgeUpdater CreateBadgeUpdaterForApplication(string applicationId);

    [MethodImpl]
    public extern BadgeUpdater CreateBadgeUpdaterForSecondaryTile(string tileId);

    public extern User User { [MethodImpl] get; }
  }
}
