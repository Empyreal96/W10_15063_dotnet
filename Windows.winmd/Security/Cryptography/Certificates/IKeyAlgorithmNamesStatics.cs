// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyAlgorithmNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1200645591, 31431, 17793, 140, 59, 208, 112, 39, 20, 4, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyAlgorithmNames))]
  internal interface IKeyAlgorithmNamesStatics
  {
    string Rsa { get; }

    string Dsa { get; }

    string Ecdh256 { get; }

    string Ecdh384 { get; }

    string Ecdh521 { get; }

    string Ecdsa256 { get; }

    string Ecdsa384 { get; }

    string Ecdsa521 { get; }
  }
}
