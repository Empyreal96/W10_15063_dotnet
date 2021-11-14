// Decompiled with JetBrains decompiler
// Type: Windows.Media.MusicDisplayProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MusicDisplayProperties : 
    IMusicDisplayProperties,
    IMusicDisplayProperties2,
    IMusicDisplayProperties3
  {
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern string AlbumArtist { [MethodImpl] get; [MethodImpl] set; }

    public extern string Artist { [MethodImpl] get; [MethodImpl] set; }

    public extern string AlbumTitle { [MethodImpl] get; [MethodImpl] set; }

    public extern uint TrackNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Genres { [MethodImpl] get; }

    public extern uint AlbumTrackCount { [MethodImpl] get; [MethodImpl] set; }
  }
}
