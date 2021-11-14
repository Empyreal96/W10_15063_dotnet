// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.INetworkOperatorNotificationTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NetworkOperatorNotificationTrigger))]
  [Guid(170016256, 10199, 17235, 173, 185, 146, 101, 170, 234, 87, 157)]
  internal interface INetworkOperatorNotificationTriggerFactory
  {
    NetworkOperatorNotificationTrigger Create(
      string networkAccountId);
  }
}
