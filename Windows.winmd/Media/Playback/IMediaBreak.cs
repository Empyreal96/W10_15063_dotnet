// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreak
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1900798576, 3567, 20156, 164, 137, 107, 52, 147, 14, 21, 88)]
  [ExclusiveTo(typeof (MediaBreak))]
  internal interface IMediaBreak
  {
    MediaPlaybackList PlaybackList { get; }

    IReference<TimeSpan> PresentationPosition { get; }

    MediaBreakInsertionMethod InsertionMethod { get; }

    ValueSet CustomProperties { get; }

    bool CanStart { get; set; }
  }
}
