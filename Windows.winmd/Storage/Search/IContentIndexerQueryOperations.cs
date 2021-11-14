// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IContentIndexerQueryOperations
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (ContentIndexer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(679624208, 18310, 17137, 151, 48, 121, 43, 53, 102, 177, 80)]
  internal interface IContentIndexerQueryOperations
  {
    [Overload("CreateQueryWithSortOrderAndLanguage")]
    ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve,
      IIterable<SortEntry> sortOrder,
      string searchFilterLanguage);

    [Overload("CreateQueryWithSortOrder")]
    ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve,
      IIterable<SortEntry> sortOrder);

    [Overload("CreateQuery")]
    ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve);
  }
}
