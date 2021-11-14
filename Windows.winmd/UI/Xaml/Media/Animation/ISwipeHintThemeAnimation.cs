// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISwipeHintThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SwipeHintThemeAnimation))]
  [WebHostHidden]
  [Guid(3452987328, 22542, 20032, 190, 152, 242, 2, 211, 216, 67, 101)]
  internal interface ISwipeHintThemeAnimation
  {
    string TargetName { get; set; }

    double ToHorizontalOffset { get; set; }

    double ToVerticalOffset { get; set; }
  }
}
