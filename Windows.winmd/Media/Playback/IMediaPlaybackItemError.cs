// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackItemError))]
  [Guid(1778118443, 56534, 19961, 164, 80, 219, 244, 198, 241, 194, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlaybackItemError
  {
    MediaPlaybackItemErrorCode ErrorCode { get; }

    HResult ExtendedError { get; }
  }
}
