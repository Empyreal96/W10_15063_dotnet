// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ISelectionPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2466470732, 27472, 16545, 178, 63, 92, 120, 221, 189, 71, 154)]
  [ExclusiveTo(typeof (SelectionPatternIdentifiers))]
  internal interface ISelectionPatternIdentifiersStatics
  {
    AutomationProperty CanSelectMultipleProperty { get; }

    AutomationProperty IsSelectionRequiredProperty { get; }

    AutomationProperty SelectionProperty { get; }
  }
}
