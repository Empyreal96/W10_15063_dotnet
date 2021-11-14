// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(3246329870, 14918, 19064, 128, 19, 118, 157, 201, 185, 115, 144)]
  [ExclusiveTo(typeof (DeviceInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceInformationStatics
  {
    [Overload("CreateFromIdAsync")]
    [RemoteAsync]
    IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId);

    [Overload("CreateFromIdAsyncAdditionalProperties")]
    IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId,
      IIterable<string> additionalProperties);

    [Overload("FindAllAsync")]
    [RemoteAsync]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync();

    [RemoteAsync]
    [DefaultOverload]
    [Overload("FindAllAsyncDeviceClass")]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      DeviceClass deviceClass);

    [Overload("FindAllAsyncAqsFilter")]
    [RemoteAsync]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter);

    [Overload("FindAllAsyncAqsFilterAndAdditionalProperties")]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter,
      IIterable<string> additionalProperties);

    [Overload("CreateWatcher")]
    DeviceWatcher CreateWatcher();

    [Overload("CreateWatcherDeviceClass")]
    [DefaultOverload]
    DeviceWatcher CreateWatcher(DeviceClass deviceClass);

    [Overload("CreateWatcherAqsFilter")]
    DeviceWatcher CreateWatcher(string aqsFilter);

    [Overload("CreateWatcherAqsFilterAndAdditionalProperties")]
    DeviceWatcher CreateWatcher(
      string aqsFilter,
      IIterable<string> additionalProperties);
  }
}
