// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdSystemAuthenticatorForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(1469628155, 7652, 16774, 162, 230, 181, 99, 248, 106, 175, 68)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (OnlineIdSystemAuthenticatorForUser))]
  internal interface IOnlineIdSystemAuthenticatorForUser
  {
    [RemoteAsync]
    [Overload("GetTicketAsync")]
    IAsyncOperation<OnlineIdSystemTicketResult> GetTicketAsync(
      OnlineIdServiceTicketRequest request);

    Guid ApplicationId { set; get; }

    User User { get; }
  }
}
