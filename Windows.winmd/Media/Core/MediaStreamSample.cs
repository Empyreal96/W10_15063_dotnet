// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSample
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IMediaStreamSampleStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaStreamSample : IMediaStreamSample
  {
    public extern event TypedEventHandler<MediaStreamSample, object> Processed;

    public extern Buffer Buffer { [MethodImpl] get; }

    public extern TimeSpan Timestamp { [MethodImpl] get; }

    public extern MediaStreamSamplePropertySet ExtendedProperties { [MethodImpl] get; }

    public extern MediaStreamSampleProtectionProperties Protection { [MethodImpl] get; }

    public extern TimeSpan DecodeTimestamp { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    public extern bool KeyFrame { [MethodImpl] set; [MethodImpl] get; }

    public extern bool Discontinuous { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public static extern MediaStreamSample CreateFromBuffer(
      IBuffer buffer,
      TimeSpan timestamp);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaStreamSample> CreateFromStreamAsync(
      IInputStream stream,
      uint count,
      TimeSpan timestamp);
  }
}
