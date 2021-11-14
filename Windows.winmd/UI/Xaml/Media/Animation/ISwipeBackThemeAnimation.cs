// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISwipeBackThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SwipeBackThemeAnimation))]
  [Guid(2743747092, 3018, 19757, 149, 247, 206, 186, 87, 251, 175, 96)]
  [WebHostHidden]
  internal interface ISwipeBackThemeAnimation
  {
    string TargetName { get; set; }

    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }
  }
}
