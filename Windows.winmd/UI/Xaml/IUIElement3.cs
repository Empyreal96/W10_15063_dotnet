// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3156945137, 9970, 19115, 178, 86, 59, 83, 80, 136, 30, 55)]
  [ExclusiveTo(typeof (UIElement))]
  internal interface IUIElement3
  {
    Transform3D Transform3D { get; set; }

    bool CanDrag { get; set; }

    event TypedEventHandler<UIElement, DragStartingEventArgs> DragStarting;

    event TypedEventHandler<UIElement, DropCompletedEventArgs> DropCompleted;

    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> StartDragAsync(
      PointerPoint pointerPoint);
  }
}
