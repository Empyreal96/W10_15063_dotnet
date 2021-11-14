// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IToastNotificationHistoryChangedTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2177301165, 34711, 18309, 129, 180, 176, 204, 203, 115, 209, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToastNotificationHistoryChangedTrigger))]
  internal interface IToastNotificationHistoryChangedTriggerFactory
  {
    ToastNotificationHistoryChangedTrigger Create(
      string applicationId);
  }
}
