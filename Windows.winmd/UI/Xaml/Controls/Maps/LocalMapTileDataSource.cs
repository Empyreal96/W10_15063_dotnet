// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ILocalMapTileDataSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public class LocalMapTileDataSource : MapTileDataSource, ILocalMapTileDataSource
  {
    [MethodImpl]
    public extern LocalMapTileDataSource();

    [MethodImpl]
    public extern LocalMapTileDataSource(string uriFormatString);

    public extern string UriFormatString { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<LocalMapTileDataSource, MapTileUriRequestedEventArgs> UriRequested;
  }
}
