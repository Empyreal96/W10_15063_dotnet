// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ContentThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IContentThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class ContentThemeTransition : Transition, IContentThemeTransition
  {
    [MethodImpl]
    public extern ContentThemeTransition();

    public extern double HorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern double VerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty HorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalOffsetProperty { [MethodImpl] get; }
  }
}
