// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Management.IUserNotificationListenerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications.Management
{
  [ExclusiveTo(typeof (UserNotificationListener))]
  [Guid(4284556239, 17286, 19107, 183, 61, 184, 4, 229, 182, 59, 35)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserNotificationListenerStatics
  {
    UserNotificationListener Current { get; }
  }
}
