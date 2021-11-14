// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectConnectionRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2394527237, 37199, 18883, 166, 20, 209, 141, 197, 177, 155, 67)]
  internal interface IWiFiDirectConnectionRequest : IClosable
  {
    DeviceInformation DeviceInformation { get; }
  }
}
