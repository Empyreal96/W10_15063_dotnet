// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSourceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaFrameSourceInfo : IMediaFrameSourceInfo
  {
    public extern string Id { [MethodImpl] get; }

    public extern MediaStreamType MediaStreamType { [MethodImpl] get; }

    public extern MediaFrameSourceKind SourceKind { [MethodImpl] get; }

    public extern MediaFrameSourceGroup SourceGroup { [MethodImpl] get; }

    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }
  }
}
