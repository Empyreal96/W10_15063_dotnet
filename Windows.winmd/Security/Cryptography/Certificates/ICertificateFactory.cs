// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (Certificate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(397681180, 19375, 17570, 150, 8, 4, 251, 98, 177, 105, 66)]
  internal interface ICertificateFactory
  {
    Certificate CreateCertificate(IBuffer certBlob);
  }
}
