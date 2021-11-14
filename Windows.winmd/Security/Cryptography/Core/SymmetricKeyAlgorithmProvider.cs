// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISymmetricKeyAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SymmetricKeyAlgorithmProvider : ISymmetricKeyAlgorithmProvider
  {
    public extern string AlgorithmName { [MethodImpl] get; }

    public extern uint BlockLength { [MethodImpl] get; }

    [MethodImpl]
    public extern CryptographicKey CreateSymmetricKey(IBuffer keyMaterial);

    [MethodImpl]
    public static extern SymmetricKeyAlgorithmProvider OpenAlgorithm(
      string algorithm);
  }
}
