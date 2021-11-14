// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.IGameChatOverlay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  [ExclusiveTo(typeof (GameChatOverlay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4224075877, 63228, 19016, 174, 7, 3, 172, 110, 212, 55, 4)]
  internal interface IGameChatOverlay
  {
    GameChatOverlayPosition DesiredPosition { get; set; }

    void AddMessage(string sender, string message, GameChatMessageOrigin origin);
  }
}
