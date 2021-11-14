// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateQuery))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1527261745, 42792, 18710, 181, 238, 255, 203, 138, 207, 36, 23)]
  internal interface ICertificateQuery
  {
    IVector<string> EnhancedKeyUsages { get; }

    string IssuerName { get; set; }

    string FriendlyName { get; set; }

    byte[] Thumbprint { get; set; }

    bool HardwareOnly { get; set; }
  }
}
