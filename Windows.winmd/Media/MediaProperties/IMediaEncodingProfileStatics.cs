// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfileStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  [Guid(427767084, 11998, 19013, 168, 150, 129, 122, 72, 84, 248, 254)]
  internal interface IMediaEncodingProfileStatics
  {
    MediaEncodingProfile CreateM4a(AudioEncodingQuality quality);

    MediaEncodingProfile CreateMp3(AudioEncodingQuality quality);

    MediaEncodingProfile CreateWma(AudioEncodingQuality quality);

    MediaEncodingProfile CreateMp4(VideoEncodingQuality quality);

    MediaEncodingProfile CreateWmv(VideoEncodingQuality quality);

    [RemoteAsync]
    IAsyncOperation<MediaEncodingProfile> CreateFromFileAsync(
      IStorageFile file);

    [RemoteAsync]
    IAsyncOperation<MediaEncodingProfile> CreateFromStreamAsync(
      IRandomAccessStream stream);
  }
}
