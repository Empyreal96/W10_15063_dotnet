// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IProvisioningAgent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (ProvisioningAgent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(561447136, 33281, 4575, 173, 185, 244, 206, 70, 45, 145, 55)]
  internal interface IProvisioningAgent
  {
    [RemoteAsync]
    IAsyncOperation<ProvisionFromXmlDocumentResults> ProvisionFromXmlDocumentAsync(
      string provisioningXmlDocument);

    ProvisionedProfile GetProvisionedProfile(
      ProfileMediaType mediaType,
      string profileName);
  }
}
