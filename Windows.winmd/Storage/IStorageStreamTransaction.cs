// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageStreamTransaction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageStreamTransaction))]
  [Guid(4135383907, 42301, 19860, 174, 44, 103, 35, 45, 147, 172, 221)]
  internal interface IStorageStreamTransaction : IClosable
  {
    IRandomAccessStream Stream { get; }

    [RemoteAsync]
    IAsyncAction CommitAsync();
  }
}
