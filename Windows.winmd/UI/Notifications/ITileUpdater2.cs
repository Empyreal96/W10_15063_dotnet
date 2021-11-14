// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdater2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(2720427538, 5614, 17389, 131, 245, 101, 179, 82, 187, 26, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TileUpdater))]
  internal interface ITileUpdater2
  {
    void EnableNotificationQueueForSquare150x150(bool enable);

    void EnableNotificationQueueForWide310x150(bool enable);

    void EnableNotificationQueueForSquare310x310(bool enable);
  }
}
