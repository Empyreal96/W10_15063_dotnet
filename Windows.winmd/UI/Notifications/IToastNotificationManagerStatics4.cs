// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [Guid(2409185235, 58646, 17915, 129, 48, 57, 142, 147, 250, 82, 195)]
  [ExclusiveTo(typeof (ToastNotificationManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IToastNotificationManagerStatics4
  {
    ToastNotificationManagerForUser GetForUser(User user);

    void ConfigureNotificationMirroring(NotificationMirroring value);
  }
}
