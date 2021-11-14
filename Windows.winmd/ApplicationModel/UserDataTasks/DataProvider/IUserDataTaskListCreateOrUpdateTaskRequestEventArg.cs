// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListCreateOrUpdateTaskRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskListCreateOrUpdateTaskRequestEventArgs))]
  [Guid(314923602, 58232, 16795, 174, 56, 165, 233, 230, 4, 71, 110)]
  internal interface IUserDataTaskListCreateOrUpdateTaskRequestEventArgs
  {
    UserDataTaskListCreateOrUpdateTaskRequest Request { get; }

    Deferral GetDeferral();
  }
}
