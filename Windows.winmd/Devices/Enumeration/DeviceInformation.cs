// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDeviceInformationStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDeviceInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DeviceInformation : IDeviceInformation, IDeviceInformation2
  {
    public extern string Id { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; }

    public extern bool IsDefault { [MethodImpl] get; }

    public extern EnclosureLocation EnclosureLocation { [MethodImpl] get; }

    public extern IMapView<string, object> Properties { [MethodImpl] [return: HasVariant] get; }

    [MethodImpl]
    public extern void Update(DeviceInformationUpdate updateInfo);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceThumbnail> GetThumbnailAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceThumbnail> GetGlyphThumbnailAsync();

    public extern DeviceInformationKind Kind { [MethodImpl] get; }

    public extern DeviceInformationPairing Pairing { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetAqsFilterFromDeviceClass(DeviceClass deviceClass);

    [Overload("CreateFromIdAsyncWithKindAndAdditionalProperties")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("FindAllAsyncWithKindAqsFilterAndAdditionalProperties")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("CreateWatcherWithKindAqsFilterAndAdditionalProperties")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher(
      string aqsFilter,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("CreateFromIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId);

    [Overload("CreateFromIdAsyncAdditionalProperties")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId,
      IIterable<string> additionalProperties);

    [Overload("FindAllAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync();

    [RemoteAsync]
    [DefaultOverload]
    [Overload("FindAllAsyncDeviceClass")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      DeviceClass deviceClass);

    [Overload("FindAllAsyncAqsFilter")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter);

    [Overload("FindAllAsyncAqsFilterAndAdditionalProperties")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter,
      IIterable<string> additionalProperties);

    [Overload("CreateWatcher")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher();

    [DefaultOverload]
    [Overload("CreateWatcherDeviceClass")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher(DeviceClass deviceClass);

    [Overload("CreateWatcherAqsFilter")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher(string aqsFilter);

    [Overload("CreateWatcherAqsFilterAndAdditionalProperties")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher(
      string aqsFilter,
      IIterable<string> additionalProperties);
  }
}
