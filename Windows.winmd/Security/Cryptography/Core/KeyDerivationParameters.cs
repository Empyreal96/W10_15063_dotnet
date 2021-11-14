// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.KeyDerivationParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Static(typeof (IKeyDerivationParametersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IKeyDerivationParametersStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class KeyDerivationParameters : IKeyDerivationParameters, IKeyDerivationParameters2
  {
    public extern IBuffer KdfGenericBinary { [MethodImpl] get; [MethodImpl] set; }

    public extern uint IterationCount { [MethodImpl] get; }

    public extern Capi1KdfTargetAlgorithm Capi1KdfTargetAlgorithm { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern KeyDerivationParameters BuildForCapi1Kdf(
      Capi1KdfTargetAlgorithm capi1KdfTargetAlgorithm);

    [MethodImpl]
    public static extern KeyDerivationParameters BuildForPbkdf2(
      IBuffer pbkdf2Salt,
      uint iterationCount);

    [MethodImpl]
    public static extern KeyDerivationParameters BuildForSP800108(
      IBuffer label,
      IBuffer context);

    [MethodImpl]
    public static extern KeyDerivationParameters BuildForSP80056a(
      IBuffer algorithmId,
      IBuffer partyUInfo,
      IBuffer partyVInfo,
      IBuffer suppPubInfo,
      IBuffer suppPrivInfo);
  }
}
