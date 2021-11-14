// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapBillboard
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(378807709, 2786, 20290, 160, 46, 41, 44, 168, 53, 211, 157)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapBillboard))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMapBillboard
  {
    Geopoint Location { get; set; }

    Point NormalizedAnchorPoint { get; set; }

    IRandomAccessStreamReference Image { get; set; }

    MapElementCollisionBehavior CollisionBehaviorDesired { get; set; }

    MapCamera ReferenceCamera { get; }
  }
}
