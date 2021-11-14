// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotifier2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(893618630, 31745, 19413, 156, 32, 96, 67, 64, 205, 43, 116)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ToastNotifier))]
  internal interface IToastNotifier2
  {
    [Overload("UpdateWithTagAndGroup")]
    NotificationUpdateResult Update(
      NotificationData data,
      string tag,
      string group);

    [Overload("UpdateWithTag")]
    NotificationUpdateResult Update(NotificationData data, string tag);
  }
}
