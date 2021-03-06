// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IHashAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Guid(3197841536, 45763, 16939, 188, 225, 236, 144, 239, 181, 215, 181)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HashAlgorithmProvider))]
  internal interface IHashAlgorithmProvider
  {
    string AlgorithmName { get; }

    uint HashLength { get; }

    IBuffer HashData(IBuffer data);

    CryptographicHash CreateHash();
  }
}
