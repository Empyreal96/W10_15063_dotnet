// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2209802185, 58525, 19257, 134, 230, 205, 85, 75, 228, 197, 193)]
  [ExclusiveTo(typeof (Gyrometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGyrometerStatics
  {
    Gyrometer GetDefault();
  }
}
