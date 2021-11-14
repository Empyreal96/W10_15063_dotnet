// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewPersistenceHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IListViewPersistenceHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ListViewPersistenceHelper : IListViewPersistenceHelper
  {
    [MethodImpl]
    public static extern string GetRelativeScrollPosition(
      ListViewBase listViewBase,
      ListViewItemToKeyHandler itemToKeyHandler);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetRelativeScrollPositionAsync(
      ListViewBase listViewBase,
      string relativeScrollPosition,
      ListViewKeyToItemHandler keyToItemHandler);
  }
}
