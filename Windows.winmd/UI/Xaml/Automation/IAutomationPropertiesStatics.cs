// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationProperties))]
  [WebHostHidden]
  [Guid(3055091067, 13008, 18800, 156, 66, 124, 3, 154, 199, 190, 120)]
  internal interface IAutomationPropertiesStatics
  {
    DependencyProperty AcceleratorKeyProperty { get; }

    string GetAcceleratorKey(DependencyObject element);

    void SetAcceleratorKey(DependencyObject element, string value);

    DependencyProperty AccessKeyProperty { get; }

    string GetAccessKey(DependencyObject element);

    void SetAccessKey(DependencyObject element, string value);

    DependencyProperty AutomationIdProperty { get; }

    string GetAutomationId(DependencyObject element);

    void SetAutomationId(DependencyObject element, string value);

    DependencyProperty HelpTextProperty { get; }

    string GetHelpText(DependencyObject element);

    void SetHelpText(DependencyObject element, string value);

    DependencyProperty IsRequiredForFormProperty { get; }

    bool GetIsRequiredForForm(DependencyObject element);

    void SetIsRequiredForForm(DependencyObject element, bool value);

    DependencyProperty ItemStatusProperty { get; }

    string GetItemStatus(DependencyObject element);

    void SetItemStatus(DependencyObject element, string value);

    DependencyProperty ItemTypeProperty { get; }

    string GetItemType(DependencyObject element);

    void SetItemType(DependencyObject element, string value);

    DependencyProperty LabeledByProperty { get; }

    UIElement GetLabeledBy(DependencyObject element);

    void SetLabeledBy(DependencyObject element, UIElement value);

    DependencyProperty NameProperty { get; }

    string GetName(DependencyObject element);

    void SetName(DependencyObject element, string value);

    DependencyProperty LiveSettingProperty { get; }

    AutomationLiveSetting GetLiveSetting(DependencyObject element);

    void SetLiveSetting(DependencyObject element, AutomationLiveSetting value);
  }
}
