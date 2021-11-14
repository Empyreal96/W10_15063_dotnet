// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameExposureCompensationControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (FrameExposureCompensationControl))]
  [Guid(3914897097, 63481, 18634, 133, 145, 162, 101, 49, 203, 21, 120)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameExposureCompensationControl
  {
    IReference<float> Value { get; set; }
  }
}
