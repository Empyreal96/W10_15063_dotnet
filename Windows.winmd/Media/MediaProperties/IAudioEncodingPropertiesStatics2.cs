// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingPropertiesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1955148143, 30624, 17213, 142, 213, 64, 64, 40, 14, 134, 101)]
  internal interface IAudioEncodingPropertiesStatics2
  {
    AudioEncodingProperties CreateAlac(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    AudioEncodingProperties CreateFlac(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);
  }
}
