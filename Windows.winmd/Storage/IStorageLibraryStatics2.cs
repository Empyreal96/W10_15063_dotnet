// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [Guid(4289760732, 64117, 18069, 185, 209, 127, 129, 249, 120, 50, 227)]
  [ExclusiveTo(typeof (StorageLibrary))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IStorageLibraryStatics2
  {
    [RemoteAsync]
    IAsyncOperation<StorageLibrary> GetLibraryForUserAsync(
      User user,
      KnownLibraryId libraryId);
  }
}
