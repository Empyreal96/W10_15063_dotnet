// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListDeleteTaskRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ExclusiveTo(typeof (UserDataTaskListDeleteTaskRequestEventArgs))]
  [Guid(1617156825, 62818, 16709, 142, 254, 213, 0, 120, 201, 43, 127)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskListDeleteTaskRequestEventArgs
  {
    UserDataTaskListDeleteTaskRequest Request { get; }

    Deferral GetDeferral();
  }
}
