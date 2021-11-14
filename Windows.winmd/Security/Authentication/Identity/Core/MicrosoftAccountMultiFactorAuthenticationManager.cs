// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.MicrosoftAccountMultiFactorAuthenticationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMicrosoftAccountMultiFactorAuthenticatorStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MicrosoftAccountMultiFactorAuthenticationManager : 
    IMicrosoftAccountMultiFactorAuthenticationManager
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorOneTimeCodedInfo> GetOneTimePassCodeAsync(
      string userAccountId,
      uint codeLength);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> AddDeviceAsync(
      string userAccountId,
      string authenticationToken,
      string wnsChannelId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> RemoveDeviceAsync(
      string userAccountId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> UpdateWnsChannelAsync(
      string userAccountId,
      string channelUri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorGetSessionsResult> GetSessionsAsync(
      IIterable<string> userAccountIdList);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo> GetSessionsAndUnregisteredAccountsAsync(
      IIterable<string> userAccountIdList);

    [RemoteAsync]
    [Overload("ApproveSessionUsingAuthSessionInfoAsync")]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> ApproveSessionAsync(
      MicrosoftAccountMultiFactorSessionAuthenticationStatus sessionAuthentictionStatus,
      MicrosoftAccountMultiFactorSessionInfo authenticationSessionInfo);

    [RemoteAsync]
    [Overload("ApproveSessionAsync")]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> ApproveSessionAsync(
      MicrosoftAccountMultiFactorSessionAuthenticationStatus sessionAuthentictionStatus,
      string userAccountId,
      string sessionId,
      MicrosoftAccountMultiFactorAuthenticationType sessionAuthenticationType);

    [Overload("DenySessionUsingAuthSessionInfoAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> DenySessionAsync(
      MicrosoftAccountMultiFactorSessionInfo authenticationSessionInfo);

    [Overload("DenySessionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> DenySessionAsync(
      string userAccountId,
      string sessionId,
      MicrosoftAccountMultiFactorAuthenticationType sessionAuthenticationType);

    public static extern MicrosoftAccountMultiFactorAuthenticationManager Current { [MethodImpl] get; }
  }
}
