// Decompiled with JetBrains decompiler
// Type: Windows.Storage.PathIO
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPathIOStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public static class PathIO
  {
    [RemoteAsync]
    [Overload("ReadTextAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> ReadTextAsync(string absolutePath);

    [Overload("ReadTextWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ReadTextAsync(
      string absolutePath,
      UnicodeEncoding encoding);

    [Overload("WriteTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteTextAsync(
      string absolutePath,
      string contents);

    [Overload("WriteTextWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteTextAsync(
      string absolutePath,
      string contents,
      UnicodeEncoding encoding);

    [Overload("AppendTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction AppendTextAsync(
      string absolutePath,
      string contents);

    [RemoteAsync]
    [Overload("AppendTextWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendTextAsync(
      string absolutePath,
      string contents,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [Overload("ReadLinesAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<string>> ReadLinesAsync(
      string absolutePath);

    [Overload("ReadLinesWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<string>> ReadLinesAsync(
      string absolutePath,
      UnicodeEncoding encoding);

    [Overload("WriteLinesAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteLinesAsync(
      string absolutePath,
      IIterable<string> lines);

    [Overload("WriteLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteLinesAsync(
      string absolutePath,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [Overload("AppendLinesAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendLinesAsync(
      string absolutePath,
      IIterable<string> lines);

    [Overload("AppendLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendLinesAsync(
      string absolutePath,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> ReadBufferAsync(
      string absolutePath);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteBufferAsync(
      string absolutePath,
      IBuffer buffer);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteBytesAsync(
      string absolutePath,
      byte[] buffer);
  }
}
