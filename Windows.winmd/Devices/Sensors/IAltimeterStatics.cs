// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAltimeterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Altimeter))]
  [Guid(2662651843, 58796, 18382, 142, 239, 211, 113, 129, 104, 192, 31)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAltimeterStatics
  {
    Altimeter GetDefault();
  }
}
