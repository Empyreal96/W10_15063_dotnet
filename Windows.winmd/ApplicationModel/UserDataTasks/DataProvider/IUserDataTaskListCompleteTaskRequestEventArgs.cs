// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListCompleteTaskRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskListCompleteTaskRequestEventArgs))]
  [Guid(3615242557, 19698, 18605, 135, 253, 150, 63, 14, 170, 122, 149)]
  internal interface IUserDataTaskListCompleteTaskRequestEventArgs
  {
    UserDataTaskListCompleteTaskRequest Request { get; }

    Deferral GetDeferral();
  }
}
