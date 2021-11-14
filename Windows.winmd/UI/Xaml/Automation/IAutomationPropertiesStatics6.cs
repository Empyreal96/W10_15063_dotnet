// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics6
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3323855631, 60233, 20061, 176, 18, 76, 28, 150, 195, 144, 27)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationProperties))]
  internal interface IAutomationPropertiesStatics6
  {
    DependencyProperty CultureProperty { get; }

    int GetCulture(DependencyObject element);

    void SetCulture(DependencyObject element, int value);
  }
}
