// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlyoutStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Flyout))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1630948875, 56181, 18401, 178, 195, 91, 144, 28, 61, 116, 182)]
  internal interface IFlyoutStatics
  {
    DependencyProperty ContentProperty { get; }

    DependencyProperty FlyoutPresenterStyleProperty { get; }
  }
}
