// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.IMediaTranscoder2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Media.MediaProperties;
using Windows.Storage.Streams;

namespace Windows.Media.Transcoding
{
  [Guid(1079188852, 13792, 20228, 133, 116, 202, 139, 196, 229, 160, 130)]
  [ExclusiveTo(typeof (MediaTranscoder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaTranscoder2
  {
    IAsyncOperation<PrepareTranscodeResult> PrepareMediaStreamSourceTranscodeAsync(
      IMediaSource source,
      IRandomAccessStream destination,
      MediaEncodingProfile profile);

    MediaVideoProcessingAlgorithm VideoProcessingAlgorithm { set; get; }
  }
}
