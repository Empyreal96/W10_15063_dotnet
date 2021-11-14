// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControl3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1345025161, 44772, 19939, 162, 171, 25, 90, 194, 12, 66, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemsControl))]
  internal interface IItemsControl3
  {
    DependencyObject GroupHeaderContainerFromItemContainer(
      DependencyObject itemContainer);
  }
}
