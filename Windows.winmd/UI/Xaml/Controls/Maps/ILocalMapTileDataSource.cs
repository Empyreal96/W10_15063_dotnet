// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.ILocalMapTileDataSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LocalMapTileDataSource))]
  [WebHostHidden]
  [Guid(1633834933, 37128, 20242, 139, 244, 187, 60, 143, 98, 116, 229)]
  internal interface ILocalMapTileDataSource
  {
    string UriFormatString { get; set; }

    event TypedEventHandler<LocalMapTileDataSource, MapTileUriRequestedEventArgs> UriRequested;
  }
}
