// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileDataSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapTileDataSource))]
  [Guid(2744258493, 58438, 17992, 167, 77, 253, 44, 93, 85, 124, 6)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapTileDataSourceFactory
  {
    MapTileDataSource CreateInstance(object outer, out object inner);
  }
}
