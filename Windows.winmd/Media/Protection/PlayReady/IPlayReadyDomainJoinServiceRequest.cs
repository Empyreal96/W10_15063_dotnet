// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyDomainJoinServiceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(387664474, 16479, 18233, 176, 64, 103, 185, 240, 195, 135, 88)]
  [ExclusiveTo(typeof (PlayReadyDomainJoinServiceRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyDomainJoinServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    Guid DomainAccountId { get; set; }

    string DomainFriendlyName { get; set; }

    Guid DomainServiceId { get; set; }
  }
}
