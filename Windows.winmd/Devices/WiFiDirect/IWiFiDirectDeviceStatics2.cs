// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectDeviceStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Guid(445988425, 45315, 17278, 146, 38, 171, 103, 151, 19, 66, 249)]
  [ExclusiveTo(typeof (WiFiDirectDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectDeviceStatics2
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector(WiFiDirectDeviceSelectorType type);

    [Overload("FromIdAsync")]
    IAsyncOperation<WiFiDirectDevice> FromIdAsync(
      string deviceId,
      WiFiDirectConnectionParameters connectionParameters);
  }
}
