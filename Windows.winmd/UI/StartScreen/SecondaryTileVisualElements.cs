// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.SecondaryTileVisualElements
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SecondaryTileVisualElements : 
    ISecondaryTileVisualElements,
    ISecondaryTileVisualElements2,
    ISecondaryTileVisualElements3
  {
    public extern Uri Square30x30Logo { [Deprecated("SecondaryTileVisualElements.Square30x30Logo may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("SecondaryTileVisualElements.Square30x30Logo may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern Uri Square70x70Logo { [Deprecated("SecondaryTileVisualElements.Square70x70Logo may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("SecondaryTileVisualElements.Square70x70Logo may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern Uri Square150x150Logo { [MethodImpl] set; [MethodImpl] get; }

    public extern Uri Wide310x150Logo { [MethodImpl] set; [MethodImpl] get; }

    public extern Uri Square310x310Logo { [MethodImpl] set; [MethodImpl] get; }

    public extern ForegroundText ForegroundText { [MethodImpl] set; [MethodImpl] get; }

    public extern Color BackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern bool ShowNameOnSquare150x150Logo { [MethodImpl] set; [MethodImpl] get; }

    public extern bool ShowNameOnWide310x150Logo { [MethodImpl] set; [MethodImpl] get; }

    public extern bool ShowNameOnSquare310x310Logo { [MethodImpl] set; [MethodImpl] get; }

    public extern Uri Square71x71Logo { [MethodImpl] set; [MethodImpl] get; }

    public extern Uri Square44x44Logo { [MethodImpl] set; [MethodImpl] get; }
  }
}
