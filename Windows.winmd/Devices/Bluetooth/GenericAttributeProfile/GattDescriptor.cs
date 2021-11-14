// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGattDescriptorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattDescriptor : IGattDescriptor, IGattDescriptor2
  {
    public extern GattProtectionLevel ProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid Uuid { [MethodImpl] get; }

    public extern ushort AttributeHandle { [MethodImpl] get; }

    [Overload("ReadValueAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattReadResult> ReadValueAsync();

    [RemoteAsync]
    [Overload("ReadValueWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattReadResult> ReadValueAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value);

    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern Guid ConvertShortIdToUuid(ushort shortId);
  }
}
