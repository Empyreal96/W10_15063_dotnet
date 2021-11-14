// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceAdvertiserFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceAdvertiser))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(822520845, 46150, 20243, 159, 154, 138, 233, 37, 254, 186, 43)]
  internal interface IWiFiDirectServiceAdvertiserFactory
  {
    WiFiDirectServiceAdvertiser CreateWiFiDirectServiceAdvertiser(
      string serviceName);
  }
}
