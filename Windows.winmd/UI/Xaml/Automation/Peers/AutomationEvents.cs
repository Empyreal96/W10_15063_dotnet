// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationEvents
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum AutomationEvents
  {
    ToolTipOpened,
    ToolTipClosed,
    MenuOpened,
    MenuClosed,
    AutomationFocusChanged,
    InvokePatternOnInvoked,
    SelectionItemPatternOnElementAddedToSelection,
    SelectionItemPatternOnElementRemovedFromSelection,
    SelectionItemPatternOnElementSelected,
    SelectionPatternOnInvalidated,
    TextPatternOnTextSelectionChanged,
    TextPatternOnTextChanged,
    AsyncContentLoaded,
    PropertyChanged,
    StructureChanged,
    DragStart,
    DragCancel,
    DragComplete,
    DragEnter,
    DragLeave,
    Dropped,
    LiveRegionChanged,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] InputReachedTarget,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] InputReachedOtherElement,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] InputDiscarded,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WindowClosed,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WindowOpened,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ConversionTargetChanged,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TextEditTextChanged,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] LayoutInvalidated,
  }
}
