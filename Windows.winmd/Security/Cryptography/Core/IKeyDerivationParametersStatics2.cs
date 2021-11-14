// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationParametersStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2776120789, 22755, 20219, 178, 131, 161, 101, 49, 38, 225, 190)]
  [ExclusiveTo(typeof (KeyDerivationParameters))]
  internal interface IKeyDerivationParametersStatics2
  {
    KeyDerivationParameters BuildForCapi1Kdf(
      Capi1KdfTargetAlgorithm capi1KdfTargetAlgorithm);
  }
}
