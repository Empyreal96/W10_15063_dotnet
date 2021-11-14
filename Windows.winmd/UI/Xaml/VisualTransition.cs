// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [ContentProperty(Name = "Storyboard")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IVisualTransitionFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class VisualTransition : DependencyObject, IVisualTransition
  {
    [MethodImpl]
    public extern VisualTransition();

    public extern Duration GeneratedDuration { [MethodImpl] get; [MethodImpl] set; }

    public extern EasingFunctionBase GeneratedEasingFunction { [MethodImpl] get; [MethodImpl] set; }

    public extern string To { [MethodImpl] get; [MethodImpl] set; }

    public extern string From { [MethodImpl] get; [MethodImpl] set; }

    public extern Storyboard Storyboard { [MethodImpl] get; [MethodImpl] set; }
  }
}
