// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2419891429, 31034, 20447, 162, 178, 175, 26, 194, 30, 49, 8)]
  internal interface IApplicationView3
  {
    ApplicationViewTitleBar TitleBar { get; }

    FullScreenSystemOverlayMode FullScreenSystemOverlayMode { get; set; }

    bool IsFullScreenMode { get; }

    bool TryEnterFullScreenMode();

    void ExitFullScreenMode();

    void ShowStandardSystemOverlays();

    bool TryResizeView(Size value);

    void SetPreferredMinSize(Size minSize);
  }
}
