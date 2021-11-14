// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristic3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1060922942, 37844, 16491, 184, 23, 219, 129, 248, 237, 83, 179)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattCharacteristic))]
  internal interface IGattCharacteristic3
  {
    [RemoteAsync]
    [Overload("GetDescriptorsAsync")]
    IAsyncOperation<GattDescriptorsResult> GetDescriptorsAsync();

    [RemoteAsync]
    [Overload("GetDescriptorsWithCacheModeAsync")]
    IAsyncOperation<GattDescriptorsResult> GetDescriptorsAsync(
      BluetoothCacheMode cacheMode);

    [Overload("GetDescriptorsForUuidAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDescriptorsResult> GetDescriptorsForUuidAsync(
      Guid descriptorUuid);

    [Overload("GetDescriptorsForUuidWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDescriptorsResult> GetDescriptorsForUuidAsync(
      Guid descriptorUuid,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("WriteValueWithResultAsync")]
    IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value);

    [RemoteAsync]
    [Overload("WriteValueWithResultAndOptionAsync")]
    IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value,
      GattWriteOption writeOption);

    [RemoteAsync]
    IAsyncOperation<GattWriteResult> WriteClientCharacteristicConfigurationDescriptorWithResultAsync(
      GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue);
  }
}
