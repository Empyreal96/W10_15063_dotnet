// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(3198762599, 56302, 20347, 175, 13, 167, 154, 174, 83, 51, 191)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationPeer))]
  internal interface IAutomationPeerOverrides
  {
    object GetPatternCore(PatternInterface patternInterface);

    string GetAcceleratorKeyCore();

    string GetAccessKeyCore();

    AutomationControlType GetAutomationControlTypeCore();

    string GetAutomationIdCore();

    Rect GetBoundingRectangleCore();

    IVector<AutomationPeer> GetChildrenCore();

    string GetClassNameCore();

    Point GetClickablePointCore();

    string GetHelpTextCore();

    string GetItemStatusCore();

    string GetItemTypeCore();

    AutomationPeer GetLabeledByCore();

    string GetLocalizedControlTypeCore();

    string GetNameCore();

    AutomationOrientation GetOrientationCore();

    bool HasKeyboardFocusCore();

    bool IsContentElementCore();

    bool IsControlElementCore();

    bool IsEnabledCore();

    bool IsKeyboardFocusableCore();

    bool IsOffscreenCore();

    bool IsPasswordCore();

    bool IsRequiredForFormCore();

    void SetFocusCore();

    AutomationPeer GetPeerFromPointCore(Point point);

    AutomationLiveSetting GetLiveSettingCore();
  }
}
