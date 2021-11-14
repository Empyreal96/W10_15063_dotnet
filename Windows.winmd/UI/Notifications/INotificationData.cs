// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotificationData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(2684166930, 40298, 19119, 182, 172, 255, 23, 240, 193, 242, 128)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (NotificationData))]
  internal interface INotificationData
  {
    IMap<string, string> Values { get; }

    uint SequenceNumber { get; set; }
  }
}
