// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceCreationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceCreationResult))]
  [Guid(1183233714, 32783, 20017, 144, 147, 118, 212, 120, 32, 19, 231)]
  internal interface IAdaptiveMediaSourceCreationResult
  {
    AdaptiveMediaSourceCreationStatus Status { get; }

    AdaptiveMediaSource MediaSource { get; }

    HttpResponseMessage HttpResponseMessage { get; }
  }
}
