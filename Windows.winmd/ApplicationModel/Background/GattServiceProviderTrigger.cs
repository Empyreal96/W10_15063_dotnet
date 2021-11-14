// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.GattServiceProviderTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGattServiceProviderTriggerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattServiceProviderTrigger : IBackgroundTrigger, IGattServiceProviderTrigger
  {
    public extern string TriggerId { [MethodImpl] get; }

    public extern GattLocalService Service { [MethodImpl] get; }

    public extern GattServiceProviderAdvertisingParameters AdvertisingParameters { [MethodImpl] set; [MethodImpl] get; }

    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GattServiceProviderTriggerResult> CreateAsync(
      string triggerId,
      Guid serviceUuid);
  }
}
