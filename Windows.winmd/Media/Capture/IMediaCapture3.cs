// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Core;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3558043440, 5476, 18030, 188, 10, 175, 148, 224, 42, 176, 22)]
  internal interface IMediaCapture3
  {
    [RemoteAsync]
    IAsyncOperation<VariablePhotoSequenceCapture> PrepareVariablePhotoSequenceCaptureAsync(
      ImageEncodingProperties type);

    event TypedEventHandler<MediaCapture, MediaCaptureFocusChangedEventArgs> FocusChanged;

    event TypedEventHandler<MediaCapture, PhotoConfirmationCapturedEventArgs> PhotoConfirmationCaptured;
  }
}
