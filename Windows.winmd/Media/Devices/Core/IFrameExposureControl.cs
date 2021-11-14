// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameExposureControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameExposureControl))]
  [Guid(2975881825, 65455, 18258, 182, 33, 245, 182, 241, 23, 244, 50)]
  internal interface IFrameExposureControl
  {
    bool Auto { get; set; }

    IReference<TimeSpan> Value { get; set; }
  }
}
