// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadStatistics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdaptiveMediaSourceDownloadStatistics : IAdaptiveMediaSourceDownloadStatistics
  {
    public extern ulong ContentBytesReceivedCount { [MethodImpl] get; }

    public extern IReference<TimeSpan> TimeToHeadersReceived { [MethodImpl] get; }

    public extern IReference<TimeSpan> TimeToFirstByteReceived { [MethodImpl] get; }

    public extern IReference<TimeSpan> TimeToLastByteReceived { [MethodImpl] get; }
  }
}
