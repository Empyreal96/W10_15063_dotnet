// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectionProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ConnectionProfile : 
    IConnectionProfile,
    IConnectionProfile2,
    IConnectionProfile3
  {
    public extern string ProfileName { [MethodImpl] get; }

    [MethodImpl]
    public extern NetworkConnectivityLevel GetNetworkConnectivityLevel();

    [MethodImpl]
    public extern IVectorView<string> GetNetworkNames();

    [MethodImpl]
    public extern ConnectionCost GetConnectionCost();

    [MethodImpl]
    public extern DataPlanStatus GetDataPlanStatus();

    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    [Deprecated("GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetLocalUsage")]
    [MethodImpl]
    public extern DataUsage GetLocalUsage(global::Windows.Foundation.DateTime StartTime, global::Windows.Foundation.DateTime EndTime);

    [Deprecated("GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetLocalUsagePerRoamingStates")]
    [MethodImpl]
    public extern DataUsage GetLocalUsage(
      global::Windows.Foundation.DateTime StartTime,
      global::Windows.Foundation.DateTime EndTime,
      RoamingStates States);

    public extern NetworkSecuritySettings NetworkSecuritySettings { [MethodImpl] get; }

    public extern bool IsWwanConnectionProfile { [MethodImpl] get; }

    public extern bool IsWlanConnectionProfile { [MethodImpl] get; }

    public extern WwanConnectionProfileDetails WwanConnectionProfileDetails { [MethodImpl] get; }

    public extern WlanConnectionProfileDetails WlanConnectionProfileDetails { [MethodImpl] get; }

    public extern IReference<Guid> ServiceProviderGuid { [MethodImpl] get; }

    [MethodImpl]
    public extern IReference<byte> GetSignalBars();

    [MethodImpl]
    public extern DomainConnectivityLevel GetDomainConnectivityLevel();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<NetworkUsage>> GetNetworkUsageAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      DataUsageGranularity granularity,
      NetworkUsageStates states);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ConnectivityInterval>> GetConnectivityIntervalsAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      NetworkUsageStates states);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AttributedNetworkUsage>> GetAttributedNetworkUsageAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      NetworkUsageStates states);
  }
}
