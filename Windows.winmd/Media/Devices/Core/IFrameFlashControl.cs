// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameFlashControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(1976956615, 48453, 20395, 147, 117, 69, 172, 4, 179, 50, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameFlashControl))]
  internal interface IFrameFlashControl
  {
    FrameFlashMode Mode { get; set; }

    bool Auto { get; set; }

    bool RedEyeReduction { get; set; }

    float PowerPercent { get; set; }
  }
}
