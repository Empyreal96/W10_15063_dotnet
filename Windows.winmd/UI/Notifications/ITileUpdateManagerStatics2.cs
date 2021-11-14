// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdateManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (TileUpdateManager))]
  [Guid(1931222492, 36372, 19324, 163, 75, 157, 34, 222, 118, 200, 77)]
  internal interface ITileUpdateManagerStatics2
  {
    TileUpdateManagerForUser GetForUser(User user);
  }
}
