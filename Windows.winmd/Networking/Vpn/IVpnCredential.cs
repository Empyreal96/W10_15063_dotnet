// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCredential
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  [Guid(3085404915, 42093, 16459, 135, 41, 24, 50, 82, 40, 83, 172)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnCredential
  {
    PasswordCredential PasskeyCredential { get; }

    Certificate CertificateCredential { get; }

    string AdditionalPin { get; }

    PasswordCredential OldPasswordCredential { get; }
  }
}
