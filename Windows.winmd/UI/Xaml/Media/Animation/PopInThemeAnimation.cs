// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PopInThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IPopInThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PopInThemeAnimation : Timeline, IPopInThemeAnimation
  {
    [MethodImpl]
    public extern PopInThemeAnimation();

    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern double FromHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern double FromVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty FromHorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty FromVerticalOffsetProperty { [MethodImpl] get; }
  }
}
