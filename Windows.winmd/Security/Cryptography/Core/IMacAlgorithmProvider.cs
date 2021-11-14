// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IMacAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1245693379, 7357, 16846, 160, 146, 170, 11, 197, 210, 210, 245)]
  [ExclusiveTo(typeof (MacAlgorithmProvider))]
  internal interface IMacAlgorithmProvider
  {
    string AlgorithmName { get; }

    uint MacLength { get; }

    CryptographicKey CreateKey(IBuffer keyMaterial);
  }
}
