// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1899232481, 5993, 20473, 167, 193, 56, 210, 196, 212, 35, 96)]
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  internal interface IMediaPlaybackItemFactory
  {
    MediaPlaybackItem Create(MediaSource source);
  }
}
