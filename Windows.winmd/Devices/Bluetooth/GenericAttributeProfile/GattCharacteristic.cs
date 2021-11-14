// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Static(typeof (IGattCharacteristicStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattCharacteristic : 
    IGattCharacteristic,
    IGattCharacteristic2,
    IGattCharacteristic3
  {
    [Deprecated("Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattDescriptor> GetDescriptors(
      Guid descriptorUuid);

    public extern GattCharacteristicProperties CharacteristicProperties { [MethodImpl] get; }

    public extern GattProtectionLevel ProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    public extern string UserDescription { [MethodImpl] get; }

    public extern Guid Uuid { [MethodImpl] get; }

    public extern ushort AttributeHandle { [MethodImpl] get; }

    public extern IVectorView<GattPresentationFormat> PresentationFormats { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("ReadValueAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattReadResult> ReadValueAsync();

    [RemoteAsync]
    [Overload("ReadValueWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattReadResult> ReadValueAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("WriteValueAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value);

    [RemoteAsync]
    [Overload("WriteValueWithOptionAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value,
      GattWriteOption writeOption);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattReadClientCharacteristicConfigurationDescriptorResult> ReadClientCharacteristicConfigurationDescriptorAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> WriteClientCharacteristicConfigurationDescriptorAsync(
      GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue);

    public extern event TypedEventHandler<GattCharacteristic, GattValueChangedEventArgs> ValueChanged;

    public extern GattDeviceService Service { [MethodImpl] get; }

    [Deprecated("Use GetDescriptorsAsync instead of GetAllDescriptors.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattDescriptor> GetAllDescriptors();

    [RemoteAsync]
    [Overload("GetDescriptorsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDescriptorsResult> GetDescriptorsAsync();

    [Overload("GetDescriptorsWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattDescriptorsResult> GetDescriptorsAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetDescriptorsForUuidAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDescriptorsResult> GetDescriptorsForUuidAsync(
      Guid descriptorUuid);

    [RemoteAsync]
    [Overload("GetDescriptorsForUuidWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDescriptorsResult> GetDescriptorsForUuidAsync(
      Guid descriptorUuid,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("WriteValueWithResultAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value);

    [RemoteAsync]
    [Overload("WriteValueWithResultAndOptionAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value,
      GattWriteOption writeOption);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> WriteClientCharacteristicConfigurationDescriptorWithResultAsync(
      GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue);

    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern Guid ConvertShortIdToUuid(ushort shortId);
  }
}
