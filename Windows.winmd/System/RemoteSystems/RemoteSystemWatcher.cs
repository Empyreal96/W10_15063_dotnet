// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemWatcher : IRemoteSystemWatcher
  {
    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern event TypedEventHandler<RemoteSystemWatcher, RemoteSystemAddedEventArgs> RemoteSystemAdded;

    public extern event TypedEventHandler<RemoteSystemWatcher, RemoteSystemUpdatedEventArgs> RemoteSystemUpdated;

    public extern event TypedEventHandler<RemoteSystemWatcher, RemoteSystemRemovedEventArgs> RemoteSystemRemoved;
  }
}
