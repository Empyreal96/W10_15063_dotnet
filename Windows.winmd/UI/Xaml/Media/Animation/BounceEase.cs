// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.BounceEase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBounceEaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class BounceEase : EasingFunctionBase, IBounceEase
  {
    [MethodImpl]
    public extern BounceEase();

    public extern int Bounces { [MethodImpl] get; [MethodImpl] set; }

    public extern double Bounciness { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty BouncesProperty { [MethodImpl] get; }

    public static extern DependencyProperty BouncinessProperty { [MethodImpl] get; }
  }
}
