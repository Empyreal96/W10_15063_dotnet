// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationAnnotationStatics
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
  [Guid(3842239159, 20197, 18635, 181, 184, 187, 205, 70, 201, 209, 218)]
  internal interface IAutomationAnnotationStatics
  {
    DependencyProperty TypeProperty { get; }

    DependencyProperty ElementProperty { get; }
  }
}
