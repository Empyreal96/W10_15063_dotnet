// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsPresenter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1543809587, 7667, 18225, 164, 201, 218, 129, 131, 120, 214, 61)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemsPresenter))]
  internal interface IItemsPresenter2
  {
    object Footer { get; set; }

    DataTemplate FooterTemplate { get; set; }

    TransitionCollection FooterTransitions { get; set; }
  }
}
