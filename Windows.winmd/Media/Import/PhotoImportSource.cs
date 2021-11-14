// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Import
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPhotoImportSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class PhotoImportSource : IPhotoImportSource
  {
    public extern string Id { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern string Manufacturer { [MethodImpl] get; }

    public extern string Model { [MethodImpl] get; }

    public extern string SerialNumber { [MethodImpl] get; }

    public extern string ConnectionProtocol { [MethodImpl] get; }

    public extern PhotoImportConnectionTransport ConnectionTransport { [MethodImpl] get; }

    public extern PhotoImportSourceType Type { [MethodImpl] get; }

    public extern PhotoImportPowerSource PowerSource { [MethodImpl] get; }

    public extern IReference<uint> BatteryLevelPercent { [MethodImpl] get; }

    public extern IReference<global::Windows.Foundation.DateTime> DateTime { [MethodImpl] get; }

    public extern IVectorView<PhotoImportStorageMedium> StorageMedia { [MethodImpl] get; }

    public extern IReference<bool> IsLocked { [MethodImpl] get; }

    public extern bool IsMassStorage { [MethodImpl] get; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    [MethodImpl]
    public extern PhotoImportSession CreateImportSession();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PhotoImportSource> FromIdAsync(
      string sourceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PhotoImportSource> FromFolderAsync(
      IStorageFolder sourceRootFolder);
  }
}
