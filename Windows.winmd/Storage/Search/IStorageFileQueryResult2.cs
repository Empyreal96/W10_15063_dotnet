// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageFileQueryResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (StorageFileQueryResult))]
  [Guid(1314765277, 28993, 18116, 139, 227, 233, 220, 158, 39, 39, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageFileQueryResult2 : IStorageQueryResultBase
  {
    IMap<string, IVectorView<TextSegment>> GetMatchingPropertiesWithRanges(
      StorageFile file);
  }
}
