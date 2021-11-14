// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IStreetsidePanorama
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(1876955096, 44384, 18020, 181, 57, 177, 6, 159, 22, 197, 175)]
  [WebHostHidden]
  [ExclusiveTo(typeof (StreetsidePanorama))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreetsidePanorama
  {
    Geopoint Location { get; }
  }
}
