// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Preview.GamesEnumeration.IGameListStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Preview.GamesEnumeration
{
  [ExclusiveTo(typeof (GameList))]
  [ContractVersion(typeof (GamesEnumerationContract), 65536)]
  [Guid(769462127, 40038, 19205, 148, 92, 214, 237, 120, 73, 27, 140)]
  internal interface IGameListStatics
  {
    [RemoteAsync]
    [Overload("FindAllAsync")]
    IAsyncOperation<IVectorView<GameListEntry>> FindAllAsync();

    [Overload("FindAllAsyncPackageFamilyName")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<GameListEntry>> FindAllAsync(
      string packageFamilyName);

    event GameListChangedEventHandler GameAdded;

    event GameListRemovedEventHandler GameRemoved;

    event GameListChangedEventHandler GameUpdated;
  }
}
