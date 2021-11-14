// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionParametersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1502278803, 30274, 17775, 185, 216, 232, 169, 235, 31, 64, 26)]
  [ExclusiveTo(typeof (WiFiDirectConnectionParameters))]
  internal interface IWiFiDirectConnectionParametersStatics
  {
    DevicePairingKinds GetDevicePairingKinds(
      WiFiDirectConfigurationMethod configurationMethod);
  }
}
