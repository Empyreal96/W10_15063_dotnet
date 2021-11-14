// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IScrollPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ScrollPatternIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1274601633, 64383, 20388, 131, 179, 207, 174, 177, 3, 166, 133)]
  internal interface IScrollPatternIdentifiersStatics
  {
    AutomationProperty HorizontallyScrollableProperty { get; }

    AutomationProperty HorizontalScrollPercentProperty { get; }

    AutomationProperty HorizontalViewSizeProperty { get; }

    double NoScroll { get; }

    AutomationProperty VerticallyScrollableProperty { get; }

    AutomationProperty VerticalScrollPercentProperty { get; }

    AutomationProperty VerticalViewSizeProperty { get; }
  }
}
