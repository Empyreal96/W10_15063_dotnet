// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IHttpMapTileDataSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1404350727, 34012, 17041, 137, 248, 109, 11, 182, 18, 160, 85)]
  [ExclusiveTo(typeof (HttpMapTileDataSource))]
  internal interface IHttpMapTileDataSourceFactory
  {
    HttpMapTileDataSource CreateInstance(object outer, out object inner);

    HttpMapTileDataSource CreateInstanceWithUriFormatString(
      string uriFormatString,
      object outer,
      out object inner);
  }
}
