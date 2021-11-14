// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IPushNotificationTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (PushNotificationTrigger))]
  [Guid(1842933019, 17806, 20418, 188, 46, 213, 102, 79, 119, 237, 25)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPushNotificationTriggerFactory
  {
    PushNotificationTrigger Create(string applicationId);
  }
}
