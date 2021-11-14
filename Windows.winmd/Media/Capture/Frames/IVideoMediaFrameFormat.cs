// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IVideoMediaFrameFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Guid(1174568896, 55067, 17863, 143, 20, 109, 154, 10, 230, 4, 228)]
  [ExclusiveTo(typeof (VideoMediaFrameFormat))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IVideoMediaFrameFormat
  {
    MediaFrameFormat MediaFrameFormat { get; }

    DepthMediaFrameFormat DepthFormat { get; }

    uint Width { get; }

    uint Height { get; }
  }
}
