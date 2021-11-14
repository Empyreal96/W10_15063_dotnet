// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyDomain
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2915865516, 38886, 17391, 149, 228, 215, 134, 143, 59, 22, 169)]
  public interface IPlayReadyDomain
  {
    Guid AccountId { get; }

    Guid ServiceId { get; }

    uint Revision { get; }

    string FriendlyName { get; }

    global::Windows.Foundation.Uri DomainJoinUrl { get; }
  }
}
