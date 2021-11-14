// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynCredentialsVerificationRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Devices.AllJoyn
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynCredentialsVerificationRequestedEventArgs : 
    IAllJoynCredentialsVerificationRequestedEventArgs
  {
    public extern AllJoynAuthenticationMechanism AuthenticationMechanism { [MethodImpl] get; }

    public extern string PeerUniqueName { [MethodImpl] get; }

    public extern Certificate PeerCertificate { [MethodImpl] get; }

    public extern SocketSslErrorSeverity PeerCertificateErrorSeverity { [MethodImpl] get; }

    public extern IVectorView<ChainValidationResult> PeerCertificateErrors { [MethodImpl] get; }

    public extern IVectorView<Certificate> PeerIntermediateCertificates { [MethodImpl] get; }

    [MethodImpl]
    public extern void Accept();

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
