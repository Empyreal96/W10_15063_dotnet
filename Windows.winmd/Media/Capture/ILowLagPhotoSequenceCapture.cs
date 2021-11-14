// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagPhotoSequenceCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (LowLagPhotoSequenceCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2093172411, 47529, 19601, 143, 250, 40, 126, 156, 102, 134, 105)]
  internal interface ILowLagPhotoSequenceCapture
  {
    [RemoteAsync]
    IAsyncAction StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();

    [RemoteAsync]
    IAsyncAction FinishAsync();

    event TypedEventHandler<LowLagPhotoSequenceCapture, PhotoCapturedEventArgs> PhotoCaptured;
  }
}
