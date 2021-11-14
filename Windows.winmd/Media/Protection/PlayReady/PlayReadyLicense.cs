// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicense
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyLicense : IPlayReadyLicense, IPlayReadyLicense2
  {
    public extern bool FullyEvaluated { [MethodImpl] get; }

    public extern bool UsableForPlay { [MethodImpl] get; }

    public extern IReference<global::Windows.Foundation.DateTime> ExpirationDate { [MethodImpl] get; }

    public extern uint ExpireAfterFirstPlay { [MethodImpl] get; }

    public extern Guid DomainAccountID { [MethodImpl] get; }

    public extern uint ChainDepth { [MethodImpl] get; }

    [MethodImpl]
    public extern Guid GetKIDAtChainDepth(uint chainDepth);

    public extern Guid SecureStopId { [MethodImpl] get; }

    public extern uint SecurityLevel { [MethodImpl] get; }

    public extern bool InMemoryOnly { [MethodImpl] get; }

    public extern bool ExpiresInRealTime { [MethodImpl] get; }
  }
}
