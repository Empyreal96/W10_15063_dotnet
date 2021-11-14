// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1996690250, 59815, 18371, 134, 44, 198, 86, 211, 6, 131, 212)]
  [ExclusiveTo(typeof (MediaPlaybackItemFailedEventArgs))]
  internal interface IMediaPlaybackItemFailedEventArgs
  {
    MediaPlaybackItem Item { get; }

    MediaPlaybackItemError Error { get; }
  }
}
