// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.HashAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHashAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class HashAlgorithmProvider : IHashAlgorithmProvider
  {
    public extern string AlgorithmName { [MethodImpl] get; }

    public extern uint HashLength { [MethodImpl] get; }

    [MethodImpl]
    public extern IBuffer HashData(IBuffer data);

    [MethodImpl]
    public extern CryptographicHash CreateHash();

    [MethodImpl]
    public static extern HashAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
