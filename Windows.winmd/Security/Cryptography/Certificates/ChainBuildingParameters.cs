// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ChainBuildingParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ChainBuildingParameters : IChainBuildingParameters
  {
    [MethodImpl]
    public extern ChainBuildingParameters();

    public extern IVector<string> EnhancedKeyUsages { [MethodImpl] get; }

    public extern DateTime ValidationTimestamp { [MethodImpl] get; [MethodImpl] set; }

    public extern bool RevocationCheckEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool NetworkRetrievalEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AuthorityInformationAccessEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CurrentTimeValidationEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<Certificate> ExclusiveTrustRoots { [MethodImpl] get; }
  }
}
