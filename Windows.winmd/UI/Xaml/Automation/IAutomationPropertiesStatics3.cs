// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(2071320373, 23729, 17069, 155, 87, 95, 171, 168, 193, 134, 127)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAutomationPropertiesStatics3
  {
    DependencyProperty PositionInSetProperty { get; }

    int GetPositionInSet(DependencyObject element);

    void SetPositionInSet(DependencyObject element, int value);

    DependencyProperty SizeOfSetProperty { get; }

    int GetSizeOfSet(DependencyObject element);

    void SetSizeOfSet(DependencyObject element, int value);

    DependencyProperty LevelProperty { get; }

    int GetLevel(DependencyObject element);

    void SetLevel(DependencyObject element, int value);

    DependencyProperty AnnotationsProperty { get; }

    IVector<AutomationAnnotation> GetAnnotations(DependencyObject element);
  }
}
