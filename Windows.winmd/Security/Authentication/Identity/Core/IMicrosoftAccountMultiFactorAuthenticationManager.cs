// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorAuthenticationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorAuthenticationManager))]
  [Guid(265502885, 62836, 17184, 160, 142, 10, 25, 168, 35, 34, 170)]
  internal interface IMicrosoftAccountMultiFactorAuthenticationManager
  {
    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorOneTimeCodedInfo> GetOneTimePassCodeAsync(
      string userAccountId,
      uint codeLength);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> AddDeviceAsync(
      string userAccountId,
      string authenticationToken,
      string wnsChannelId);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> RemoveDeviceAsync(
      string userAccountId);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> UpdateWnsChannelAsync(
      string userAccountId,
      string channelUri);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorGetSessionsResult> GetSessionsAsync(
      IIterable<string> userAccountIdList);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo> GetSessionsAndUnregisteredAccountsAsync(
      IIterable<string> userAccountIdList);

    [Overload("ApproveSessionUsingAuthSessionInfoAsync")]
    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> ApproveSessionAsync(
      MicrosoftAccountMultiFactorSessionAuthenticationStatus sessionAuthentictionStatus,
      MicrosoftAccountMultiFactorSessionInfo authenticationSessionInfo);

    [Overload("ApproveSessionAsync")]
    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> ApproveSessionAsync(
      MicrosoftAccountMultiFactorSessionAuthenticationStatus sessionAuthentictionStatus,
      string userAccountId,
      string sessionId,
      MicrosoftAccountMultiFactorAuthenticationType sessionAuthenticationType);

    [Overload("DenySessionUsingAuthSessionInfoAsync")]
    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> DenySessionAsync(
      MicrosoftAccountMultiFactorSessionInfo authenticationSessionInfo);

    [Overload("DenySessionAsync")]
    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> DenySessionAsync(
      string userAccountId,
      string sessionId,
      MicrosoftAccountMultiFactorAuthenticationType sessionAuthenticationType);
  }
}
