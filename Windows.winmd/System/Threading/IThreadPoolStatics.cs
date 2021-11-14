// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.IThreadPoolStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [ExclusiveTo(typeof (ThreadPool))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3065997277, 33981, 17656, 172, 28, 147, 235, 203, 157, 186, 145)]
  internal interface IThreadPoolStatics
  {
    [RemoteAsync]
    [Overload("RunAsync")]
    IAsyncAction RunAsync(WorkItemHandler handler);

    [Overload("RunWithPriorityAsync")]
    [RemoteAsync]
    IAsyncAction RunAsync(WorkItemHandler handler, WorkItemPriority priority);

    [RemoteAsync]
    [Overload("RunWithPriorityAndOptionsAsync")]
    IAsyncAction RunAsync(
      WorkItemHandler handler,
      WorkItemPriority priority,
      WorkItemOptions options);
  }
}
