// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationPeer))]
  [Guid(900384890, 25326, 19774, 162, 76, 43, 200, 67, 45, 104, 183)]
  [WebHostHidden]
  internal interface IAutomationPeer
  {
    AutomationPeer EventsSource { get; set; }

    object GetPattern(PatternInterface patternInterface);

    void RaiseAutomationEvent(AutomationEvents eventId);

    void RaisePropertyChangedEvent(
      AutomationProperty automationProperty,
      object oldValue,
      object newValue);

    string GetAcceleratorKey();

    string GetAccessKey();

    AutomationControlType GetAutomationControlType();

    string GetAutomationId();

    Rect GetBoundingRectangle();

    IVector<AutomationPeer> GetChildren();

    string GetClassName();

    Point GetClickablePoint();

    string GetHelpText();

    string GetItemStatus();

    string GetItemType();

    AutomationPeer GetLabeledBy();

    string GetLocalizedControlType();

    string GetName();

    AutomationOrientation GetOrientation();

    bool HasKeyboardFocus();

    bool IsContentElement();

    bool IsControlElement();

    bool IsEnabled();

    bool IsKeyboardFocusable();

    bool IsOffscreen();

    bool IsPassword();

    bool IsRequiredForForm();

    void SetFocus();

    [Deprecated("Consider using Navigate with AutomationNavigationDirection::Parent, which is an improved version of GetParent. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    AutomationPeer GetParent();

    void InvalidatePeer();

    [Deprecated("Consider using GetElementFromPoint, which is an improved version of GetPeerFromPoint. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    AutomationPeer GetPeerFromPoint(Point point);

    AutomationLiveSetting GetLiveSetting();
  }
}
