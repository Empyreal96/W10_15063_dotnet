// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadClientCharacteristicConfigurationDescriptorResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(468821405, 47693, 17954, 134, 81, 244, 238, 21, 13, 10, 93)]
  [ExclusiveTo(typeof (GattReadClientCharacteristicConfigurationDescriptorResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattReadClientCharacteristicConfigurationDescriptorResult2
  {
    IReference<byte> ProtocolError { get; }
  }
}
