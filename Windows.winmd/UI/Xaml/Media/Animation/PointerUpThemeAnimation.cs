// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PointerUpThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPointerUpThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class PointerUpThemeAnimation : Timeline, IPointerUpThemeAnimation
  {
    [MethodImpl]
    public extern PointerUpThemeAnimation();

    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }
  }
}
