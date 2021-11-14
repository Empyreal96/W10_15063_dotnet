// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDrillOutThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DrillOutThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3633368287, 1747, 20350, 142, 74, 79, 183, 110, 37, 97, 57)]
  internal interface IDrillOutThemeAnimation
  {
    string EntranceTargetName { get; set; }

    DependencyObject EntranceTarget { get; set; }

    string ExitTargetName { get; set; }

    DependencyObject ExitTarget { get; set; }
  }
}
