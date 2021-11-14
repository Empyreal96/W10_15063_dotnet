// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Preview.GamesEnumeration.GameList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Preview.GamesEnumeration
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGameListStatics), 65536, "Windows.Gaming.Preview.GamesEnumerationContract")]
  [ContractVersion(typeof (GamesEnumerationContract), 65536)]
  public static class GameList
  {
    [Overload("FindAllAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<GameListEntry>> FindAllAsync();

    [RemoteAsync]
    [Overload("FindAllAsyncPackageFamilyName")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<GameListEntry>> FindAllAsync(
      string packageFamilyName);

    public static extern event GameListChangedEventHandler GameAdded;

    public static extern event GameListRemovedEventHandler GameRemoved;

    public static extern event GameListChangedEventHandler GameUpdated;
  }
}
