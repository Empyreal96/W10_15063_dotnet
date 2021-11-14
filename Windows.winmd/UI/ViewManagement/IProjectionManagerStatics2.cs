// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IProjectionManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4080873283, 10057, 19678, 185, 119, 192, 196, 30, 116, 21, 209)]
  [ExclusiveTo(typeof (ProjectionManager))]
  internal interface IProjectionManagerStatics2
  {
    [Overload("StartProjectingWithDeviceInfoAsync")]
    [RemoteAsync]
    IAsyncAction StartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      DeviceInformation displayDeviceInfo);

    [RemoteAsync]
    [Overload("RequestStartProjectingAsync")]
    IAsyncOperation<bool> RequestStartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      Rect selection);

    [RemoteAsync]
    [Overload("RequestStartProjectingWithPlacementAsync")]
    IAsyncOperation<bool> RequestStartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      Rect selection,
      Placement prefferedPlacement);

    string GetDeviceSelector();
  }
}
