// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IRoutePolicyFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RoutePolicy))]
  [Guid(906131763, 41358, 19893, 166, 151, 245, 143, 167, 54, 78, 68)]
  internal interface IRoutePolicyFactory
  {
    RoutePolicy CreateRoutePolicy(
      ConnectionProfile connectionProfile,
      HostName hostName,
      DomainNameType type);
  }
}
