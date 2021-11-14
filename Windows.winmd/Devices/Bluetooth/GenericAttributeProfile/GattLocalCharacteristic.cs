// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristic
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
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattLocalCharacteristic : IGattLocalCharacteristic
  {
    public extern Guid Uuid { [MethodImpl] get; }

    public extern IBuffer StaticValue { [MethodImpl] get; }

    public extern GattCharacteristicProperties CharacteristicProperties { [MethodImpl] get; }

    public extern GattProtectionLevel ReadProtectionLevel { [MethodImpl] get; }

    public extern GattProtectionLevel WriteProtectionLevel { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattLocalDescriptorResult> CreateDescriptorAsync(
      Guid descriptorUuid,
      GattLocalDescriptorParameters parameters);

    public extern IVectorView<GattLocalDescriptor> Descriptors { [MethodImpl] get; }

    public extern string UserDescription { [MethodImpl] get; }

    public extern IVectorView<GattPresentationFormat> PresentationFormats { [MethodImpl] get; }

    public extern IVectorView<GattSubscribedClient> SubscribedClients { [MethodImpl] get; }

    public extern event TypedEventHandler<GattLocalCharacteristic, object> SubscribedClientsChanged;

    public extern event TypedEventHandler<GattLocalCharacteristic, GattReadRequestedEventArgs> ReadRequested;

    public extern event TypedEventHandler<GattLocalCharacteristic, GattWriteRequestedEventArgs> WriteRequested;

    [RemoteAsync]
    [Overload("NotifyValueAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<GattClientNotificationResult>> NotifyValueAsync(
      IBuffer value);

    [RemoteAsync]
    [Overload("NotifyValueForSubscribedClientAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattClientNotificationResult> NotifyValueAsync(
      IBuffer value,
      GattSubscribedClient subscribedClient);
  }
}
