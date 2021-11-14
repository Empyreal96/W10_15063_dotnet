// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.VideoMediaFrameFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  public sealed class VideoMediaFrameFormat : IVideoMediaFrameFormat
  {
    public extern MediaFrameFormat MediaFrameFormat { [MethodImpl] get; }

    public extern DepthMediaFrameFormat DepthFormat { [MethodImpl] get; }

    public extern uint Width { [MethodImpl] get; }

    public extern uint Height { [MethodImpl] get; }
  }
}
