// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.ICurrentMediaPlaybackItemChangedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CurrentMediaPlaybackItemChangedEventArgs))]
  [Guid(494970142, 39278, 16553, 190, 72, 230, 110, 201, 11, 43, 125)]
  internal interface ICurrentMediaPlaybackItemChangedEventArgs2 : 
    ICurrentMediaPlaybackItemChangedEventArgs
  {
    MediaPlaybackItemChangedReason Reason { get; }
  }
}
