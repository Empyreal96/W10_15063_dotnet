// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackCommandManagerCommandBehavior
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaPlaybackCommandManagerCommandBehavior : 
    IMediaPlaybackCommandManagerCommandBehavior
  {
    public extern MediaPlaybackCommandManager CommandManager { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; }

    public extern MediaCommandEnablingRule EnablingRule { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<MediaPlaybackCommandManagerCommandBehavior, object> IsEnabledChanged;
  }
}
