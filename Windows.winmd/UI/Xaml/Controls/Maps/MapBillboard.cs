// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapBillboard
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IMapBillboardStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IMapBillboardFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class MapBillboard : MapElement, IMapBillboard
  {
    [MethodImpl]
    public extern MapBillboard(MapCamera camera);

    public extern Geopoint Location { [MethodImpl] get; [MethodImpl] set; }

    public extern Point NormalizedAnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Image { [MethodImpl] get; [MethodImpl] set; }

    public extern MapElementCollisionBehavior CollisionBehaviorDesired { [MethodImpl] get; [MethodImpl] set; }

    public extern MapCamera ReferenceCamera { [MethodImpl] get; }

    public static extern DependencyProperty LocationProperty { [MethodImpl] get; }

    public static extern DependencyProperty NormalizedAnchorPointProperty { [MethodImpl] get; }

    public static extern DependencyProperty CollisionBehaviorDesiredProperty { [MethodImpl] get; }
  }
}
