// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Pedometer))]
  [Guid(3852732127, 11137, 19165, 178, 255, 119, 171, 108, 152, 186, 25)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IPedometer2
  {
    IMapView<PedometerStepKind, PedometerReading> GetCurrentReadings();
  }
}
