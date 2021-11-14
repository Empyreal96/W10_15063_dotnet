// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.IPreallocatedWorkItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [ExclusiveTo(typeof (PreallocatedWorkItem))]
  [Guid(3822267205, 57322, 18075, 130, 197, 246, 227, 206, 253, 234, 251)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPreallocatedWorkItemFactory
  {
    PreallocatedWorkItem CreateWorkItem(WorkItemHandler handler);

    PreallocatedWorkItem CreateWorkItemWithPriority(
      WorkItemHandler handler,
      WorkItemPriority priority);

    PreallocatedWorkItem CreateWorkItemWithPriorityAndOptions(
      WorkItemHandler handler,
      WorkItemPriority priority,
      WorkItemOptions options);
  }
}
