// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceSessionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceSessionRequest))]
  [Guid(2699197579, 20683, 19032, 155, 207, 228, 114, 185, 159, 186, 4)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectServiceSessionRequest : IClosable
  {
    DeviceInformation DeviceInformation { get; }

    WiFiDirectServiceProvisioningInfo ProvisioningInfo { get; }

    IBuffer SessionInfo { get; }
  }
}
