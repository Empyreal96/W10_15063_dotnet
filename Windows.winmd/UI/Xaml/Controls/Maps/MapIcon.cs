// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapIcon
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
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapIconStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapIconStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapIcon : MapElement, IMapIcon, IMapIcon2
  {
    [MethodImpl]
    public extern MapIcon();

    public extern Geopoint Location { [MethodImpl] get; [MethodImpl] set; }

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern Point NormalizedAnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Image { [MethodImpl] get; [MethodImpl] set; }

    public extern MapElementCollisionBehavior CollisionBehaviorDesired { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty CollisionBehaviorDesiredProperty { [MethodImpl] get; }

    public static extern DependencyProperty LocationProperty { [MethodImpl] get; }

    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    public static extern DependencyProperty NormalizedAnchorPointProperty { [MethodImpl] get; }
  }
}
