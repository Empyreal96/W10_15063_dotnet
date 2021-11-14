// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialEntityStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System.RemoteSystems;

namespace Windows.Perception.Spatial
{
  [Static(typeof (ISpatialEntityStoreStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialEntityStore : ISpatialEntityStore
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync(SpatialEntity entity);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveAsync(SpatialEntity entity);

    [MethodImpl]
    public extern SpatialEntityWatcher CreateEntityWatcher();

    public static extern bool IsSupported { [MethodImpl] get; }

    [Overload("TryGetForRemoteSystemSession")]
    [MethodImpl]
    public static extern SpatialEntityStore TryGet(RemoteSystemSession session);
  }
}
