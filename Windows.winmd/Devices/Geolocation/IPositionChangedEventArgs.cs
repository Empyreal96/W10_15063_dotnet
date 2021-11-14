// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IPositionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PositionChangedEventArgs))]
  [Guid(931503333, 40222, 18117, 191, 59, 106, 216, 202, 193, 160, 147)]
  internal interface IPositionChangedEventArgs
  {
    Geoposition Position { get; }
  }
}
