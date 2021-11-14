// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAutomationPeerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAutomationPeerStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IAutomationPeerFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class AutomationPeer : 
    DependencyObject,
    IAutomationPeer,
    IAutomationPeerOverrides,
    IAutomationPeerProtected,
    IAutomationPeer2,
    IAutomationPeerOverrides2,
    IAutomationPeer3,
    IAutomationPeerOverrides3,
    IAutomationPeer4,
    IAutomationPeerOverrides4,
    IAutomationPeer5,
    IAutomationPeerOverrides5,
    IAutomationPeer6,
    IAutomationPeerOverrides6
  {
    [MethodImpl]
    protected extern AutomationPeer();

    public extern AutomationPeer EventsSource { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern object GetPattern(PatternInterface patternInterface);

    [MethodImpl]
    public extern void RaiseAutomationEvent(AutomationEvents eventId);

    [MethodImpl]
    public extern void RaisePropertyChangedEvent(
      AutomationProperty automationProperty,
      object oldValue,
      object newValue);

    [MethodImpl]
    public extern string GetAcceleratorKey();

    [MethodImpl]
    public extern string GetAccessKey();

    [MethodImpl]
    public extern AutomationControlType GetAutomationControlType();

    [MethodImpl]
    public extern string GetAutomationId();

    [MethodImpl]
    public extern Rect GetBoundingRectangle();

    [MethodImpl]
    public extern IVector<AutomationPeer> GetChildren();

    [MethodImpl]
    public extern string GetClassName();

    [MethodImpl]
    public extern Point GetClickablePoint();

    [MethodImpl]
    public extern string GetHelpText();

    [MethodImpl]
    public extern string GetItemStatus();

    [MethodImpl]
    public extern string GetItemType();

    [MethodImpl]
    public extern AutomationPeer GetLabeledBy();

    [MethodImpl]
    public extern string GetLocalizedControlType();

    [MethodImpl]
    public extern string GetName();

    [MethodImpl]
    public extern AutomationOrientation GetOrientation();

    [MethodImpl]
    public extern bool HasKeyboardFocus();

    [MethodImpl]
    public extern bool IsContentElement();

    [MethodImpl]
    public extern bool IsControlElement();

    [MethodImpl]
    public extern bool IsEnabled();

    [MethodImpl]
    public extern bool IsKeyboardFocusable();

    [MethodImpl]
    public extern bool IsOffscreen();

    [MethodImpl]
    public extern bool IsPassword();

    [MethodImpl]
    public extern bool IsRequiredForForm();

    [MethodImpl]
    public extern void SetFocus();

    [Deprecated("Consider using Navigate with AutomationNavigationDirection::Parent, which is an improved version of GetParent. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AutomationPeer GetParent();

    [MethodImpl]
    public extern void InvalidatePeer();

    [Deprecated("Consider using GetElementFromPoint, which is an improved version of GetPeerFromPoint. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AutomationPeer GetPeerFromPoint(Point point);

    [MethodImpl]
    public extern AutomationLiveSetting GetLiveSetting();

    [MethodImpl]
    extern object IAutomationPeerOverrides.GetPatternCore(
      PatternInterface patternInterface);

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetAcceleratorKeyCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetAccessKeyCore();

    [MethodImpl]
    extern AutomationControlType IAutomationPeerOverrides.GetAutomationControlTypeCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetAutomationIdCore();

    [MethodImpl]
    extern Rect IAutomationPeerOverrides.GetBoundingRectangleCore();

    [MethodImpl]
    extern IVector<AutomationPeer> IAutomationPeerOverrides.GetChildrenCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetClassNameCore();

    [MethodImpl]
    extern Point IAutomationPeerOverrides.GetClickablePointCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetHelpTextCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetItemStatusCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetItemTypeCore();

    [MethodImpl]
    extern AutomationPeer IAutomationPeerOverrides.GetLabeledByCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetLocalizedControlTypeCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetNameCore();

    [MethodImpl]
    extern AutomationOrientation IAutomationPeerOverrides.GetOrientationCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.HasKeyboardFocusCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsContentElementCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsControlElementCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsEnabledCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsKeyboardFocusableCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsOffscreenCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsPasswordCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsRequiredForFormCore();

    [MethodImpl]
    extern void IAutomationPeerOverrides.SetFocusCore();

    [MethodImpl]
    extern AutomationPeer IAutomationPeerOverrides.GetPeerFromPointCore(
      Point point);

    [MethodImpl]
    extern AutomationLiveSetting IAutomationPeerOverrides.GetLiveSettingCore();

    [MethodImpl]
    extern AutomationPeer IAutomationPeerProtected.PeerFromProvider(
      IRawElementProviderSimple provider);

    [MethodImpl]
    extern IRawElementProviderSimple IAutomationPeerProtected.ProviderFromPeer(
      AutomationPeer peer);

    [MethodImpl]
    extern void IAutomationPeerOverrides2.ShowContextMenuCore();

    [MethodImpl]
    extern IVectorView<AutomationPeer> IAutomationPeerOverrides2.GetControlledPeersCore();

    [MethodImpl]
    public extern object Navigate(AutomationNavigationDirection direction);

    [MethodImpl]
    public extern object GetElementFromPoint(Point pointInWindowCoordinates);

    [MethodImpl]
    public extern object GetFocusedElement();

    [MethodImpl]
    public extern void ShowContextMenu();

    [MethodImpl]
    public extern IVectorView<AutomationPeer> GetControlledPeers();

    [MethodImpl]
    public extern IVector<AutomationPeerAnnotation> GetAnnotations();

    [MethodImpl]
    public extern void SetParent(AutomationPeer peer);

    [MethodImpl]
    public extern void RaiseTextEditTextChangedEvent(
      AutomationTextEditChangeType automationTextEditChangeType,
      IVectorView<string> changedData);

    [MethodImpl]
    public extern int GetPositionInSet();

    [MethodImpl]
    public extern int GetSizeOfSet();

    [MethodImpl]
    public extern int GetLevel();

    [MethodImpl]
    public extern void RaiseStructureChangedEvent(
      AutomationStructureChangeType structureChangeType,
      AutomationPeer child);

    [MethodImpl]
    extern object IAutomationPeerOverrides3.NavigateCore(
      AutomationNavigationDirection direction);

    [MethodImpl]
    extern object IAutomationPeerOverrides3.GetElementFromPointCore(
      Point pointInWindowCoordinates);

    [MethodImpl]
    extern object IAutomationPeerOverrides3.GetFocusedElementCore();

    [MethodImpl]
    extern IVector<AutomationPeerAnnotation> IAutomationPeerOverrides3.GetAnnotationsCore();

    [MethodImpl]
    extern int IAutomationPeerOverrides3.GetPositionInSetCore();

    [MethodImpl]
    extern int IAutomationPeerOverrides3.GetSizeOfSetCore();

    [MethodImpl]
    extern int IAutomationPeerOverrides3.GetLevelCore();

    [MethodImpl]
    public extern AutomationLandmarkType GetLandmarkType();

    [MethodImpl]
    public extern string GetLocalizedLandmarkType();

    [MethodImpl]
    extern AutomationLandmarkType IAutomationPeerOverrides4.GetLandmarkTypeCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides4.GetLocalizedLandmarkTypeCore();

    [MethodImpl]
    public extern bool IsPeripheral();

    [MethodImpl]
    public extern bool IsDataValidForForm();

    [MethodImpl]
    public extern string GetFullDescription();

    [MethodImpl]
    extern bool IAutomationPeerOverrides5.IsPeripheralCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides5.IsDataValidForFormCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides5.GetFullDescriptionCore();

    [MethodImpl]
    extern IIterable<AutomationPeer> IAutomationPeerOverrides5.GetDescribedByCore();

    [MethodImpl]
    extern IIterable<AutomationPeer> IAutomationPeerOverrides5.GetFlowsToCore();

    [MethodImpl]
    extern IIterable<AutomationPeer> IAutomationPeerOverrides5.GetFlowsFromCore();

    [MethodImpl]
    public extern int GetCulture();

    [MethodImpl]
    extern int IAutomationPeerOverrides6.GetCultureCore();

    [MethodImpl]
    public static extern RawElementProviderRuntimeId GenerateRawElementProviderRuntimeId();

    [MethodImpl]
    public static extern bool ListenerExists(AutomationEvents eventId);
  }
}
