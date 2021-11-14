// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(848791738, 58643, 20230, 136, 157, 27, 227, 14, 207, 67, 230)]
  [ExclusiveTo(typeof (SpatialEntityStore))]
  internal interface ISpatialEntityStore
  {
    [RemoteAsync]
    IAsyncAction SaveAsync(SpatialEntity entity);

    [RemoteAsync]
    IAsyncAction RemoveAsync(SpatialEntity entity);

    SpatialEntityWatcher CreateEntityWatcher();
  }
}
