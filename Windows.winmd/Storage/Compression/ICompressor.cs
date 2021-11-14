// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.ICompressor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  [Guid(180577370, 22444, 20193, 183, 2, 132, 211, 157, 84, 36, 224)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Compressor))]
  internal interface ICompressor : IOutputStream, IClosable
  {
    [RemoteAsync]
    IAsyncOperation<bool> FinishAsync();

    IOutputStream DetachStream();
  }
}
