// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakEndedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaBreakEndedEventArgs))]
  [Guid(850997878, 7261, 20462, 135, 50, 35, 109, 195, 168, 133, 128)]
  internal interface IMediaBreakEndedEventArgs
  {
    MediaBreak MediaBreak { get; }
  }
}
