// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlaybackRateChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaybackRateChangeRequestedEventArgs))]
  [Guid(257319342, 11400, 19658, 133, 64, 213, 134, 9, 93, 19, 165)]
  internal interface IPlaybackRateChangeRequestedEventArgs
  {
    double Rate { get; }
  }
}
