// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CameraCaptureUIPhotoCaptureSettings : ICameraCaptureUIPhotoCaptureSettings
  {
    public extern CameraCaptureUIPhotoFormat Format { [MethodImpl] get; [MethodImpl] set; }

    public extern CameraCaptureUIMaxPhotoResolution MaxResolution { [MethodImpl] get; [MethodImpl] set; }

    public extern Size CroppedSizeInPixels { [MethodImpl] get; [MethodImpl] set; }

    public extern Size CroppedAspectRatio { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowCropping { [MethodImpl] get; [MethodImpl] set; }
  }
}
