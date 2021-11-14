// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFolder2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3894929593, 2265, 19086, 160, 172, 254, 94, 211, 203, 187, 211)]
  public interface IStorageFolder2
  {
    [RemoteAsync]
    IAsyncOperation<IStorageItem> TryGetItemAsync(string name);
  }
}
