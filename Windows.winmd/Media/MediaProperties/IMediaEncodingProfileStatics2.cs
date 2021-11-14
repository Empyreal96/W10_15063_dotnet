// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfileStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  [Guid(3465406287, 27380, 17032, 143, 226, 121, 173, 241, 247, 154, 67)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaEncodingProfileStatics2
  {
    MediaEncodingProfile CreateWav(AudioEncodingQuality quality);

    MediaEncodingProfile CreateAvi(VideoEncodingQuality quality);
  }
}
