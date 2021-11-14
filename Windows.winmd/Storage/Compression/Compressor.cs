// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.Compressor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ICompressorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Compressor : ICompressor, IOutputStream, IClosable
  {
    [MethodImpl]
    public extern Compressor(IOutputStream underlyingStream);

    [MethodImpl]
    public extern Compressor(
      IOutputStream underlyingStream,
      CompressAlgorithm algorithm,
      uint blockSize);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> FinishAsync();

    [MethodImpl]
    public extern IOutputStream DetachStream();

    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> WriteAsync(
      IBuffer buffer);

    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    [MethodImpl]
    public extern void Close();
  }
}
