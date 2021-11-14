// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SplitOpenThemeAnimation))]
  [Guid(2019547050, 21590, 17977, 143, 210, 38, 186, 230, 165, 255, 228)]
  internal interface ISplitOpenThemeAnimation
  {
    string OpenedTargetName { get; set; }

    DependencyObject OpenedTarget { get; set; }

    string ClosedTargetName { get; set; }

    DependencyObject ClosedTarget { get; set; }

    string ContentTargetName { get; set; }

    DependencyObject ContentTarget { get; set; }

    double OpenedLength { get; set; }

    double ClosedLength { get; set; }

    double OffsetFromCenter { get; set; }

    AnimationDirection ContentTranslationDirection { get; set; }

    double ContentTranslationOffset { get; set; }
  }
}
