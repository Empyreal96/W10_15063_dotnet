// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class CoreDragOperation : ICoreDragOperation, ICoreDragOperation2
  {
    [MethodImpl]
    public extern CoreDragOperation();

    public extern DataPackage Data { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetPointerId(uint pointerId);

    [Overload("SetDragUIContentFromSoftwareBitmap")]
    [MethodImpl]
    public extern void SetDragUIContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetDragUIContentFromSoftwareBitmapWithAnchorPoint")]
    [MethodImpl]
    public extern void SetDragUIContentFromSoftwareBitmap(
      SoftwareBitmap softwareBitmap,
      Point anchorPoint);

    public extern CoreDragUIContentMode DragUIContentMode { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DataPackageOperation> StartAsync();

    public extern DataPackageOperation AllowedOperations { [MethodImpl] get; [MethodImpl] set; }
  }
}
