// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IHotspotAuthenticationContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (HotspotAuthenticationContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3881224081, 4099, 19941, 131, 199, 222, 97, 216, 136, 49, 208)]
  internal interface IHotspotAuthenticationContext
  {
    byte[] WirelessNetworkId { get; }

    NetworkAdapter NetworkAdapter { get; }

    Uri RedirectMessageUrl { get; }

    XmlDocument RedirectMessageXml { get; }

    Uri AuthenticationUrl { get; }

    void IssueCredentials(
      string userName,
      string password,
      string extraParameters,
      bool markAsManualConnectOnFailure);

    void AbortAuthentication(bool markAsManual);

    void SkipAuthentication();

    void TriggerAttentionRequired(string packageRelativeApplicationId, string applicationParameters);
  }
}
