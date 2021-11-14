// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceSessionRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  [Guid(1958595601, 21462, 18841, 180, 248, 108, 142, 204, 23, 113, 231)]
  [ExclusiveTo(typeof (WiFiDirectServiceSessionRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectServiceSessionRequestedEventArgs
  {
    WiFiDirectServiceSessionRequest GetSessionRequest();
  }
}
