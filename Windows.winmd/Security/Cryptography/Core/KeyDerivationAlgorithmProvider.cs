// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.KeyDerivationAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKeyDerivationAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class KeyDerivationAlgorithmProvider : IKeyDerivationAlgorithmProvider
  {
    public extern string AlgorithmName { [MethodImpl] get; }

    [MethodImpl]
    public extern CryptographicKey CreateKey(IBuffer keyMaterial);

    [MethodImpl]
    public static extern KeyDerivationAlgorithmProvider OpenAlgorithm(
      string algorithm);
  }
}
