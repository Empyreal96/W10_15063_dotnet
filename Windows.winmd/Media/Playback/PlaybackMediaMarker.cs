// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.PlaybackMediaMarker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Activatable(typeof (IPlaybackMediaMarkerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlaybackMediaMarker : IPlaybackMediaMarker
  {
    [MethodImpl]
    public extern PlaybackMediaMarker(TimeSpan value);

    [MethodImpl]
    public extern PlaybackMediaMarker(TimeSpan value, string mediaMarketType, string text);

    public extern TimeSpan Time { [MethodImpl] get; }

    public extern string MediaMarkerType { [MethodImpl] get; }

    public extern string Text { [MethodImpl] get; }
  }
}
