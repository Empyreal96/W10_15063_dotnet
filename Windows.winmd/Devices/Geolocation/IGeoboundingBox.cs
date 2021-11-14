// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoboundingBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (GeoboundingBox))]
  [Guid(144099339, 10063, 17370, 154, 6, 203, 252, 218, 235, 78, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeoboundingBox : IGeoshape
  {
    BasicGeoposition NorthwestCorner { get; }

    BasicGeoposition SoutheastCorner { get; }

    BasicGeoposition Center { get; }

    double MinAltitude { get; }

    double MaxAltitude { get; }
  }
}
