// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdateManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (TileUpdateManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1427379016, 12002, 20013, 156, 193, 33, 106, 32, 222, 204, 159)]
  internal interface ITileUpdateManagerForUser
  {
    [Overload("CreateTileUpdaterForApplication")]
    TileUpdater CreateTileUpdaterForApplicationForUser();

    [Overload("CreateTileUpdaterForApplicationWithId")]
    TileUpdater CreateTileUpdaterForApplication(string applicationId);

    TileUpdater CreateTileUpdaterForSecondaryTile(string tileId);

    User User { get; }
  }
}
