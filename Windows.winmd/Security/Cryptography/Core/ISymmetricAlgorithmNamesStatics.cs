// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ISymmetricAlgorithmNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1752199803, 51606, 20142, 132, 215, 121, 178, 174, 183, 59, 156)]
  [ExclusiveTo(typeof (SymmetricAlgorithmNames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISymmetricAlgorithmNamesStatics
  {
    string DesCbc { get; }

    string DesEcb { get; }

    string TripleDesCbc { get; }

    string TripleDesEcb { get; }

    string Rc2Cbc { get; }

    string Rc2Ecb { get; }

    string AesCbc { get; }

    string AesEcb { get; }

    string AesGcm { get; }

    string AesCcm { get; }

    string AesCbcPkcs7 { get; }

    string AesEcbPkcs7 { get; }

    string DesCbcPkcs7 { get; }

    string DesEcbPkcs7 { get; }

    string TripleDesCbcPkcs7 { get; }

    string TripleDesEcbPkcs7 { get; }

    string Rc2CbcPkcs7 { get; }

    string Rc2EcbPkcs7 { get; }

    string Rc4 { get; }
  }
}
