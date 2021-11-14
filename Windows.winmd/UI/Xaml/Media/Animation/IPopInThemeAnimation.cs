// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPopInThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (PopInThemeAnimation))]
  [Guid(426326209, 7175, 19496, 136, 71, 249, 240, 85, 179, 40, 85)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPopInThemeAnimation
  {
    string TargetName { get; set; }

    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }
  }
}
