// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDLicenseFetchDescriptorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("INDLicenseFetchDescriptorFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (NDLicenseFetchDescriptor))]
  [Guid(3489862146, 53164, 20224, 174, 106, 151, 175, 128, 184, 72, 242)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INDLicenseFetchDescriptorFactory
  {
    [Deprecated("INDLicenseFetchDescriptorFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    NDLicenseFetchDescriptor CreateInstance(
      NDContentIDType contentIDType,
      byte[] contentIDBytes,
      INDCustomData licenseFetchChallengeCustomData);
  }
}
