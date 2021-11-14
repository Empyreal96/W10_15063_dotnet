// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.Media.Playback
{
  [Guid(248927164, 46902, 18883, 131, 11, 118, 74, 56, 69, 49, 58)]
  [ExclusiveTo(typeof (MediaPlayerSurface))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IMediaPlayerSurface
  {
    ICompositionSurface CompositionSurface { get; }

    Compositor Compositor { get; }

    MediaPlayer MediaPlayer { get; }
  }
}
