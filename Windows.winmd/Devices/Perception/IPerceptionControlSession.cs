// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionControlSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(2576975443, 23101, 16767, 146, 57, 241, 136, 158, 84, 139, 72)]
  [Deprecated("PerceptionControlSession may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionControlSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionControlSession : IClosable
  {
    event TypedEventHandler<PerceptionControlSession, object> ControlLost;

    [Deprecated("PerceptionControlSession may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<PerceptionFrameSourcePropertyChangeResult> TrySetPropertyAsync(
      string name,
      [HasVariant] object value);
  }
}
