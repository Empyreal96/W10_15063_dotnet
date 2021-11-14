// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionStopFaceAuthenticationHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [Guid(947840682, 35277, 18462, 170, 222, 221, 146, 247, 11, 42, 215)]
  [Deprecated("PerceptionStopFaceAuthenticationHandler may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void PerceptionStopFaceAuthenticationHandler(
    PerceptionFaceAuthenticationGroup sender);
}
