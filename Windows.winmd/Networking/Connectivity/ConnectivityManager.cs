// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectivityManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IConnectivityManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class ConnectivityManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ConnectionSession> AcquireConnectionAsync(
      CellularApnContext cellularApnContext);

    [MethodImpl]
    public static extern void AddHttpRoutePolicy(RoutePolicy routePolicy);

    [MethodImpl]
    public static extern void RemoveHttpRoutePolicy(RoutePolicy routePolicy);
  }
}
