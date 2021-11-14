// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileUriRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3239554528, 48958, 19537, 143, 170, 75, 89, 60, 246, 142, 178)]
  [ExclusiveTo(typeof (MapTileUriRequestDeferral))]
  [WebHostHidden]
  internal interface IMapTileUriRequestDeferral
  {
    void Complete();
  }
}
