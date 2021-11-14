// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.Decompressor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (IDecompressorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Decompressor : IDecompressor, IInputStream, IClosable
  {
    [MethodImpl]
    public extern Decompressor(IInputStream underlyingStream);

    [MethodImpl]
    public extern IInputStream DetachStream();

    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, uint> ReadAsync(
      IBuffer buffer,
      uint count,
      InputStreamOptions options);

    [MethodImpl]
    public extern void Close();
  }
}
