// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1191313150, 3806, 19007, 174, 120, 191, 164, 113, 73, 105, 37)]
  [ExclusiveTo(typeof (PushNotificationChannelManager))]
  internal interface IPushNotificationChannelManagerStatics3
  {
    PushNotificationChannelManagerForUser GetDefault();
  }
}
