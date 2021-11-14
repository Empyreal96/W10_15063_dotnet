// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ConnectionProfile))]
  [Guid(1908020284, 22926, 18896, 132, 235, 143, 235, 174, 220, 193, 149)]
  internal interface IConnectionProfile
  {
    string ProfileName { get; }

    NetworkConnectivityLevel GetNetworkConnectivityLevel();

    IVectorView<string> GetNetworkNames();

    ConnectionCost GetConnectionCost();

    DataPlanStatus GetDataPlanStatus();

    NetworkAdapter NetworkAdapter { get; }

    [Overload("GetLocalUsage")]
    [Deprecated("GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    DataUsage GetLocalUsage(DateTime StartTime, DateTime EndTime);

    [Overload("GetLocalUsagePerRoamingStates")]
    [Deprecated("GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    DataUsage GetLocalUsage(DateTime StartTime, DateTime EndTime, RoamingStates States);

    NetworkSecuritySettings NetworkSecuritySettings { get; }
  }
}
