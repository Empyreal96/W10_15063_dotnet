// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackSphericalVideoProjection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaPlaybackSphericalVideoProjection : IMediaPlaybackSphericalVideoProjection
  {
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern SphericalVideoFrameFormat FrameFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern double HorizontalFieldOfViewInDegrees { [MethodImpl] get; [MethodImpl] set; }

    public extern Quaternion ViewOrientation { [MethodImpl] get; [MethodImpl] set; }

    public extern SphericalVideoProjectionMode ProjectionMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
