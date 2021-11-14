// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.EmailServerSettingsDiscovery
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(100859904)]
  public sealed class EmailServerSettingsDiscovery : IEmailServerSettingsDiscovery
  {
    [MethodImpl]
    public extern EmailServerSettingsDiscovery();

    [MethodImpl]
    public extern IAsyncOperation<ExchangeServerDiscoveryResult> DiscoverExchangeServerConfigAsync(
      string userEmail,
      string userName,
      string password);

    [MethodImpl]
    public extern IAsyncOperation<ExchangeServerAuthType> DiscoverExchangeServerAuthTypeAsync(
      string userEmail);

    [MethodImpl]
    public extern void CancelDiscoverExchangeServerConfig();

    [MethodImpl]
    public extern IAsyncOperation<InternetMailServerDiscoveryResult> DiscoverInternetMailServerConfigAsync(
      Guid clientId,
      string userEmail,
      string customDomain);

    [MethodImpl]
    public extern void CancelDiscoverInternetMailServerConfig(Guid clientId);

    [MethodImpl]
    public extern IAsyncOperation<ExchangeServerAuthType> VerifyExchangeMailBoxTokenAuthAsync(
      string server,
      string accountId,
      bool useSsl);
  }
}
