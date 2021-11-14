// Decompiled with JetBrains decompiler
// Type: Windows.Media.IPlaybackPositionChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3024699272, 60200, 18785, 156, 20, 51, 94, 68, 243, 225, 37)]
  [ExclusiveTo(typeof (PlaybackPositionChangeRequestedEventArgs))]
  internal interface IPlaybackPositionChangeRequestedEventArgs
  {
    TimeSpan RequestedPlaybackPosition { get; }
  }
}
