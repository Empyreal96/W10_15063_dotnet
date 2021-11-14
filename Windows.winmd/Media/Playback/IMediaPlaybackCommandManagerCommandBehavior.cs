// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManagerCommandBehavior
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManagerCommandBehavior))]
  [Guid(2020351608, 52856, 18960, 175, 214, 132, 63, 203, 185, 12, 46)]
  internal interface IMediaPlaybackCommandManagerCommandBehavior
  {
    MediaPlaybackCommandManager CommandManager { get; }

    bool IsEnabled { get; }

    MediaCommandEnablingRule EnablingRule { get; set; }

    event TypedEventHandler<MediaPlaybackCommandManagerCommandBehavior, object> IsEnabledChanged;
  }
}
