// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.BadgeUpdateManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [Muse(Version = 100794368)]
  [Static(typeof (IBadgeUpdateManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBadgeUpdateManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class BadgeUpdateManager
  {
    [MethodImpl]
    public static extern BadgeUpdateManagerForUser GetForUser(User user);

    [Overload("CreateBadgeUpdaterForApplication")]
    [MethodImpl]
    public static extern BadgeUpdater CreateBadgeUpdaterForApplication();

    [Overload("CreateBadgeUpdaterForApplicationWithId")]
    [MethodImpl]
    public static extern BadgeUpdater CreateBadgeUpdaterForApplication(
      string applicationId);

    [MethodImpl]
    public static extern BadgeUpdater CreateBadgeUpdaterForSecondaryTile(string tileId);

    [MethodImpl]
    public static extern XmlDocument GetTemplateContent(BadgeTemplateType type);
  }
}
