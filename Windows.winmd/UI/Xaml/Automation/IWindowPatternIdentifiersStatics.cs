// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IWindowPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(131116294, 25346, 19753, 135, 139, 25, 218, 3, 252, 34, 141)]
  [ExclusiveTo(typeof (WindowPatternIdentifiers))]
  internal interface IWindowPatternIdentifiersStatics
  {
    AutomationProperty CanMaximizeProperty { get; }

    AutomationProperty CanMinimizeProperty { get; }

    AutomationProperty IsModalProperty { get; }

    AutomationProperty IsTopmostProperty { get; }

    AutomationProperty WindowInteractionStateProperty { get; }

    AutomationProperty WindowVisualStateProperty { get; }
  }
}
