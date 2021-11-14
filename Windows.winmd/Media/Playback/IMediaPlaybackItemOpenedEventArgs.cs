// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemOpenedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(3420044674, 12343, 20414, 174, 143, 57, 252, 57, 237, 244, 239)]
  [ExclusiveTo(typeof (MediaPlaybackItemOpenedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlaybackItemOpenedEventArgs
  {
    MediaPlaybackItem Item { get; }
  }
}
