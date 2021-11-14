// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiAdapterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  [ExclusiveTo(typeof (WiFiAdapter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3659922909, 53836, 17379, 170, 189, 196, 101, 159, 115, 15, 153)]
  internal interface IWiFiAdapterStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<WiFiAdapter>> FindAllAdaptersAsync();

    string GetDeviceSelector();

    [RemoteAsync]
    [Overload("FromIdAsync")]
    IAsyncOperation<WiFiAdapter> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<WiFiAccessStatus> RequestAccessAsync();
  }
}
