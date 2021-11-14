// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakStartedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaBreakStartedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2826894961, 57300, 17738, 149, 110, 10, 74, 100, 131, 149, 248)]
  internal interface IMediaBreakStartedEventArgs
  {
    MediaBreak MediaBreak { get; }
  }
}
