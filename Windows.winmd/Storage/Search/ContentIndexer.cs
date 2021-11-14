// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.ContentIndexer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [Static(typeof (IContentIndexerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContentIndexer : IContentIndexer, IContentIndexerQueryOperations
  {
    [MethodImpl]
    public extern IAsyncAction AddAsync(IIndexableContent indexableContent);

    [MethodImpl]
    public extern IAsyncAction UpdateAsync(IIndexableContent indexableContent);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(string contentId);

    [MethodImpl]
    public extern IAsyncAction DeleteMultipleAsync(IIterable<string> contentIds);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAllAsync();

    [MethodImpl]
    public extern IAsyncOperation<IMapView<string, object>> RetrievePropertiesAsync(
      string contentId,
      IIterable<string> propertiesToRetrieve);

    public extern ulong Revision { [MethodImpl] get; }

    [Overload("CreateQueryWithSortOrderAndLanguage")]
    [MethodImpl]
    public extern ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve,
      IIterable<SortEntry> sortOrder,
      string searchFilterLanguage);

    [Overload("CreateQueryWithSortOrder")]
    [MethodImpl]
    public extern ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve,
      IIterable<SortEntry> sortOrder);

    [Overload("CreateQuery")]
    [MethodImpl]
    public extern ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve);

    [Overload("GetIndexerWithName")]
    [MethodImpl]
    public static extern ContentIndexer GetIndexer(string indexName);

    [Overload("GetIndexer")]
    [MethodImpl]
    public static extern ContentIndexer GetIndexer();
  }
}
