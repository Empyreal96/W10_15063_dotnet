// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystem))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2760225682, 65323, 19271, 190, 98, 116, 63, 47, 20, 15, 48)]
  internal interface IRemoteSystemStatics
  {
    [RemoteAsync]
    IAsyncOperation<RemoteSystem> FindByHostNameAsync(HostName hostName);

    [Overload("CreateWatcher")]
    RemoteSystemWatcher CreateWatcher();

    [Overload("CreateWatcherWithFilters")]
    RemoteSystemWatcher CreateWatcher(IIterable<IRemoteSystemFilter> filters);

    [RemoteAsync]
    IAsyncOperation<RemoteSystemAccessStatus> RequestAccessAsync();
  }
}
