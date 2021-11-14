// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IRepositionThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RepositionThemeAnimation))]
  [Guid(3973719272, 35141, 18761, 161, 191, 98, 16, 153, 101, 167, 233)]
  [WebHostHidden]
  internal interface IRepositionThemeAnimation
  {
    string TargetName { get; set; }

    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }
  }
}
