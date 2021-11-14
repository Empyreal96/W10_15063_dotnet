// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportVideoSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class PhotoImportVideoSegment : IPhotoImportVideoSegment
  {
    public extern string Name { [MethodImpl] get; }

    public extern ulong SizeInBytes { [MethodImpl] get; }

    public extern DateTime Date { [MethodImpl] get; }

    public extern PhotoImportSidecar Sibling { [MethodImpl] get; }

    public extern IVectorView<PhotoImportSidecar> Sidecars { [MethodImpl] get; }
  }
}
