// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUIVideoCaptureSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class CameraCaptureUIVideoCaptureSettings : ICameraCaptureUIVideoCaptureSettings
  {
    public extern CameraCaptureUIVideoFormat Format { [MethodImpl] get; [MethodImpl] set; }

    public extern CameraCaptureUIMaxVideoResolution MaxResolution { [MethodImpl] get; [MethodImpl] set; }

    public extern float MaxDurationInSeconds { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowTrimming { [MethodImpl] get; [MethodImpl] set; }
  }
}
