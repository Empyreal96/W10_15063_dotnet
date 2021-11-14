// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakSeekedOverEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3853150022, 1542, 17554, 185, 211, 195, 200, 253, 224, 164, 234)]
  [ExclusiveTo(typeof (MediaBreakSeekedOverEventArgs))]
  internal interface IMediaBreakSeekedOverEventArgs
  {
    IVectorView<MediaBreak> SeekedOverBreaks { get; }

    TimeSpan OldPosition { get; }

    TimeSpan NewPosition { get; }
  }
}
