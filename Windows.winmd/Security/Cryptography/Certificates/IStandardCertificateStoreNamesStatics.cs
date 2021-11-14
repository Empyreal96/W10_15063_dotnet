// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IStandardCertificateStoreNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(202722011, 42134, 16888, 143, 229, 158, 150, 243, 110, 251, 248)]
  [ExclusiveTo(typeof (StandardCertificateStoreNames))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IStandardCertificateStoreNamesStatics
  {
    string Personal { get; }

    string TrustedRootCertificationAuthorities { get; }

    string IntermediateCertificationAuthorities { get; }
  }
}
