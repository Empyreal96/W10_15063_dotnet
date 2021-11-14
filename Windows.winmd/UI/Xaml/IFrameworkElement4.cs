// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  [Guid(1802918835, 64419, 17412, 189, 238, 26, 69, 209, 202, 95, 33)]
  [WebHostHidden]
  [ExclusiveTo(typeof (FrameworkElement))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IFrameworkElement4
  {
    bool AllowFocusOnInteraction { get; set; }

    Thickness FocusVisualMargin { get; set; }

    Thickness FocusVisualSecondaryThickness { get; set; }

    Thickness FocusVisualPrimaryThickness { get; set; }

    Brush FocusVisualSecondaryBrush { get; set; }

    Brush FocusVisualPrimaryBrush { get; set; }

    bool AllowFocusWhenDisabled { get; set; }
  }
}
