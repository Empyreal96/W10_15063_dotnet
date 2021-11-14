// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticatorForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.OnlineId
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class OnlineIdSystemAuthenticatorForUser : IOnlineIdSystemAuthenticatorForUser
  {
    [RemoteAsync]
    [Overload("GetTicketAsync")]
    [MethodImpl]
    public extern IAsyncOperation<OnlineIdSystemTicketResult> GetTicketAsync(
      OnlineIdServiceTicketRequest request);

    public extern Guid ApplicationId { [MethodImpl] set; [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }
  }
}
