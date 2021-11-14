// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IContactStoreNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(3358802331, 18181, 17777, 154, 22, 6, 185, 151, 191, 156, 150)]
  [ExclusiveTo(typeof (ContactStoreNotificationTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactStoreNotificationTrigger : IBackgroundTrigger
  {
  }
}
