// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSphericalVideoProjection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackSphericalVideoProjection))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3557143420, 28430, 18017, 184, 238, 212, 135, 186, 151, 82, 213)]
  internal interface IMediaPlaybackSphericalVideoProjection
  {
    bool IsEnabled { get; set; }

    SphericalVideoFrameFormat FrameFormat { get; set; }

    double HorizontalFieldOfViewInDegrees { get; set; }

    Quaternion ViewOrientation { get; set; }

    SphericalVideoProjectionMode ProjectionMode { get; set; }
  }
}
