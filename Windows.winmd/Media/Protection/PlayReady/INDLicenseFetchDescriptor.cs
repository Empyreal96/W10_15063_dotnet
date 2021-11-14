// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDLicenseFetchDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(1419301690, 59014, 18741, 165, 103, 124, 167, 122, 210, 15, 164)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDLicenseFetchDescriptor
  {
    NDContentIDType ContentIDType { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    byte[] ContentID { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    INDCustomData LicenseFetchChallengeCustomData { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
