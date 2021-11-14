// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceUnpairingResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceUnpairingResult))]
  [Guid(1727285971, 31193, 17483, 146, 207, 169, 46, 247, 37, 113, 199)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IDeviceUnpairingResult
  {
    DeviceUnpairingResultStatus Status { get; }
  }
}
