// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewTitleBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ApplicationViewTitleBar : IApplicationViewTitleBar
  {
    public extern IReference<Color> ForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> BackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> ButtonForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> ButtonBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> ButtonHoverForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> ButtonHoverBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> ButtonPressedForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> ButtonPressedBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> InactiveForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> InactiveBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> ButtonInactiveForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    public extern IReference<Color> ButtonInactiveBackgroundColor { [MethodImpl] set; [MethodImpl] get; }
  }
}
