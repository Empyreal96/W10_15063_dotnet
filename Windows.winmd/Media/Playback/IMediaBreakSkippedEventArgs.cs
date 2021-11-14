// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakSkippedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaBreakSkippedEventArgs))]
  [Guid(1860783109, 12116, 19006, 163, 171, 36, 195, 178, 112, 180, 163)]
  internal interface IMediaBreakSkippedEventArgs
  {
    MediaBreak MediaBreak { get; }
  }
}
