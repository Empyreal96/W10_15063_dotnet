// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.RandomAccessStream
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Static(typeof (IRandomAccessStreamStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class RandomAccessStream
  {
    [RemoteAsync]
    [Overload("CopyAsync")]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAsync(
      IInputStream source,
      IOutputStream destination);

    [RemoteAsync]
    [Overload("CopySizeAsync")]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAsync(
      IInputStream source,
      IOutputStream destination,
      ulong bytesToCopy);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync(
      IInputStream source,
      IOutputStream destination);
  }
}
