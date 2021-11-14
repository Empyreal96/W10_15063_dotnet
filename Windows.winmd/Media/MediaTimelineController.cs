// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaTimelineController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Threading(ThreadingModel.Both)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaTimelineController : IMediaTimelineController, IMediaTimelineController2
  {
    [MethodImpl]
    public extern MediaTimelineController();

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Resume();

    [MethodImpl]
    public extern void Pause();

    public extern TimeSpan Position { [MethodImpl] get; [MethodImpl] set; }

    public extern double ClockRate { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaTimelineControllerState State { [MethodImpl] get; }

    public extern event TypedEventHandler<MediaTimelineController, object> PositionChanged;

    public extern event TypedEventHandler<MediaTimelineController, object> StateChanged;

    public extern IReference<TimeSpan> Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsLoopingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<MediaTimelineController, MediaTimelineControllerFailedEventArgs> Failed;

    public extern event TypedEventHandler<MediaTimelineController, object> Ended;
  }
}
