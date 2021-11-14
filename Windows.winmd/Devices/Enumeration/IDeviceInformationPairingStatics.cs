// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationPairingStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceInformationPairing))]
  [Guid(3910517768, 14036, 18849, 191, 19, 81, 65, 115, 121, 155, 107)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IDeviceInformationPairingStatics
  {
    bool TryRegisterForAllInboundPairingRequests(DevicePairingKinds pairingKindsSupported);
  }
}
