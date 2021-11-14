// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3069232301, 19769, 18918, 187, 145, 217, 36, 238, 253, 133, 56)]
  [ExclusiveTo(typeof (AutomationPeer))]
  internal interface IAutomationPeerOverrides3
  {
    object NavigateCore(AutomationNavigationDirection direction);

    object GetElementFromPointCore(Point pointInWindowCoordinates);

    object GetFocusedElementCore();

    IVector<AutomationPeerAnnotation> GetAnnotationsCore();

    int GetPositionInSetCore();

    int GetSizeOfSetCore();

    int GetLevelCore();
  }
}
