// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectLegacySettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFiDirect
{
  [Guid(2790251450, 62205, 17767, 169, 27, 245, 194, 245, 50, 16, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectLegacySettings))]
  internal interface IWiFiDirectLegacySettings
  {
    bool IsEnabled { get; set; }

    string Ssid { get; set; }

    PasswordCredential Passphrase { get; set; }
  }
}
