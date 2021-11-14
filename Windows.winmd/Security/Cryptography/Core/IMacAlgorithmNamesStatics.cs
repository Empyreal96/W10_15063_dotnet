// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IMacAlgorithmNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (MacAlgorithmNames))]
  [Guid(1094788728, 64286, 17316, 137, 94, 169, 2, 110, 67, 144, 163)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMacAlgorithmNamesStatics
  {
    string HmacMd5 { get; }

    string HmacSha1 { get; }

    string HmacSha256 { get; }

    string HmacSha384 { get; }

    string HmacSha512 { get; }

    string AesCmac { get; }
  }
}
