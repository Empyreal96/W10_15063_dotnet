// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectLegacySettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFiDirect
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiDirectLegacySettings : IWiFiDirectLegacySettings
  {
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string Ssid { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential Passphrase { [MethodImpl] get; [MethodImpl] set; }
  }
}
