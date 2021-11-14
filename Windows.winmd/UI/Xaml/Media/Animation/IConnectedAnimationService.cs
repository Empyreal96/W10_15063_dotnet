// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IConnectedAnimationService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(476607945, 6587, 19783, 185, 170, 102, 200, 2, 220, 185, 255)]
  [ExclusiveTo(typeof (ConnectedAnimationService))]
  [WebHostHidden]
  internal interface IConnectedAnimationService
  {
    TimeSpan DefaultDuration { get; set; }

    CompositionEasingFunction DefaultEasingFunction { get; set; }

    ConnectedAnimation PrepareToAnimate(string key, UIElement source);

    ConnectedAnimation GetAnimation(string key);
  }
}
