// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElementPointerExitedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapElementPointerExitedEventArgs))]
  [Guid(3248773881, 24777, 18041, 145, 25, 32, 171, 199, 93, 147, 31)]
  [WebHostHidden]
  internal interface IMapElementPointerExitedEventArgs
  {
    Point Position { get; }

    Geopoint Location { get; }

    MapElement MapElement { get; }
  }
}
