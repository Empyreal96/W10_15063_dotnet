// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynCredentialsVerificationRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Devices.AllJoyn
{
  [Guid(2148169234, 47109, 17583, 162, 225, 121, 42, 182, 85, 162, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynCredentialsVerificationRequestedEventArgs))]
  internal interface IAllJoynCredentialsVerificationRequestedEventArgs
  {
    AllJoynAuthenticationMechanism AuthenticationMechanism { get; }

    string PeerUniqueName { get; }

    Certificate PeerCertificate { get; }

    SocketSslErrorSeverity PeerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> PeerCertificateErrors { get; }

    IVectorView<Certificate> PeerIntermediateCertificates { get; }

    void Accept();

    Deferral GetDeferral();
  }
}
