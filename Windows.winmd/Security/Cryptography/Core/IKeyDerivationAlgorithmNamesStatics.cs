// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (KeyDerivationAlgorithmNames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2070820414, 38098, 18233, 165, 123, 2, 46, 12, 58, 64, 42)]
  internal interface IKeyDerivationAlgorithmNamesStatics
  {
    string Pbkdf2Md5 { get; }

    string Pbkdf2Sha1 { get; }

    string Pbkdf2Sha256 { get; }

    string Pbkdf2Sha384 { get; }

    string Pbkdf2Sha512 { get; }

    string Sp800108CtrHmacMd5 { get; }

    string Sp800108CtrHmacSha1 { get; }

    string Sp800108CtrHmacSha256 { get; }

    string Sp800108CtrHmacSha384 { get; }

    string Sp800108CtrHmacSha512 { get; }

    string Sp80056aConcatMd5 { get; }

    string Sp80056aConcatSha1 { get; }

    string Sp80056aConcatSha256 { get; }

    string Sp80056aConcatSha384 { get; }

    string Sp80056aConcatSha512 { get; }
  }
}
