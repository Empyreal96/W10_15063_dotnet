// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDropOperationTarget
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [Guid(3641860502, 19547, 16765, 187, 55, 118, 56, 29, 239, 141, 180)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICoreDropOperationTarget
  {
    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> EnterAsync(
      CoreDragInfo dragInfo,
      CoreDragUIOverride dragUIOverride);

    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> OverAsync(
      CoreDragInfo dragInfo,
      CoreDragUIOverride dragUIOverride);

    [RemoteAsync]
    IAsyncAction LeaveAsync(CoreDragInfo dragInfo);

    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> DropAsync(
      CoreDragInfo dragInfo);
  }
}
