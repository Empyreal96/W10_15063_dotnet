// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaEnginePlaybackSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1545407399, 14422, 18617, 141, 198, 36, 75, 241, 7, 191, 140)]
  [Deprecated("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public interface IMediaEnginePlaybackSource
  {
    MediaPlaybackItem CurrentItem { [Deprecated("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void SetPlaybackSource(IMediaPlaybackSource source);
  }
}
