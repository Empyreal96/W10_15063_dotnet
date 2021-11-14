// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PaneThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IPaneThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaneThemeTransition : Transition, IPaneThemeTransition
  {
    [MethodImpl]
    public extern PaneThemeTransition();

    public extern EdgeTransitionLocation Edge { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty EdgeProperty { [MethodImpl] get; }
  }
}
