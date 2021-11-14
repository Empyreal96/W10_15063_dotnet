// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectDevice))]
  [Guid(3899438460, 15020, 18513, 167, 146, 72, 42, 175, 147, 27, 4)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("FromIdAsync")]
    [RemoteAsync]
    IAsyncOperation<WiFiDirectDevice> FromIdAsync(string deviceId);
  }
}
