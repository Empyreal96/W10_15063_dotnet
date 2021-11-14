// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ISymmetricKeyAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1031686707, 15312, 18690, 138, 200, 71, 13, 80, 210, 19, 118)]
  [ExclusiveTo(typeof (SymmetricKeyAlgorithmProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISymmetricKeyAlgorithmProvider
  {
    string AlgorithmName { get; }

    uint BlockLength { get; }

    CryptographicKey CreateSymmetricKey(IBuffer keyMaterial);
  }
}
