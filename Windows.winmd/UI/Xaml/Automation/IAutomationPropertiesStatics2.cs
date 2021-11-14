// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationProperties))]
  [Guid(964056191, 28809, 18433, 143, 29, 170, 183, 128, 144, 209, 160)]
  internal interface IAutomationPropertiesStatics2
  {
    DependencyProperty AccessibilityViewProperty { get; }

    AccessibilityView GetAccessibilityView(DependencyObject element);

    void SetAccessibilityView(DependencyObject element, AccessibilityView value);

    DependencyProperty ControlledPeersProperty { get; }

    IVector<UIElement> GetControlledPeers(DependencyObject element);
  }
}
