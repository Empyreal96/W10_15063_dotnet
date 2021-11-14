// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Networking.PushNotifications
{
  [ExclusiveTo(typeof (PushNotificationChannelManager))]
  [Guid(3024397917, 42985, 19240, 149, 14, 243, 117, 169, 7, 249, 223)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPushNotificationChannelManagerStatics2
  {
    PushNotificationChannelManagerForUser GetForUser(User user);
  }
}
