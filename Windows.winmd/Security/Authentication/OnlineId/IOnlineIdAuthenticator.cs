// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdAuthenticator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(2684614026, 10667, 18455, 184, 132, 215, 81, 109, 173, 24, 185)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (OnlineIdAuthenticator))]
  internal interface IOnlineIdAuthenticator
  {
    [Overload("AuthenticateUserAsync")]
    UserAuthenticationOperation AuthenticateUserAsync(
      OnlineIdServiceTicketRequest request);

    [Overload("AuthenticateUserAsyncAdvanced")]
    UserAuthenticationOperation AuthenticateUserAsync(
      IIterable<OnlineIdServiceTicketRequest> requests,
      CredentialPromptType credentialPromptType);

    SignOutUserOperation SignOutUserAsync();

    Guid ApplicationId { set; get; }

    bool CanSignOut { get; }

    string AuthenticatedSafeCustomerId { get; }
  }
}
