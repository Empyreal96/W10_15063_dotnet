// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerReadingYawAccuracy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3025397888, 8163, 18822, 162, 87, 230, 236, 226, 114, 57, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InclinometerReading))]
  internal interface IInclinometerReadingYawAccuracy
  {
    MagnetometerAccuracy YawAccuracy { get; }
  }
}
