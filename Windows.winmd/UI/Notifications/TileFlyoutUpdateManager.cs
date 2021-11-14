// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileFlyoutUpdateManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (ITileFlyoutUpdateManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class TileFlyoutUpdateManager
  {
    [Overload("CreateTileFlyoutUpdaterForApplication")]
    [MethodImpl]
    public static extern TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication();

    [Overload("CreateTileFlyoutUpdaterForApplicationWithId")]
    [MethodImpl]
    public static extern TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication(
      string applicationId);

    [MethodImpl]
    public static extern TileFlyoutUpdater CreateTileFlyoutUpdaterForSecondaryTile(
      string tileId);

    [MethodImpl]
    public static extern XmlDocument GetTemplateContent(TileFlyoutTemplateType type);
  }
}
