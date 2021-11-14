// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEntranceThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(124357641, 43235, 16794, 160, 29, 116, 16, 160, 174, 142, 200)]
  [ExclusiveTo(typeof (EntranceThemeTransition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IEntranceThemeTransition
  {
    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }

    bool IsStaggeringEnabled { get; set; }
  }
}
