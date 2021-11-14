// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.VariablePhotoSequenceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices.Core
{
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class VariablePhotoSequenceController : IVariablePhotoSequenceController
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern float MaxPhotosPerSecond { [MethodImpl] get; }

    public extern float PhotosPerSecondLimit { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern MediaRatio GetHighestConcurrentFrameRate(
      IMediaEncodingProperties captureProperties);

    [MethodImpl]
    public extern MediaRatio GetCurrentFrameRate();

    public extern FrameControlCapabilities FrameCapabilities { [MethodImpl] get; }

    public extern IVector<FrameController> DesiredFrameControllers { [MethodImpl] get; }
  }
}
