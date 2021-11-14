// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Static(typeof (IGattServiceProviderStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class GattServiceProvider : IGattServiceProvider
  {
    public extern GattLocalService Service { [MethodImpl] get; }

    public extern GattServiceProviderAdvertisementStatus AdvertisementStatus { [MethodImpl] get; }

    public extern event TypedEventHandler<GattServiceProvider, GattServiceProviderAdvertisementStatusChangedEventArgs> AdvertisementStatusChanged;

    [Overload("StartAdvertising")]
    [MethodImpl]
    public extern void StartAdvertising();

    [Overload("StartAdvertisingWithParameters")]
    [MethodImpl]
    public extern void StartAdvertising(
      GattServiceProviderAdvertisingParameters parameters);

    [MethodImpl]
    public extern void StopAdvertising();

    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GattServiceProviderResult> CreateAsync(
      Guid serviceUuid);
  }
}
