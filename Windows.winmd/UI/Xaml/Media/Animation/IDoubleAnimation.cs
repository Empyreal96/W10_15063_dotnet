// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDoubleAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2124365145, 3847, 19401, 151, 125, 3, 118, 63, 248, 21, 79)]
  [ExclusiveTo(typeof (DoubleAnimation))]
  internal interface IDoubleAnimation
  {
    IReference<double> From { get; set; }

    IReference<double> To { get; set; }

    IReference<double> By { get; set; }

    EasingFunctionBase EasingFunction { get; set; }

    bool EnableDependentAnimation { get; set; }
  }
}
