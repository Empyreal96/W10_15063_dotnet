// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Import
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoImportItem : IPhotoImportItem
  {
    public extern string Name { [MethodImpl] get; }

    public extern ulong ItemKey { [MethodImpl] get; }

    public extern PhotoImportContentType ContentType { [MethodImpl] get; }

    public extern ulong SizeInBytes { [MethodImpl] get; }

    public extern DateTime Date { [MethodImpl] get; }

    public extern PhotoImportSidecar Sibling { [MethodImpl] get; }

    public extern IVectorView<PhotoImportSidecar> Sidecars { [MethodImpl] get; }

    public extern IVectorView<PhotoImportVideoSegment> VideoSegments { [MethodImpl] get; }

    public extern bool IsSelected { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    public extern IVectorView<string> ImportedFileNames { [MethodImpl] get; }

    public extern IVectorView<string> DeletedFileNames { [MethodImpl] get; }
  }
}
