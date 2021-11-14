// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDrillInThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DrillInThemeAnimation : Timeline, IDrillInThemeAnimation
  {
    [MethodImpl]
    public extern DrillInThemeAnimation();

    public extern string EntranceTargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject EntranceTarget { [MethodImpl] get; [MethodImpl] set; }

    public extern string ExitTargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject ExitTarget { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty EntranceTargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty EntranceTargetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ExitTargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty ExitTargetProperty { [MethodImpl] get; }
  }
}
