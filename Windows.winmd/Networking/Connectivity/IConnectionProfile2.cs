// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfile2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ConnectionProfile))]
  [Guid(3791933765, 19615, 16396, 145, 80, 126, 199, 214, 226, 136, 138)]
  internal interface IConnectionProfile2
  {
    bool IsWwanConnectionProfile { get; }

    bool IsWlanConnectionProfile { get; }

    WwanConnectionProfileDetails WwanConnectionProfileDetails { get; }

    WlanConnectionProfileDetails WlanConnectionProfileDetails { get; }

    IReference<Guid> ServiceProviderGuid { get; }

    IReference<byte> GetSignalBars();

    DomainConnectivityLevel GetDomainConnectivityLevel();

    [RemoteAsync]
    IAsyncOperation<IVectorView<NetworkUsage>> GetNetworkUsageAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      DataUsageGranularity granularity,
      NetworkUsageStates states);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ConnectivityInterval>> GetConnectivityIntervalsAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      NetworkUsageStates states);
  }
}
