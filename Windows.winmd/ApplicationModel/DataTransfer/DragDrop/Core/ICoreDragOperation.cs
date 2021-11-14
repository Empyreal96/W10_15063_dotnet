// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3423002191, 28080, 20066, 171, 27, 167, 74, 2, 220, 109, 133)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreDragOperation))]
  internal interface ICoreDragOperation
  {
    DataPackage Data { get; }

    void SetPointerId(uint pointerId);

    [Overload("SetDragUIContentFromSoftwareBitmap")]
    void SetDragUIContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetDragUIContentFromSoftwareBitmapWithAnchorPoint")]
    void SetDragUIContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap, Point anchorPoint);

    CoreDragUIContentMode DragUIContentMode { get; set; }

    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> StartAsync();
  }
}
