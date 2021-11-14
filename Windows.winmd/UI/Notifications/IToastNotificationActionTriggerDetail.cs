// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationActionTriggerDetail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(2487554906, 14579, 17142, 150, 170, 121, 85, 176, 240, 61, 162)]
  [ExclusiveTo(typeof (ToastNotificationActionTriggerDetail))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastNotificationActionTriggerDetail
  {
    string Argument { get; }

    ValueSet UserInput { get; }
  }
}
