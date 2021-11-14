// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [Guid(4158006869, 12570, 19324, 161, 49, 82, 78, 137, 205, 60, 249)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (AutomationProperties))]
  [WebHostHidden]
  internal interface IAutomationPropertiesStatics4
  {
    DependencyProperty LandmarkTypeProperty { get; }

    AutomationLandmarkType GetLandmarkType(DependencyObject element);

    void SetLandmarkType(DependencyObject element, AutomationLandmarkType value);

    DependencyProperty LocalizedLandmarkTypeProperty { get; }

    string GetLocalizedLandmarkType(DependencyObject element);

    void SetLocalizedLandmarkType(DependencyObject element, string value);
  }
}
