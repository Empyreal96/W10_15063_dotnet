// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagPhotoCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(2742178231, 27460, 18237, 143, 36, 247, 3, 214, 192, 236, 68)]
  [ExclusiveTo(typeof (LowLagPhotoCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILowLagPhotoCapture
  {
    [RemoteAsync]
    IAsyncOperation<CapturedPhoto> CaptureAsync();

    [RemoteAsync]
    IAsyncAction FinishAsync();
  }
}
