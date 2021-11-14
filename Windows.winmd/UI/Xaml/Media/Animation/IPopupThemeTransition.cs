// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPopupThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(1199846738, 17027, 21598, 199, 145, 38, 141, 202, 34, 206, 75)]
  [ExclusiveTo(typeof (PopupThemeTransition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPopupThemeTransition
  {
    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }
  }
}
