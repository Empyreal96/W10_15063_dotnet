// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaFrameReference))]
  [Guid(4139288129, 61660, 16452, 141, 201, 150, 28, 237, 208, 91, 173)]
  internal interface IMediaFrameReference : IClosable
  {
    MediaFrameSourceKind SourceKind { get; }

    MediaFrameFormat Format { get; }

    IReference<global::Windows.Foundation.TimeSpan> SystemRelativeTime { get; }

    global::Windows.Foundation.TimeSpan Duration { get; }

    IMapView<Guid, object> Properties { get; }

    BufferMediaFrame BufferMediaFrame { get; }

    VideoMediaFrame VideoMediaFrame { get; }

    SpatialCoordinateSystem CoordinateSystem { get; }
  }
}
