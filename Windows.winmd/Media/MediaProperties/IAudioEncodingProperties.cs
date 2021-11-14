// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(1656519190, 92, 19259, 138, 11, 10, 9, 14, 150, 135, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  internal interface IAudioEncodingProperties : IMediaEncodingProperties
  {
    uint Bitrate { set; get; }

    uint ChannelCount { set; get; }

    uint SampleRate { set; get; }

    uint BitsPerSample { set; get; }
  }
}
