// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricAlgorithmNamesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(4047618262, 19455, 20259, 186, 102, 96, 69, 177, 55, 213, 223)]
  [ExclusiveTo(typeof (AsymmetricAlgorithmNames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAsymmetricAlgorithmNamesStatics2
  {
    string EcdsaSha256 { get; }

    string EcdsaSha384 { get; }

    string EcdsaSha512 { get; }
  }
}
