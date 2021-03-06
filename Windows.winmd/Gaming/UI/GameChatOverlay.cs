// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.GameChatOverlay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  [Static(typeof (IGameChatOverlayStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GameChatOverlay : IGameChatOverlay
  {
    public extern GameChatOverlayPosition DesiredPosition { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddMessage(string sender, string message, GameChatMessageOrigin origin);

    [MethodImpl]
    public static extern GameChatOverlay GetDefault();
  }
}
