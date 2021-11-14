// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsPresenterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(417228493, 19052, 19246, 170, 134, 203, 18, 108, 154, 41, 32)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemsPresenter))]
  internal interface IItemsPresenterStatics
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty HeaderTransitionsProperty { get; }

    DependencyProperty PaddingProperty { get; }
  }
}
