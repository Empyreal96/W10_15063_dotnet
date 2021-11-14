// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IInfraredMediaFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Guid(1070675203, 75, 20238, 145, 172, 70, 82, 153, 180, 22, 88)]
  [ExclusiveTo(typeof (InfraredMediaFrame))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInfraredMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    VideoMediaFrame VideoMediaFrame { get; }

    bool IsIlluminated { get; }
  }
}
