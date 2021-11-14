// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToConnectionError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Deprecated("PlayToConnectionError may be altered or unavailable for releases after Windows 10. Instead, use CastingConnectionErrorStatus.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PlayToConnectionError
  {
    None,
    DeviceNotResponding,
    DeviceError,
    DeviceLocked,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ProtectedPlaybackFailed,
  }
}
