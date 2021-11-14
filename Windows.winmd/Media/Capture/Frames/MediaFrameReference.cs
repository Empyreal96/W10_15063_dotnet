// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  public sealed class MediaFrameReference : IMediaFrameReference, IClosable
  {
    public extern MediaFrameSourceKind SourceKind { [MethodImpl] get; }

    public extern MediaFrameFormat Format { [MethodImpl] get; }

    public extern IReference<global::Windows.Foundation.TimeSpan> SystemRelativeTime { [MethodImpl] get; }

    public extern global::Windows.Foundation.TimeSpan Duration { [MethodImpl] get; }

    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    public extern BufferMediaFrame BufferMediaFrame { [MethodImpl] get; }

    public extern VideoMediaFrame VideoMediaFrame { [MethodImpl] get; }

    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
