// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfileStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(2430256554, 53110, 17044, 169, 237, 26, 20, 32, 245, 31, 107)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMediaEncodingProfileStatics3
  {
    MediaEncodingProfile CreateAlac(AudioEncodingQuality quality);

    MediaEncodingProfile CreateFlac(AudioEncodingQuality quality);

    MediaEncodingProfile CreateHevc(VideoEncodingQuality quality);
  }
}
