// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameFormat))]
  [Guid(1905273678, 45689, 19095, 169, 219, 189, 90, 47, 183, 143, 57)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaFrameFormat
  {
    string MajorType { get; }

    string Subtype { get; }

    MediaRatio FrameRate { get; }

    IMapView<Guid, object> Properties { get; }

    VideoMediaFrameFormat VideoFormat { get; }
  }
}
