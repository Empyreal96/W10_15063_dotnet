// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (UIElement))]
  [Guid(1619865373, 30808, 19179, 137, 228, 181, 78, 44, 126, 211, 211)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IUIElementOverrides
  {
    AutomationPeer OnCreateAutomationPeer();

    void OnDisconnectVisualChildren();

    IIterable<IIterable<Point>> FindSubElementsForTouchTargeting(
      Point point,
      Rect boundingRect);
  }
}
