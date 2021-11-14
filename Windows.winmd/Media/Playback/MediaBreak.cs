// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreak
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IMediaBreakFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaBreak : IMediaBreak
  {
    [MethodImpl]
    public extern MediaBreak(MediaBreakInsertionMethod insertionMethod);

    [MethodImpl]
    public extern MediaBreak(
      MediaBreakInsertionMethod insertionMethod,
      TimeSpan presentationPosition);

    public extern MediaPlaybackList PlaybackList { [MethodImpl] get; }

    public extern IReference<TimeSpan> PresentationPosition { [MethodImpl] get; }

    public extern MediaBreakInsertionMethod InsertionMethod { [MethodImpl] get; }

    public extern ValueSet CustomProperties { [MethodImpl] get; }

    public extern bool CanStart { [MethodImpl] get; [MethodImpl] set; }
  }
}
