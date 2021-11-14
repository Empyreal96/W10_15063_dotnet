// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.DataTransfer
{
  [Static(typeof (ISharedStorageAccessManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class SharedStorageAccessManager
  {
    [MethodImpl]
    public static extern string AddFile(IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> RedeemTokenForFileAsync(
      string token);

    [MethodImpl]
    public static extern void RemoveFile(string token);
  }
}
