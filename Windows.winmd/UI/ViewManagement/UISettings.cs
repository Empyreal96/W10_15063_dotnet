// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.UISettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class UISettings : IUISettings, IUISettings2, IUISettings3, IUISettings4
  {
    [MethodImpl]
    public extern UISettings();

    public extern HandPreference HandPreference { [MethodImpl] get; }

    public extern Size CursorSize { [MethodImpl] get; }

    public extern Size ScrollBarSize { [MethodImpl] get; }

    public extern Size ScrollBarArrowSize { [MethodImpl] get; }

    public extern Size ScrollBarThumbBoxSize { [MethodImpl] get; }

    public extern uint MessageDuration { [MethodImpl] get; }

    public extern bool AnimationsEnabled { [MethodImpl] get; }

    public extern bool CaretBrowsingEnabled { [MethodImpl] get; }

    public extern uint CaretBlinkRate { [MethodImpl] get; }

    public extern uint CaretWidth { [MethodImpl] get; }

    public extern uint DoubleClickTime { [MethodImpl] get; }

    public extern uint MouseHoverTime { [MethodImpl] get; }

    [MethodImpl]
    public extern Color UIElementColor(UIElementType desiredElement);

    public extern double TextScaleFactor { [MethodImpl] get; }

    public extern event TypedEventHandler<UISettings, object> TextScaleFactorChanged;

    [MethodImpl]
    public extern Color GetColorValue(UIColorType desiredColor);

    public extern event TypedEventHandler<UISettings, object> ColorValuesChanged;

    public extern bool AdvancedEffectsEnabled { [MethodImpl] get; }

    public extern event TypedEventHandler<UISettings, object> AdvancedEffectsEnabledChanged;
  }
}
