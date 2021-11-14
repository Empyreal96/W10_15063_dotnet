// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateChain
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CertificateChain))]
  [Guid(549409669, 13969, 17665, 166, 44, 253, 151, 39, 139, 49, 238)]
  internal interface ICertificateChain
  {
    [Overload("Validate")]
    ChainValidationResult Validate();

    [Overload("ValidateWithParameters")]
    ChainValidationResult Validate(ChainValidationParameters parameter);

    IVectorView<Certificate> GetCertificates(bool includeRoot);
  }
}
