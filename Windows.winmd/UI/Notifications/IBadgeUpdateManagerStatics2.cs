// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeUpdateManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (BadgeUpdateManager))]
  [Guid(2543465934, 63808, 18623, 148, 232, 202, 36, 77, 64, 11, 65)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IBadgeUpdateManagerStatics2
  {
    BadgeUpdateManagerForUser GetForUser(User user);
  }
}
