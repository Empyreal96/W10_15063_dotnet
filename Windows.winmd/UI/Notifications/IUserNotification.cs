// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IUserNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(2918704431, 20051, 17109, 156, 51, 235, 94, 165, 21, 178, 62)]
  [ExclusiveTo(typeof (UserNotification))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserNotification
  {
    Notification Notification { get; }

    AppInfo AppInfo { get; }

    uint Id { get; }

    DateTime CreationTime { get; }
  }
}
