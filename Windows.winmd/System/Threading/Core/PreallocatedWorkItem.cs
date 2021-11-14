// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.PreallocatedWorkItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [global::Windows.Foundation.Metadata.Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPreallocatedWorkItemFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class PreallocatedWorkItem : IPreallocatedWorkItem
  {
    [MethodImpl]
    public extern PreallocatedWorkItem(WorkItemHandler handler);

    [MethodImpl]
    public extern PreallocatedWorkItem(WorkItemHandler handler, WorkItemPriority priority);

    [MethodImpl]
    public extern PreallocatedWorkItem(
      WorkItemHandler handler,
      WorkItemPriority priority,
      WorkItemOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RunAsync();
  }
}
