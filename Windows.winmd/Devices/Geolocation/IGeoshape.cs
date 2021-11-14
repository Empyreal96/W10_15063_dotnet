// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoshape
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3382485679, 50985, 17345, 143, 171, 214, 222, 201, 20, 223, 126)]
  public interface IGeoshape
  {
    GeoshapeType GeoshapeType { get; }

    uint SpatialReferenceId { get; }

    AltitudeReferenceSystem AltitudeReferenceSystem { get; }
  }
}
