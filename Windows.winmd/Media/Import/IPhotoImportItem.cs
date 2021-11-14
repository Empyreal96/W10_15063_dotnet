// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Import
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2849013366, 39932, 17336, 179, 86, 99, 59, 106, 152, 140, 158)]
  [ExclusiveTo(typeof (PhotoImportItem))]
  internal interface IPhotoImportItem
  {
    string Name { get; }

    ulong ItemKey { get; }

    PhotoImportContentType ContentType { get; }

    ulong SizeInBytes { get; }

    DateTime Date { get; }

    PhotoImportSidecar Sibling { get; }

    IVectorView<PhotoImportSidecar> Sidecars { get; }

    IVectorView<PhotoImportVideoSegment> VideoSegments { get; }

    bool IsSelected { get; set; }

    IRandomAccessStreamReference Thumbnail { get; }

    IVectorView<string> ImportedFileNames { get; }

    IVectorView<string> DeletedFileNames { get; }
  }
}
