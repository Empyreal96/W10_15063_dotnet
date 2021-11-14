// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4063151441, 39984, 17722, 139, 73, 60, 62, 235, 51, 203, 97)]
  [ExclusiveTo(typeof (Inclinometer))]
  internal interface IInclinometerStatics
  {
    Inclinometer GetDefault();
  }
}
