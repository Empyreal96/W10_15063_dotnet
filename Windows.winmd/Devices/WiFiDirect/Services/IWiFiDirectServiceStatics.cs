// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  [Guid(2108948549, 64884, 18056, 183, 37, 93, 206, 134, 172, 242, 51)]
  [ExclusiveTo(typeof (WiFiDirectService))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectServiceStatics
  {
    [Overload("GetSelector")]
    string GetSelector(string serviceName);

    [Overload("GetSelectorWithFilter")]
    string GetSelector(string serviceName, IBuffer serviceInfoFilter);

    [RemoteAsync]
    IAsyncOperation<WiFiDirectService> FromIdAsync(string deviceId);
  }
}
