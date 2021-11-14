// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDTransmitterProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(3845566243, 44111, 19164, 140, 102, 79, 247, 194, 112, 45, 214)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDTransmitterProperties
  {
    NDCertificateType CertificateType { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    NDCertificatePlatformID PlatformIdentifier { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    NDCertificateFeature[] SupportedFeatures { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    uint SecurityLevel { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    uint SecurityVersion { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    DateTime ExpirationDate { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    byte[] ClientID { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    byte[] ModelDigest { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    string ModelManufacturerName { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    string ModelName { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    string ModelNumber { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
