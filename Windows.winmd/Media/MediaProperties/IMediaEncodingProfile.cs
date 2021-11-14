// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(3889952168, 7609, 18307, 135, 107, 61, 254, 18, 172, 253, 179)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaEncodingProfile
  {
    AudioEncodingProperties Audio { set; get; }

    VideoEncodingProperties Video { set; get; }

    ContainerEncodingProperties Container { set; get; }
  }
}
