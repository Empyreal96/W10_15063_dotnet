// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IGridPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [Guid(2076463859, 41345, 16695, 141, 233, 31, 155, 26, 131, 32, 237)]
  [ExclusiveTo(typeof (GridPatternIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridPatternIdentifiersStatics
  {
    AutomationProperty ColumnCountProperty { get; }

    AutomationProperty RowCountProperty { get; }
  }
}
