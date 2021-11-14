// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4048987704, 31127, 18649, 161, 12, 38, 157, 70, 83, 63, 72)]
  [ExclusiveTo(typeof (DeviceInformation))]
  internal interface IDeviceInformation2
  {
    DeviceInformationKind Kind { get; }

    DeviceInformationPairing Pairing { get; }
  }
}
