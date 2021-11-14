// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IMacAlgorithmProvider2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1839409685, 55601, 17133, 142, 126, 195, 1, 202, 238, 17, 156)]
  [ExclusiveTo(typeof (MacAlgorithmProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMacAlgorithmProvider2
  {
    CryptographicHash CreateHash(IBuffer keyMaterial);
  }
}
