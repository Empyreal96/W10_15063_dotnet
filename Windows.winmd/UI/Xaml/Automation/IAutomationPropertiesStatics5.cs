// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(199449382, 51449, 16802, 180, 219, 230, 167, 163, 43, 12, 52)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationProperties))]
  internal interface IAutomationPropertiesStatics5
  {
    DependencyProperty IsPeripheralProperty { get; }

    bool GetIsPeripheral(DependencyObject element);

    void SetIsPeripheral(DependencyObject element, bool value);

    DependencyProperty IsDataValidForFormProperty { get; }

    bool GetIsDataValidForForm(DependencyObject element);

    void SetIsDataValidForForm(DependencyObject element, bool value);

    DependencyProperty FullDescriptionProperty { get; }

    string GetFullDescription(DependencyObject element);

    void SetFullDescription(DependencyObject element, string value);

    DependencyProperty LocalizedControlTypeProperty { get; }

    string GetLocalizedControlType(DependencyObject element);

    void SetLocalizedControlType(DependencyObject element, string value);

    DependencyProperty DescribedByProperty { get; }

    IVector<DependencyObject> GetDescribedBy(DependencyObject element);

    DependencyProperty FlowsToProperty { get; }

    IVector<DependencyObject> GetFlowsTo(DependencyObject element);

    DependencyProperty FlowsFromProperty { get; }

    IVector<DependencyObject> GetFlowsFrom(DependencyObject element);
  }
}
