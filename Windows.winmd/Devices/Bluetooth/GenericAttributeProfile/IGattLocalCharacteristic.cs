// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalCharacteristic
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
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2933798765, 21522, 19828, 146, 168, 141, 235, 133, 38, 130, 156)]
  [ExclusiveTo(typeof (GattLocalCharacteristic))]
  internal interface IGattLocalCharacteristic
  {
    Guid Uuid { get; }

    IBuffer StaticValue { get; }

    GattCharacteristicProperties CharacteristicProperties { get; }

    GattProtectionLevel ReadProtectionLevel { get; }

    GattProtectionLevel WriteProtectionLevel { get; }

    [RemoteAsync]
    IAsyncOperation<GattLocalDescriptorResult> CreateDescriptorAsync(
      Guid descriptorUuid,
      GattLocalDescriptorParameters parameters);

    IVectorView<GattLocalDescriptor> Descriptors { get; }

    string UserDescription { get; }

    IVectorView<GattPresentationFormat> PresentationFormats { get; }

    IVectorView<GattSubscribedClient> SubscribedClients { get; }

    event TypedEventHandler<GattLocalCharacteristic, object> SubscribedClientsChanged;

    event TypedEventHandler<GattLocalCharacteristic, GattReadRequestedEventArgs> ReadRequested;

    event TypedEventHandler<GattLocalCharacteristic, GattWriteRequestedEventArgs> WriteRequested;

    [Overload("NotifyValueAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<GattClientNotificationResult>> NotifyValueAsync(
      IBuffer value);

    [RemoteAsync]
    [Overload("NotifyValueForSubscribedClientAsync")]
    IAsyncOperation<GattClientNotificationResult> NotifyValueAsync(
      IBuffer value,
      GattSubscribedClient subscribedClient);
  }
}
