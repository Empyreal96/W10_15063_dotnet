// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportFindItemsResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(4225591867, 60665, 16490, 129, 94, 80, 21, 98, 91, 10, 136)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PhotoImportFindItemsResult))]
  internal interface IPhotoImportFindItemsResult2
  {
    void AddItemsInDateRangeToSelection(DateTime rangeStart, TimeSpan rangeLength);
  }
}
