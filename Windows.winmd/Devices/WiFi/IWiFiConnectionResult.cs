// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiConnectionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  [ExclusiveTo(typeof (WiFiConnectionResult))]
  [Guid(339468249, 50045, 16574, 165, 200, 133, 123, 206, 133, 169, 49)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiConnectionResult
  {
    WiFiConnectionStatus ConnectionStatus { get; }
  }
}
