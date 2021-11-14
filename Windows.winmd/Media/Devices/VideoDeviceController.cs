// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.VideoDeviceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Devices.Core;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoDeviceController : 
    IVideoDeviceController,
    IMediaDeviceController,
    IAdvancedVideoCaptureDeviceController,
    IAdvancedVideoCaptureDeviceController2,
    IAdvancedVideoCaptureDeviceController3,
    IAdvancedVideoCaptureDeviceController4,
    IAdvancedVideoCaptureDeviceController5
  {
    public extern MediaDeviceControl Brightness { [MethodImpl] get; }

    public extern MediaDeviceControl Contrast { [MethodImpl] get; }

    public extern MediaDeviceControl Hue { [MethodImpl] get; }

    public extern MediaDeviceControl WhiteBalance { [MethodImpl] get; }

    public extern MediaDeviceControl BacklightCompensation { [MethodImpl] get; }

    public extern MediaDeviceControl Pan { [MethodImpl] get; }

    public extern MediaDeviceControl Tilt { [MethodImpl] get; }

    public extern MediaDeviceControl Zoom { [MethodImpl] get; }

    public extern MediaDeviceControl Roll { [MethodImpl] get; }

    public extern MediaDeviceControl Exposure { [MethodImpl] get; }

    public extern MediaDeviceControl Focus { [MethodImpl] get; }

    [MethodImpl]
    public extern bool TrySetPowerlineFrequency(PowerlineFrequency value);

    [MethodImpl]
    public extern bool TryGetPowerlineFrequency(out PowerlineFrequency value);

    [MethodImpl]
    public extern IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties(
      MediaStreamType mediaStreamType);

    [MethodImpl]
    public extern IMediaEncodingProperties GetMediaStreamProperties(
      MediaStreamType mediaStreamType);

    [MethodImpl]
    public extern IAsyncAction SetMediaStreamPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties);

    [MethodImpl]
    public extern void SetDeviceProperty(string propertyId, [Variant] object propertyValue);

    [MethodImpl]
    [return: Variant]
    public extern object GetDeviceProperty(string propertyId);

    public extern LowLagPhotoSequenceControl LowLagPhotoSequence { [MethodImpl] get; }

    public extern LowLagPhotoControl LowLagPhoto { [MethodImpl] get; }

    public extern SceneModeControl SceneModeControl { [MethodImpl] get; }

    public extern TorchControl TorchControl { [MethodImpl] get; }

    public extern FlashControl FlashControl { [MethodImpl] get; }

    public extern WhiteBalanceControl WhiteBalanceControl { [MethodImpl] get; }

    public extern ExposureControl ExposureControl { [MethodImpl] get; }

    public extern FocusControl FocusControl { [MethodImpl] get; }

    public extern ExposureCompensationControl ExposureCompensationControl { [MethodImpl] get; }

    public extern IsoSpeedControl IsoSpeedControl { [MethodImpl] get; }

    public extern RegionsOfInterestControl RegionsOfInterestControl { [MethodImpl] get; }

    public extern CaptureUse PrimaryUse { [MethodImpl] get; [MethodImpl] set; }

    public extern VariablePhotoSequenceController VariablePhotoSequenceController { [MethodImpl] get; }

    public extern PhotoConfirmationControl PhotoConfirmationControl { [MethodImpl] get; }

    public extern ZoomControl ZoomControl { [MethodImpl] get; }

    public extern ExposurePriorityVideoControl ExposurePriorityVideoControl { [MethodImpl] get; }

    public extern MediaCaptureOptimization DesiredOptimization { [MethodImpl] get; [MethodImpl] set; }

    public extern HdrVideoControl HdrVideoControl { [MethodImpl] get; }

    public extern OpticalImageStabilizationControl OpticalImageStabilizationControl { [MethodImpl] get; }

    public extern AdvancedPhotoControl AdvancedPhotoControl { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern VideoDeviceControllerGetDevicePropertyResult GetDevicePropertyById(
      string propertyId,
      IReference<uint> maxPropertyValueSize);

    [MethodImpl]
    public extern VideoDeviceControllerSetDevicePropertyStatus SetDevicePropertyById(
      string propertyId,
      [Variant] object propertyValue);

    [MethodImpl]
    public extern VideoDeviceControllerGetDevicePropertyResult GetDevicePropertyByExtendedId(
      byte[] extendedPropertyId,
      IReference<uint> maxPropertyValueSize);

    [MethodImpl]
    public extern VideoDeviceControllerSetDevicePropertyStatus SetDevicePropertyByExtendedId(
      byte[] extendedPropertyId,
      byte[] propertyValue);
  }
}
