// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVirtualizingStackPanelStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (VirtualizingStackPanel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2199185272, 37331, 19798, 172, 9, 34, 58, 220, 210, 189, 63)]
  internal interface IVirtualizingStackPanelStatics
  {
    DependencyProperty AreScrollSnapPointsRegularProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty VirtualizationModeProperty { get; }

    VirtualizationMode GetVirtualizationMode(DependencyObject element);

    void SetVirtualizationMode(DependencyObject element, VirtualizationMode value);

    DependencyProperty IsVirtualizingProperty { get; }

    bool GetIsVirtualizing(DependencyObject o);
  }
}
