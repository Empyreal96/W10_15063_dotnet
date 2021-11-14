// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture.Frames
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaFrameFormat : IMediaFrameFormat
  {
    public extern string MajorType { [MethodImpl] get; }

    public extern string Subtype { [MethodImpl] get; }

    public extern MediaRatio FrameRate { [MethodImpl] get; }

    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    public extern VideoMediaFrameFormat VideoFormat { [MethodImpl] get; }
  }
}
