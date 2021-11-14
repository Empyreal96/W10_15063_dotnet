// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportVideoSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1648099977, 12826, 16856, 145, 102, 140, 98, 163, 51, 39, 108)]
  [ExclusiveTo(typeof (PhotoImportVideoSegment))]
  internal interface IPhotoImportVideoSegment
  {
    string Name { get; }

    ulong SizeInBytes { get; }

    DateTime Date { get; }

    PhotoImportSidecar Sibling { get; }

    IVectorView<PhotoImportSidecar> Sidecars { get; }
  }
}
