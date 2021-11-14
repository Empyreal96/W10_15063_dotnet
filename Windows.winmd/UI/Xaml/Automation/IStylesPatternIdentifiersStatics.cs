// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IStylesPatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [Guid(1384793466, 48188, 19784, 148, 175, 31, 104, 112, 60, 162, 150)]
  [ExclusiveTo(typeof (StylesPatternIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStylesPatternIdentifiersStatics
  {
    AutomationProperty ExtendedPropertiesProperty { get; }

    AutomationProperty FillColorProperty { get; }

    AutomationProperty FillPatternColorProperty { get; }

    AutomationProperty FillPatternStyleProperty { get; }

    AutomationProperty ShapeProperty { get; }

    AutomationProperty StyleIdProperty { get; }

    AutomationProperty StyleNameProperty { get; }
  }
}
