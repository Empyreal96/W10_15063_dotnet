// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ITablePatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (TablePatternIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1963408677, 13001, 18691, 174, 207, 220, 53, 4, 203, 210, 68)]
  [WebHostHidden]
  internal interface ITablePatternIdentifiersStatics
  {
    AutomationProperty ColumnHeadersProperty { get; }

    AutomationProperty RowHeadersProperty { get; }

    AutomationProperty RowOrColumnMajorProperty { get; }
  }
}
