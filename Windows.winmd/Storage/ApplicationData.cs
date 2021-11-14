// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ApplicationData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IApplicationDataStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IApplicationDataStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class ApplicationData : IApplicationData, IApplicationData2, IApplicationData3
  {
    public extern uint Version { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetVersionAsync(
      uint desiredVersion,
      ApplicationDataSetVersionHandler handler);

    [RemoteAsync]
    [Overload("ClearAllAsync")]
    [MethodImpl]
    public extern IAsyncAction ClearAsync();

    [RemoteAsync]
    [Overload("ClearAsync")]
    [MethodImpl]
    public extern IAsyncAction ClearAsync(ApplicationDataLocality locality);

    public extern ApplicationDataContainer LocalSettings { [MethodImpl] get; }

    public extern ApplicationDataContainer RoamingSettings { [MethodImpl] get; }

    public extern StorageFolder LocalFolder { [MethodImpl] get; }

    public extern StorageFolder RoamingFolder { [MethodImpl] get; }

    public extern StorageFolder TemporaryFolder { [MethodImpl] get; }

    public extern event TypedEventHandler<ApplicationData, object> DataChanged;

    [MethodImpl]
    public extern void SignalDataChanged();

    public extern ulong RoamingStorageQuota { [MethodImpl] get; }

    public extern StorageFolder LocalCacheFolder { [MethodImpl] get; }

    [MethodImpl]
    public extern StorageFolder GetPublisherCacheFolder(string folderName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearPublisherCacheFolderAsync(string folderName);

    public extern StorageFolder SharedLocalFolder { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ApplicationData> GetForUserAsync(
      User user);

    public static extern ApplicationData Current { [MethodImpl] get; }
  }
}
