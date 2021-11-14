// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkInformationStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(1167912212, 10290, 18870, 186, 110, 226, 101, 240, 71, 134, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NetworkInformation))]
  internal interface INetworkInformationStatics2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ConnectionProfile>> FindConnectionProfilesAsync(
      ConnectionProfileFilter pProfileFilter);
  }
}
