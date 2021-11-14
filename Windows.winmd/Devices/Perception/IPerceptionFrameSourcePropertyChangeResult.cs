// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionFrameSourcePropertyChangeResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(506673418, 15504, 19746, 184, 152, 244, 43, 186, 100, 24, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PerceptionFrameSourcePropertyChangeResult))]
  [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionFrameSourcePropertyChangeResult
  {
    PerceptionFrameSourcePropertyChangeStatus Status { [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    object NewValue { [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] [return: Variant] get; }
  }
}
