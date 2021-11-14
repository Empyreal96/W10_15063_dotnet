// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationElementIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(1162426783, 33600, 19815, 185, 191, 140, 42, 198, 160, 119, 58)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationElementIdentifiers))]
  internal interface IAutomationElementIdentifiersStatics
  {
    AutomationProperty AcceleratorKeyProperty { get; }

    AutomationProperty AccessKeyProperty { get; }

    AutomationProperty AutomationIdProperty { get; }

    AutomationProperty BoundingRectangleProperty { get; }

    AutomationProperty ClassNameProperty { get; }

    AutomationProperty ClickablePointProperty { get; }

    AutomationProperty ControlTypeProperty { get; }

    AutomationProperty HasKeyboardFocusProperty { get; }

    AutomationProperty HelpTextProperty { get; }

    AutomationProperty IsContentElementProperty { get; }

    AutomationProperty IsControlElementProperty { get; }

    AutomationProperty IsEnabledProperty { get; }

    AutomationProperty IsKeyboardFocusableProperty { get; }

    AutomationProperty IsOffscreenProperty { get; }

    AutomationProperty IsPasswordProperty { get; }

    AutomationProperty IsRequiredForFormProperty { get; }

    AutomationProperty ItemStatusProperty { get; }

    AutomationProperty ItemTypeProperty { get; }

    AutomationProperty LabeledByProperty { get; }

    AutomationProperty LocalizedControlTypeProperty { get; }

    AutomationProperty NameProperty { get; }

    AutomationProperty OrientationProperty { get; }

    AutomationProperty LiveSettingProperty { get; }
  }
}
