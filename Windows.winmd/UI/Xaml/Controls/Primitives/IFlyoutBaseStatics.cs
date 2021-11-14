// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBaseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (FlyoutBase))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3805779427, 34240, 19938, 186, 193, 82, 148, 202, 1, 26, 120)]
  internal interface IFlyoutBaseStatics
  {
    DependencyProperty PlacementProperty { get; }

    DependencyProperty AttachedFlyoutProperty { get; }

    FlyoutBase GetAttachedFlyout(FrameworkElement element);

    void SetAttachedFlyout(FrameworkElement element, FlyoutBase value);

    void ShowAttachedFlyout(FrameworkElement flyoutOwner);
  }
}
