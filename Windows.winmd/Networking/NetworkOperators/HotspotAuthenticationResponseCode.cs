// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.HotspotAuthenticationResponseCode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HotspotAuthenticationResponseCode
  {
    NoError = 0,
    LoginSucceeded = 50, // 0x00000032
    LoginFailed = 100, // 0x00000064
    RadiusServerError = 102, // 0x00000066
    NetworkAdministratorError = 105, // 0x00000069
    LoginAborted = 151, // 0x00000097
    AccessGatewayInternalError = 255, // 0x000000FF
  }
}
