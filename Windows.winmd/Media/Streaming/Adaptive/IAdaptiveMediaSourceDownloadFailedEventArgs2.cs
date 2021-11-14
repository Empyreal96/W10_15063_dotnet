// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadFailedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(1888589160, 38524, 18822, 144, 197, 198, 252, 75, 49, 226, 216)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadFailedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAdaptiveMediaSourceDownloadFailedEventArgs2
  {
    int RequestId { get; }

    HResult ExtendedError { get; }

    AdaptiveMediaSourceDownloadStatistics Statistics { get; }

    IReference<TimeSpan> Position { get; }
  }
}
