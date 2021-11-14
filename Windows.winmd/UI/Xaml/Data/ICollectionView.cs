// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2347286500, 56303, 17631, 129, 38, 163, 26, 137, 18, 29, 220)]
  [WebHostHidden]
  public interface ICollectionView : IObservableVector<object>, IVector<object>, IIterable<object>
  {
    object CurrentItem { get; }

    int CurrentPosition { get; }

    bool IsCurrentAfterLast { get; }

    bool IsCurrentBeforeFirst { get; }

    IObservableVector<object> CollectionGroups { get; }

    bool HasMoreItems { get; }

    event EventHandler<object> CurrentChanged;

    event CurrentChangingEventHandler CurrentChanging;

    bool MoveCurrentTo(object item);

    bool MoveCurrentToPosition(int index);

    bool MoveCurrentToFirst();

    bool MoveCurrentToLast();

    bool MoveCurrentToNext();

    bool MoveCurrentToPrevious();

    [RemoteAsync]
    IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(
      uint count);
  }
}
