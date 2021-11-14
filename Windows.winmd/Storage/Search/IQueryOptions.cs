// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(509495022, 3909, 18488, 168, 233, 208, 71, 157, 68, 108, 48)]
  [ExclusiveTo(typeof (QueryOptions))]
  internal interface IQueryOptions
  {
    IVector<string> FileTypeFilter { get; }

    FolderDepth FolderDepth { get; set; }

    string ApplicationSearchFilter { get; set; }

    string UserSearchFilter { get; set; }

    string Language { get; set; }

    IndexerOption IndexerOption { get; set; }

    IVector<SortEntry> SortOrder { get; }

    string GroupPropertyName { get; }

    DateStackOption DateStackOption { get; }

    string SaveToString();

    void LoadFromString(string value);

    void SetThumbnailPrefetch(ThumbnailMode mode, uint requestedSize, ThumbnailOptions options);

    void SetPropertyPrefetch(
      PropertyPrefetchOptions options,
      IIterable<string> propertiesToRetrieve);
  }
}
