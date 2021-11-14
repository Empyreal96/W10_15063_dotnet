// Decompiled with JetBrains decompiler
// Type: Windows.Storage.CachedFileManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.Storage
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICachedFileManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class CachedFileManager
  {
    [MethodImpl]
    public static extern void DeferUpdates(IStorageFile file);

    [MethodImpl]
    public static extern IAsyncOperation<FileUpdateStatus> CompleteUpdatesAsync(
      IStorageFile file);
  }
}
