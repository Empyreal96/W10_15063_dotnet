// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICameraCaptureUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (CameraCaptureUI))]
  [Guid(1213756736, 28563, 19380, 184, 243, 232, 158, 72, 148, 140, 145)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICameraCaptureUI
  {
    CameraCaptureUIPhotoCaptureSettings PhotoSettings { get; }

    CameraCaptureUIVideoCaptureSettings VideoSettings { get; }

    IAsyncOperation<StorageFile> CaptureFileAsync(CameraCaptureUIMode mode);
  }
}
