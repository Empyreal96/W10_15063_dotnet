// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadStatistics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadStatistics))]
  [Guid(2735132411, 59754, 19967, 169, 184, 26, 224, 140, 1, 174, 152)]
  internal interface IAdaptiveMediaSourceDownloadStatistics
  {
    ulong ContentBytesReceivedCount { get; }

    IReference<TimeSpan> TimeToHeadersReceived { get; }

    IReference<TimeSpan> TimeToFirstByteReceived { get; }

    IReference<TimeSpan> TimeToLastByteReceived { get; }
  }
}
