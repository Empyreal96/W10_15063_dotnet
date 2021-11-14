// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IFileIOStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [Guid(2289308139, 32596, 18226, 165, 240, 94, 67, 227, 184, 194, 245)]
  [ExclusiveTo(typeof (FileIO))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFileIOStatics
  {
    [Overload("ReadTextAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ReadTextAsync(IStorageFile file);

    [RemoteAsync]
    [Overload("ReadTextWithEncodingAsync")]
    IAsyncOperation<string> ReadTextAsync(
      IStorageFile file,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [Overload("WriteTextAsync")]
    IAsyncAction WriteTextAsync(IStorageFile file, string contents);

    [RemoteAsync]
    [Overload("WriteTextWithEncodingAsync")]
    IAsyncAction WriteTextAsync(
      IStorageFile file,
      string contents,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [Overload("AppendTextAsync")]
    IAsyncAction AppendTextAsync(IStorageFile file, string contents);

    [Overload("AppendTextWithEncodingAsync")]
    [RemoteAsync]
    IAsyncAction AppendTextAsync(
      IStorageFile file,
      string contents,
      UnicodeEncoding encoding);

    [Overload("ReadLinesAsync")]
    [RemoteAsync]
    IAsyncOperation<IVector<string>> ReadLinesAsync(IStorageFile file);

    [RemoteAsync]
    [Overload("ReadLinesWithEncodingAsync")]
    IAsyncOperation<IVector<string>> ReadLinesAsync(
      IStorageFile file,
      UnicodeEncoding encoding);

    [Overload("WriteLinesAsync")]
    IAsyncAction WriteLinesAsync(IStorageFile file, IIterable<string> lines);

    [Overload("WriteLinesWithEncodingAsync")]
    IAsyncAction WriteLinesAsync(
      IStorageFile file,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [Overload("AppendLinesAsync")]
    IAsyncAction AppendLinesAsync(IStorageFile file, IIterable<string> lines);

    [Overload("AppendLinesWithEncodingAsync")]
    IAsyncAction AppendLinesAsync(
      IStorageFile file,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [RemoteAsync]
    IAsyncOperation<IBuffer> ReadBufferAsync(IStorageFile file);

    [RemoteAsync]
    IAsyncAction WriteBufferAsync(IStorageFile file, IBuffer buffer);

    [RemoteAsync]
    IAsyncAction WriteBytesAsync(IStorageFile file, byte[] buffer);
  }
}
