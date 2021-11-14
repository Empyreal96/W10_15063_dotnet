// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1021398340, 7621, 17371, 159, 56, 235, 235, 249, 1, 82, 203)]
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  internal interface IVideoEncodingPropertiesStatics
  {
    VideoEncodingProperties CreateH264();

    VideoEncodingProperties CreateMpeg2();

    VideoEncodingProperties CreateUncompressed(
      string subtype,
      uint width,
      uint height);
  }
}
