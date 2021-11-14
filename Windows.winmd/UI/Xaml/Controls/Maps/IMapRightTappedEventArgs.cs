// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapRightTappedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRightTappedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(546582897, 28648, 16550, 173, 14, 41, 115, 121, 181, 117, 167)]
  internal interface IMapRightTappedEventArgs
  {
    Point Position { get; }

    Geopoint Location { get; }
  }
}
