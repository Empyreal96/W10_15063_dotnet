// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapIcon))]
  [WebHostHidden]
  [Guid(3523831922, 9177, 18987, 139, 224, 105, 243, 168, 84, 130, 171)]
  internal interface IMapIcon
  {
    Geopoint Location { get; set; }

    string Title { get; set; }

    Point NormalizedAnchorPoint { get; set; }

    IRandomAccessStreamReference Image { get; set; }
  }
}
