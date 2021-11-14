// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattDescriptor))]
  [Guid(2449825579, 32900, 17220, 180, 194, 40, 77, 225, 154, 133, 6)]
  internal interface IGattDescriptor
  {
    GattProtectionLevel ProtectionLevel { get; set; }

    Guid Uuid { get; }

    ushort AttributeHandle { get; }

    [Overload("ReadValueAsync")]
    [RemoteAsync]
    IAsyncOperation<GattReadResult> ReadValueAsync();

    [Overload("ReadValueWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattReadResult> ReadValueAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value);
  }
}
