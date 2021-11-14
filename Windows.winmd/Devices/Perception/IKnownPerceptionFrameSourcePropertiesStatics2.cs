// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IKnownPerceptionFrameSourcePropertiesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(2848483441, 1500, 19021, 138, 92, 164, 236, 242, 107, 188, 70)]
  [ExclusiveTo(typeof (KnownPerceptionFrameSourceProperties))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IKnownPerceptionFrameSourcePropertiesStatics2
  {
    string DeviceId { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
