// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IToastNotificationActionTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2963143719, 25728, 17225, 129, 37, 151, 179, 239, 170, 10, 58)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToastNotificationActionTrigger))]
  internal interface IToastNotificationActionTriggerFactory
  {
    ToastNotificationActionTrigger Create(string applicationId);
  }
}
