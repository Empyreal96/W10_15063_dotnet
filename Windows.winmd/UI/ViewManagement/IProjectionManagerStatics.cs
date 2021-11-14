// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IProjectionManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProjectionManager))]
  [Guid(3059716413, 58096, 20477, 186, 149, 52, 36, 22, 71, 228, 92)]
  internal interface IProjectionManagerStatics
  {
    [Overload("StartProjectingAsync")]
    [RemoteAsync]
    IAsyncAction StartProjectingAsync(int projectionViewId, int anchorViewId);

    [RemoteAsync]
    IAsyncAction SwapDisplaysForViewsAsync(int projectionViewId, int anchorViewId);

    [RemoteAsync]
    IAsyncAction StopProjectingAsync(int projectionViewId, int anchorViewId);

    bool ProjectionDisplayAvailable { get; }

    event EventHandler<object> ProjectionDisplayAvailableChanged;
  }
}
