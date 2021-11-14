// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateStore))]
  [Guid(2965370656, 13390, 17201, 175, 20, 167, 247, 167, 235, 201, 58)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateStore
  {
    void Add(Certificate certificate);

    void Delete(Certificate certificate);
  }
}
