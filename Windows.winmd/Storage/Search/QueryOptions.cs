// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.QueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage.Search
{
  [Activatable(typeof (IQueryOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class QueryOptions : IQueryOptions, IQueryOptionsWithProviderFilter
  {
    [MethodImpl]
    public extern QueryOptions(CommonFileQuery query, IIterable<string> fileTypeFilter);

    [MethodImpl]
    public extern QueryOptions(CommonFolderQuery query);

    [MethodImpl]
    public extern QueryOptions();

    public extern IVector<string> FileTypeFilter { [MethodImpl] get; }

    public extern FolderDepth FolderDepth { [MethodImpl] get; [MethodImpl] set; }

    public extern string ApplicationSearchFilter { [MethodImpl] get; [MethodImpl] set; }

    public extern string UserSearchFilter { [MethodImpl] get; [MethodImpl] set; }

    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    public extern IndexerOption IndexerOption { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<SortEntry> SortOrder { [MethodImpl] get; }

    public extern string GroupPropertyName { [MethodImpl] get; }

    public extern DateStackOption DateStackOption { [MethodImpl] get; }

    [MethodImpl]
    public extern string SaveToString();

    [MethodImpl]
    public extern void LoadFromString(string value);

    [MethodImpl]
    public extern void SetThumbnailPrefetch(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    [MethodImpl]
    public extern void SetPropertyPrefetch(
      PropertyPrefetchOptions options,
      IIterable<string> propertiesToRetrieve);

    public extern IVector<string> StorageProviderIdFilter { [MethodImpl] get; }
  }
}
