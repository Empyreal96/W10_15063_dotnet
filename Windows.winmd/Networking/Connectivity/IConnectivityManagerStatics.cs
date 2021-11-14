// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectivityManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (ConnectivityManager))]
  [Guid(1361106097, 20401, 18608, 175, 201, 66, 224, 9, 42, 129, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IConnectivityManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<ConnectionSession> AcquireConnectionAsync(
      CellularApnContext cellularApnContext);

    void AddHttpRoutePolicy(RoutePolicy routePolicy);

    void RemoveHttpRoutePolicy(RoutePolicy routePolicy);
  }
}
