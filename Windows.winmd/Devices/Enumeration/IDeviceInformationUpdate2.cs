// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationUpdate2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1570575500, 43123, 18526, 186, 166, 170, 98, 7, 136, 227, 204)]
  [ExclusiveTo(typeof (DeviceInformationUpdate))]
  internal interface IDeviceInformationUpdate2
  {
    DeviceInformationKind Kind { get; }
  }
}
