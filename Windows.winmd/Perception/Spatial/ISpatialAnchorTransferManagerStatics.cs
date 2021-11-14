// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorTransferManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(62650809, 4824, 19406, 136, 53, 197, 223, 58, 192, 173, 171)]
  [ExclusiveTo(typeof (SpatialAnchorTransferManager))]
  internal interface ISpatialAnchorTransferManagerStatics
  {
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<IMapView<string, SpatialAnchor>> TryImportAnchorsAsync(
      IInputStream stream);

    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<bool> TryExportAnchorsAsync(
      IIterable<IKeyValuePair<string, SpatialAnchor>> anchors,
      IOutputStream stream);

    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
