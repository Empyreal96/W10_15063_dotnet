// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadRequestedDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(96898916, 64032, 19901, 152, 33, 75, 244, 201, 191, 119, 171)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadRequestedDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdaptiveMediaSourceDownloadRequestedDeferral
  {
    void Complete();
  }
}
