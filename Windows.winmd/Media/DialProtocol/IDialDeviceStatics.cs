// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ExclusiveTo(typeof (DialDevice))]
  [Guid(2859060373, 504, 18264, 132, 97, 43, 189, 28, 220, 60, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDialDeviceStatics
  {
    string GetDeviceSelector(string appName);

    [RemoteAsync]
    IAsyncOperation<DialDevice> FromIdAsync(string value);

    [RemoteAsync]
    IAsyncOperation<bool> DeviceInfoSupportsDialAsync(DeviceInformation device);
  }
}
