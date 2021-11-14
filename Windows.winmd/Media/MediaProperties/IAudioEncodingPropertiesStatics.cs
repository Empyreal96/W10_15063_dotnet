// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(212677420, 60393, 17703, 179, 109, 228, 42, 19, 207, 56, 219)]
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioEncodingPropertiesStatics
  {
    AudioEncodingProperties CreateAac(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    AudioEncodingProperties CreateAacAdts(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    AudioEncodingProperties CreateMp3(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    AudioEncodingProperties CreatePcm(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    AudioEncodingProperties CreateWma(
      uint sampleRate,
      uint channelCount,
      uint bitrate);
  }
}
