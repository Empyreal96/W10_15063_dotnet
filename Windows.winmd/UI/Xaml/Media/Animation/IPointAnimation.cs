// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPointAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(821052178, 30502, 20360, 184, 226, 47, 165, 69, 24, 150, 59)]
  [ExclusiveTo(typeof (PointAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointAnimation
  {
    IReference<Point> From { get; set; }

    IReference<Point> To { get; set; }

    IReference<Point> By { get; set; }

    EasingFunctionBase EasingFunction { get; set; }

    bool EnableDependentAnimation { get; set; }
  }
}
