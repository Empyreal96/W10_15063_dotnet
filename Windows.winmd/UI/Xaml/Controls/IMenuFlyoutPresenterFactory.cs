// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutPresenterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MenuFlyoutPresenter))]
  [WebHostHidden]
  [Guid(3096137873, 4124, 16888, 170, 193, 27, 16, 92, 20, 251, 153)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMenuFlyoutPresenterFactory
  {
    MenuFlyoutPresenter CreateInstance(object outer, out object inner);
  }
}
