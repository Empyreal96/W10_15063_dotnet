// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CapturedFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace Windows.Media.Capture
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [GCPressure(amount = GCPressureAmount.High)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CapturedFrame : 
    ICapturedFrame,
    IRandomAccessStreamWithContentType,
    IContentTypeProvider,
    IRandomAccessStream,
    IOutputStream,
    IClosable,
    IInputStream,
    ICapturedFrameWithSoftwareBitmap
  {
    public extern uint Width { [MethodImpl] get; }

    public extern uint Height { [MethodImpl] get; }

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

    public extern string ContentType { [MethodImpl] get; }

    public extern SoftwareBitmap SoftwareBitmap { [MethodImpl] get; }
  }
}
