// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadResult))]
  [Guid(357903543, 31616, 19140, 134, 96, 164, 185, 127, 124, 112, 240)]
  internal interface IAdaptiveMediaSourceDownloadResult2
  {
    IReference<ulong> ResourceByteRangeOffset { get; set; }

    IReference<ulong> ResourceByteRangeLength { get; set; }
  }
}
