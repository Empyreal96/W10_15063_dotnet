// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MseStreamSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [DualApiPartition(version = 167772160)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMseStreamSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MseStreamSource : IMseStreamSource, IMediaSource
  {
    [MethodImpl]
    public extern MseStreamSource();

    public extern event TypedEventHandler<MseStreamSource, object> Opened;

    public extern event TypedEventHandler<MseStreamSource, object> Ended;

    public extern event TypedEventHandler<MseStreamSource, object> Closed;

    public extern MseSourceBufferList SourceBuffers { [MethodImpl] get; }

    public extern MseSourceBufferList ActiveSourceBuffers { [MethodImpl] get; }

    public extern MseReadyState ReadyState { [MethodImpl] get; }

    public extern IReference<TimeSpan> Duration { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern MseSourceBuffer AddSourceBuffer(string mimeType);

    [MethodImpl]
    public extern void RemoveSourceBuffer(MseSourceBuffer buffer);

    [MethodImpl]
    public extern void EndOfStream(MseEndOfStreamStatus status);

    [MethodImpl]
    public static extern bool IsContentTypeSupported(string contentType);
  }
}
