// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileUpdateManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class TileUpdateManagerForUser : ITileUpdateManagerForUser
  {
    [Overload("CreateTileUpdaterForApplication")]
    [MethodImpl]
    public extern TileUpdater CreateTileUpdaterForApplicationForUser();

    [Overload("CreateTileUpdaterForApplicationWithId")]
    [MethodImpl]
    public extern TileUpdater CreateTileUpdaterForApplication(string applicationId);

    [MethodImpl]
    public extern TileUpdater CreateTileUpdaterForSecondaryTile(string tileId);

    public extern User User { [MethodImpl] get; }
  }
}
