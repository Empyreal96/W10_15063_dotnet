// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2235327692, 1688, 19930, 166, 223, 156, 185, 204, 74, 180, 10)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Magnetometer))]
  internal interface IMagnetometerStatics
  {
    Magnetometer GetDefault();
  }
}
