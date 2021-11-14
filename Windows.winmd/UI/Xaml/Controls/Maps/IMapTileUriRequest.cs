// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileUriRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(390079285, 12583, 17848, 135, 167, 153, 248, 125, 78, 39, 69)]
  [ExclusiveTo(typeof (MapTileUriRequest))]
  internal interface IMapTileUriRequest
  {
    Uri Uri { get; set; }

    MapTileUriRequestDeferral GetDeferral();
  }
}
