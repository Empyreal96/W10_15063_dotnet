// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Import
{
  [Guid(529441630, 5211, 19670, 135, 241, 84, 150, 90, 152, 47, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportSource))]
  internal interface IPhotoImportSource
  {
    string Id { get; }

    string DisplayName { get; }

    string Description { get; }

    string Manufacturer { get; }

    string Model { get; }

    string SerialNumber { get; }

    string ConnectionProtocol { get; }

    PhotoImportConnectionTransport ConnectionTransport { get; }

    PhotoImportSourceType Type { get; }

    PhotoImportPowerSource PowerSource { get; }

    IReference<uint> BatteryLevelPercent { get; }

    IReference<global::Windows.Foundation.DateTime> DateTime { get; }

    IVectorView<PhotoImportStorageMedium> StorageMedia { get; }

    IReference<bool> IsLocked { get; }

    bool IsMassStorage { get; }

    IRandomAccessStreamReference Thumbnail { get; }

    PhotoImportSession CreateImportSession();
  }
}
