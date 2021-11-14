// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlyoutPresenterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (FlyoutPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3998049935, 55926, 18074, 172, 215, 48, 96, 230, 19, 173, 231)]
  internal interface IFlyoutPresenterFactory
  {
    FlyoutPresenter CreateInstance(object outer, out object inner);
  }
}
