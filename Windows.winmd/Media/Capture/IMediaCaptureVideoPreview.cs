// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureVideoPreview
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MediaCapture))]
  [Guid(661811315, 21662, 17535, 162, 10, 79, 3, 196, 121, 216, 192)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCaptureVideoPreview
  {
    [RemoteAsync]
    IAsyncAction StartPreviewAsync();

    [Overload("StartPreviewToCustomSinkAsync")]
    IAsyncAction StartPreviewToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    [Overload("StartPreviewToCustomSinkIdAsync")]
    IAsyncAction StartPreviewToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    [RemoteAsync]
    IAsyncAction StopPreviewAsync();
  }
}
