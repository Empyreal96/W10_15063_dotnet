// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutItemStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1230025764, 42042, 16887, 170, 58, 156, 233, 97, 151, 71, 213)]
  [ExclusiveTo(typeof (MenuFlyoutItem))]
  [WebHostHidden]
  internal interface IMenuFlyoutItemStatics
  {
    DependencyProperty TextProperty { get; }

    DependencyProperty CommandProperty { get; }

    DependencyProperty CommandParameterProperty { get; }
  }
}
