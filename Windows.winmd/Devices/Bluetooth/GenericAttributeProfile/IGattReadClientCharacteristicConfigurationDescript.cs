// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadClientCharacteristicConfigurationDescriptorResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReadClientCharacteristicConfigurationDescriptorResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1671851785, 6890, 19532, 165, 15, 151, 186, 228, 116, 179, 72)]
  internal interface IGattReadClientCharacteristicConfigurationDescriptorResult
  {
    GattCommunicationStatus Status { get; }

    GattClientCharacteristicConfigurationDescriptorValue ClientCharacteristicConfigurationDescriptor { get; }
  }
}
