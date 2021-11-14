// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IValuePatternIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(3259492599, 44492, 17423, 177, 35, 51, 120, 138, 64, 82, 90)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ValuePatternIdentifiers))]
  internal interface IValuePatternIdentifiersStatics
  {
    AutomationProperty IsReadOnlyProperty { get; }

    AutomationProperty ValueProperty { get; }
  }
}
