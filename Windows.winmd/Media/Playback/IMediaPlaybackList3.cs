// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackList3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackList))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3710172073, 48199, 17507, 170, 144, 193, 139, 126, 95, 253, 225)]
  internal interface IMediaPlaybackList3 : 
    IMediaPlaybackList2,
    IMediaPlaybackList,
    IMediaPlaybackSource
  {
    IReference<uint> MaxPlayedItemsToKeepOpen { get; set; }
  }
}
