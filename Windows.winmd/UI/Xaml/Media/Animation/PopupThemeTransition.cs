// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PopupThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPopupThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PopupThemeTransition : Transition, IPopupThemeTransition
  {
    [MethodImpl]
    public extern PopupThemeTransition();

    public extern double FromHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern double FromVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FromHorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty FromVerticalOffsetProperty { [MethodImpl] get; }
  }
}
