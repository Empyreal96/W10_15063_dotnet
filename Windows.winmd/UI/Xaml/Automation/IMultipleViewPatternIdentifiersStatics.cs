// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IMultipleViewPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (MultipleViewPatternIdentifiers))]
  [Guid(2848958063, 27524, 19825, 158, 72, 215, 100, 211, 188, 218, 142)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMultipleViewPatternIdentifiersStatics
  {
    AutomationProperty CurrentViewProperty { get; }

    AutomationProperty SupportedViewsProperty { get; }
  }
}
