// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadBitrateChangedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadBitrateChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4092720196, 38574, 19936, 181, 64, 43, 50, 70, 230, 150, 140)]
  internal interface IAdaptiveMediaSourceDownloadBitrateChangedEventArgs2
  {
    AdaptiveMediaSourceDownloadBitrateChangedReason Reason { get; }
  }
}
