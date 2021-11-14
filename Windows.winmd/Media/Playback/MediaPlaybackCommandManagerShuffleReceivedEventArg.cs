// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackCommandManagerShuffleReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaPlaybackCommandManagerShuffleReceivedEventArgs : 
    IMediaPlaybackCommandManagerShuffleReceivedEventArgs
  {
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsShuffleRequested { [MethodImpl] get; }

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
