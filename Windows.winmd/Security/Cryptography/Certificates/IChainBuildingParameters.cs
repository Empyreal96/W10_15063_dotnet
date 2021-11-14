// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IChainBuildingParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (ChainBuildingParameters))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1110157602, 31885, 18359, 181, 155, 177, 39, 3, 115, 58, 195)]
  internal interface IChainBuildingParameters
  {
    IVector<string> EnhancedKeyUsages { get; }

    DateTime ValidationTimestamp { get; set; }

    bool RevocationCheckEnabled { get; set; }

    bool NetworkRetrievalEnabled { get; set; }

    bool AuthorityInformationAccessEnabled { get; set; }

    bool CurrentTimeValidationEnabled { get; set; }

    IVector<Certificate> ExclusiveTrustRoots { get; }
  }
}
