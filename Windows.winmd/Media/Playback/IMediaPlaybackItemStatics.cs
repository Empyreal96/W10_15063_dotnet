// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1260120052, 17221, 16444, 138, 103, 245, 222, 145, 223, 76, 134)]
  internal interface IMediaPlaybackItemStatics
  {
    MediaPlaybackItem FindFromMediaSource(MediaSource source);
  }
}
