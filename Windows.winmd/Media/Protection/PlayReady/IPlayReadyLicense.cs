// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3997649998, 64060, 16717, 169, 242, 63, 252, 30, 248, 50, 212)]
  public interface IPlayReadyLicense
  {
    bool FullyEvaluated { get; }

    bool UsableForPlay { get; }

    IReference<global::Windows.Foundation.DateTime> ExpirationDate { get; }

    uint ExpireAfterFirstPlay { get; }

    Guid DomainAccountID { get; }

    uint ChainDepth { get; }

    Guid GetKIDAtChainDepth(uint chainDepth);
  }
}
