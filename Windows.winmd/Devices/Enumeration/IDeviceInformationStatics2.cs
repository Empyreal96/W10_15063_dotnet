// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1228623668, 43087, 17917, 145, 103, 21, 209, 203, 27, 209, 249)]
  [ExclusiveTo(typeof (DeviceInformation))]
  internal interface IDeviceInformationStatics2
  {
    string GetAqsFilterFromDeviceClass(DeviceClass deviceClass);

    [Overload("CreateFromIdAsyncWithKindAndAdditionalProperties")]
    IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("FindAllAsyncWithKindAqsFilterAndAdditionalProperties")]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("CreateWatcherWithKindAqsFilterAndAdditionalProperties")]
    DeviceWatcher CreateWatcher(
      string aqsFilter,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);
  }
}
