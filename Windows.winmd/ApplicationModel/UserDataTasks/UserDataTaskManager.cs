// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Static(typeof (IUserDataTaskManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataTaskManager : IUserDataTaskManager
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskStore> RequestStoreAsync(
      UserDataTaskStoreAccessType accessType);

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public static extern UserDataTaskManager GetDefault();

    [MethodImpl]
    public static extern UserDataTaskManager GetForUser(User user);
  }
}
