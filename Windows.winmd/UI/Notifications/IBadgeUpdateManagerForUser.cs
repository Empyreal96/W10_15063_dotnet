// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeUpdateManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [Guid(2573935036, 902, 17637, 186, 141, 12, 16, 119, 166, 46, 146)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (BadgeUpdateManagerForUser))]
  internal interface IBadgeUpdateManagerForUser
  {
    [Overload("CreateBadgeUpdaterForApplication")]
    BadgeUpdater CreateBadgeUpdaterForApplication();

    [Overload("CreateBadgeUpdaterForApplicationWithId")]
    BadgeUpdater CreateBadgeUpdaterForApplication(string applicationId);

    BadgeUpdater CreateBadgeUpdaterForSecondaryTile(string tileId);

    User User { get; }
  }
}
