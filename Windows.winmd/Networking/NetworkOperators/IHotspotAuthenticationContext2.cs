// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IHotspotAuthenticationContext2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3881224081, 4100, 19941, 131, 199, 222, 97, 216, 136, 49, 208)]
  [ExclusiveTo(typeof (HotspotAuthenticationContext))]
  internal interface IHotspotAuthenticationContext2
  {
    [RemoteAsync]
    IAsyncOperation<HotspotCredentialsAuthenticationResult> IssueCredentialsAsync(
      string userName,
      string password,
      string extraParameters,
      bool markAsManualConnectOnFailure);
  }
}
