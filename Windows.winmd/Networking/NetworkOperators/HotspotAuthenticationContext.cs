// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.HotspotAuthenticationContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [Static(typeof (IHotspotAuthenticationContextStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HotspotAuthenticationContext : 
    IHotspotAuthenticationContext,
    IHotspotAuthenticationContext2
  {
    public extern byte[] WirelessNetworkId { [MethodImpl] get; }

    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    public extern Uri RedirectMessageUrl { [MethodImpl] get; }

    public extern XmlDocument RedirectMessageXml { [MethodImpl] get; }

    public extern Uri AuthenticationUrl { [MethodImpl] get; }

    [MethodImpl]
    public extern void IssueCredentials(
      string userName,
      string password,
      string extraParameters,
      bool markAsManualConnectOnFailure);

    [MethodImpl]
    public extern void AbortAuthentication(bool markAsManual);

    [MethodImpl]
    public extern void SkipAuthentication();

    [MethodImpl]
    public extern void TriggerAttentionRequired(
      string packageRelativeApplicationId,
      string applicationParameters);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HotspotCredentialsAuthenticationResult> IssueCredentialsAsync(
      string userName,
      string password,
      string extraParameters,
      bool markAsManualConnectOnFailure);

    [MethodImpl]
    public static extern bool TryGetAuthenticationContext(
      string evenToken,
      out HotspotAuthenticationContext context);
  }
}
