// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureVideoProfileMediaDescription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaCaptureVideoProfileMediaDescription : 
    IMediaCaptureVideoProfileMediaDescription
  {
    public extern uint Width { [MethodImpl] get; }

    public extern uint Height { [MethodImpl] get; }

    public extern double FrameRate { [MethodImpl] get; }

    public extern bool IsVariablePhotoSequenceSupported { [MethodImpl] get; }

    public extern bool IsHdrVideoSupported { [MethodImpl] get; }
  }
}
