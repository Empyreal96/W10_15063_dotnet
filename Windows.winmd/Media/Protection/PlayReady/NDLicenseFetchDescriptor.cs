// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDLicenseFetchDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Activatable(typeof (INDLicenseFetchDescriptorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("NDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NDLicenseFetchDescriptor : INDLicenseFetchDescriptor
  {
    [Deprecated("INDLicenseFetchDescriptorFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern NDLicenseFetchDescriptor(
      NDContentIDType contentIDType,
      byte[] contentIDBytes,
      INDCustomData licenseFetchChallengeCustomData);

    public extern NDContentIDType ContentIDType { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern byte[] ContentID { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern INDCustomData LicenseFetchChallengeCustomData { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }
  }
}
