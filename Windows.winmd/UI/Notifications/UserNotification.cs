// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.UserNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserNotification : IUserNotification
  {
    public extern Notification Notification { [MethodImpl] get; }

    public extern AppInfo AppInfo { [MethodImpl] get; }

    public extern uint Id { [MethodImpl] get; }

    public extern DateTime CreationTime { [MethodImpl] get; }
  }
}
