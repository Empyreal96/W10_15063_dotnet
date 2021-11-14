// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDrillInThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2962274340, 61906, 16824, 135, 186, 120, 3, 65, 38, 89, 76)]
  [ExclusiveTo(typeof (DrillInThemeAnimation))]
  internal interface IDrillInThemeAnimation
  {
    string EntranceTargetName { get; set; }

    DependencyObject EntranceTarget { get; set; }

    string ExitTargetName { get; set; }

    DependencyObject ExitTarget { get; set; }
  }
}
