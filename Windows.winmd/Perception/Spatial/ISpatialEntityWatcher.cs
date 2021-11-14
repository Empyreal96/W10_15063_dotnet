// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialEntityWatcher))]
  [Guid(3015204768, 27998, 19388, 128, 93, 95, 229, 185, 186, 25, 89)]
  internal interface ISpatialEntityWatcher
  {
    SpatialEntityWatcherStatus Status { get; }

    event TypedEventHandler<SpatialEntityWatcher, SpatialEntityAddedEventArgs> Added;

    event TypedEventHandler<SpatialEntityWatcher, SpatialEntityUpdatedEventArgs> Updated;

    event TypedEventHandler<SpatialEntityWatcher, SpatialEntityRemovedEventArgs> Removed;

    event TypedEventHandler<SpatialEntityWatcher, object> EnumerationCompleted;

    void Start();

    void Stop();
  }
}
