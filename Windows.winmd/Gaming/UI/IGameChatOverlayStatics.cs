// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.IGameChatOverlayStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  [ExclusiveTo(typeof (GameChatOverlay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2309813780, 30823, 18935, 150, 135, 37, 217, 219, 244, 68, 209)]
  internal interface IGameChatOverlayStatics
  {
    GameChatOverlay GetDefault();
  }
}
