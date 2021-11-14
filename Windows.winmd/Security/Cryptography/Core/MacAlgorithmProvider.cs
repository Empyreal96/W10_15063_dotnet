// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.MacAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMacAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MacAlgorithmProvider : IMacAlgorithmProvider, IMacAlgorithmProvider2
  {
    public extern string AlgorithmName { [MethodImpl] get; }

    public extern uint MacLength { [MethodImpl] get; }

    [MethodImpl]
    public extern CryptographicKey CreateKey(IBuffer keyMaterial);

    [MethodImpl]
    public extern CryptographicHash CreateHash(IBuffer keyMaterial);

    [MethodImpl]
    public static extern MacAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
