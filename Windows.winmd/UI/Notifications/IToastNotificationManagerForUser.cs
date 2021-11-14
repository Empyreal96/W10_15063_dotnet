// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2041272310, 17406, 18555, 138, 127, 153, 86, 114, 0, 174, 148)]
  [ExclusiveTo(typeof (ToastNotificationManagerForUser))]
  internal interface IToastNotificationManagerForUser
  {
    [Overload("CreateToastNotifier")]
    ToastNotifier CreateToastNotifier();

    [Overload("CreateToastNotifierWithId")]
    ToastNotifier CreateToastNotifier(string applicationId);

    ToastNotificationHistory History { get; }

    User User { get; }
  }
}
