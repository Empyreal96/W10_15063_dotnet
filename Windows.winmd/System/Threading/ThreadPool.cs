// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.ThreadPool
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [global::Windows.Foundation.Metadata.Threading(ThreadingModel.Both)]
  [Static(typeof (IThreadPoolStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ThreadPool
  {
    [RemoteAsync]
    [Overload("RunAsync")]
    [MethodImpl]
    public static extern IAsyncAction RunAsync(WorkItemHandler handler);

    [Overload("RunWithPriorityAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction RunAsync(
      WorkItemHandler handler,
      WorkItemPriority priority);

    [Overload("RunWithPriorityAndOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction RunAsync(
      WorkItemHandler handler,
      WorkItemPriority priority,
      WorkItemOptions options);
  }
}
