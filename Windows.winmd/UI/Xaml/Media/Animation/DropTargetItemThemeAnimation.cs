// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDropTargetItemThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DropTargetItemThemeAnimation : Timeline, IDropTargetItemThemeAnimation
  {
    [MethodImpl]
    public extern DropTargetItemThemeAnimation();

    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }
  }
}
