// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorTransferManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISpatialAnchorTransferManagerStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public static class SpatialAnchorTransferManager
  {
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IMapView<string, SpatialAnchor>> TryImportAnchorsAsync(
      IInputStream stream);

    [RemoteAsync]
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryExportAnchorsAsync(
      IIterable<IKeyValuePair<string, SpatialAnchor>> anchors,
      IOutputStream stream);

    [RemoteAsync]
    [Deprecated("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
