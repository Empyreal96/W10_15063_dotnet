// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ConnectedAnimationService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Animation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IConnectedAnimationServiceStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class ConnectedAnimationService : IConnectedAnimationService
  {
    public extern TimeSpan DefaultDuration { [MethodImpl] get; [MethodImpl] set; }

    public extern CompositionEasingFunction DefaultEasingFunction { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern ConnectedAnimation PrepareToAnimate(
      string key,
      UIElement source);

    [MethodImpl]
    public extern ConnectedAnimation GetAnimation(string key);

    [MethodImpl]
    public static extern ConnectedAnimationService GetForCurrentView();
  }
}
