// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.System.RemoteSystems
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRemoteSystemStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRemoteSystemStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class RemoteSystem : IRemoteSystem, IRemoteSystem2
  {
    public extern string DisplayName { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern string Kind { [MethodImpl] get; }

    public extern RemoteSystemStatus Status { [MethodImpl] get; }

    public extern bool IsAvailableByProximity { [MethodImpl] get; }

    public extern bool IsAvailableBySpatialProximity { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetCapabilitySupportedAsync(
      string capabilityName);

    [MethodImpl]
    public static extern bool IsAuthorizationKindEnabled(RemoteSystemAuthorizationKind kind);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RemoteSystem> FindByHostNameAsync(
      HostName hostName);

    [Overload("CreateWatcher")]
    [MethodImpl]
    public static extern RemoteSystemWatcher CreateWatcher();

    [Overload("CreateWatcherWithFilters")]
    [MethodImpl]
    public static extern RemoteSystemWatcher CreateWatcher(
      IIterable<IRemoteSystemFilter> filters);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RemoteSystemAccessStatus> RequestAccessAsync();
  }
}
