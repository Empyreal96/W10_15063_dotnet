// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportStorageMedium
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PhotoImportStorageMedium : IPhotoImportStorageMedium
  {
    public extern string Name { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern string SerialNumber { [MethodImpl] get; }

    public extern PhotoImportStorageMediumType StorageMediumType { [MethodImpl] get; }

    public extern PhotoImportAccessMode SupportedAccessMode { [MethodImpl] get; }

    public extern ulong CapacityInBytes { [MethodImpl] get; }

    public extern ulong AvailableSpaceInBytes { [MethodImpl] get; }

    [MethodImpl]
    public extern void Refresh();
  }
}
