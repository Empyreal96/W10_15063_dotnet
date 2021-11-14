// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationParametersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (KeyDerivationParameters))]
  [Guid(3935707070, 62335, 16710, 157, 254, 164, 86, 241, 115, 95, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyDerivationParametersStatics
  {
    KeyDerivationParameters BuildForPbkdf2(
      IBuffer pbkdf2Salt,
      uint iterationCount);

    KeyDerivationParameters BuildForSP800108(IBuffer label, IBuffer context);

    KeyDerivationParameters BuildForSP80056a(
      IBuffer algorithmId,
      IBuffer partyUInfo,
      IBuffer partyVInfo,
      IBuffer suppPubInfo,
      IBuffer suppPrivInfo);
  }
}
