// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.InMemoryRandomAccessStream
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InMemoryRandomAccessStream : 
    IRandomAccessStream,
    IOutputStream,
    IClosable,
    IInputStream
  {
    [MethodImpl]
    public extern InMemoryRandomAccessStream();

    public extern ulong Size { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IInputStream GetInputStreamAt(ulong position);

    [MethodImpl]
    public extern IOutputStream GetOutputStreamAt(ulong position);

    public extern ulong Position { [MethodImpl] get; }

    [MethodImpl]
    public extern void Seek(ulong position);

    [MethodImpl]
    public extern IRandomAccessStream CloneStream();

    public extern bool CanRead { [MethodImpl] get; }

    public extern bool CanWrite { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, uint> ReadAsync(
      IBuffer buffer,
      uint count,
      InputStreamOptions options);

    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> WriteAsync(
      IBuffer buffer);

    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();
  }
}
