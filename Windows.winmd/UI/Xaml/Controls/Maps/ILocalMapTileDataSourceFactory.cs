// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.ILocalMapTileDataSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3318737404, 29356, 18489, 138, 13, 1, 31, 36, 105, 60, 121)]
  [ExclusiveTo(typeof (LocalMapTileDataSource))]
  internal interface ILocalMapTileDataSourceFactory
  {
    LocalMapTileDataSource CreateInstance(object outer, out object inner);

    LocalMapTileDataSource CreateInstanceWithUriFormatString(
      string uriFormatString,
      object outer,
      out object inner);
  }
}
