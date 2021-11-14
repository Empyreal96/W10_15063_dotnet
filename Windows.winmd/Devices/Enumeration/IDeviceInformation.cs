// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(2879454101, 17304, 18589, 142, 68, 230, 19, 9, 39, 1, 31)]
  [ExclusiveTo(typeof (DeviceInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceInformation
  {
    string Id { get; }

    string Name { get; }

    bool IsEnabled { get; }

    bool IsDefault { get; }

    EnclosureLocation EnclosureLocation { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }

    void Update(DeviceInformationUpdate updateInfo);

    [RemoteAsync]
    IAsyncOperation<DeviceThumbnail> GetThumbnailAsync();

    [RemoteAsync]
    IAsyncOperation<DeviceThumbnail> GetGlyphThumbnailAsync();
  }
}
