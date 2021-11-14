// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameSourceInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2277362125, 17921, 16527, 145, 207, 3, 131, 24, 205, 10, 243)]
  internal interface IMediaFrameSourceInfo
  {
    string Id { get; }

    MediaStreamType MediaStreamType { get; }

    MediaFrameSourceKind SourceKind { get; }

    MediaFrameSourceGroup SourceGroup { get; }

    DeviceInformation DeviceInformation { get; }

    IMapView<Guid, object> Properties { get; }

    SpatialCoordinateSystem CoordinateSystem { get; }
  }
}
