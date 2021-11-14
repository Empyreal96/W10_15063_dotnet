// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectInformationElementStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectInformationElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3687853846, 4517, 20064, 140, 170, 52, 119, 33, 72, 55, 138)]
  internal interface IWiFiDirectInformationElementStatics
  {
    IVector<WiFiDirectInformationElement> CreateFromBuffer(
      IBuffer buffer);

    IVector<WiFiDirectInformationElement> CreateFromDeviceInformation(
      DeviceInformation deviceInformation);
  }
}
