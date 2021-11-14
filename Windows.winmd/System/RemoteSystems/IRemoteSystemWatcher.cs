// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemWatcher))]
  [Guid(1566575742, 11271, 18629, 136, 156, 69, 93, 43, 9, 151, 113)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteSystemWatcher
  {
    void Start();

    void Stop();

    event TypedEventHandler<RemoteSystemWatcher, RemoteSystemAddedEventArgs> RemoteSystemAdded;

    event TypedEventHandler<RemoteSystemWatcher, RemoteSystemUpdatedEventArgs> RemoteSystemUpdated;

    event TypedEventHandler<RemoteSystemWatcher, RemoteSystemRemovedEventArgs> RemoteSystemRemoved;
  }
}
