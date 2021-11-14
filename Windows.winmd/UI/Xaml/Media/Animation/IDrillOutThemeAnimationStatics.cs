// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDrillOutThemeAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DrillOutThemeAnimation))]
  [Guid(3199589275, 9751, 18568, 128, 221, 114, 250, 123, 182, 250, 195)]
  internal interface IDrillOutThemeAnimationStatics
  {
    DependencyProperty EntranceTargetNameProperty { get; }

    DependencyProperty EntranceTargetProperty { get; }

    DependencyProperty ExitTargetNameProperty { get; }

    DependencyProperty ExitTargetProperty { get; }
  }
}
