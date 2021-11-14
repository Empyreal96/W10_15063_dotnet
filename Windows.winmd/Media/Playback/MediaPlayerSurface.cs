// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayerSurface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.Media.Playback
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaPlayerSurface : IMediaPlayerSurface, IClosable
  {
    public extern ICompositionSurface CompositionSurface { [MethodImpl] get; }

    public extern Compositor Compositor { [MethodImpl] get; }

    public extern MediaPlayer MediaPlayer { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
