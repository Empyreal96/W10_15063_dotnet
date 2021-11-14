// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ICachedFileManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (CachedFileManager))]
  [Guid(2415665738, 59266, 18781, 182, 20, 101, 76, 79, 11, 35, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICachedFileManagerStatics
  {
    void DeferUpdates(IStorageFile file);

    IAsyncOperation<FileUpdateStatus> CompleteUpdatesAsync(
      IStorageFile file);
  }
}
