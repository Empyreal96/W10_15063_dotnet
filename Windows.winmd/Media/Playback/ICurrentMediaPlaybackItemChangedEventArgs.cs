// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.ICurrentMediaPlaybackItemChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (CurrentMediaPlaybackItemChangedEventArgs))]
  [Guid(390310034, 23619, 18965, 150, 122, 87, 45, 45, 15, 38, 198)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICurrentMediaPlaybackItemChangedEventArgs
  {
    MediaPlaybackItem NewItem { get; }

    MediaPlaybackItem OldItem { get; }
  }
}
