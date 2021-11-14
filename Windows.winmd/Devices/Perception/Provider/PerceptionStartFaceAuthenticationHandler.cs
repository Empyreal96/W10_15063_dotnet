// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionStartFaceAuthenticationHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1954639146, 8336, 18032, 140, 72, 239, 57, 231, 255, 124, 38)]
  [Deprecated("PerceptionStartFaceAuthenticationHandler may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public delegate bool PerceptionStartFaceAuthenticationHandler(
    PerceptionFaceAuthenticationGroup sender);
}
