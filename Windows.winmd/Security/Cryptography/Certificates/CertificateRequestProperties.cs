// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateRequestProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CertificateRequestProperties : 
    ICertificateRequestProperties,
    ICertificateRequestProperties2,
    ICertificateRequestProperties3,
    ICertificateRequestProperties4
  {
    [MethodImpl]
    public extern CertificateRequestProperties();

    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    public extern string KeyAlgorithmName { [MethodImpl] get; [MethodImpl] set; }

    public extern uint KeySize { [MethodImpl] get; [MethodImpl] set; }

    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    public extern string HashAlgorithmName { [MethodImpl] get; [MethodImpl] set; }

    public extern ExportOption Exportable { [MethodImpl] get; [MethodImpl] set; }

    public extern EnrollKeyUsages KeyUsages { [MethodImpl] get; [MethodImpl] set; }

    public extern KeyProtectionLevel KeyProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    public extern string KeyStorageProviderName { [MethodImpl] get; [MethodImpl] set; }

    public extern string SmartcardReaderName { [MethodImpl] get; [MethodImpl] set; }

    public extern Certificate SigningCertificate { [MethodImpl] get; [MethodImpl] set; }

    public extern Certificate AttestationCredentialCertificate { [MethodImpl] get; [MethodImpl] set; }

    public extern string CurveName { [MethodImpl] get; [MethodImpl] set; }

    public extern byte[] CurveParameters { [MethodImpl] get; [MethodImpl] set; }

    public extern string ContainerNamePrefix { [MethodImpl] get; [MethodImpl] set; }

    public extern string ContainerName { [MethodImpl] get; [MethodImpl] set; }

    public extern bool UseExistingKey { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> SuppressedDefaults { [MethodImpl] get; }

    public extern SubjectAlternativeNameInfo SubjectAlternativeName { [MethodImpl] get; }

    public extern IVector<CertificateExtension> Extensions { [MethodImpl] get; }
  }
}
