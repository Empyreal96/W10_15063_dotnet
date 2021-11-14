// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Storage.SharedAccess.SharedStorageAccessManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Phone.Storage.SharedAccess
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISharedStorageAccessManagerStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public static class SharedStorageAccessManager
  {
    [MethodImpl]
    public static extern IAsyncOperation<IStorageFile> CopySharedFileAsync(
      StorageFolder destinationFolder,
      string desiredName,
      NameCollisionOption option,
      string fileToken);

    [MethodImpl]
    public static extern string GetSharedFileName(string fileToken);
  }
}
