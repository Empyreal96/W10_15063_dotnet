// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(421793219, 23351, 18970, 137, 112, 214, 33, 203, 108, 168, 59)]
  internal interface IAdaptiveMediaSourceDownloadCompletedEventArgs
  {
    AdaptiveMediaSourceResourceType ResourceType { get; }

    Uri ResourceUri { get; }

    IReference<ulong> ResourceByteRangeOffset { get; }

    IReference<ulong> ResourceByteRangeLength { get; }

    HttpResponseMessage HttpResponseMessage { get; }
  }
}
