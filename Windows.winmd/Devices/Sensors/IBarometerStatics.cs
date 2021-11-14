// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IBarometerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Barometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(678110986, 739, 20358, 132, 252, 253, 216, 146, 181, 148, 15)]
  internal interface IBarometerStatics
  {
    Barometer GetDefault();
  }
}
