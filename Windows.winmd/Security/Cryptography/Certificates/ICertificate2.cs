// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificate2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(397948748, 35365, 19862, 164, 146, 143, 194, 154, 196, 253, 166)]
  [ExclusiveTo(typeof (Certificate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificate2
  {
    bool IsSecurityDeviceBound { get; }

    CertificateKeyUsages KeyUsages { get; }

    string KeyAlgorithmName { get; }

    string SignatureAlgorithmName { get; }

    string SignatureHashAlgorithmName { get; }

    SubjectAlternativeNameInfo SubjectAlternativeName { get; }
  }
}
