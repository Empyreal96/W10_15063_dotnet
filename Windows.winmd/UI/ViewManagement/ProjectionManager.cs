// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ProjectionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.ViewManagement
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IProjectionManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IProjectionManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public static class ProjectionManager
  {
    [Overload("StartProjectingWithDeviceInfoAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction StartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      DeviceInformation displayDeviceInfo);

    [RemoteAsync]
    [Overload("RequestStartProjectingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestStartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      Rect selection);

    [Overload("RequestStartProjectingWithPlacementAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestStartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      Rect selection,
      Placement prefferedPlacement);

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [RemoteAsync]
    [Overload("StartProjectingAsync")]
    [MethodImpl]
    public static extern IAsyncAction StartProjectingAsync(
      int projectionViewId,
      int anchorViewId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SwapDisplaysForViewsAsync(
      int projectionViewId,
      int anchorViewId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction StopProjectingAsync(
      int projectionViewId,
      int anchorViewId);

    public static extern bool ProjectionDisplayAvailable { [MethodImpl] get; }

    public static extern event EventHandler<object> ProjectionDisplayAvailableChanged;
  }
}
