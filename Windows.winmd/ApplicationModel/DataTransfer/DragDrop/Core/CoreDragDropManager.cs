// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragDropManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (ICoreDragDropManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreDragDropManager : ICoreDragDropManager
  {
    public extern event TypedEventHandler<CoreDragDropManager, CoreDropOperationTargetRequestedEventArgs> TargetRequested;

    public extern bool AreConcurrentOperationsEnabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern CoreDragDropManager GetForCurrentView();
  }
}
