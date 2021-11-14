// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadRequestedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3011349502, 43588, 19842, 130, 91, 97, 29, 227, 188, 254, 203)]
  internal interface IAdaptiveMediaSourceDownloadRequestedEventArgs2
  {
    int RequestId { get; }

    IReference<TimeSpan> Position { get; }
  }
}
