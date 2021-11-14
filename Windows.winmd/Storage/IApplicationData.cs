// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (ApplicationData))]
  [Guid(3285872567, 46916, 19269, 176, 184, 34, 58, 9, 56, 208, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationData
  {
    uint Version { get; }

    [RemoteAsync]
    IAsyncAction SetVersionAsync(
      uint desiredVersion,
      ApplicationDataSetVersionHandler handler);

    [RemoteAsync]
    [Overload("ClearAllAsync")]
    IAsyncAction ClearAsync();

    [Overload("ClearAsync")]
    [RemoteAsync]
    IAsyncAction ClearAsync(ApplicationDataLocality locality);

    ApplicationDataContainer LocalSettings { get; }

    ApplicationDataContainer RoamingSettings { get; }

    StorageFolder LocalFolder { get; }

    StorageFolder RoamingFolder { get; }

    StorageFolder TemporaryFolder { get; }

    event TypedEventHandler<ApplicationData, object> DataChanged;

    void SignalDataChanged();

    ulong RoamingStorageQuota { get; }
  }
}
