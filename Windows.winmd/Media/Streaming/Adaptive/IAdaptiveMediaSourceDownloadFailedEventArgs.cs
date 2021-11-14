// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(930320456, 62635, 16548, 177, 53, 198, 223, 216, 189, 127, 241)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadFailedEventArgs))]
  internal interface IAdaptiveMediaSourceDownloadFailedEventArgs
  {
    AdaptiveMediaSourceResourceType ResourceType { get; }

    Uri ResourceUri { get; }

    IReference<ulong> ResourceByteRangeOffset { get; }

    IReference<ulong> ResourceByteRangeLength { get; }

    HttpResponseMessage HttpResponseMessage { get; }
  }
}
