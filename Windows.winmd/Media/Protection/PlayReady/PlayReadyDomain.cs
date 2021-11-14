// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyDomain
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
  public sealed class PlayReadyDomain : IPlayReadyDomain
  {
    public extern Guid AccountId { [MethodImpl] get; }

    public extern Guid ServiceId { [MethodImpl] get; }

    public extern uint Revision { [MethodImpl] get; }

    public extern string FriendlyName { [MethodImpl] get; }

    public extern global::Windows.Foundation.Uri DomainJoinUrl { [MethodImpl] get; }
  }
}
