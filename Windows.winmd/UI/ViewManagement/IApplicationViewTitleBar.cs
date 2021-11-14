// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewTitleBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationViewTitleBar))]
  [Guid(9587392, 37675, 19051, 156, 75, 220, 56, 200, 36, 120, 206)]
  internal interface IApplicationViewTitleBar
  {
    IReference<Color> ForegroundColor { set; get; }

    IReference<Color> BackgroundColor { set; get; }

    IReference<Color> ButtonForegroundColor { set; get; }

    IReference<Color> ButtonBackgroundColor { set; get; }

    IReference<Color> ButtonHoverForegroundColor { set; get; }

    IReference<Color> ButtonHoverBackgroundColor { set; get; }

    IReference<Color> ButtonPressedForegroundColor { set; get; }

    IReference<Color> ButtonPressedBackgroundColor { set; get; }

    IReference<Color> InactiveForegroundColor { set; get; }

    IReference<Color> InactiveBackgroundColor { set; get; }

    IReference<Color> ButtonInactiveForegroundColor { set; get; }

    IReference<Color> ButtonInactiveBackgroundColor { set; get; }
  }
}
