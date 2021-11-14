// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IContentIndexer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [Guid(2977333133, 63128, 18818, 176, 95, 58, 110, 140, 171, 1, 162)]
  [ExclusiveTo(typeof (ContentIndexer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentIndexer
  {
    IAsyncAction AddAsync(IIndexableContent indexableContent);

    IAsyncAction UpdateAsync(IIndexableContent indexableContent);

    [RemoteAsync]
    IAsyncAction DeleteAsync(string contentId);

    IAsyncAction DeleteMultipleAsync(IIterable<string> contentIds);

    [RemoteAsync]
    IAsyncAction DeleteAllAsync();

    IAsyncOperation<IMapView<string, object>> RetrievePropertiesAsync(
      string contentId,
      IIterable<string> propertiesToRetrieve);

    ulong Revision { get; }
  }
}
