// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmNamesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1469398955, 24644, 18031, 151, 244, 51, 123, 120, 8, 56, 77)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyDerivationAlgorithmNames))]
  internal interface IKeyDerivationAlgorithmNamesStatics2
  {
    string CapiKdfMd5 { get; }

    string CapiKdfSha1 { get; }

    string CapiKdfSha256 { get; }

    string CapiKdfSha384 { get; }

    string CapiKdfSha512 { get; }
  }
}
