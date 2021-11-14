// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricKeyAlgorithmProvider2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AsymmetricKeyAlgorithmProvider))]
  [Guid(1311910526, 31821, 18839, 172, 79, 27, 132, 139, 54, 48, 110)]
  internal interface IAsymmetricKeyAlgorithmProvider2
  {
    CryptographicKey CreateKeyPairWithCurveName(string curveName);

    CryptographicKey CreateKeyPairWithCurveParameters([Range(0, 65536)] byte[] parameters);
  }
}
