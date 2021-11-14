// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
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
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISplitCloseThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SplitCloseThemeAnimation : Timeline, ISplitCloseThemeAnimation
  {
    [MethodImpl]
    public extern SplitCloseThemeAnimation();

    public extern string OpenedTargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject OpenedTarget { [MethodImpl] get; [MethodImpl] set; }

    public extern string ClosedTargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject ClosedTarget { [MethodImpl] get; [MethodImpl] set; }

    public extern string ContentTargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject ContentTarget { [MethodImpl] get; [MethodImpl] set; }

    public extern double OpenedLength { [MethodImpl] get; [MethodImpl] set; }

    public extern double ClosedLength { [MethodImpl] get; [MethodImpl] set; }

    public extern double OffsetFromCenter { [MethodImpl] get; [MethodImpl] set; }

    public extern AnimationDirection ContentTranslationDirection { [MethodImpl] get; [MethodImpl] set; }

    public extern double ContentTranslationOffset { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty OpenedTargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty OpenedTargetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ClosedTargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty ClosedTargetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTargetProperty { [MethodImpl] get; }

    public static extern DependencyProperty OpenedLengthProperty { [MethodImpl] get; }

    public static extern DependencyProperty ClosedLengthProperty { [MethodImpl] get; }

    public static extern DependencyProperty OffsetFromCenterProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTranslationDirectionProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTranslationOffsetProperty { [MethodImpl] get; }
  }
}
