// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaItemDisplayProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaItemDisplayProperties : IMediaItemDisplayProperties
  {
    public extern MediaPlaybackType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern MusicDisplayProperties MusicProperties { [MethodImpl] get; }

    public extern VideoDisplayProperties VideoProperties { [MethodImpl] get; }

    public extern RandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void ClearAll();
  }
}
