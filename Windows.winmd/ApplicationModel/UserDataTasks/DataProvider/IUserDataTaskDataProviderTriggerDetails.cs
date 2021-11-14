// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskDataProviderTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [Guid(2921804290, 45513, 17726, 175, 197, 179, 10, 243, 189, 33, 125)]
  [ExclusiveTo(typeof (UserDataTaskDataProviderTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskDataProviderTriggerDetails
  {
    UserDataTaskDataProviderConnection Connection { get; }
  }
}
