// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Preview.GamesEnumeration.IGameListEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Preview.GamesEnumeration
{
  [Guid(1935221971, 33055, 17556, 182, 156, 198, 65, 160, 198, 21, 67)]
  [ContractVersion(typeof (GamesEnumerationContract), 65536)]
  public interface IGameListEntry
  {
    AppDisplayInfo DisplayInfo { get; }

    [RemoteAsync]
    IAsyncOperation<bool> LaunchAsync();

    GameListCategory Category { get; }

    IMapView<string, object> Properties { get; }

    [RemoteAsync]
    IAsyncAction SetCategoryAsync(GameListCategory value);
  }
}
