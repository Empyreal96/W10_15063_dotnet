// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1506496705, 22836, 20328, 161, 152, 235, 134, 79, 164, 78, 107)]
  [ExclusiveTo(typeof (GattCharacteristic))]
  internal interface IGattCharacteristic
  {
    [Deprecated("Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IVectorView<GattDescriptor> GetDescriptors(Guid descriptorUuid);

    GattCharacteristicProperties CharacteristicProperties { get; }

    GattProtectionLevel ProtectionLevel { get; set; }

    string UserDescription { get; }

    Guid Uuid { get; }

    ushort AttributeHandle { get; }

    IVectorView<GattPresentationFormat> PresentationFormats { get; }

    [Overload("ReadValueAsync")]
    [RemoteAsync]
    IAsyncOperation<GattReadResult> ReadValueAsync();

    [RemoteAsync]
    [Overload("ReadValueWithCacheModeAsync")]
    IAsyncOperation<GattReadResult> ReadValueAsync(
      BluetoothCacheMode cacheMode);

    [Overload("WriteValueAsync")]
    [RemoteAsync]
    IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value);

    [RemoteAsync]
    [Overload("WriteValueWithOptionAsync")]
    IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value,
      GattWriteOption writeOption);

    [RemoteAsync]
    IAsyncOperation<GattReadClientCharacteristicConfigurationDescriptorResult> ReadClientCharacteristicConfigurationDescriptorAsync();

    [RemoteAsync]
    IAsyncOperation<GattCommunicationStatus> WriteClientCharacteristicConfigurationDescriptorAsync(
      GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue);

    event TypedEventHandler<GattCharacteristic, GattValueChangedEventArgs> ValueChanged;
  }
}
