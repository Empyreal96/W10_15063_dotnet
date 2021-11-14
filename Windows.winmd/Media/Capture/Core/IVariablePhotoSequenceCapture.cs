// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.IVariablePhotoSequenceCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  [Guid(3490786589, 798, 16449, 166, 214, 189, 116, 36, 118, 168, 238)]
  [ExclusiveTo(typeof (VariablePhotoSequenceCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVariablePhotoSequenceCapture
  {
    [RemoteAsync]
    IAsyncAction StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();

    [RemoteAsync]
    IAsyncAction FinishAsync();

    event TypedEventHandler<VariablePhotoSequenceCapture, VariablePhotoCapturedEventArgs> PhotoCaptured;

    event TypedEventHandler<VariablePhotoSequenceCapture, object> Stopped;
  }
}
