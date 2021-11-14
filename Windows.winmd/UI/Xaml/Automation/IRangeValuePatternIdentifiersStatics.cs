// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IRangeValuePatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [Guid(3458417935, 7207, 17791, 184, 21, 122, 94, 70, 134, 61, 187)]
  [ExclusiveTo(typeof (RangeValuePatternIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRangeValuePatternIdentifiersStatics
  {
    AutomationProperty IsReadOnlyProperty { get; }

    AutomationProperty LargeChangeProperty { get; }

    AutomationProperty MaximumProperty { get; }

    AutomationProperty MinimumProperty { get; }

    AutomationProperty SmallChangeProperty { get; }

    AutomationProperty ValueProperty { get; }
  }
}
