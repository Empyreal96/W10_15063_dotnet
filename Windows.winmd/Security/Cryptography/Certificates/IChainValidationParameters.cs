// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IChainValidationParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(3295951690, 32432, 19286, 160, 64, 185, 200, 230, 85, 221, 243)]
  [ExclusiveTo(typeof (ChainValidationParameters))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChainValidationParameters
  {
    CertificateChainPolicy CertificateChainPolicy { get; set; }

    HostName ServerDnsName { get; set; }
  }
}
