// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibrary
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [Static(typeof (IStorageLibraryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStorageLibraryStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class StorageLibrary : IStorageLibrary, IStorageLibrary2
  {
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> RequestAddFolderAsync();

    [MethodImpl]
    public extern IAsyncOperation<bool> RequestRemoveFolderAsync(StorageFolder folder);

    public extern IObservableVector<StorageFolder> Folders { [MethodImpl] get; }

    public extern StorageFolder SaveFolder { [MethodImpl] get; }

    public extern event TypedEventHandler<StorageLibrary, object> DefinitionChanged;

    public extern StorageLibraryChangeTracker ChangeTracker { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageLibrary> GetLibraryForUserAsync(
      User user,
      KnownLibraryId libraryId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageLibrary> GetLibraryAsync(
      KnownLibraryId libraryId);
  }
}
