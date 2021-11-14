// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.ITimedMetadataPresentationModeChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [Guid(3512950937, 26079, 17838, 140, 239, 220, 11, 83, 253, 194, 187)]
  [ExclusiveTo(typeof (TimedMetadataPresentationModeChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedMetadataPresentationModeChangedEventArgs
  {
    TimedMetadataTrack Track { get; }

    TimedMetadataTrackPresentationMode OldPresentationMode { get; }

    TimedMetadataTrackPresentationMode NewPresentationMode { get; }
  }
}
