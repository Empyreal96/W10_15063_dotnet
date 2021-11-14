// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragDropManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [WebHostHidden]
  [Guid(2102842180, 33892, 20399, 170, 73, 55, 234, 110, 45, 123, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreDragDropManager))]
  internal interface ICoreDragDropManager
  {
    event TypedEventHandler<CoreDragDropManager, CoreDropOperationTargetRequestedEventArgs> TargetRequested;

    bool AreConcurrentOperationsEnabled { get; set; }
  }
}
