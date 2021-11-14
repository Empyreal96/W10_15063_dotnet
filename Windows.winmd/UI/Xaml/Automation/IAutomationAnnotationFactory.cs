// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationAnnotationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (AutomationAnnotation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1225194066, 56768, 20073, 183, 107, 1, 157, 146, 141, 130, 47)]
  internal interface IAutomationAnnotationFactory
  {
    AutomationAnnotation CreateInstance(AnnotationType type);

    AutomationAnnotation CreateWithElementParameter(
      AnnotationType type,
      UIElement element);
  }
}
