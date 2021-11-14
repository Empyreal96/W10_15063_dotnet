// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportStorageMedium
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportStorageMedium))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4072255635, 64645, 18559, 135, 194, 88, 214, 117, 208, 91, 7)]
  internal interface IPhotoImportStorageMedium
  {
    string Name { get; }

    string Description { get; }

    string SerialNumber { get; }

    PhotoImportStorageMediumType StorageMediumType { get; }

    PhotoImportAccessMode SupportedAccessMode { get; }

    ulong CapacityInBytes { get; }

    ulong AvailableSpaceInBytes { get; }

    void Refresh();
  }
}
