// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ITableItemPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(616872227, 59810, 19945, 178, 164, 168, 178, 45, 11, 227, 98)]
  [ExclusiveTo(typeof (TableItemPatternIdentifiers))]
  internal interface ITableItemPatternIdentifiersStatics
  {
    AutomationProperty ColumnHeaderItemsProperty { get; }

    AutomationProperty RowHeaderItemsProperty { get; }
  }
}
