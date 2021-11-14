// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Capture.Frames
{
  [Guid(3598199123, 37083, 18088, 138, 221, 42, 168, 132, 168, 210, 83)]
  [ExclusiveTo(typeof (MediaFrameSource))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaFrameSource
  {
    MediaFrameSourceInfo Info { get; }

    MediaFrameSourceController Controller { get; }

    IVectorView<MediaFrameFormat> SupportedFormats { get; }

    MediaFrameFormat CurrentFormat { get; }

    [RemoteAsync]
    IAsyncAction SetFormatAsync(MediaFrameFormat format);

    event TypedEventHandler<MediaFrameSource, object> FormatChanged;

    CameraIntrinsics TryGetCameraIntrinsics(MediaFrameFormat format);
  }
}
