// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileUpdateManager
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
  [Threading(ThreadingModel.MTA)]
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ITileUpdateManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITileUpdateManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class TileUpdateManager
  {
    [MethodImpl]
    public static extern TileUpdateManagerForUser GetForUser(User user);

    [Overload("CreateTileUpdaterForApplication")]
    [MethodImpl]
    public static extern TileUpdater CreateTileUpdaterForApplication();

    [Overload("CreateTileUpdaterForApplicationWithId")]
    [MethodImpl]
    public static extern TileUpdater CreateTileUpdaterForApplication(string applicationId);

    [MethodImpl]
    public static extern TileUpdater CreateTileUpdaterForSecondaryTile(string tileId);

    [MethodImpl]
    public static extern XmlDocument GetTemplateContent(TileTemplateType type);
  }
}
