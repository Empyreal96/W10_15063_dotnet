// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundAccessStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundAccessStatus
  {
    Unspecified,
    [Deprecated("Use AlwaysAllowed or AllowedSubjectToSystemPolicy instead of AllowedWithAlwaysOnRealTimeConnectivity. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] AllowedWithAlwaysOnRealTimeConnectivity,
    [Deprecated("Use AlwaysAllowed or AllowedSubjectToSystemPolicy instead of AllowedMayUseActiveRealTimeConnectivity. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] AllowedMayUseActiveRealTimeConnectivity,
    [Deprecated("Use DeniedByUser or DeniedBySystemPolicy instead of Denied. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] Denied,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AlwaysAllowed,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AllowedSubjectToSystemPolicy,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DeniedBySystemPolicy,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DeniedByUser,
  }
}
