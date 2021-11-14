// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AdaptiveMediaSourceDownloadRequestedEventArgs : 
    IAdaptiveMediaSourceDownloadRequestedEventArgs,
    IAdaptiveMediaSourceDownloadRequestedEventArgs2
  {
    public extern AdaptiveMediaSourceResourceType ResourceType { [MethodImpl] get; }

    public extern Uri ResourceUri { [MethodImpl] get; }

    public extern IReference<ulong> ResourceByteRangeOffset { [MethodImpl] get; }

    public extern IReference<ulong> ResourceByteRangeLength { [MethodImpl] get; }

    public extern AdaptiveMediaSourceDownloadResult Result { [MethodImpl] get; }

    [MethodImpl]
    public extern AdaptiveMediaSourceDownloadRequestedDeferral GetDeferral();

    public extern int RequestId { [MethodImpl] get; }

    public extern IReference<TimeSpan> Position { [MethodImpl] get; }
  }
}
