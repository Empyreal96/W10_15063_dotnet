// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialEntityWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class SpatialEntityWatcher : ISpatialEntityWatcher
  {
    public extern SpatialEntityWatcherStatus Status { [MethodImpl] get; }

    public extern event TypedEventHandler<SpatialEntityWatcher, SpatialEntityAddedEventArgs> Added;

    public extern event TypedEventHandler<SpatialEntityWatcher, SpatialEntityUpdatedEventArgs> Updated;

    public extern event TypedEventHandler<SpatialEntityWatcher, SpatialEntityRemovedEventArgs> Removed;

    public extern event TypedEventHandler<SpatialEntityWatcher, object> EnumerationCompleted;

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();
  }
}
