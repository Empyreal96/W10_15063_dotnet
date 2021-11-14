// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItem3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(221413920, 47114, 19721, 159, 248, 248, 112, 148, 161, 200, 49)]
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  internal interface IMediaPlaybackItem3 : 
    IMediaPlaybackItem2,
    IMediaPlaybackItem,
    IMediaPlaybackSource
  {
    bool IsDisabledInPlaybackList { get; set; }

    double TotalDownloadProgress { get; }

    AutoLoadedDisplayPropertyKind AutoLoadedDisplayProperties { get; set; }
  }
}
