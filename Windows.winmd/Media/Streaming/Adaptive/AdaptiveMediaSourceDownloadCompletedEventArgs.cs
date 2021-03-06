// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdaptiveMediaSourceDownloadCompletedEventArgs : 
    IAdaptiveMediaSourceDownloadCompletedEventArgs,
    IAdaptiveMediaSourceDownloadCompletedEventArgs2
  {
    public extern AdaptiveMediaSourceResourceType ResourceType { [MethodImpl] get; }

    public extern Uri ResourceUri { [MethodImpl] get; }

    public extern IReference<ulong> ResourceByteRangeOffset { [MethodImpl] get; }

    public extern IReference<ulong> ResourceByteRangeLength { [MethodImpl] get; }

    public extern HttpResponseMessage HttpResponseMessage { [MethodImpl] get; }

    public extern int RequestId { [MethodImpl] get; }

    public extern AdaptiveMediaSourceDownloadStatistics Statistics { [MethodImpl] get; }

    public extern IReference<TimeSpan> Position { [MethodImpl] get; }
  }
}
