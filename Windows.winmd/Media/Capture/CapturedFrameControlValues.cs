// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CapturedFrameControlValues
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CapturedFrameControlValues : 
    ICapturedFrameControlValues,
    ICapturedFrameControlValues2
  {
    public extern IReference<TimeSpan> Exposure { [MethodImpl] get; }

    public extern IReference<float> ExposureCompensation { [MethodImpl] get; }

    public extern IReference<uint> IsoSpeed { [MethodImpl] get; }

    public extern IReference<uint> Focus { [MethodImpl] get; }

    public extern IReference<CaptureSceneMode> SceneMode { [MethodImpl] get; }

    public extern IReference<bool> Flashed { [MethodImpl] get; }

    public extern IReference<float> FlashPowerPercent { [MethodImpl] get; }

    public extern IReference<uint> WhiteBalance { [MethodImpl] get; }

    public extern IReference<float> ZoomFactor { [MethodImpl] get; }

    public extern IReference<MediaCaptureFocusState> FocusState { [MethodImpl] get; }

    public extern IReference<double> IsoDigitalGain { [MethodImpl] get; }

    public extern IReference<double> IsoAnalogGain { [MethodImpl] get; }

    public extern MediaRatio SensorFrameRate { [MethodImpl] get; }

    public extern IReference<global::Windows.Media.Capture.WhiteBalanceGain> WhiteBalanceGain { [MethodImpl] get; }
  }
}
