// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationElementIdentifiersStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (AutomationElementIdentifiers))]
  [Guid(2557116934, 56921, 17145, 161, 231, 98, 184, 175, 158, 117, 109)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IAutomationElementIdentifiersStatics5
  {
    AutomationProperty IsPeripheralProperty { get; }

    AutomationProperty IsDataValidForFormProperty { get; }

    AutomationProperty FullDescriptionProperty { get; }

    AutomationProperty DescribedByProperty { get; }

    AutomationProperty FlowsToProperty { get; }

    AutomationProperty FlowsFromProperty { get; }
  }
}
