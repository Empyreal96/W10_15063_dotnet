// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadCompletedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadCompletedEventArgs))]
  [Guid(1883718852, 38474, 16612, 175, 149, 145, 119, 221, 109, 250, 0)]
  internal interface IAdaptiveMediaSourceDownloadCompletedEventArgs2
  {
    int RequestId { get; }

    AdaptiveMediaSourceDownloadStatistics Statistics { get; }

    IReference<TimeSpan> Position { get; }
  }
}
