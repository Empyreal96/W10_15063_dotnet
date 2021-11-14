// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IHttpMapTileDataSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class HttpMapTileDataSource : MapTileDataSource, IHttpMapTileDataSource
  {
    [MethodImpl]
    public extern HttpMapTileDataSource();

    [MethodImpl]
    public extern HttpMapTileDataSource(string uriFormatString);

    public extern string UriFormatString { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, string> AdditionalRequestHeaders { [MethodImpl] get; }

    public extern bool AllowCaching { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<HttpMapTileDataSource, MapTileUriRequestedEventArgs> UriRequested;
  }
}
