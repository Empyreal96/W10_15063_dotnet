// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IGridItemPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (GridItemPatternIdentifiers))]
  [Guid(561849346, 24134, 19809, 135, 148, 184, 238, 142, 119, 71, 20)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridItemPatternIdentifiersStatics
  {
    AutomationProperty ColumnProperty { get; }

    AutomationProperty ColumnSpanProperty { get; }

    AutomationProperty ContainingGridProperty { get; }

    AutomationProperty RowProperty { get; }

    AutomationProperty RowSpanProperty { get; }
  }
}
