// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ExclusiveTo(typeof (UserDataTaskManager))]
  [Guid(2219952404, 58891, 18601, 146, 17, 127, 184, 165, 108, 184, 76)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskManager
  {
    [RemoteAsync]
    IAsyncOperation<UserDataTaskStore> RequestStoreAsync(
      UserDataTaskStoreAccessType accessType);

    User User { get; }
  }
}
