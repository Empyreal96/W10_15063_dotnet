// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.RoutePolicy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IRoutePolicyFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RoutePolicy : IRoutePolicy
  {
    [MethodImpl]
    public extern RoutePolicy(
      ConnectionProfile connectionProfile,
      HostName hostName,
      DomainNameType type);

    public extern ConnectionProfile ConnectionProfile { [MethodImpl] get; }

    public extern HostName HostName { [MethodImpl] get; }

    public extern DomainNameType HostNameType { [MethodImpl] get; }
  }
}
