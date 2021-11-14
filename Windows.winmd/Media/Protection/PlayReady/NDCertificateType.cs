// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDCertificateType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Deprecated("NDCertificateType is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NDCertificateType
  {
    Unknown,
    PC,
    Device,
    Domain,
    Issuer,
    CrlSigner,
    Service,
    Silverlight,
    Application,
    Metering,
    KeyFileSigner,
    Server,
    LicenseSigner,
  }
}
