// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsPresenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ItemsPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3262207643, 28106, 20011, 142, 20, 197, 81, 54, 176, 42, 113)]
  internal interface IItemsPresenter
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    TransitionCollection HeaderTransitions { get; set; }

    Thickness Padding { get; set; }
  }
}
