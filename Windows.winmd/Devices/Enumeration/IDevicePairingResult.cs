// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePairingResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DevicePairingResult))]
  [Guid(120259263, 56725, 16421, 155, 55, 222, 81, 173, 186, 55, 183)]
  internal interface IDevicePairingResult
  {
    DevicePairingResultStatus Status { get; }

    DevicePairingProtectionLevel ProtectionLevelUsed { get; }
  }
}
