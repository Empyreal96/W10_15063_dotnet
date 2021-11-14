// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListSkipOccurrenceRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ExclusiveTo(typeof (UserDataTaskListSkipOccurrenceRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2050724426, 52271, 20091, 170, 205, 165, 185, 210, 156, 250, 78)]
  internal interface IUserDataTaskListSkipOccurrenceRequestEventArgs
  {
    UserDataTaskListSkipOccurrenceRequest Request { get; }

    Deferral GetDeferral();
  }
}
