// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IVariablePhotoSequenceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (VariablePhotoSequenceController))]
  [Guid(2143287424, 60812, 17405, 167, 195, 179, 88, 9, 228, 34, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVariablePhotoSequenceController
  {
    bool Supported { get; }

    float MaxPhotosPerSecond { get; }

    float PhotosPerSecondLimit { get; set; }

    MediaRatio GetHighestConcurrentFrameRate(IMediaEncodingProperties captureProperties);

    MediaRatio GetCurrentFrameRate();

    FrameControlCapabilities FrameCapabilities { get; }

    IVector<FrameController> DesiredFrameControllers { get; }
  }
}
