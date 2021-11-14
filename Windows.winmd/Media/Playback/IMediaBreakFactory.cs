// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaBreak))]
  [Guid(1159127042, 6368, 16505, 139, 95, 211, 52, 149, 193, 93, 46)]
  internal interface IMediaBreakFactory
  {
    MediaBreak Create(MediaBreakInsertionMethod insertionMethod);

    MediaBreak CreateWithPresentationPosition(
      MediaBreakInsertionMethod insertionMethod,
      TimeSpan presentationPosition);
  }
}
