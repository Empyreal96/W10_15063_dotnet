// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCredential
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnCredential : IVpnCredential
  {
    public extern PasswordCredential PasskeyCredential { [MethodImpl] get; }

    public extern Certificate CertificateCredential { [MethodImpl] get; }

    public extern string AdditionalPin { [MethodImpl] get; }

    public extern PasswordCredential OldPasswordCredential { [MethodImpl] get; }
  }
}
