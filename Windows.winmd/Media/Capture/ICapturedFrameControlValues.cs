// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrameControlValues
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CapturedFrameControlValues))]
  [Guid(2428918655, 19981, 19620, 136, 45, 122, 20, 79, 237, 10, 144)]
  internal interface ICapturedFrameControlValues
  {
    IReference<TimeSpan> Exposure { get; }

    IReference<float> ExposureCompensation { get; }

    IReference<uint> IsoSpeed { get; }

    IReference<uint> Focus { get; }

    IReference<CaptureSceneMode> SceneMode { get; }

    IReference<bool> Flashed { get; }

    IReference<float> FlashPowerPercent { get; }

    IReference<uint> WhiteBalance { get; }

    IReference<float> ZoomFactor { get; }
  }
}
