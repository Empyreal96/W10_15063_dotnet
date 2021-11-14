// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewPersistenceHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1829513992, 48027, 17657, 128, 99, 92, 63, 156, 33, 136, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewPersistenceHelper))]
  internal interface IListViewPersistenceHelperStatics
  {
    string GetRelativeScrollPosition(
      ListViewBase listViewBase,
      ListViewItemToKeyHandler itemToKeyHandler);

    [RemoteAsync]
    IAsyncAction SetRelativeScrollPositionAsync(
      ListViewBase listViewBase,
      string relativeScrollPosition,
      ListViewKeyToItemHandler keyToItemHandler);
  }
}
