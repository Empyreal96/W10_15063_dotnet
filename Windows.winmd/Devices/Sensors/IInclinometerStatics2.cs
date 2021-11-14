// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(71276405, 27166, 18844, 134, 224, 99, 140, 26, 134, 75, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Inclinometer))]
  internal interface IInclinometerStatics2
  {
    Inclinometer GetDefaultForRelativeReadings();
  }
}
