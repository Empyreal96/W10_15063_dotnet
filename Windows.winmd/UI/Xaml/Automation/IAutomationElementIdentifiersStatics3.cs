// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationElementIdentifiersStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationElementIdentifiers))]
  [WebHostHidden]
  [Guid(257736381, 46059, 16515, 173, 199, 12, 47, 57, 187, 53, 67)]
  internal interface IAutomationElementIdentifiersStatics3
  {
    AutomationProperty PositionInSetProperty { get; }

    AutomationProperty SizeOfSetProperty { get; }

    AutomationProperty LevelProperty { get; }

    AutomationProperty AnnotationsProperty { get; }
  }
}
