// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IDepthMediaFrameFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Guid(3272789824, 55081, 17726, 135, 128, 46, 4, 241, 64, 210, 142)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (DepthMediaFrameFormat))]
  internal interface IDepthMediaFrameFormat
  {
    VideoMediaFrameFormat VideoFormat { get; }

    double DepthScaleInMeters { get; }
  }
}
