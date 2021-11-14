// Decompiled with JetBrains decompiler
// Type: Windows.Media.IPlaybackRateChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(753058847, 15574, 20343, 155, 167, 235, 39, 194, 106, 33, 64)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaybackRateChangeRequestedEventArgs))]
  internal interface IPlaybackRateChangeRequestedEventArgs
  {
    double RequestedPlaybackRate { get; }
  }
}
