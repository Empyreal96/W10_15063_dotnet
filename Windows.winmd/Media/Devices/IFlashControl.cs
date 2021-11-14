// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFlashControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (FlashControl))]
  [Guid(3740540350, 32104, 17891, 140, 15, 190, 123, 179, 40, 55, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFlashControl
  {
    bool Supported { get; }

    bool PowerSupported { get; }

    bool RedEyeReductionSupported { get; }

    bool Enabled { get; set; }

    bool Auto { get; set; }

    bool RedEyeReduction { get; set; }

    float PowerPercent { get; set; }
  }
}
