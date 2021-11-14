// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IHotspotCredentialsAuthenticationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3881224081, 4101, 19941, 131, 199, 222, 97, 216, 136, 49, 208)]
  [ExclusiveTo(typeof (HotspotCredentialsAuthenticationResult))]
  internal interface IHotspotCredentialsAuthenticationResult
  {
    bool HasNetworkErrorOccurred { get; }

    HotspotAuthenticationResponseCode ResponseCode { get; }

    Uri LogoffUrl { get; }

    XmlDocument AuthenticationReplyXml { get; }
  }
}
