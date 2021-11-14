// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerRateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1080036696, 15201, 19378, 152, 159, 252, 101, 96, 139, 108, 171)]
  [ExclusiveTo(typeof (MediaPlayerRateChangedEventArgs))]
  internal interface IMediaPlayerRateChangedEventArgs
  {
    double NewRate { get; }
  }
}
