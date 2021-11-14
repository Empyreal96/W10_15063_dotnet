// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2630255200, 32161, 16451, 182, 82, 33, 184, 135, 141, 175, 249)]
  internal interface IMediaCapture2
  {
    IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToStorageFileAsync(
      MediaEncodingProfile encodingProfile,
      IStorageFile file);

    IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToStreamAsync(
      MediaEncodingProfile encodingProfile,
      IRandomAccessStream stream);

    [Overload("PrepareLowLagRecordToCustomSinkAsync")]
    IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    [Overload("PrepareLowLagRecordToCustomSinkIdAsync")]
    IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    IAsyncOperation<LowLagPhotoCapture> PrepareLowLagPhotoCaptureAsync(
      ImageEncodingProperties type);

    [RemoteAsync]
    IAsyncOperation<LowLagPhotoSequenceCapture> PrepareLowLagPhotoSequenceCaptureAsync(
      ImageEncodingProperties type);

    IAsyncAction SetEncodingPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties,
      MediaPropertySet encoderProperties);
  }
}
