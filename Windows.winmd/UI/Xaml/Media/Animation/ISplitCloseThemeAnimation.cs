// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (SplitCloseThemeAnimation))]
  [WebHostHidden]
  [Guid(1333368088, 65337, 20112, 187, 116, 42, 189, 86, 2, 116, 2)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISplitCloseThemeAnimation
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
