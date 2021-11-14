// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerSource2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(2185534367, 29474, 19467, 176, 59, 62, 105, 164, 130, 96, 197)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayerSource2
  {
    IMediaPlaybackSource Source { get; set; }
  }
}
