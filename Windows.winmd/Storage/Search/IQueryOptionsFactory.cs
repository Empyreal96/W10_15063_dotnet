// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IQueryOptionsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(53354380, 43457, 20081, 128, 17, 13, 238, 157, 72, 17, 163)]
  [ExclusiveTo(typeof (QueryOptions))]
  internal interface IQueryOptionsFactory
  {
    QueryOptions CreateCommonFileQuery(
      CommonFileQuery query,
      IIterable<string> fileTypeFilter);

    QueryOptions CreateCommonFolderQuery(CommonFolderQuery query);
  }
}
