// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Preview.GamesEnumeration.GameListEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Preview.GamesEnumeration
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (GamesEnumerationContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class GameListEntry : IGameListEntry
  {
    public extern AppDisplayInfo DisplayInfo { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> LaunchAsync();

    public extern GameListCategory Category { [MethodImpl] get; }

    public extern IMapView<string, object> Properties { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetCategoryAsync(GameListCategory value);
  }
}
