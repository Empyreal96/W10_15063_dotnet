// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IDragOverThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DragOverThemeAnimation : Timeline, IDragOverThemeAnimation
  {
    [MethodImpl]
    public extern DragOverThemeAnimation();

    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern double ToOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern AnimationDirection Direction { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty ToOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty DirectionProperty { [MethodImpl] get; }
  }
}
