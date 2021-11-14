// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ProvisioningAgent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Static(typeof (IProvisioningAgentStaticMethods), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ProvisioningAgent : IProvisioningAgent
  {
    [MethodImpl]
    public extern ProvisioningAgent();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ProvisionFromXmlDocumentResults> ProvisionFromXmlDocumentAsync(
      string provisioningXmlDocument);

    [MethodImpl]
    public extern ProvisionedProfile GetProvisionedProfile(
      ProfileMediaType mediaType,
      string profileName);

    [MethodImpl]
    public static extern ProvisioningAgent CreateFromNetworkAccountId(
      string networkAccountId);
  }
}
