// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2234914304, 7267, 17959, 188, 177, 58, 137, 224, 188, 156, 85)]
  [ExclusiveTo(typeof (UISettings))]
  internal interface IUISettings
  {
    HandPreference HandPreference { get; }

    Size CursorSize { get; }

    Size ScrollBarSize { get; }

    Size ScrollBarArrowSize { get; }

    Size ScrollBarThumbBoxSize { get; }

    uint MessageDuration { get; }

    bool AnimationsEnabled { get; }

    bool CaretBrowsingEnabled { get; }

    uint CaretBlinkRate { get; }

    uint CaretWidth { get; }

    uint DoubleClickTime { get; }

    uint MouseHoverTime { get; }

    Color UIElementColor(UIElementType desiredElement);
  }
}
