// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeer3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3553606007, 132, 16855, 162, 33, 40, 21, 141, 59, 195, 44)]
  [ExclusiveTo(typeof (AutomationPeer))]
  internal interface IAutomationPeer3
  {
    object Navigate(AutomationNavigationDirection direction);

    object GetElementFromPoint(Point pointInWindowCoordinates);

    object GetFocusedElement();

    void ShowContextMenu();

    IVectorView<AutomationPeer> GetControlledPeers();

    IVector<AutomationPeerAnnotation> GetAnnotations();

    void SetParent(AutomationPeer peer);

    void RaiseTextEditTextChangedEvent(
      AutomationTextEditChangeType automationTextEditChangeType,
      IVectorView<string> changedData);

    int GetPositionInSet();

    int GetSizeOfSet();

    int GetLevel();

    void RaiseStructureChangedEvent(
      AutomationStructureChangeType structureChangeType,
      AutomationPeer child);
  }
}
