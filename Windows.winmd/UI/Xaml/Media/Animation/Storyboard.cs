// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.Storyboard
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Children")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStoryboardStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Storyboard : Timeline, IStoryboard
  {
    [MethodImpl]
    public extern Storyboard();

    public extern TimelineCollection Children { [MethodImpl] get; }

    [MethodImpl]
    public extern void Seek(TimeSpan offset);

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void Begin();

    [MethodImpl]
    public extern void Pause();

    [MethodImpl]
    public extern void Resume();

    [MethodImpl]
    public extern ClockState GetCurrentState();

    [MethodImpl]
    public extern TimeSpan GetCurrentTime();

    [MethodImpl]
    public extern void SeekAlignedToLastTick(TimeSpan offset);

    [MethodImpl]
    public extern void SkipToFill();

    public static extern DependencyProperty TargetPropertyProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetTargetProperty(Timeline element);

    [MethodImpl]
    public static extern void SetTargetProperty(Timeline element, string path);

    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetTargetName(Timeline element);

    [MethodImpl]
    public static extern void SetTargetName(Timeline element, string name);

    [MethodImpl]
    public static extern void SetTarget(Timeline timeline, DependencyObject target);
  }
}
