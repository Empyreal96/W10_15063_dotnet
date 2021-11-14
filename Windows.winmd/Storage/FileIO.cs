// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileIO
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFileIOStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class FileIO
  {
    [Overload("ReadTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ReadTextAsync(IStorageFile file);

    [Overload("ReadTextWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ReadTextAsync(
      IStorageFile file,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [Overload("WriteTextAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteTextAsync(IStorageFile file, string contents);

    [RemoteAsync]
    [Overload("WriteTextWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteTextAsync(
      IStorageFile file,
      string contents,
      UnicodeEncoding encoding);

    [Overload("AppendTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction AppendTextAsync(
      IStorageFile file,
      string contents);

    [RemoteAsync]
    [Overload("AppendTextWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendTextAsync(
      IStorageFile file,
      string contents,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [Overload("ReadLinesAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<string>> ReadLinesAsync(
      IStorageFile file);

    [Overload("ReadLinesWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<string>> ReadLinesAsync(
      IStorageFile file,
      UnicodeEncoding encoding);

    [Overload("WriteLinesAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteLinesAsync(
      IStorageFile file,
      IIterable<string> lines);

    [Overload("WriteLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteLinesAsync(
      IStorageFile file,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [Overload("AppendLinesAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendLinesAsync(
      IStorageFile file,
      IIterable<string> lines);

    [Overload("AppendLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendLinesAsync(
      IStorageFile file,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> ReadBufferAsync(
      IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteBufferAsync(
      IStorageFile file,
      IBuffer buffer);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteBytesAsync(IStorageFile file, byte[] buffer);
  }
}
