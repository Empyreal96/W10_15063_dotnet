// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IHttpMapTileDataSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(2634271580, 64889, 18325, 135, 190, 126, 84, 202, 11, 55, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMapTileDataSource))]
  internal interface IHttpMapTileDataSource
  {
    string UriFormatString { get; set; }

    IMap<string, string> AdditionalRequestHeaders { get; }

    bool AllowCaching { get; set; }

    event TypedEventHandler<HttpMapTileDataSource, MapTileUriRequestedEventArgs> UriRequested;
  }
}
