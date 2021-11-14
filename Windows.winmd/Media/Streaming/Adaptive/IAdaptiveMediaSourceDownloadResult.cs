// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(4105165939, 48366, 19050, 159, 10, 254, 196, 30, 35, 57, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadResult))]
  internal interface IAdaptiveMediaSourceDownloadResult
  {
    Uri ResourceUri { get; set; }

    IInputStream InputStream { get; set; }

    IBuffer Buffer { get; set; }

    string ContentType { get; set; }

    uint ExtendedStatus { get; set; }
  }
}
