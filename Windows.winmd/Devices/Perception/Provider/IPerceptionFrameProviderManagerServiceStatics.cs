// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionFrameProviderManagerServiceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(2927855334, 51929, 17241, 143, 150, 142, 174, 81, 129, 5, 38)]
  [ExclusiveTo(typeof (PerceptionFrameProviderManagerService))]
  internal interface IPerceptionFrameProviderManagerServiceStatics
  {
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void RegisterFrameProviderInfo(
      IPerceptionFrameProviderManager manager,
      PerceptionFrameProviderInfo frameProviderInfo);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnregisterFrameProviderInfo(
      IPerceptionFrameProviderManager manager,
      PerceptionFrameProviderInfo frameProviderInfo);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void RegisterFaceAuthenticationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionFaceAuthenticationGroup faceAuthenticationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnregisterFaceAuthenticationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionFaceAuthenticationGroup faceAuthenticationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void RegisterControlGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionControlGroup controlGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnregisterControlGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionControlGroup controlGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void RegisterCorrelationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionCorrelationGroup correlationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnregisterCorrelationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionCorrelationGroup correlationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UpdateAvailabilityForProvider(IPerceptionFrameProvider provider, bool available);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void PublishFrameForProvider(IPerceptionFrameProvider provider, PerceptionFrame frame);
  }
}
