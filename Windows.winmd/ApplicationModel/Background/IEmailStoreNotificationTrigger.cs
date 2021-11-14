// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IEmailStoreNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2557282010, 18411, 17000, 164, 242, 243, 247, 113, 136, 56, 138)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailStoreNotificationTrigger))]
  internal interface IEmailStoreNotificationTrigger : IBackgroundTrigger
  {
  }
}
