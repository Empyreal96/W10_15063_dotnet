// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketProtectionLevel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketProtectionLevel
  {
    PlainSocket,
    [Deprecated("Ssl may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Ssl,
    SslAllowNullEncryption,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BluetoothEncryptionAllowNullAuthentication,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BluetoothEncryptionWithAuthentication,
    [Deprecated("Ssl3AllowWeakEncryption may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Ssl3AllowWeakEncryption,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Tls10,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Tls11,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Tls12,
  }
}
