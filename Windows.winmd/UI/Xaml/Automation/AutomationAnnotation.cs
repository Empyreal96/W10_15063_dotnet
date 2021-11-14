// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationAnnotation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(typeof (IAutomationAnnotationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationAnnotationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AutomationAnnotation : DependencyObject, IAutomationAnnotation
  {
    [MethodImpl]
    public extern AutomationAnnotation(AnnotationType type);

    [MethodImpl]
    public extern AutomationAnnotation(AnnotationType type, UIElement element);

    [MethodImpl]
    public extern AutomationAnnotation();

    public extern AnnotationType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement Element { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ElementProperty { [MethodImpl] get; }
  }
}
