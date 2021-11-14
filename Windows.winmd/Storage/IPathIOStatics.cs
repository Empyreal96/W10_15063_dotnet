// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IPathIOStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [Guid(254752600, 36551, 17281, 146, 43, 143, 108, 7, 210, 136, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PathIO))]
  internal interface IPathIOStatics
  {
    [RemoteAsync]
    [Overload("ReadTextAsync")]
    IAsyncOperation<string> ReadTextAsync(string absolutePath);

    [RemoteAsync]
    [Overload("ReadTextWithEncodingAsync")]
    IAsyncOperation<string> ReadTextAsync(
      string absolutePath,
      UnicodeEncoding encoding);

    [Overload("WriteTextAsync")]
    [RemoteAsync]
    IAsyncAction WriteTextAsync(string absolutePath, string contents);

    [Overload("WriteTextWithEncodingAsync")]
    [RemoteAsync]
    IAsyncAction WriteTextAsync(
      string absolutePath,
      string contents,
      UnicodeEncoding encoding);

    [Overload("AppendTextAsync")]
    [RemoteAsync]
    IAsyncAction AppendTextAsync(string absolutePath, string contents);

    [Overload("AppendTextWithEncodingAsync")]
    [RemoteAsync]
    IAsyncAction AppendTextAsync(
      string absolutePath,
      string contents,
      UnicodeEncoding encoding);

    [RemoteAsync]
    [Overload("ReadLinesAsync")]
    IAsyncOperation<IVector<string>> ReadLinesAsync(string absolutePath);

    [Overload("ReadLinesWithEncodingAsync")]
    [RemoteAsync]
    IAsyncOperation<IVector<string>> ReadLinesAsync(
      string absolutePath,
      UnicodeEncoding encoding);

    [Overload("WriteLinesAsync")]
    IAsyncAction WriteLinesAsync(string absolutePath, IIterable<string> lines);

    [Overload("WriteLinesWithEncodingAsync")]
    IAsyncAction WriteLinesAsync(
      string absolutePath,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [Overload("AppendLinesAsync")]
    IAsyncAction AppendLinesAsync(string absolutePath, IIterable<string> lines);

    [Overload("AppendLinesWithEncodingAsync")]
    IAsyncAction AppendLinesAsync(
      string absolutePath,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [RemoteAsync]
    IAsyncOperation<IBuffer> ReadBufferAsync(string absolutePath);

    [RemoteAsync]
    IAsyncAction WriteBufferAsync(string absolutePath, IBuffer buffer);

    [RemoteAsync]
    IAsyncAction WriteBytesAsync(string absolutePath, byte[] buffer);
  }
}
