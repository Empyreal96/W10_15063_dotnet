// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.CommonFolderQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CommonFolderQuery
  {
    DefaultQuery = 0,
    GroupByYear = 100, // 0x00000064
    GroupByMonth = 101, // 0x00000065
    GroupByArtist = 102, // 0x00000066
    GroupByAlbum = 103, // 0x00000067
    GroupByAlbumArtist = 104, // 0x00000068
    GroupByComposer = 105, // 0x00000069
    GroupByGenre = 106, // 0x0000006A
    GroupByPublishedYear = 107, // 0x0000006B
    GroupByRating = 108, // 0x0000006C
    GroupByTag = 109, // 0x0000006D
    GroupByAuthor = 110, // 0x0000006E
    GroupByType = 111, // 0x0000006F
  }
}
