// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSampleStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSample))]
  [Guid(3755942287, 42703, 17785, 190, 65, 115, 221, 148, 26, 217, 114)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaStreamSampleStatics
  {
    MediaStreamSample CreateFromBuffer(IBuffer buffer, TimeSpan timestamp);

    [RemoteAsync]
    IAsyncOperation<MediaStreamSample> CreateFromStreamAsync(
      IInputStream stream,
      uint count,
      TimeSpan timestamp);
  }
}
