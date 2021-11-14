// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.BeginStoryboard
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBeginStoryboardStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Storyboard")]
  public sealed class BeginStoryboard : TriggerAction, IBeginStoryboard
  {
    [MethodImpl]
    public extern BeginStoryboard();

    public extern Storyboard Storyboard { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty StoryboardProperty { [MethodImpl] get; }
  }
}
