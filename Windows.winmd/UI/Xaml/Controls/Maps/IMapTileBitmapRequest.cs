// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileBitmapRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapTileBitmapRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1181958076, 55453, 18219, 181, 246, 215, 6, 107, 5, 132, 244)]
  internal interface IMapTileBitmapRequest
  {
    IRandomAccessStreamReference PixelData { get; set; }

    MapTileBitmapRequestDeferral GetDeferral();
  }
}
