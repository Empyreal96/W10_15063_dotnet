// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialStageFrameOfReferenceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(4153236557, 41124, 18844, 141, 145, 168, 201, 101, 212, 6, 84)]
  [ExclusiveTo(typeof (SpatialStageFrameOfReference))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialStageFrameOfReferenceStatics
  {
    SpatialStageFrameOfReference Current { get; }

    event EventHandler<object> CurrentChanged;

    [RemoteAsync]
    IAsyncOperation<SpatialStageFrameOfReference> RequestNewStageAsync();
  }
}
