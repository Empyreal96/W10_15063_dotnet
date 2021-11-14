// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [Static(typeof (IPerceptionFrameProviderManagerServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public static class PerceptionFrameProviderManagerService
  {
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void RegisterFrameProviderInfo(
      IPerceptionFrameProviderManager manager,
      PerceptionFrameProviderInfo frameProviderInfo);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UnregisterFrameProviderInfo(
      IPerceptionFrameProviderManager manager,
      PerceptionFrameProviderInfo frameProviderInfo);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void RegisterFaceAuthenticationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionFaceAuthenticationGroup faceAuthenticationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UnregisterFaceAuthenticationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionFaceAuthenticationGroup faceAuthenticationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void RegisterControlGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionControlGroup controlGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UnregisterControlGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionControlGroup controlGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void RegisterCorrelationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionCorrelationGroup correlationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UnregisterCorrelationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionCorrelationGroup correlationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UpdateAvailabilityForProvider(
      IPerceptionFrameProvider provider,
      bool available);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void PublishFrameForProvider(
      IPerceptionFrameProvider provider,
      PerceptionFrame frame);
  }
}
