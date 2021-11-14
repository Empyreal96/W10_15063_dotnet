// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDrillInThemeAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (DrillInThemeAnimation))]
  [Guid(3323978888, 41338, 19217, 181, 59, 164, 241, 160, 125, 75, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDrillInThemeAnimationStatics
  {
    DependencyProperty EntranceTargetNameProperty { get; }

    DependencyProperty EntranceTargetProperty { get; }

    DependencyProperty ExitTargetNameProperty { get; }

    DependencyProperty ExitTargetProperty { get; }
  }
}
