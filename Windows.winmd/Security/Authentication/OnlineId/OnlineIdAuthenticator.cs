// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class OnlineIdAuthenticator : IOnlineIdAuthenticator
  {
    [MethodImpl]
    public extern OnlineIdAuthenticator();

    [Overload("AuthenticateUserAsync")]
    [MethodImpl]
    public extern UserAuthenticationOperation AuthenticateUserAsync(
      OnlineIdServiceTicketRequest request);

    [Overload("AuthenticateUserAsyncAdvanced")]
    [MethodImpl]
    public extern UserAuthenticationOperation AuthenticateUserAsync(
      IIterable<OnlineIdServiceTicketRequest> requests,
      CredentialPromptType credentialPromptType);

    [MethodImpl]
    public extern SignOutUserOperation SignOutUserAsync();

    public extern Guid ApplicationId { [MethodImpl] set; [MethodImpl] get; }

    public extern bool CanSignOut { [MethodImpl] get; }

    public extern string AuthenticatedSafeCustomerId { [MethodImpl] get; }
  }
}
