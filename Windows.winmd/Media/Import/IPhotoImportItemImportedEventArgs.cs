// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportItemImportedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(1120612317, 32104, 18357, 188, 124, 206, 183, 62, 12, 119, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportItemImportedEventArgs))]
  internal interface IPhotoImportItemImportedEventArgs
  {
    PhotoImportItem ImportedItem { get; }
  }
}
