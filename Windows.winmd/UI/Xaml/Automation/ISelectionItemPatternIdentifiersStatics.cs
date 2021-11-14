// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ISelectionItemPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (SelectionItemPatternIdentifiers))]
  [Guid(2836975971, 18558, 20030, 159, 134, 123, 68, 172, 190, 39, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISelectionItemPatternIdentifiersStatics
  {
    AutomationProperty IsSelectedProperty { get; }

    AutomationProperty SelectionContainerProperty { get; }
  }
}
