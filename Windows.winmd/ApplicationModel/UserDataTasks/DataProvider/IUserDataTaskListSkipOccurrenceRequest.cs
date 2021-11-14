// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListSkipOccurrenceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [Guid(2877809485, 7379, 17180, 159, 88, 8, 154, 164, 51, 141, 133)]
  [ExclusiveTo(typeof (UserDataTaskListSkipOccurrenceRequest))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskListSkipOccurrenceRequest
  {
    string TaskListId { get; }

    string TaskId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
