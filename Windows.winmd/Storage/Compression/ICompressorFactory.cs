// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.ICompressorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1597871780, 11515, 17452, 168, 186, 215, 209, 27, 3, 157, 160)]
  [ExclusiveTo(typeof (Compressor))]
  internal interface ICompressorFactory
  {
    Compressor CreateCompressor(IOutputStream underlyingStream);

    Compressor CreateCompressorEx(
      IOutputStream underlyingStream,
      CompressAlgorithm algorithm,
      uint blockSize);
  }
}
