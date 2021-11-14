// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.STA)]
  [MarshalingBehavior(MarshalingType.None)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CameraCaptureUI : ICameraCaptureUI
  {
    [MethodImpl]
    public extern CameraCaptureUI();

    public extern CameraCaptureUIPhotoCaptureSettings PhotoSettings { [MethodImpl] get; }

    public extern CameraCaptureUIVideoCaptureSettings VideoSettings { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CaptureFileAsync(
      CameraCaptureUIMode mode);
  }
}
