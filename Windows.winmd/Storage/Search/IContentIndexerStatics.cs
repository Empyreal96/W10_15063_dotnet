// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IContentIndexerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (ContentIndexer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2353562485, 45950, 19552, 155, 168, 183, 96, 253, 163, 229, 157)]
  internal interface IContentIndexerStatics
  {
    [Overload("GetIndexerWithName")]
    ContentIndexer GetIndexer(string indexName);

    [Overload("GetIndexer")]
    ContentIndexer GetIndexer();
  }
}
