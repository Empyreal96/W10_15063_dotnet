// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrameControlValues2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1342909320, 1746, 19111, 167, 219, 211, 122, 247, 51, 33, 216)]
  [ExclusiveTo(typeof (CapturedFrameControlValues))]
  internal interface ICapturedFrameControlValues2
  {
    IReference<MediaCaptureFocusState> FocusState { get; }

    IReference<double> IsoDigitalGain { get; }

    IReference<double> IsoAnalogGain { get; }

    MediaRatio SensorFrameRate { get; }

    IReference<global::Windows.Media.Capture.WhiteBalanceGain> WhiteBalanceGain { get; }
  }
}
